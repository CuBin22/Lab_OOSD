using System;
using System.Data;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Services
{
    /// <summary>Phân công hướng dẫn viên, kiểm tra trùng lịch, tính lương tháng.</summary>
    public static class PhanCongService
    {
        public static DataTable LayChuyen()
        {
            return Db.Query(
                "SELECT c.MaChuyen AS Ma, c.NgayDi, c.NgayVe, c.MaChuyen + N' - ' + t.TenTour + N' (' + CONVERT(nvarchar(10), c.NgayDi, 103) + N' - ' + CONVERT(nvarchar(10), c.NgayVe, 103) + N')' AS HienThi " +
                "FROM ChuyenTour c JOIN Tour t ON t.MaTour = c.MaTour ORDER BY c.NgayDi DESC");
        }

        public static DataTable LayDoan()
        {
            return Db.Query(
                "SELECT p.SoPhieu AS Ma, d.NgayDi, DATEADD(day, t.SoNgay - 1, d.NgayDi) AS NgayVe, " +
                "p.SoPhieu + N' - ' + k.TenKH + N' - ' + t.TenTour + N' (đi ' + CONVERT(nvarchar(10), d.NgayDi, 103) + N')' AS HienThi " +
                "FROM PhieuDangKyDoan d JOIN PhieuDangKy p ON p.SoPhieu = d.SoPhieu JOIN KhachHang k ON k.MaKH = p.MaKH " +
                "JOIN Tour t ON t.MaTour = d.MaTour WHERE p.TrangThai <> N'Đã hủy' ORDER BY d.NgayDi DESC");
        }

        public static DataTable LayLich(string maNV)
        {
            return Db.Query(
                "SELECT pc.MaPC, CASE WHEN pc.MaChuyen IS NOT NULL THEN N'Chuyến ' + pc.MaChuyen ELSE N'Đoàn ' + pc.SoPhieu END AS DoiTuong, " +
                "pc.NgayBatDau, pc.NgayKetThuc, pc.TienCongTour FROM PhanCong pc WHERE pc.MaNV = @nv ORDER BY pc.NgayBatDau",
                Hlp.P("@nv", maNV));
        }

        public static bool TrungLich(string maNV, DateTime tu, DateTime den)
        {
            object o = Db.Scalar(
                "SELECT COUNT(*) FROM PhanCong WHERE MaNV = @nv AND NgayBatDau <= @den AND NgayKetThuc >= @tu",
                Hlp.P("@nv", maNV), Hlp.P("@tu", tu.Date), Hlp.P("@den", den.Date));
            return Convert.ToInt32(o) > 0;
        }

        private static void KiemTraChung(string maNV, DateTime tu, DateTime den, decimal tienCong)
        {
            if (string.IsNullOrEmpty(maNV)) throw new InvalidOperationException("Chưa chọn nhân viên.");
            if (den.Date < tu.Date) throw new InvalidOperationException("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
            if (tienCong < 0) throw new InvalidOperationException("Tiền công không được âm.");
            if (TrungLich(maNV, tu, den))
                throw new InvalidOperationException("Nhân viên đã được phân công trong khoảng thời gian này (trùng lịch).");
        }

        /// <summary>Mỗi chuyến khách lẻ chỉ có một nhân viên.</summary>
        public static void PhanCongChuyen(string maNV, string maChuyen, DateTime tu, DateTime den, decimal tienCong)
        {
            if (string.IsNullOrEmpty(maChuyen)) throw new InvalidOperationException("Chưa chọn chuyến.");
            KiemTraChung(maNV, tu, den, tienCong);
            object co = Db.Scalar("SELECT COUNT(*) FROM PhanCong WHERE MaChuyen = @c", Hlp.P("@c", maChuyen));
            if (Convert.ToInt32(co) > 0)
                throw new InvalidOperationException("Chuyến này đã có hướng dẫn viên (mỗi chuyến khách lẻ chỉ có một nhân viên).");
            Db.Execute(
                "INSERT INTO PhanCong (MaPC, MaNV, MaChuyen, SoPhieu, NgayBatDau, NgayKetThuc, TienCongTour) VALUES (@pc, @nv, @c, NULL, @tu, @den, @tien)",
                Hlp.P("@pc", Hlp.MaTiepTheo("PhanCong", "MaPC", "PC", 5)), Hlp.P("@nv", maNV), Hlp.P("@c", maChuyen),
                Hlp.P("@tu", tu.Date), Hlp.P("@den", den.Date), Hlp.P("@tien", tienCong));
        }

        /// <summary>Đoàn đông có thể có nhiều nhân viên.</summary>
        public static void PhanCongDoan(string maNV, string soPhieu, DateTime tu, DateTime den, decimal tienCong)
        {
            if (string.IsNullOrEmpty(soPhieu)) throw new InvalidOperationException("Chưa chọn đoàn.");
            KiemTraChung(maNV, tu, den, tienCong);
            object co = Db.Scalar("SELECT COUNT(*) FROM PhanCong WHERE SoPhieu = @sp AND MaNV = @nv", Hlp.P("@sp", soPhieu), Hlp.P("@nv", maNV));
            if (Convert.ToInt32(co) > 0)
                throw new InvalidOperationException("Nhân viên này đã được phân công cho đoàn.");
            Db.Execute(
                "INSERT INTO PhanCong (MaPC, MaNV, MaChuyen, SoPhieu, NgayBatDau, NgayKetThuc, TienCongTour) VALUES (@pc, @nv, NULL, @sp, @tu, @den, @tien)",
                Hlp.P("@pc", Hlp.MaTiepTheo("PhanCong", "MaPC", "PC", 5)), Hlp.P("@nv", maNV), Hlp.P("@sp", soPhieu),
                Hlp.P("@tu", tu.Date), Hlp.P("@den", den.Date), Hlp.P("@tien", tienCong));
        }

        /// <summary>Lương tháng = lương căn bản + tiền công các tour kết thúc trong tháng.</summary>
        public static DataTable TinhLuong(int thang, int nam)
        {
            return Db.Query(
                "SELECT n.MaNV, n.HoTen, n.LuongCanBan, COUNT(pc.MaPC) AS SoTour, ISNULL(SUM(pc.TienCongTour), 0) AS LuongTheoTour, " +
                "n.LuongCanBan + ISNULL(SUM(pc.TienCongTour), 0) AS TongLuong " +
                "FROM NhanVien n LEFT JOIN PhanCong pc ON pc.MaNV = n.MaNV AND YEAR(pc.NgayKetThuc) = @nam AND MONTH(pc.NgayKetThuc) = @thang " +
                "GROUP BY n.MaNV, n.HoTen, n.LuongCanBan ORDER BY n.MaNV",
                Hlp.P("@nam", nam), Hlp.P("@thang", thang));
        }
    }
}
