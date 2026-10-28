using System;
using System.Data;
using QuanLyCuaHangNuoc.Data;

namespace QuanLyCuaHangNuoc.Services
{
    public class ThongKeService
    {
        /// <summary>Một dòng tổng hợp theo khoảng ngày.</summary>
        public DataTable TongHop(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT
                (SELECT COUNT(*) FROM DonDatHang WHERE NgayDat BETWEEN @tu AND @den) AS SoDonDat,
                (SELECT COUNT(*) FROM PhieuGiaoHang WHERE NgayGiao BETWEEN @tu AND @den) AS SoPhieuGiao,
                (SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS SoHoaDon,
                (SELECT ISNULL(SUM(TongTien),0) FROM HoaDon WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS DoanhThu,
                (SELECT COUNT(*) FROM PhieuHen WHERE TrangThai=N'Chưa giao') AS SoHenChuaGiao,
                (SELECT COUNT(*) FROM PhieuGhiNo WHERE NgayLap BETWEEN @tu AND @den) AS SoPhieuNo,
                (SELECT ISNULL(SUM(SoTienNo),0) FROM PhieuGhiNo WHERE NgayLap BETWEEN @tu AND @den) AS TongNo",
                Db.P("@tu", tu.Date), Db.P("@den", den.Date));
        }

        public DataTable DoanhSoTheoHang(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT n.MaNGK,n.TenNGK,l.TenLoai,SUM(c.SoLuong) AS SoLuongBan,SUM(c.SoLuong*c.DonGia) AS DoanhThu
                              FROM ChiTietHoaDon c JOIN HoaDon h ON h.SoHD=c.SoHD JOIN NuocGiaiKhat n ON n.MaNGK=c.MaNGK JOIN LoaiNGK l ON l.MaLoai=n.MaLoai
                              WHERE CAST(h.NgayLap AS date) BETWEEN @tu AND @den
                              GROUP BY n.MaNGK,n.TenNGK,l.TenLoai ORDER BY DoanhThu DESC", Db.P("@tu", tu.Date), Db.P("@den", den.Date));
        }

        public DataTable TonKho()
        {
            return Db.Query(@"SELECT n.MaNGK,n.TenNGK,l.TenLoai,c.TenNCC,n.DonViTinh,n.SoLuongTon
                              FROM NuocGiaiKhat n JOIN LoaiNGK l ON l.MaLoai=n.MaLoai JOIN NhaCungCap c ON c.MaNCC=n.MaNCC ORDER BY n.SoLuongTon, n.MaNGK");
        }

        public DataTable DatHangNhanHang(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT d.SoDDH,c.TenNCC,d.NgayDat,d.NgayNhanDuKien,
                                     (SELECT COUNT(*) FROM PhieuGiaoHang p WHERE p.SoDDH=d.SoDDH) AS SoDotGiao,
                                     (SELECT ISNULL(SUM(p.SoTienPhaiTra),0) FROM PhieuGiaoHang p WHERE p.SoDDH=d.SoDDH) AS TongTienPhaiTra
                              FROM DonDatHang d JOIN NhaCungCap c ON c.MaNCC=d.MaNCC
                              WHERE d.NgayDat BETWEEN @tu AND @den ORDER BY d.NgayDat DESC", Db.P("@tu", tu.Date), Db.P("@den", den.Date));
        }

        public DataTable CongNo(DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT k.MaKH,k.HoTen,COUNT(*) AS SoPhieu,SUM(p.SoTienNo) AS TongNo,MIN(p.NgayDuKienTra) AS NgayTraSomNhat
                              FROM PhieuGhiNo p JOIN KhachHang k ON k.MaKH=p.MaKH
                              WHERE p.NgayLap BETWEEN @tu AND @den GROUP BY k.MaKH,k.HoTen ORDER BY TongNo DESC", Db.P("@tu", tu.Date), Db.P("@den", den.Date));
        }

        public DataTable HenChuaGiao()
        {
            return Db.Query(@"SELECT p.SoPhieuHen,p.SoHD,k.HoTen,p.NgayHen,SUM(c.SoLuongHen) AS TongSoLuong
                              FROM PhieuHen p JOIN HoaDon h ON h.SoHD=p.SoHD JOIN KhachHang k ON k.MaKH=h.MaKH JOIN ChiTietPhieuHen c ON c.SoPhieuHen=p.SoPhieuHen
                              WHERE p.TrangThai=N'Chưa giao' GROUP BY p.SoPhieuHen,p.SoHD,k.HoTen,p.NgayHen ORDER BY p.NgayHen");
        }
    }
}
