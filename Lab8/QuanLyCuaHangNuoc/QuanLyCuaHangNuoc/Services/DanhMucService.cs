using System;
using System.Data;
using QuanLyCuaHangNuoc.Data;

namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Danh mục: nhãn hiệu, nhà cung ứng, nước giải khát, nhân viên, khách hàng.</summary>
    public class DanhMucService
    {
        static string Like(string kw) { return "%" + (kw ?? "").Trim() + "%"; }
        static string Rong(string s) { return string.IsNullOrWhiteSpace(s) ? null : s.Trim(); }
        static bool Thieu(params string[] ds)
        {
            foreach (string s in ds) if (string.IsNullOrWhiteSpace(s)) return true;
            return false;
        }
        static string KetQuaDong(int n, string ok)
        {
            if (n == 0) throw new NghiepVuException("Không tìm thấy bản ghi cần cập nhật.");
            return ok;
        }

        // ---------------- Nhãn hiệu ----------------
        public DataTable LayLoai(string kw = null)
        {
            return Db.Query("SELECT MaLoai,TenLoai FROM LoaiNGK WHERE MaLoai LIKE @k OR TenLoai LIKE @k ORDER BY MaLoai", Db.P("@k", Like(kw)));
        }
        public KetQuaXuLy ThemLoai(string ma, string ten)
        {
            if (Thieu(ma, ten)) return KetQuaXuLy.Fail("Mã loại và tên loại không được để trống.");
            return KetQuaXuLy.Chay(() =>
            {
                Db.Execute("INSERT INTO LoaiNGK(MaLoai,TenLoai) VALUES(@m,@t)", Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()));
                return "Đã thêm nhãn hiệu.";
            });
        }
        public KetQuaXuLy SuaLoai(string ma, string ten)
        {
            if (Thieu(ma, ten)) return KetQuaXuLy.Fail("Mã loại và tên loại không được để trống.");
            return KetQuaXuLy.Chay(() => KetQuaDong(
                Db.Execute("UPDATE LoaiNGK SET TenLoai=@t WHERE MaLoai=@m", Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim())), "Đã cập nhật nhãn hiệu."));
        }
        public KetQuaXuLy XoaLoai(string ma)
        {
            if (Thieu(ma)) return KetQuaXuLy.Fail("Chưa chọn nhãn hiệu cần xóa.");
            return KetQuaXuLy.Chay(() => KetQuaDong(
                Db.Execute("DELETE FROM LoaiNGK WHERE MaLoai=@m", Db.P("@m", ma.Trim())), "Đã xóa nhãn hiệu."),
                "Không thể xóa nhãn hiệu vì còn mặt hàng tham chiếu.");
        }

        // ---------------- Nhà cung ứng ----------------
        public DataTable LayNCC(string kw = null)
        {
            return Db.Query("SELECT MaNCC,TenNCC,DiaChi,DienThoai FROM NhaCungCap WHERE MaNCC LIKE @k OR TenNCC LIKE @k OR DienThoai LIKE @k ORDER BY MaNCC", Db.P("@k", Like(kw)));
        }
        public KetQuaXuLy ThemNCC(string ma, string ten, string diaChi, string dt)
        {
            if (Thieu(ma, ten, diaChi, dt)) return KetQuaXuLy.Fail("Mã, tên, địa chỉ và điện thoại nhà cung ứng là bắt buộc.");
            return KetQuaXuLy.Chay(() =>
            {
                Db.Execute("INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai) VALUES(@m,@t,@d,@s)",
                    Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@d", diaChi.Trim()), Db.P("@s", dt.Trim()));
                return "Đã thêm nhà cung ứng.";
            });
        }
        public KetQuaXuLy SuaNCC(string ma, string ten, string diaChi, string dt)
        {
            if (Thieu(ma, ten, diaChi, dt)) return KetQuaXuLy.Fail("Mã, tên, địa chỉ và điện thoại nhà cung ứng là bắt buộc.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute("UPDATE NhaCungCap SET TenNCC=@t,DiaChi=@d,DienThoai=@s WHERE MaNCC=@m",
                Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@d", diaChi.Trim()), Db.P("@s", dt.Trim())), "Đã cập nhật nhà cung ứng."));
        }
        public KetQuaXuLy XoaNCC(string ma)
        {
            if (Thieu(ma)) return KetQuaXuLy.Fail("Chưa chọn nhà cung ứng cần xóa.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute("DELETE FROM NhaCungCap WHERE MaNCC=@m", Db.P("@m", ma.Trim())), "Đã xóa nhà cung ứng."),
                "Không thể xóa nhà cung ứng vì còn mặt hàng hoặc đơn đặt hàng tham chiếu.");
        }

        // ---------------- Nước giải khát ----------------
        public DataTable LayNGK(string kw = null)
        {
            return Db.Query(@"SELECT n.MaNGK,n.TenNGK,n.DonViTinh,n.MaLoai,l.TenLoai,n.MaNCC,c.TenNCC,n.DonGia,n.SoLuongTon
                              FROM NuocGiaiKhat n JOIN LoaiNGK l ON l.MaLoai=n.MaLoai JOIN NhaCungCap c ON c.MaNCC=n.MaNCC
                              WHERE n.MaNGK LIKE @k OR n.TenNGK LIKE @k OR l.TenLoai LIKE @k OR c.TenNCC LIKE @k ORDER BY n.MaNGK", Db.P("@k", Like(kw)));
        }
        public KetQuaXuLy ThemNGK(string ma, string ten, string dvt, string loai, string ncc, decimal gia)
        {
            if (Thieu(ma, ten, dvt, loai, ncc)) return KetQuaXuLy.Fail("Mã, tên, đơn vị tính, nhãn hiệu và nhà cung ứng là bắt buộc.");
            if (gia < 0) return KetQuaXuLy.Fail("Đơn giá không được âm.");
            return KetQuaXuLy.Chay(() =>
            {
                Db.Execute("INSERT INTO NuocGiaiKhat(MaNGK,TenNGK,DonViTinh,MaLoai,MaNCC,DonGia,SoLuongTon) VALUES(@m,@t,@d,@l,@c,@g,0)",
                    Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@d", dvt.Trim()), Db.P("@l", loai), Db.P("@c", ncc), Db.P("@g", gia));
                return "Đã thêm nước giải khát.";
            });
        }
        public KetQuaXuLy SuaNGK(string ma, string ten, string dvt, string loai, string ncc, decimal gia)
        {
            if (Thieu(ma, ten, dvt, loai, ncc)) return KetQuaXuLy.Fail("Mã, tên, đơn vị tính, nhãn hiệu và nhà cung ứng là bắt buộc.");
            if (gia < 0) return KetQuaXuLy.Fail("Đơn giá không được âm.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute(
                "UPDATE NuocGiaiKhat SET TenNGK=@t,DonViTinh=@d,MaLoai=@l,MaNCC=@c,DonGia=@g WHERE MaNGK=@m",
                Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@d", dvt.Trim()), Db.P("@l", loai), Db.P("@c", ncc), Db.P("@g", gia)),
                "Đã cập nhật nước giải khát."));
        }
        public KetQuaXuLy XoaNGK(string ma)
        {
            if (Thieu(ma)) return KetQuaXuLy.Fail("Chưa chọn mặt hàng cần xóa.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute("DELETE FROM NuocGiaiKhat WHERE MaNGK=@m", Db.P("@m", ma.Trim())), "Đã xóa nước giải khát."),
                "Không thể xóa mặt hàng đã được dùng trong đơn đặt hàng, phiếu giao, hóa đơn hoặc phiếu hẹn.");
        }

        // ---------------- Nhân viên ----------------
        public DataTable LayNV(string kw = null)
        {
            return Db.Query("SELECT MaNV,HoTen,ChucVu,DiaChi,DienThoai FROM NhanVien WHERE MaNV LIKE @k OR HoTen LIKE @k OR ChucVu LIKE @k ORDER BY MaNV", Db.P("@k", Like(kw)));
        }
        public DataTable LayNVCombo()
        {
            return Db.Query("SELECT MaNV, MaNV + N' - ' + HoTen AS HienThi FROM NhanVien ORDER BY MaNV");
        }
        public KetQuaXuLy ThemNV(string ma, string ten, string chucVu, string diaChi, string dt)
        {
            if (Thieu(ma, ten, chucVu, diaChi, dt)) return KetQuaXuLy.Fail("Thông tin nhân viên phải được nhập đầy đủ.");
            return KetQuaXuLy.Chay(() =>
            {
                Db.Execute("INSERT INTO NhanVien(MaNV,HoTen,ChucVu,DiaChi,DienThoai) VALUES(@m,@t,@c,@d,@s)",
                    Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@c", chucVu.Trim()), Db.P("@d", diaChi.Trim()), Db.P("@s", dt.Trim()));
                return "Đã thêm nhân viên.";
            });
        }
        public KetQuaXuLy SuaNV(string ma, string ten, string chucVu, string diaChi, string dt)
        {
            if (Thieu(ma, ten, chucVu, diaChi, dt)) return KetQuaXuLy.Fail("Thông tin nhân viên phải được nhập đầy đủ.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute("UPDATE NhanVien SET HoTen=@t,ChucVu=@c,DiaChi=@d,DienThoai=@s WHERE MaNV=@m",
                Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@c", chucVu.Trim()), Db.P("@d", diaChi.Trim()), Db.P("@s", dt.Trim())), "Đã cập nhật nhân viên."));
        }
        public KetQuaXuLy XoaNV(string ma)
        {
            if (Thieu(ma)) return KetQuaXuLy.Fail("Chưa chọn nhân viên cần xóa.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute("DELETE FROM NhanVien WHERE MaNV=@m", Db.P("@m", ma.Trim())), "Đã xóa nhân viên."),
                "Không thể xóa nhân viên đã lập đơn hàng, hóa đơn hoặc phiếu ghi nợ.");
        }

        // ---------------- Khách hàng ----------------
        public DataTable LayKH(string kw = null)
        {
            return Db.Query("SELECT MaKH,HoTen,DiaChi,DienThoai,LoaiKhach FROM KhachHang WHERE MaKH LIKE @k OR HoTen LIKE @k OR DienThoai LIKE @k OR LoaiKhach LIKE @k ORDER BY MaKH", Db.P("@k", Like(kw)));
        }
        public KetQuaXuLy ThemKH(string ma, string ten, string diaChi, string dt, string loai)
        {
            if (Thieu(ma, ten, loai)) return KetQuaXuLy.Fail("Mã, họ tên và loại khách là bắt buộc.");
            return KetQuaXuLy.Chay(() =>
            {
                Db.Execute("INSERT INTO KhachHang(MaKH,HoTen,DiaChi,DienThoai,LoaiKhach) VALUES(@m,@t,@d,@s,@l)",
                    Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@d", Rong(diaChi)), Db.P("@s", Rong(dt)), Db.P("@l", loai));
                return "Đã thêm khách hàng.";
            }, "Loại khách chỉ gồm Khách quen hoặc Khách vãng lai.");
        }
        public KetQuaXuLy SuaKH(string ma, string ten, string diaChi, string dt, string loai)
        {
            if (Thieu(ma, ten, loai)) return KetQuaXuLy.Fail("Mã, họ tên và loại khách là bắt buộc.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute("UPDATE KhachHang SET HoTen=@t,DiaChi=@d,DienThoai=@s,LoaiKhach=@l WHERE MaKH=@m",
                Db.P("@m", ma.Trim()), Db.P("@t", ten.Trim()), Db.P("@d", Rong(diaChi)), Db.P("@s", Rong(dt)), Db.P("@l", loai)), "Đã cập nhật khách hàng."));
        }
        public KetQuaXuLy XoaKH(string ma)
        {
            if (Thieu(ma)) return KetQuaXuLy.Fail("Chưa chọn khách hàng cần xóa.");
            return KetQuaXuLy.Chay(() => KetQuaDong(Db.Execute("DELETE FROM KhachHang WHERE MaKH=@m", Db.P("@m", ma.Trim())), "Đã xóa khách hàng."),
                "Không thể xóa khách hàng đã có hóa đơn hoặc phiếu ghi nợ.");
        }
    }
}
