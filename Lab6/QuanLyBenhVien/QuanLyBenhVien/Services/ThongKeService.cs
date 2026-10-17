using System;
using System.Data;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>Theo dõi - thống kê: theo bác sĩ (trách nhiệm điều trị), thuốc và phản ứng phụ, diễn biến theo hồ sơ.</summary>
    public class ThongKeService
    {
        /// <summary>Danh sách bác sĩ để lọc, dòng đầu là "Tất cả" (MaBS rỗng).</summary>
        public DataTable LayBacSiLoc()
        {
            return Db.Query(@"SELECT CAST('' AS varchar(20)) AS MaBS, N'Tất cả' AS HoTen, 0 AS Thu
                              UNION ALL
                              SELECT MaBS, HoTen, 1 FROM BacSi
                              ORDER BY Thu, MaBS");
        }

        public DataTable TongHop(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT
                (SELECT COUNT(*) FROM HoSoBenhAn WHERE NgayCap BETWEEN @tu AND @den) AS SoHoSoMoi,
                (SELECT COUNT(*) FROM PhieuKham WHERE CAST(NgayGioKham AS date) BETWEEN @tu AND @den) AS SoPhieuKham,
                (SELECT COUNT(*) FROM PhieuKham WHERE LoaiKham = N'Khám định kỳ' AND CAST(NgayGioKham AS date) BETWEEN @tu AND @den) AS SoKhamDinhKy,
                (SELECT ISNULL(SUM(SoTien), 0) FROM LePhi WHERE CAST(NgayDong AS date) BETWEEN @tu AND @den) AS TongLePhi,
                (SELECT ISNULL(SUM(SoTien), 0) FROM ThanhToanVienPhi WHERE CAST(NgayThanhToan AS date) BETWEEN @tu AND @den) AS TongVienPhi",
                Db.P("@tu", tu.Date), Db.P("@den", den.Date));
        }

        public DataTable TheoBacSi(DateTime tu, DateTime den, string maBS)
        {
            return Db.Query(@"SELECT b.MaBS, b.HoTen AS TenBS, k.TenKhoa, COUNT(p.SoPhieuKham) AS SoPhieuKham,
                                     SUM(CASE WHEN p.LoaiKham = N'Khám bệnh' THEN 1 ELSE 0 END) AS SoKhamBenh,
                                     SUM(CASE WHEN p.LoaiKham = N'Khám định kỳ' THEN 1 ELSE 0 END) AS SoKhamDinhKy
                              FROM BacSi b
                              JOIN Khoa k ON k.MaKhoa = b.MaKhoa
                              LEFT JOIN PhieuKham p ON p.MaBS = b.MaBS AND CAST(p.NgayGioKham AS date) BETWEEN @tu AND @den
                              WHERE (@bs = '' OR b.MaBS = @bs)
                              GROUP BY b.MaBS, b.HoTen, k.TenKhoa
                              ORDER BY COUNT(p.SoPhieuKham) DESC, b.MaBS",
                Db.P("@tu", tu.Date), Db.P("@den", den.Date), Db.P("@bs", maBS ?? ""));
        }

        public DataTable TheoThuoc(DateTime tu, DateTime den, string maBS)
        {
            return Db.Query(@"SELECT t.MaThuoc, t.TenThuoc, COUNT(DISTINCT a.MaToa) AS SoLanKe, SUM(c.SoLuong) AS TongSoLuong,
                                     ISNULL(t.PhanUngPhu, N'') AS PhanUngPhu
                              FROM ChiTietToaThuoc c
                              JOIN ToaThuoc a ON a.MaToa = c.MaToa
                              JOIN PhieuKham p ON p.SoPhieuKham = a.SoPhieuKham
                              JOIN Thuoc t ON t.MaThuoc = c.MaThuoc
                              WHERE CAST(p.NgayGioKham AS date) BETWEEN @tu AND @den AND (@bs = '' OR p.MaBS = @bs)
                              GROUP BY t.MaThuoc, t.TenThuoc, t.PhanUngPhu
                              ORDER BY COUNT(DISTINCT a.MaToa) DESC, t.MaThuoc",
                Db.P("@tu", tu.Date), Db.P("@den", den.Date), Db.P("@bs", maBS ?? ""));
        }

        public DataTable TheoHoSo(DateTime tu, DateTime den, string maBS)
        {
            return Db.Query(@"SELECT h.MaHoSo, b.HoTen, COUNT(p.SoPhieuKham) AS SoDotDieuTri,
                                     FORMAT(MAX(p.NgayGioKham), 'dd/MM/yyyy HH:mm') AS LanKhamGanNhat,
                                     ISNULL((SELECT TOP 1 p2.KetLuan FROM PhieuKham p2
                                             WHERE p2.MaHoSo = h.MaHoSo AND CAST(p2.NgayGioKham AS date) BETWEEN @tu AND @den
                                               AND (@bs = '' OR p2.MaBS = @bs)
                                             ORDER BY p2.NgayGioKham DESC), N'') AS KetLuanGanNhat
                              FROM HoSoBenhAn h
                              JOIN BenhNhan b ON b.MaBN = h.MaBN
                              JOIN PhieuKham p ON p.MaHoSo = h.MaHoSo
                              WHERE CAST(p.NgayGioKham AS date) BETWEEN @tu AND @den AND (@bs = '' OR p.MaBS = @bs)
                              GROUP BY h.MaHoSo, b.HoTen
                              ORDER BY MAX(p.NgayGioKham) DESC",
                Db.P("@tu", tu.Date), Db.P("@den", den.Date), Db.P("@bs", maBS ?? ""));
        }
    }
}
