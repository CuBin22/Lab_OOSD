using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>Quyết định tuyển dụng và thời gian thử việc.</summary>
    public class TuyenDungService
    {
        public DataTable LayQuyetDinh()
        {
            return Db.Query(@"SELECT q.SoQDTD, n.HoTen AS NhanVien, p.TenPhongBan, q.NgayKy, q.NgayBatDauThuViec,
                                     q.NgayKetThucThuViec, q.LuongThuViec, q.DieuKhoan
                              FROM QuyetDinhTuyenDung q
                              JOIN NhanVien n ON n.MaNV = q.MaNV
                              JOIN PhongBan p ON p.MaPhongBan = q.MaPhongBan
                              ORDER BY q.NgayKy DESC, q.SoQDTD");
        }

        /// <summary>Nhân viên chưa có quyết định tuyển dụng.</summary>
        public DataTable LayNhanVienChuaTuyenDung()
        {
            return Db.Query(@"SELECT n.MaNV, n.HoTen FROM NhanVien n
                              WHERE n.TrangThai <> N'Đã nghỉ'
                                AND NOT EXISTS(SELECT 1 FROM QuyetDinhTuyenDung q WHERE q.MaNV = n.MaNV)
                              ORDER BY n.HoTen");
        }

        public KetQuaXuLy ThemQuyetDinh(string soQD, string maNV, string maPhongBan, DateTime ngayKy,
            DateTime batDau, DateTime ketThuc, decimal luong, string dieuKhoan, string maNguoiKy)
        {
            if (KiemTra.Trong(soQD) || KiemTra.Trong(maNV) || KiemTra.Trong(maPhongBan) || KiemTra.Trong(maNguoiKy))
                return KetQuaXuLy.Fail("Quyết định tuyển dụng chưa đủ thông tin (số quyết định, nhân viên, phòng ban, người ký).");
            if (ketThuc.Date <= batDau.Date)
                return KetQuaXuLy.Fail("Ngày kết thúc thử việc phải sau ngày bắt đầu thử việc.");
            if (ngayKy.Date > batDau.Date)
                return KetQuaXuLy.Fail("Ngày ký quyết định không được sau ngày bắt đầu thử việc.");
            if (luong <= 0)
                return KetQuaXuLy.Fail("Lương thử việc phải lớn hơn 0.");
            if (KiemTra.Trong(dieuKhoan))
                return KetQuaXuLy.Fail("Quyết định phải ghi rõ điều khoản của hai bên (nhà tuyển dụng và người được tuyển dụng).");

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    Db.Execute(tx, @"INSERT INTO QuyetDinhTuyenDung(SoQDTD, MaNV, MaPhongBan, NgayKy, NgayBatDauThuViec,
                                         NgayKetThucThuViec, LuongThuViec, DieuKhoan, MaNguoiKy)
                                     VALUES(@so, @nv, @pb, @ky, @bd, @kt, @l, @dk, @nk)",
                        Db.P("@so", soQD), Db.P("@nv", maNV), Db.P("@pb", maPhongBan), Db.P("@ky", ngayKy.Date),
                        Db.P("@bd", batDau.Date), Db.P("@kt", ketThuc.Date), Db.P("@l", luong),
                        Db.P("@dk", dieuKhoan), Db.P("@nk", maNguoiKy));
                    // Nhân viên về làm việc tại phòng ban tuyển dụng, trạng thái thử việc.
                    Db.Execute(tx, "UPDATE NhanVien SET MaPhongBan=@pb, TrangThai=N'Thử việc' WHERE MaNV=@nv",
                        Db.P("@pb", maPhongBan), Db.P("@nv", maNV));
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập quyết định tuyển dụng. Nhân viên bắt đầu thử việc tại phòng ban đã chọn.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(Loi.Dich(ex));
                }
            }
        }
    }
}
