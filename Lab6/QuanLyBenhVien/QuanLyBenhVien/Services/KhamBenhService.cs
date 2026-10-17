using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>Khám bệnh: lập phiếu khám cùng toa thuốc và xét nghiệm; tra cứu lịch sử bệnh án.</summary>
    public class KhamBenhService
    {
        public DataTable LayLichSu(string maHoSo)
        {
            return Db.Query(@"SELECT p.SoPhieuKham, FORMAT(p.NgayGioKham, 'dd/MM/yyyy HH:mm') AS NgayGioKham, p.LoaiKham,
                                     bs.HoTen AS TenBS, k.TenKhoa, ISNULL(p.TrieuChung, N'') AS TrieuChung, ISNULL(p.KetLuan, N'') AS KetLuan
                              FROM PhieuKham p
                              JOIN BacSi bs ON bs.MaBS = p.MaBS
                              JOIN Khoa k ON k.MaKhoa = p.MaKhoa
                              WHERE p.MaHoSo = @m ORDER BY p.NgayGioKham DESC", Db.P("@m", maHoSo));
        }

        public DataTable LayToaThuoc(string soPhieuKham)
        {
            return Db.Query(@"SELECT t.TenThuoc, c.SoLuong, c.LieuDung, c.CachDung
                              FROM ToaThuoc a
                              JOIN ChiTietToaThuoc c ON c.MaToa = a.MaToa
                              JOIN Thuoc t ON t.MaThuoc = c.MaThuoc
                              WHERE a.SoPhieuKham = @p ORDER BY t.TenThuoc", Db.P("@p", soPhieuKham));
        }

        public DataTable LayXetNghiem(string soPhieuKham)
        {
            return Db.Query(@"SELECT l.TenLoaiXN, CONVERT(varchar(10), x.NgayChiDinh, 103) AS NgayChiDinh,
                                     ISNULL(x.KetQua, N'') AS KetQua, ISNULL(CONVERT(varchar(10), x.NgayCoKetQua, 103), N'') AS NgayCoKetQua
                              FROM XetNghiem x JOIN LoaiXetNghiem l ON l.MaLoaiXN = x.MaLoaiXN
                              WHERE x.SoPhieuKham = @p ORDER BY l.TenLoaiXN", Db.P("@p", soPhieuKham));
        }

        /// <summary>Lưu phiếu khám + toa thuốc + xét nghiệm trong một lần xử lý (transaction).</summary>
        public KetQuaXuLy LuuPhieuKham(string soPhieu, string maHoSo, string maBS, string maKhoa, string maNV, DateTime ngayGio,
            string loaiKham, string trieuChung, decimal thanNhiet, string huyetAp, string ketLuan,
            string maToa, List<ThuocItem> toa, List<XetNghiemItem> xetNghiem)
        {
            try
            {
                using (SqlConnection cn = Db.MoKetNoi())
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    string loi = TaoPhieuKham(tx, soPhieu, maHoSo, maBS, maKhoa, maNV, ngayGio, loaiKham, trieuChung, thanNhiet,
                        huyetAp, ketLuan, null, maToa, toa, xetNghiem);
                    if (loi != null) return KetQuaXuLy.Fail(loi);
                    tx.Commit();
                    int soThuoc = toa == null ? 0 : toa.Count;
                    int soXN = xetNghiem == null ? 0 : xetNghiem.Count;
                    return KetQuaXuLy.Ok("Đã lưu phiếu khám " + soPhieu.Trim() + " (" + soThuoc + " thuốc, " + soXN + " xét nghiệm).");
                }
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi(ex);
            }
        }

        /// <summary>
        /// Lõi lập phiếu khám dùng chung cho khám bệnh và khám định kỳ.
        /// Trả về null nếu thành công, ngược lại là nguyên nhân từ chối. Caller chịu trách nhiệm Commit.
        /// </summary>
        internal static string TaoPhieuKham(SqlTransaction tx, string soPhieu, string maHoSo, string maBS, string maKhoa, string maNV,
            DateTime ngayGio, string loaiKham, string trieuChung, decimal? thanNhiet, string huyetAp, string ketLuan,
            string maLichHen, string maToa, List<ThuocItem> toa, List<XetNghiemItem> xetNghiem)
        {
            if (KiemTra.Rong(soPhieu) || KiemTra.Rong(maHoSo) || KiemTra.Rong(maNV)) return "Phiếu khám chưa đủ thông tin.";
            if (KiemTra.Rong(maBS)) return "Phiếu khám phải ghi rõ bác sĩ khám.";
            if (KiemTra.Rong(maKhoa)) return "Phiếu khám phải ghi khoa điều trị.";
            if (loaiKham != "Khám bệnh" && loaiKham != "Khám định kỳ") return "Loại khám không hợp lệ.";
            if (loaiKham == "Khám bệnh" && KiemTra.Rong(trieuChung)) return "Khám bệnh phải ghi triệu chứng.";
            if (thanNhiet.HasValue && (thanNhiet.Value < 30 || thanNhiet.Value > 45)) return "Thân nhiệt phải trong khoảng 30 - 45 °C.";
            if (ngayGio > DateTime.Now.AddMinutes(10)) return "Ngày giờ khám không được ở tương lai.";
            if (toa != null && toa.Count > 0 && KiemTra.Rong(maToa)) return "Toa thuốc phải có mã toa.";

            string loi = HoSoService.KiemTraDuDieuKienKham(tx, maHoSo.Trim(), ngayGio);
            if (loi != null) return loi;
            if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM PhieuKham WHERE SoPhieuKham = @m", soPhieu.Trim()) > 0) return "Số phiếu khám đã tồn tại.";
            if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM BacSi WHERE MaBS = @m", maBS) == 0) return "Không tìm thấy bác sĩ.";
            if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @m", maKhoa) == 0) return "Không tìm thấy khoa.";

            Db.Execute(tx, @"INSERT INTO PhieuKham(SoPhieuKham, MaHoSo, MaBS, MaKhoa, MaNV, NgayGioKham, LoaiKham, TrieuChung, ThanNhiet, HuyetAp, KetLuan, MaLichHen)
                             VALUES(@p, @h, @bs, @k, @nv, @n, @l, @tc, @tn, @ha, @kl, @lh)",
                Db.P("@p", soPhieu.Trim()), Db.P("@h", maHoSo.Trim()), Db.P("@bs", maBS), Db.P("@k", maKhoa), Db.P("@nv", maNV),
                Db.P("@n", ngayGio), Db.P("@l", loaiKham), Db.P("@tc", KiemTra.ChuoiHoacNull(trieuChung)), Db.P("@tn", thanNhiet),
                Db.P("@ha", KiemTra.ChuoiHoacNull(huyetAp)), Db.P("@kl", KiemTra.ChuoiHoacNull(ketLuan)), Db.P("@lh", maLichHen));

            if (toa != null && toa.Count > 0)
            {
                if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM ToaThuoc WHERE MaToa = @m", maToa.Trim()) > 0) return "Mã toa đã tồn tại.";
                Db.Execute(tx, "INSERT INTO ToaThuoc(MaToa, SoPhieuKham, NgayKe) VALUES(@t, @p, @n)",
                    Db.P("@t", maToa.Trim()), Db.P("@p", soPhieu.Trim()), Db.P("@n", ngayGio));
                HashSet<string> daCo = new HashSet<string>();
                foreach (ThuocItem x in toa)
                {
                    if (x.SoLuong <= 0) return "Số lượng thuốc " + x.TenThuoc + " phải lớn hơn 0.";
                    if (KiemTra.Rong(x.LieuDung) || KiemTra.Rong(x.CachDung)) return "Thuốc " + x.TenThuoc + " thiếu liều dùng hoặc cách dùng.";
                    if (!daCo.Add(x.MaThuoc)) return "Thuốc " + x.TenThuoc + " xuất hiện nhiều lần trong toa.";
                    Db.Execute(tx, "INSERT INTO ChiTietToaThuoc(MaToa, MaThuoc, SoLuong, LieuDung, CachDung) VALUES(@t, @m, @sl, @ld, @cd)",
                        Db.P("@t", maToa.Trim()), Db.P("@m", x.MaThuoc), Db.P("@sl", x.SoLuong), Db.P("@ld", x.LieuDung.Trim()), Db.P("@cd", x.CachDung.Trim()));
                }
            }

            if (xetNghiem != null)
            {
                HashSet<string> daCoXN = new HashSet<string>();
                foreach (XetNghiemItem x in xetNghiem)
                {
                    if (!daCoXN.Add(x.MaLoaiXN)) return "Loại xét nghiệm " + x.TenLoaiXN + " bị chỉ định nhiều lần.";
                    Db.Execute(tx, "INSERT INTO XetNghiem(MaXN, SoPhieuKham, MaLoaiXN, NgayChiDinh) VALUES(@x, @p, @l, @n)",
                        Db.P("@x", "XN-" + soPhieu.Trim() + "-" + x.MaLoaiXN), Db.P("@p", soPhieu.Trim()), Db.P("@l", x.MaLoaiXN), Db.P("@n", ngayGio.Date));
                }
            }
            return null;
        }
    }
}
