using eShopping.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static eShopping.Models.Models;

namespace eShopping.Services
{
    internal class DonHangService
    {
        private static readonly Random rnd = new Random();
        private readonly GioHangService gioSv = new GioHangService();
        private readonly ThanhToanService thanhToanSv = new ThanhToanService();
        private readonly SanPhamService sanPhamSv = new SanPhamService();

        public const string THUONG = "THUONG";
        public const string NHANH = "NHANH";
        public const string TRONGNGAY = "TRONGNGAY";

        public DataTable LayKhuVuc()
        {
            return Db.Query("SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc ORDER BY TenKhuVuc");
        }

        public DataTable LayLoaiPhieu()
        {
            return Db.Query("SELECT MaLoaiPhieu, TenLoaiPhieu, ThoiGianXuLyGio, NguongMienPhi FROM LoaiPhieuDat ORDER BY ThoiGianXuLyGio DESC");
        }

        public string TaoMaDonHang()
        {
            int so; lock (rnd) { so = rnd.Next(100, 1000); }
            return "DH" + DateTime.Now.ToString("yyyyMMddHHmmss") + so;
        }

        // ---------------- UC7: tính phí giao hàng (BR09-BR11, QĐ06, QĐ07) ----------------
        /// <summary>tongTienHang là tiền hàng CHƯA gồm phí giao (QĐ06). Ngưỡng và bảng phí đọc từ CSDL (QĐ07).</summary>
        public KetQuaXuLy TinhPhiGiaoHang(string maKhuVuc, string maLoaiPhieu, decimal tongTienHang)
        {
            if (string.IsNullOrWhiteSpace(maLoaiPhieu)) return KetQuaXuLy.Loi("Vui lòng chọn loại phiếu đặt hàng.");
            if (string.IsNullOrWhiteSpace(maKhuVuc)) return KetQuaXuLy.Loi("Vui lòng chọn khu vực giao hàng.");
            try
            {
                DataTable lp = Db.Query("SELECT ThoiGianXuLyGio, NguongMienPhi FROM LoaiPhieuDat WHERE MaLoaiPhieu=@l", new SqlParameter("@l", maLoaiPhieu));
                if (lp.Rows.Count == 0) return KetQuaXuLy.Loi("Loại phiếu đặt hàng không hợp lệ.");
                int gio = Convert.ToInt32(lp.Rows[0]["ThoiGianXuLyGio"]);
                object nguong = lp.Rows[0]["NguongMienPhi"];

                if (nguong != DBNull.Value && tongTienHang >= Convert.ToDecimal(nguong))
                    return KetQuaXuLy.Ok("Miễn phí giao hàng.", new KetQuaPhi { Phi = 0m, MienPhi = true, ThoiGianXuLyGio = gio });

                object phi = Db.Scalar("SELECT PhiGiaoHang FROM BangPhiGiaoHang WHERE MaKhuVuc=@k AND MaLoaiPhieu=@l",
                    new SqlParameter("@k", maKhuVuc), new SqlParameter("@l", maLoaiPhieu));
                if (phi == null || phi == DBNull.Value)
                    return KetQuaXuLy.Loi("Chưa có biểu phí giao hàng cho khu vực và loại phiếu này. Vui lòng chọn loại khác.");
                return KetQuaXuLy.Ok("Đã tính phí giao hàng.", new KetQuaPhi { Phi = Convert.ToDecimal(phi), MienPhi = false, ThoiGianXuLyGio = gio });
            }
            catch (SqlException ex) { return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message); }
        }

        // ---------------- UC8: kiểm tra thông tin người nhận (BR12) ----------------
        public KetQuaXuLy KiemTraNguoiNhan(string hoTen, string diaChi, string soDienThoai)
        {
            if (string.IsNullOrWhiteSpace(hoTen) || hoTen.Trim().Length < 2) return KetQuaXuLy.Loi("Vui lòng nhập họ tên người nhận.");
            if (string.IsNullOrWhiteSpace(diaChi)) return KetQuaXuLy.Loi("Vui lòng nhập địa chỉ người nhận.");
            if (string.IsNullOrWhiteSpace(soDienThoai) || !Regex.IsMatch(soDienThoai.Trim(), @"^\d{9,11}$"))
                return KetQuaXuLy.Loi("Số điện thoại người nhận phải gồm 9-11 chữ số.");
            return KetQuaXuLy.Ok("Thông tin người nhận hợp lệ.");
        }

        // ---------------- UC9 + UC10: kiểm tra thẻ, ghi đơn, gửi email ----------------
        public KetQuaXuLy DatHang(DonHangDangLap don, TheThanhToan the)
        {
            if (don == null || the == null) return KetQuaXuLy.Loi("Thiếu thông tin đặt hàng.");
            if (!PhienLamViec.DaDangNhap) return KetQuaXuLy.Loi("Bạn cần đăng nhập để đặt hàng.");      // BR07, NFR08
            KhachHang kh = PhienLamViec.KhachHangHienTai;

            KetQuaXuLy kq = KiemTraNguoiNhan(don.HoTenNguoiNhan, don.DiaChiNguoiNhan, don.SoDienThoaiNguoiNhan);
            if (!kq.ThanhCong) return kq;
            kq = thanhToanSv.KiemTraDinhDang(the);                                                      // QĐ08
            if (!kq.ThanhCong) return kq;

            // Lấy lại giỏ + giá hiện hành, kiểm tra lại tồn kho (QĐ03, QĐ04)
            string maGio; DataTable gio;
            try
            {
                maGio = gioSv.LayMaGioHienTai(false);
                if (maGio == null) return KetQuaXuLy.Loi("Giỏ hàng đang trống.");
                gio = gioSv.LayChiTietGio(maGio);
            }
            catch (Exception ex) { return KetQuaXuLy.Loi("Không lấy được dữ liệu giỏ hàng/sản phẩm: " + ex.Message); }
            kq = gioSv.KiemTraGioHopLe(gio);
            if (!kq.ThanhCong) return kq;

            decimal tienHang = GioHangService.TongTamTinh(gio);
            kq = TinhPhiGiaoHang(don.MaKhuVuc, don.MaLoaiPhieu, tienHang);
            if (!kq.ThanhCong) return kq;
            KetQuaPhi phi = (KetQuaPhi)kq.Data;
            if (tienHang != don.TongTienHang || phi.Phi != don.PhiGiaoHang)
                return KetQuaXuLy.Loi("Giá sản phẩm hoặc phí giao hàng đã thay đổi so với lúc bạn xem. Vui lòng quay lại bước Đặt hàng để kiểm tra lại.");

            decimal tongGiaTri = tienHang + phi.Phi;
            decimal lePhi;
            try { lePhi = thanhToanSv.LayLePhi(the.MaLoaiThe); }
            catch (SqlException ex) { return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message); }

            // BR18, BR19, QĐ11, QĐ12: thẻ không hợp lệ -> không tạo đơn, giữ nguyên giỏ
            kq = thanhToanSv.KiemTraTheOnline(the, tongGiaTri + lePhi);
            if (!kq.ThanhCong) return kq;

            // Ghi đơn trong một giao dịch
            string maEmail = null;
            DateTime bay = DateTime.Now;
            DateTime hetHan = new DateTime(the.NgayHetHan.Year, the.NgayHetHan.Month, 1).AddMonths(1).AddDays(-1);
            string soThe = the.SoThe;
            try
            {
                using (SqlConnection cn = Db.MoKetNoi())
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        // Khóa giỏ trước: nếu giỏ đã được đặt rồi thì dừng (NFR09 - không ghi đơn trùng)
                        int n = Db.Execute(tx, "UPDATE GioHang SET TrangThai=0 WHERE MaGioHang=@g AND TrangThai=1", new SqlParameter("@g", maGio));
                        if (n == 0) { tx.Rollback(); return KetQuaXuLy.Loi("Giỏ hàng này đã được đặt hoặc không còn hiệu lực."); }

                        Db.Execute(tx, @"INSERT INTO DonDatHang (MaDonHang, MaKhachHang, NgayDat, HoTenNguoiNhan, DiaChiNguoiNhan, SoDienThoaiNguoiNhan,
                                                                 MaKhuVuc, MaLoaiPhieu, TongTienHang, PhiGiaoHang, TongGiaTri)
                                         VALUES (@ma,@kh,@ngay,@ten,@dc,@sdt,@kv,@lp,@th,@pg,@tg)",
                            new SqlParameter("@ma", don.MaDonHang), new SqlParameter("@kh", kh.MaKhachHang),
                            new SqlParameter("@ngay", bay),
                            new SqlParameter("@ten", don.HoTenNguoiNhan.Trim()), new SqlParameter("@dc", don.DiaChiNguoiNhan.Trim()),
                            new SqlParameter("@sdt", don.SoDienThoaiNguoiNhan.Trim()),
                            new SqlParameter("@kv", don.MaKhuVuc), new SqlParameter("@lp", don.MaLoaiPhieu),
                            new SqlParameter("@th", tienHang), new SqlParameter("@pg", phi.Phi), new SqlParameter("@tg", tongGiaTri));

                        foreach (DataRow r in gio.Rows)
                            Db.Execute(tx, "INSERT INTO ChiTietDonHang (MaChiTiet, MaDonHang, MaSanPham, SoLuong, DonGia) VALUES (@ct,@dh,@sp,@sl,@dg)",
                                new SqlParameter("@ct", "CD" + Guid.NewGuid().ToString("N")),
                                new SqlParameter("@dh", don.MaDonHang),
                                new SqlParameter("@sp", Convert.ToString(r["MaSanPham"])),
                                new SqlParameter("@sl", Convert.ToInt32(r["SoLuong"])),
                                new SqlParameter("@dg", Convert.ToDecimal(r["DonGia"])));    // đơn giá chốt (QĐ03)

                        // QĐ09: không lưu CSV, chỉ lưu 4 số cuối
                        Db.Execute(tx, @"INSERT INTO ThanhToan (MaThanhToan, MaDonHang, MaLoaiThe, BonSoCuoiThe, NgayHetHan, HoTenChuThe, LePhi, NgayThanhToan)
                                         VALUES (@tt,@dh,@lt,@so,@hh,@ten,@lp,@ngay)",
                            new SqlParameter("@tt", "TT" + Guid.NewGuid().ToString("N")),
                            new SqlParameter("@dh", don.MaDonHang), new SqlParameter("@lt", the.MaLoaiThe),
                            new SqlParameter("@so", soThe.Substring(soThe.Length - 4)),
                            new SqlParameter("@hh", hetHan), new SqlParameter("@ten", the.HoTenChuThe.Trim().ToUpper()),
                            new SqlParameter("@lp", lePhi), new SqlParameter("@ngay", bay));

                        if (!string.IsNullOrWhiteSpace(kh.Email))
                        {
                            maEmail = "EM" + Guid.NewGuid().ToString("N");
                            Db.Execute(tx, "INSERT INTO NhatKyEmail (MaEmail, MaDonHang, EmailNhan) VALUES (@e,@dh,@mail)",
                                new SqlParameter("@e", maEmail), new SqlParameter("@dh", don.MaDonHang), new SqlParameter("@mail", kh.Email.Trim()));
                        }
                        tx.Commit();
                    }
                    catch { try { tx.Rollback(); } catch (InvalidOperationException) { } throw; }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    don.MaDonHang = TaoMaDonHang();
                    return KetQuaXuLy.Loi("Mã đơn hàng bị trùng, vui lòng bấm thanh toán lại.");
                }
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu khi ghi đơn hàng: " + ex.Message);
            }

            // QĐ13: gửi email bất đồng bộ sau khi ghi đơn, lỗi thì thử lại, không hủy đơn
            if (maEmail != null) new EmailService().GuiBatDongBo(maEmail);
            return KetQuaXuLy.Ok("Đặt hàng thành công. Mã đơn hàng: " + don.MaDonHang, don.MaDonHang);
        }

        // ---------------- Truy vấn đơn hàng ----------------
        public DataTable LayDonHangCuaKhach(string maKhachHang)
        {
            return Db.Query(@"SELECT d.MaDonHang, d.NgayDat, d.HoTenNguoiNhan, kv.TenKhuVuc, lp.TenLoaiPhieu, d.PhiGiaoHang, d.TongGiaTri
                              FROM DonDatHang d
                              JOIN KhuVuc kv ON kv.MaKhuVuc = d.MaKhuVuc
                              JOIN LoaiPhieuDat lp ON lp.MaLoaiPhieu = d.MaLoaiPhieu
                              WHERE d.MaKhachHang=@kh ORDER BY d.NgayDat DESC",
                new SqlParameter("@kh", maKhachHang));
        }

        /// <summary>maKhachHang != null: chỉ xem đơn của chính mình (NFR08). Truyền null cho tiến trình nội bộ (email).</summary>
        public DataTable LayDonHang(string maDonHang, string maKhachHang)
        {
            return Db.Query(@"SELECT d.MaDonHang, d.NgayDat, d.HoTenNguoiNhan, d.DiaChiNguoiNhan, d.SoDienThoaiNguoiNhan,
                                     kv.TenKhuVuc, lp.TenLoaiPhieu, lp.ThoiGianXuLyGio,
                                     d.TongTienHang, d.PhiGiaoHang, d.TongGiaTri,
                                     (k.Ho + N' ' + k.Ten) AS HoTenNguoiMua
                              FROM DonDatHang d
                              JOIN KhachHang k ON k.MaKhachHang = d.MaKhachHang
                              JOIN KhuVuc kv ON kv.MaKhuVuc = d.MaKhuVuc
                              JOIN LoaiPhieuDat lp ON lp.MaLoaiPhieu = d.MaLoaiPhieu
                              WHERE d.MaDonHang=@dh AND (@kh IS NULL OR d.MaKhachHang=@kh)",
                new SqlParameter("@dh", maDonHang),
                new SqlParameter("@kh", string.IsNullOrEmpty(maKhachHang) ? (object)DBNull.Value : maKhachHang));
        }

        /// <summary>Chi tiết đơn: SoLuong, DonGia (giá chốt) từ CSDL; TenSanPham lấy từ Hệ thống quản lý sản phẩm.</summary>
        public DataTable LayChiTietDonHang(string maDonHang)
        {
            DataTable dt = Db.Query(@"SELECT MaSanPham, SoLuong, DonGia, CAST(SoLuong * DonGia AS DECIMAL(18,0)) AS ThanhTien
                                      FROM ChiTietDonHang WHERE MaDonHang=@dh ORDER BY MaChiTiet",
                new SqlParameter("@dh", maDonHang));
            dt.Columns.Add("TenSanPham", typeof(string));
            foreach (DataRow r in dt.Rows)
            {
                string ma = Convert.ToString(r["MaSanPham"]);
                try { SanPham sp = sanPhamSv.LayChiTiet(ma); r["TenSanPham"] = sp == null ? ma : sp.TenSanPham; }
                catch (Exception) { r["TenSanPham"] = ma; }     // hệ thống ngoài lỗi vẫn xem được đơn
            }
            return dt;
        }

        public DataTable LayNhatKyEmail(string maDonHang)
        {
            return Db.Query("SELECT MaEmail, EmailNhan, NgayGui, TrangThai, SoLanThu FROM NhatKyEmail WHERE MaDonHang=@dh",
                new SqlParameter("@dh", maDonHang));
        }
    }
}
