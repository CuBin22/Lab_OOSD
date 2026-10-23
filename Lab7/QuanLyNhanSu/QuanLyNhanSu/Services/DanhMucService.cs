using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>Phòng ban và hồ sơ nhân viên.</summary>
    public class DanhMucService
    {
        public DataTable LayPhongBan()
        {
            return Db.Query("SELECT MaPhongBan, TenPhongBan, MoTa FROM PhongBan ORDER BY MaPhongBan");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"SELECT n.MaNV, n.HoTen, n.CCCD, n.NgaySinh, n.GioiTinh, p.TenPhongBan, n.VaiTro, n.TrangThai
                              FROM NhanVien n LEFT JOIN PhongBan p ON n.MaPhongBan = p.MaPhongBan
                              ORDER BY n.MaNV");
        }

        /// <summary>Nhân viên chưa nghỉ việc, dùng nạp ComboBox. Có thể lọc theo vai trò (LIKE) và phòng ban.</summary>
        public DataTable LayNhanVienCombo(string mauVaiTro, string maPhongBan)
        {
            string sql = "SELECT MaNV, HoTen FROM NhanVien WHERE TrangThai <> N'Đã nghỉ'";
            List<SqlParameter> ps = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(mauVaiTro))
            {
                sql += " AND VaiTro LIKE @v";
                ps.Add(Db.P("@v", mauVaiTro));
            }
            if (!string.IsNullOrEmpty(maPhongBan))
            {
                sql += " AND MaPhongBan = @pb";
                ps.Add(Db.P("@pb", maPhongBan));
            }
            sql += " ORDER BY HoTen";
            return Db.Query(sql, ps.ToArray());
        }

        public KetQuaXuLy ThemPhongBan(string ma, string ten, string moTa)
        {
            if (KiemTra.Trong(ma) || KiemTra.Trong(ten))
                return KetQuaXuLy.Fail("Mã phòng ban và tên phòng ban không được để trống.");
            try
            {
                Db.Execute("INSERT INTO PhongBan(MaPhongBan, TenPhongBan, MoTa) VALUES(@m, @t, @mt)",
                    Db.P("@m", ma), Db.P("@t", ten), Db.P("@mt", KiemTra.Trong(moTa) ? null : moTa));
                return KetQuaXuLy.Ok("Đã thêm phòng ban.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }

        public KetQuaXuLy ThemNhanVien(string ma, string hoTen, string cccd, DateTime ngaySinh, string gioiTinh,
            string sdt, string maPhongBan, string vaiTro, string trangThai, string diaChi)
        {
            if (KiemTra.Trong(ma) || KiemTra.Trong(hoTen) || KiemTra.Trong(cccd))
                return KetQuaXuLy.Fail("Mã nhân viên, họ tên và CCCD không được để trống.");
            if (KiemTra.Trong(maPhongBan))
                return KetQuaXuLy.Fail("Chưa chọn phòng ban (hãy thêm phòng ban trước).");
            if (ngaySinh.Date > DateTime.Today.AddYears(-18))
                return KetQuaXuLy.Fail("Nhân viên phải đủ 18 tuổi.");
            try
            {
                Db.Execute(@"INSERT INTO NhanVien(MaNV, HoTen, CCCD, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaPhongBan, VaiTro, TrangThai)
                             VALUES(@m, @t, @c, @ns, @gt, @dc, @sdt, @pb, @vt, @tt)",
                    Db.P("@m", ma), Db.P("@t", hoTen), Db.P("@c", cccd), Db.P("@ns", ngaySinh.Date),
                    Db.P("@gt", KiemTra.Trong(gioiTinh) ? null : gioiTinh),
                    Db.P("@dc", KiemTra.Trong(diaChi) ? null : diaChi),
                    Db.P("@sdt", KiemTra.Trong(sdt) ? null : sdt),
                    Db.P("@pb", maPhongBan),
                    Db.P("@vt", KiemTra.Trong(vaiTro) ? null : vaiTro),
                    Db.P("@tt", KiemTra.Trong(trangThai) ? "Thử việc" : trangThai));
                return KetQuaXuLy.Ok("Đã thêm nhân viên.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }
    }
}
