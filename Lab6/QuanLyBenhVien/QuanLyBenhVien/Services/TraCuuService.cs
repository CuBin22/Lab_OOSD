using System;
using System.Data;
using System.Globalization;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>Tái khám - tra cứu hồ sơ theo mã hoặc thông tin thay thế (họ tên, ngày sinh, điện thoại).</summary>
    public class TraCuuService
    {
        public DataTable TimHoSo(string tieuChi, string tuKhoa)
        {
            tuKhoa = (tuKhoa ?? "").Trim();
            string order = " ORDER BY b.HoTen, h.MaHoSo";
            switch (tieuChi)
            {
                case "Mã hồ sơ":
                    return Db.Query(HoSoService.SelectHoSo + "WHERE h.MaHoSo LIKE N'%' + @k + N'%'" + order, Db.P("@k", tuKhoa));
                case "Họ tên":
                    return Db.Query(HoSoService.SelectHoSo + "WHERE b.HoTen LIKE N'%' + @k + N'%'" + order, Db.P("@k", tuKhoa));
                case "Điện thoại":
                    return Db.Query(HoSoService.SelectHoSo + "WHERE b.DienThoai LIKE N'%' + @k + N'%'" + order, Db.P("@k", tuKhoa));
                case "Ngày sinh":
                    DateTime ns;
                    if (!DateTime.TryParseExact(tuKhoa, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ns))
                        throw new ArgumentException("Ngày sinh phải theo định dạng dd/MM/yyyy.");
                    return Db.Query(HoSoService.SelectHoSo + "WHERE b.NgaySinh = @d" + order, Db.P("@d", ns.Date));
                default:
                    throw new ArgumentException("Tiêu chí tìm kiếm không hợp lệ.");
            }
        }
    }
}
