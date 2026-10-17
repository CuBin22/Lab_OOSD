using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>Danh mục: khoa, bác sĩ, nhân viên, loại xét nghiệm, thuốc.</summary>
    public class DanhMucService
    {
        public DataTable LayKhoa()
        {
            return Db.Query("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY MaKhoa");
        }

        public DataTable LayBacSi()
        {
            return Db.Query(@"SELECT b.MaBS, b.HoTen, b.MaKhoa, k.TenKhoa, b.SoDienThoai
                              FROM BacSi b JOIN Khoa k ON k.MaKhoa = b.MaKhoa ORDER BY b.MaBS");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query("SELECT MaNV, HoTen, VaiTro, SoDienThoai FROM NhanVien ORDER BY MaNV");
        }

        public DataTable LayLoaiXetNghiem()
        {
            return Db.Query("SELECT MaLoaiXN, TenLoaiXN FROM LoaiXetNghiem ORDER BY MaLoaiXN");
        }

        public DataTable LayThuoc()
        {
            return Db.Query("SELECT MaThuoc, TenThuoc, DonViTinh, ISNULL(PhanUngPhu, N'') AS PhanUngPhu FROM Thuoc ORDER BY MaThuoc");
        }

        /// <summary>Danh sách người dùng theo vai trò (cột Ma, HoTen) cho màn hình đăng nhập.</summary>
        public DataTable LayNguoiTheoVaiTro(string vaiTro)
        {
            if (vaiTro == PhienLamViec.BacSi)
                return Db.Query("SELECT MaBS AS Ma, HoTen FROM BacSi ORDER BY MaBS");
            return Db.Query("SELECT MaNV AS Ma, HoTen FROM NhanVien WHERE VaiTro = @v ORDER BY MaNV", Db.P("@v", vaiTro));
        }

        private KetQuaXuLy ThucThi(string sql, string thongBaoOk, params SqlParameter[] ps)
        {
            try
            {
                Db.Execute(sql, ps);
                return KetQuaXuLy.Ok(thongBaoOk);
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi(ex);
            }
        }

        public KetQuaXuLy ThemKhoa(string ma, string ten)
        {
            if (KiemTra.Rong(ma) || KiemTra.Rong(ten)) return KetQuaXuLy.Fail("Mã khoa và tên khoa không được để trống.");
            return ThucThi("INSERT INTO Khoa(MaKhoa, TenKhoa) VALUES(@m, @t)", "Đã thêm khoa.",
                Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()));
        }

        public KetQuaXuLy ThemBacSi(string ma, string hoTen, string maKhoa, string sdt)
        {
            if (KiemTra.Rong(ma) || KiemTra.Rong(hoTen) || KiemTra.Rong(maKhoa)) return KetQuaXuLy.Fail("Thông tin bác sĩ chưa đầy đủ.");
            if (!KiemTra.Rong(sdt) && !KiemTra.LaSoDienThoai(sdt)) return KetQuaXuLy.Fail("Số điện thoại không hợp lệ.");
            return ThucThi("INSERT INTO BacSi(MaBS, HoTen, MaKhoa, SoDienThoai) VALUES(@m, @t, @k, @s)", "Đã thêm bác sĩ.",
                Db.P("@m", ma.Trim()), Db.P("@t", hoTen.Trim()), Db.P("@k", maKhoa), Db.P("@s", KiemTra.ChuoiHoacNull(sdt)));
        }

        public KetQuaXuLy ThemNhanVien(string ma, string hoTen, string vaiTro, string sdt)
        {
            if (KiemTra.Rong(ma) || KiemTra.Rong(hoTen) || KiemTra.Rong(vaiTro)) return KetQuaXuLy.Fail("Thông tin nhân viên chưa đầy đủ.");
            if (!KiemTra.Rong(sdt) && !KiemTra.LaSoDienThoai(sdt)) return KetQuaXuLy.Fail("Số điện thoại không hợp lệ.");
            return ThucThi("INSERT INTO NhanVien(MaNV, HoTen, VaiTro, SoDienThoai) VALUES(@m, @t, @v, @s)", "Đã thêm nhân viên.",
                Db.P("@m", ma.Trim()), Db.P("@t", hoTen.Trim()), Db.P("@v", vaiTro), Db.P("@s", KiemTra.ChuoiHoacNull(sdt)));
        }

        public KetQuaXuLy ThemLoaiXetNghiem(string ma, string ten)
        {
            if (KiemTra.Rong(ma) || KiemTra.Rong(ten)) return KetQuaXuLy.Fail("Thông tin loại xét nghiệm chưa đủ.");
            return ThucThi("INSERT INTO LoaiXetNghiem(MaLoaiXN, TenLoaiXN) VALUES(@m, @t)", "Đã thêm loại xét nghiệm.",
                Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()));
        }

        public KetQuaXuLy ThemThuoc(string ma, string ten, string dvt, string phanUngPhu)
        {
            if (KiemTra.Rong(ma) || KiemTra.Rong(ten) || KiemTra.Rong(dvt)) return KetQuaXuLy.Fail("Thông tin thuốc chưa đầy đủ.");
            return ThucThi("INSERT INTO Thuoc(MaThuoc, TenThuoc, DonViTinh, PhanUngPhu) VALUES(@m, @t, @d, @p)", "Đã thêm thuốc.",
                Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@d", dvt.Trim()), Db.P("@p", KiemTra.ChuoiHoacNull(phanUngPhu)));
        }
    }
}
