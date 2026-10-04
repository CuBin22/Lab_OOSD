using eShopping.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eShopping.Models.Models;

namespace eShopping.Services
{
    internal class GioHangService
    {
        /// <summary>Đề bài chưa nêu giới hạn số lượng (vấn đề cần xác nhận số 3) - tạm đặt 99, đổi tại đây.</summary>
        public const int SoLuongToiDa = 99;

        private readonly SanPhamService sanPham = new SanPhamService();

        // ---------------- Giỏ hiện tại (QĐ05) ----------------
        public string LayMaGioHienTai(bool taoNeuChuaCo)
        {
            DataTable dt;
            if (PhienLamViec.DaDangNhap)
                dt = Db.Query("SELECT MaGioHang FROM GioHang WHERE MaKhachHang=@kh AND TrangThai=1",
                    new SqlParameter("@kh", PhienLamViec.KhachHangHienTai.MaKhachHang));
            else
                dt = Db.Query("SELECT MaGioHang FROM GioHang WHERE MaPhien=@p AND MaKhachHang IS NULL AND TrangThai=1",
                    new SqlParameter("@p", PhienLamViec.MaPhien));
            if (dt.Rows.Count > 0) return Convert.ToString(dt.Rows[0]["MaGioHang"]);
            if (!taoNeuChuaCo) return null;

            string ma = "GH" + Guid.NewGuid().ToString("N").Substring(0, 14).ToUpper();
            object kh = PhienLamViec.DaDangNhap ? (object)PhienLamViec.KhachHangHienTai.MaKhachHang : DBNull.Value;
            try
            {
                Db.Execute("INSERT INTO GioHang (MaGioHang, MaKhachHang, MaPhien) VALUES (@ma,@kh,@p)",
                    new SqlParameter("@ma", ma), new SqlParameter("@kh", kh), new SqlParameter("@p", PhienLamViec.MaPhien));
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627) return LayMaGioHienTai(false);   // vừa có giỏ khác được tạo
                throw;
            }
            return ma;
        }

        public DateTime? LayNgayTao(string maGio)
        {
            if (string.IsNullOrEmpty(maGio)) return null;
            object o = Db.Scalar("SELECT NgayTao FROM GioHang WHERE MaGioHang=@g", new SqlParameter("@g", maGio));
            return o == null || o == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(o);
        }

        /// <summary>Khi khách đăng nhập: gắn giỏ của phiên vào tài khoản, gộp nếu tài khoản đã có giỏ (QĐ05).</summary>
        public KetQuaXuLy GanGioVaoTaiKhoan(string maPhien, string maKhachHang)
        {
            try
            {
                DataTable s = Db.Query("SELECT MaGioHang FROM GioHang WHERE MaPhien=@p AND MaKhachHang IS NULL AND TrangThai=1",
                    new SqlParameter("@p", maPhien));
                if (s.Rows.Count == 0) return KetQuaXuLy.Ok("Không có giỏ hàng tạm cần gắn.");
                string gioPhien = Convert.ToString(s.Rows[0]["MaGioHang"]);

                DataTable c = Db.Query("SELECT MaGioHang FROM GioHang WHERE MaKhachHang=@kh AND TrangThai=1",
                    new SqlParameter("@kh", maKhachHang));
                if (c.Rows.Count == 0)
                {
                    Db.Execute("UPDATE GioHang SET MaKhachHang=@kh WHERE MaGioHang=@g",
                        new SqlParameter("@kh", maKhachHang), new SqlParameter("@g", gioPhien));
                    return KetQuaXuLy.Ok("Đã gắn giỏ hàng vào tài khoản.");
                }

                string gioKhach = Convert.ToString(c.Rows[0]["MaGioHang"]);
                using (SqlConnection cn = Db.MoKetNoi())
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        // 1. Sản phẩm trùng: cộng dồn (không vượt mức tối đa)
                        Db.Execute(tx, @"UPDATE c SET c.SoLuong = CASE WHEN c.SoLuong + s.SoLuong > @max THEN @max ELSE c.SoLuong + s.SoLuong END
                                         FROM ChiTietGioHang c JOIN ChiTietGioHang s ON s.MaSanPham = c.MaSanPham AND s.MaGioHang=@s
                                         WHERE c.MaGioHang=@c",
                            new SqlParameter("@max", SoLuongToiDa), new SqlParameter("@s", gioPhien), new SqlParameter("@c", gioKhach));
                        Db.Execute(tx, @"DELETE FROM ChiTietGioHang WHERE MaGioHang=@s
                                         AND MaSanPham IN (SELECT MaSanPham FROM ChiTietGioHang WHERE MaGioHang=@c)",
                            new SqlParameter("@s", gioPhien), new SqlParameter("@c", gioKhach));
                        // 2. Sản phẩm còn lại: chuyển sang giỏ của khách
                        Db.Execute(tx, "UPDATE ChiTietGioHang SET MaGioHang=@c WHERE MaGioHang=@s",
                            new SqlParameter("@c", gioKhach), new SqlParameter("@s", gioPhien));
                        Db.Execute(tx, "UPDATE GioHang SET TrangThai=0 WHERE MaGioHang=@s", new SqlParameter("@s", gioPhien));
                        tx.Commit();
                    }
                    catch { tx.Rollback(); throw; }
                }
                return KetQuaXuLy.Ok("Đã gộp giỏ hàng vào tài khoản.");
            }
            catch (SqlException ex)
            {
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        // ---------------- Thêm sản phẩm (UC3) ----------------
        public KetQuaXuLy ThemSanPham(string maSanPham, int soLuong)
        {
            if (string.IsNullOrWhiteSpace(maSanPham)) return KetQuaXuLy.Loi("Vui lòng chọn một sản phẩm.");
            if (soLuong < 1 || soLuong > SoLuongToiDa)
                return KetQuaXuLy.Loi("Số lượng phải từ 1 đến " + SoLuongToiDa + ".");

            SanPham sp;
            try { sp = sanPham.LayChiTiet(maSanPham.Trim()); }
            catch (Exception ex) { return KetQuaXuLy.Loi("Không kết nối được Hệ thống quản lý sản phẩm: " + ex.Message); }
            if (sp == null) return KetQuaXuLy.Loi("Không tìm thấy sản phẩm.");
            if (!sp.ConHang) return KetQuaXuLy.Loi("Sản phẩm \"" + sp.TenSanPham + "\" đã hết hàng.");   // QĐ04

            try
            {
                string gio = LayMaGioHienTai(true);
                object cur = Db.Scalar("SELECT SoLuong FROM ChiTietGioHang WHERE MaGioHang=@g AND MaSanPham=@sp",
                    new SqlParameter("@g", gio), new SqlParameter("@sp", sp.MaSanPham));
                int hienCo = (cur == null || cur == DBNull.Value) ? 0 : Convert.ToInt32(cur);
                if (hienCo + soLuong > SoLuongToiDa)
                    return KetQuaXuLy.Loi("Mỗi sản phẩm chỉ mua tối đa " + SoLuongToiDa + " cái (trong giỏ đang có " + hienCo + ").");

                int n = Db.Execute("UPDATE ChiTietGioHang SET SoLuong = SoLuong + @sl WHERE MaGioHang=@g AND MaSanPham=@sp",
                    new SqlParameter("@sl", soLuong), new SqlParameter("@g", gio), new SqlParameter("@sp", sp.MaSanPham));
                if (n == 0)
                    Db.Execute("INSERT INTO ChiTietGioHang (MaChiTiet, MaGioHang, MaSanPham, SoLuong) VALUES (@ct,@g,@sp,@sl)",
                        new SqlParameter("@ct", "CT" + Guid.NewGuid().ToString("N")),
                        new SqlParameter("@g", gio), new SqlParameter("@sp", sp.MaSanPham), new SqlParameter("@sl", soLuong));
                return KetQuaXuLy.Ok("Đã thêm " + soLuong + " \"" + sp.TenSanPham + "\" vào giỏ hàng.");
            }
            catch (SqlException ex)
            {
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        // ---------------- Xem giỏ (UC4): đơn giá luôn lấy theo giá hiện hành (BR04) ----------------
        /// <summary>Có thể ném Exception nếu Hệ thống quản lý sản phẩm không phản hồi - form phải bắt (NFR10).</summary>
        public DataTable LayChiTietGio(string maGio)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaChiTiet", typeof(string));
            dt.Columns.Add("MaSanPham", typeof(string));
            dt.Columns.Add("TenSanPham", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(decimal));
            dt.Columns.Add("ThanhTien", typeof(decimal));
            dt.Columns.Add("ConHang", typeof(bool));
            if (string.IsNullOrEmpty(maGio)) return dt;

            DataTable ct = Db.Query("SELECT MaChiTiet, MaSanPham, SoLuong FROM ChiTietGioHang WHERE MaGioHang=@g ORDER BY MaChiTiet",
                new SqlParameter("@g", maGio));
            foreach (DataRow r in ct.Rows)
            {
                string ma = Convert.ToString(r["MaSanPham"]);
                int sl = Convert.ToInt32(r["SoLuong"]);
                SanPham sp = sanPham.LayChiTiet(ma);
                string ten = sp == null ? "(Không còn trong hệ thống) " + ma : sp.TenSanPham;
                decimal gia = sp == null ? 0m : sp.GiaBan;
                bool con = sp != null && sp.ConHang;
                dt.Rows.Add(Convert.ToString(r["MaChiTiet"]), ma, ten, sl, gia, gia * sl, con);
            }
            dt.AcceptChanges();
            return dt;
        }

        public static decimal TongTamTinh(DataTable gio)
        {
            decimal tong = 0m;
            if (gio == null) return tong;
            foreach (DataRow r in gio.Rows) tong += Convert.ToDecimal(r["ThanhTien"]);
            return tong;
        }

        /// <summary>Giỏ phải có hàng và mọi sản phẩm còn hàng (QĐ04) trước khi tính tiền / đặt hàng.</summary>
        public KetQuaXuLy KiemTraGioHopLe(DataTable gio)
        {
            if (gio == null || gio.Rows.Count == 0) return KetQuaXuLy.Loi("Giỏ hàng đang trống.");
            foreach (DataRow r in gio.Rows)
                if (!Convert.ToBoolean(r["ConHang"]))
                    return KetQuaXuLy.Loi("Sản phẩm \"" + Convert.ToString(r["TenSanPham"]) + "\" đã hết hàng. Vui lòng xóa khỏi giỏ để tiếp tục.");
            return KetQuaXuLy.Ok("Giỏ hàng hợp lệ.");
        }

        // ---------------- Xóa / cập nhật (UC4) ----------------
        public KetQuaXuLy XoaSanPham(string maChiTiet)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet)) return KetQuaXuLy.Loi("Vui lòng chọn sản phẩm cần xóa.");
            try
            {
                int n = Db.Execute("DELETE FROM ChiTietGioHang WHERE MaChiTiet=@ct", new SqlParameter("@ct", maChiTiet));
                return n > 0 ? KetQuaXuLy.Ok("Đã xóa sản phẩm khỏi giỏ hàng.") : KetQuaXuLy.Loi("Không tìm thấy sản phẩm trong giỏ.");
            }
            catch (SqlException ex) { return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message); }
        }

        /// <summary>Cập nhật số lượng nhiều dòng trong một giao dịch: khóa = MaChiTiet, giá trị = số lượng mới.</summary>
        public KetQuaXuLy CapNhatSoLuong(IDictionary<string, int> soLuongMoi)
        {
            if (soLuongMoi == null || soLuongMoi.Count == 0) return KetQuaXuLy.Loi("Không có số lượng nào thay đổi.");
            foreach (KeyValuePair<string, int> kv in soLuongMoi)
                if (kv.Value < 1 || kv.Value > SoLuongToiDa)
                    return KetQuaXuLy.Loi("Số lượng phải là số nguyên từ 1 đến " + SoLuongToiDa + " (muốn bỏ sản phẩm hãy dùng nút Xóa).");
            try
            {
                using (SqlConnection cn = Db.MoKetNoi())
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        foreach (KeyValuePair<string, int> kv in soLuongMoi)
                            Db.Execute(tx, "UPDATE ChiTietGioHang SET SoLuong=@sl WHERE MaChiTiet=@ct",
                                new SqlParameter("@sl", kv.Value), new SqlParameter("@ct", kv.Key));
                        tx.Commit();
                    }
                    catch { tx.Rollback(); throw; }
                }
                return KetQuaXuLy.Ok("Cập nhật số lượng thành công.");
            }
            catch (SqlException ex) { return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message); }
        }
    }
}
