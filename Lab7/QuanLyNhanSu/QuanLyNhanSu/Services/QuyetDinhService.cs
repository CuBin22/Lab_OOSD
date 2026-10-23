using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>Quyết định chức vụ (kèm phụ cấp chức vụ) và quyết định lương.</summary>
    public class QuyetDinhService
    {
        /// <summary>Nhân viên đã ký hợp đồng chính thức (đang hiệu lực).</summary>
        public DataTable LayNhanVienChinhThuc()
        {
            return Db.Query(@"SELECT n.MaNV, n.HoTen FROM NhanVien n
                              WHERE EXISTS(SELECT 1 FROM HopDong h WHERE h.MaNV = n.MaNV AND h.TrangThai = N'Hiệu lực')
                              ORDER BY n.HoTen");
        }

        public DataTable LayChucVu()
        {
            return Db.Query(@"SELECT q.SoQDCV, n.HoTen AS NhanVien, q.ChucVu, q.PhuCapChucVu, q.NgayHieuLuc, k.HoTen AS NguoiKy
                              FROM QuyetDinhChucVu q
                              JOIN NhanVien n ON n.MaNV = q.MaNV
                              JOIN NhanVien k ON k.MaNV = q.MaNguoiKy
                              ORDER BY q.NgayHieuLuc DESC, q.SoQDCV");
        }

        public DataTable LayLuong()
        {
            return Db.Query(@"SELECT q.SoQDL, n.HoTen AS NhanVien, q.LuongCoBan, q.PhuCapLuong, q.PhuCapDocHai, q.NgayHieuLuc
                              FROM QuyetDinhLuong q JOIN NhanVien n ON n.MaNV = q.MaNV
                              ORDER BY q.NgayHieuLuc DESC, q.SoQDL");
        }

        public KetQuaXuLy LapChucVu(string so, string maNV, string chucVu, decimal phuCap, DateTime ngayHieuLuc, string maNguoiKy)
        {
            if (KiemTra.Trong(so) || KiemTra.Trong(maNV) || KiemTra.Trong(chucVu) || KiemTra.Trong(maNguoiKy))
                return KetQuaXuLy.Fail("Quyết định chức vụ chưa đủ thông tin.");
            if (phuCap < 0) return KetQuaXuLy.Fail("Phụ cấp chức vụ không được âm.");
            try
            {
                if (!KiemTra.CoHopDongHieuLuc(maNV))
                    return KetQuaXuLy.Fail("Nhân viên chưa ký hợp đồng chính thức nên chưa thể ra quyết định chức vụ.");
                Db.Execute(@"INSERT INTO QuyetDinhChucVu(SoQDCV, MaNV, ChucVu, PhuCapChucVu, NgayHieuLuc, MaNguoiKy)
                             VALUES(@so, @m, @cv, @pc, @n, @nk)",
                    Db.P("@so", so), Db.P("@m", maNV), Db.P("@cv", chucVu), Db.P("@pc", phuCap),
                    Db.P("@n", ngayHieuLuc.Date), Db.P("@nk", maNguoiKy));
                return KetQuaXuLy.Ok("Đã lập quyết định chức vụ (bổ nhiệm được ghi nhận theo ngày hiệu lực).");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }

        public KetQuaXuLy LapLuong(string so, string maNV, decimal luongCoBan, decimal phuCapLuong, decimal phuCapDocHai,
            DateTime ngayHieuLuc, string maNguoiKy)
        {
            if (KiemTra.Trong(so) || KiemTra.Trong(maNV) || KiemTra.Trong(maNguoiKy))
                return KetQuaXuLy.Fail("Quyết định lương chưa đủ thông tin.");
            if (luongCoBan <= 0) return KetQuaXuLy.Fail("Lương cơ bản phải lớn hơn 0.");
            if (phuCapLuong < 0 || phuCapDocHai < 0) return KetQuaXuLy.Fail("Phụ cấp không được âm.");
            try
            {
                if (!KiemTra.CoHopDongHieuLuc(maNV))
                    return KetQuaXuLy.Fail("Nhân viên chưa ký hợp đồng chính thức nên chưa thể ra quyết định lương.");
                Db.Execute(@"INSERT INTO QuyetDinhLuong(SoQDL, MaNV, LuongCoBan, PhuCapLuong, PhuCapDocHai, NgayHieuLuc, MaNguoiKy)
                             VALUES(@so, @m, @lcb, @pcl, @pdh, @n, @nk)",
                    Db.P("@so", so), Db.P("@m", maNV), Db.P("@lcb", luongCoBan), Db.P("@pcl", phuCapLuong),
                    Db.P("@pdh", phuCapDocHai), Db.P("@n", ngayHieuLuc.Date), Db.P("@nk", maNguoiKy));
                return KetQuaXuLy.Ok("Đã lập quyết định lương (quá trình tăng lương được ghi nhận theo ngày hiệu lực).");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }
    }
}
