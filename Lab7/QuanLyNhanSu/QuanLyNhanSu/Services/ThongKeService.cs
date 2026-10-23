using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>Tra cứu - thống kê nhân sự, lương, khen thưởng, kỷ luật theo khoảng thời gian.</summary>
    public class ThongKeService
    {
        public DataTable TongHop(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT
                (SELECT COUNT(*) FROM NhanVien WHERE TrangThai <> N'Đã nghỉ') AS TongNV,
                (SELECT COUNT(*) FROM NhanVien WHERE TrangThai = N'Thử việc') AS DangThuViec,
                (SELECT COUNT(*) FROM HopDong WHERE TrangThai = N'Hiệu lực') AS HopDongHieuLuc,
                (SELECT ISNULL(SUM(ThucLanh), 0) FROM BangLuong
                   WHERE DATEFROMPARTS(Nam, Thang, 1) BETWEEN @dauThang AND @den) AS TongThucLanh,
                (SELECT ISNULL(SUM(SoTien), 0) FROM QuyetDinhKhenThuong WHERE NgayKy BETWEEN @tu AND @den) AS TongThuong,
                (SELECT ISNULL(SUM(SoTienPhat), 0) FROM QuyetDinhKyLuat WHERE NgayKy BETWEEN @tu AND @den) AS TongPhat",
                Db.P("@tu", tu.Date), Db.P("@den", den.Date), Db.P("@dauThang", new DateTime(tu.Year, tu.Month, 1)));
        }

        public DataTable LuongTheoThang(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT CAST(Thang AS varchar(2)) + '/' + CAST(Nam AS varchar(4)) AS ThangNam,
                                     COUNT(*) AS SoNV, SUM(ThucLanh) AS TongThucLanh, SUM(TienPhuTroi) AS TongPhuTroi
                              FROM BangLuong
                              WHERE DATEFROMPARTS(Nam, Thang, 1) BETWEEN @dauThang AND @den
                              GROUP BY Nam, Thang
                              ORDER BY Nam, Thang",
                Db.P("@den", den.Date), Db.P("@dauThang", new DateTime(tu.Year, tu.Month, 1)));
        }

        public DataTable NhanSuTheoPhongBan()
        {
            return Db.Query(@"SELECT p.MaPhongBan, p.TenPhongBan, COUNT(n.MaNV) AS SoNhanVien,
                                     SUM(CASE WHEN n.TrangThai = N'Thử việc' THEN 1 ELSE 0 END) AS DangThuViec
                              FROM PhongBan p
                              LEFT JOIN NhanVien n ON n.MaPhongBan = p.MaPhongBan AND n.TrangThai <> N'Đã nghỉ'
                              GROUP BY p.MaPhongBan, p.TenPhongBan
                              ORDER BY p.MaPhongBan");
        }
    }
}
