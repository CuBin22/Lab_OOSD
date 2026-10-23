using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>Quyết định khen thưởng/kỷ luật (cá nhân hoặc tập thể), phiếu chi và phiếu thu nộp phạt.</summary>
    public class KhenKyLuatService
    {
        // ------------------------------------------------------------ Khen thưởng
        public DataTable LayQDKT()
        {
            return Db.Query(@"SELECT q.SoQDKT, q.NgayKy, q.LoaiKhenThuong,
                                     ISNULL(n.HoTen, N'Tập thể ' + p.TenPhongBan) AS DoiTuong,
                                     q.SoTien, k.HoTen AS NguoiKy,
                                     CASE WHEN EXISTS(SELECT 1 FROM PhieuChiKhenThuong c WHERE c.SoQDKT = q.SoQDKT)
                                          THEN N'Đã chi' ELSE N'Chưa chi' END AS DaChi
                              FROM QuyetDinhKhenThuong q
                              LEFT JOIN NhanVien n ON n.MaNV = q.MaNV
                              LEFT JOIN PhongBan p ON p.MaPhongBan = q.MaPhongBan
                              JOIN NhanVien k ON k.MaNV = q.MaNguoiKy
                              ORDER BY q.NgayKy DESC, q.SoQDKT");
        }

        public KetQuaXuLy LapQDKT(string so, DateTime ngayKy, string loai, string maNV, string maPhongBan,
            decimal soTien, string noiDung, string maNguoiKy)
        {
            if (KiemTra.Trong(so) || KiemTra.Trong(loai) || KiemTra.Trong(maNguoiKy))
                return KetQuaXuLy.Fail("Quyết định khen thưởng chưa đủ thông tin.");
            if (KiemTra.Trong(maNV) == KiemTra.Trong(maPhongBan))
                return KetQuaXuLy.Fail("Quyết định phải áp dụng cho một cá nhân hoặc một tập thể phòng ban.");
            if (soTien <= 0) return KetQuaXuLy.Fail("Số tiền khen thưởng phải lớn hơn 0.");
            try
            {
                if (!KiemTra.CoVaiTro(maNguoiKy, "Giám đốc"))
                    return KetQuaXuLy.Fail("Quyết định khen thưởng do giám đốc ký.");
                Db.Execute(@"INSERT INTO QuyetDinhKhenThuong(SoQDKT, NgayKy, LoaiKhenThuong, MaNV, MaPhongBan, SoTien, NoiDung, MaNguoiKy)
                             VALUES(@so, @n, @l, @m, @pb, @t, @nd, @nk)",
                    Db.P("@so", so), Db.P("@n", ngayKy.Date), Db.P("@l", loai),
                    Db.P("@m", KiemTra.Trong(maNV) ? null : maNV), Db.P("@pb", KiemTra.Trong(maPhongBan) ? null : maPhongBan),
                    Db.P("@t", soTien), Db.P("@nd", KiemTra.Trong(noiDung) ? null : noiDung), Db.P("@nk", maNguoiKy));
                return KetQuaXuLy.Ok("Đã lập quyết định khen thưởng. Chọn quyết định trong danh sách để lập phiếu chi.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }

        public KetQuaXuLy LapPhieuChi(string soPhieu, string soQDKT, DateTime ngayChi, string maNVLap)
        {
            if (KiemTra.Trong(soPhieu) || KiemTra.Trong(maNVLap))
                return KetQuaXuLy.Fail("Phiếu chi chưa đủ thông tin.");
            if (KiemTra.Trong(soQDKT)) return KetQuaXuLy.Fail("Hãy chọn quyết định khen thưởng trong danh sách.");
            try
            {
                DataTable qd = Db.Query("SELECT SoTien, NgayKy FROM QuyetDinhKhenThuong WHERE SoQDKT=@s", Db.P("@s", soQDKT));
                if (qd.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy quyết định khen thưởng.");
                if (ngayChi.Date < Convert.ToDateTime(qd.Rows[0]["NgayKy"]).Date)
                    return KetQuaXuLy.Fail("Ngày chi không được trước ngày ký quyết định.");
                decimal soTien = Convert.ToDecimal(qd.Rows[0]["SoTien"]);
                Db.Execute(@"INSERT INTO PhieuChiKhenThuong(SoPhieuChi, SoQDKT, NgayChi, SoTien, MaNVLap)
                             VALUES(@so, @q, @n, @t, @nl)",
                    Db.P("@so", soPhieu), Db.P("@q", soQDKT), Db.P("@n", ngayChi.Date), Db.P("@t", soTien), Db.P("@nl", maNVLap));
                return KetQuaXuLy.Ok("Đã lập phiếu chi khen thưởng " + soTien.ToString("N0") + " đ theo quyết định " + soQDKT + ".");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }

        // ------------------------------------------------------------ Kỷ luật
        public DataTable LayQDKL()
        {
            return Db.Query(@"SELECT q.SoQDKL, q.NgayKy, q.HinhThucXuLy,
                                     ISNULL(n.HoTen, N'Tập thể ' + p.TenPhongBan) AS DoiTuong,
                                     q.SoTienPhat, k.HoTen AS NguoiKy,
                                     CASE WHEN q.SoTienPhat = 0 THEN N'Không phạt tiền'
                                          WHEN EXISTS(SELECT 1 FROM PhieuThuNopPhat t WHERE t.SoQDKL = q.SoQDKL) THEN N'Đã thu'
                                          ELSE N'Chưa thu' END AS DaThu
                              FROM QuyetDinhKyLuat q
                              LEFT JOIN NhanVien n ON n.MaNV = q.MaNV
                              LEFT JOIN PhongBan p ON p.MaPhongBan = q.MaPhongBan
                              JOIN NhanVien k ON k.MaNV = q.MaNguoiKy
                              ORDER BY q.NgayKy DESC, q.SoQDKL");
        }

        public KetQuaXuLy LapQDKL(string so, DateTime ngayKy, string hinhThuc, string maNV, string maPhongBan,
            decimal soTienPhat, string lyDo, string maNguoiKy)
        {
            if (KiemTra.Trong(so) || KiemTra.Trong(hinhThuc) || KiemTra.Trong(maNguoiKy))
                return KetQuaXuLy.Fail("Quyết định kỷ luật chưa đủ thông tin.");
            if (KiemTra.Trong(maNV) == KiemTra.Trong(maPhongBan))
                return KetQuaXuLy.Fail("Quyết định phải áp dụng cho một cá nhân hoặc một tập thể phòng ban.");
            if (soTienPhat < 0) return KetQuaXuLy.Fail("Số tiền phạt không được âm.");
            try
            {
                Db.Execute(@"INSERT INTO QuyetDinhKyLuat(SoQDKL, NgayKy, HinhThucXuLy, MaNV, MaPhongBan, SoTienPhat, LyDo, MaNguoiKy)
                             VALUES(@so, @n, @h, @m, @pb, @t, @ld, @nk)",
                    Db.P("@so", so), Db.P("@n", ngayKy.Date), Db.P("@h", hinhThuc),
                    Db.P("@m", KiemTra.Trong(maNV) ? null : maNV), Db.P("@pb", KiemTra.Trong(maPhongBan) ? null : maPhongBan),
                    Db.P("@t", soTienPhat), Db.P("@ld", KiemTra.Trong(lyDo) ? null : lyDo), Db.P("@nk", maNguoiKy));
                return KetQuaXuLy.Ok(soTienPhat > 0
                    ? "Đã lập quyết định kỷ luật. Chọn quyết định trong danh sách để lập phiếu thu nộp phạt."
                    : "Đã lập quyết định kỷ luật (không phạt tiền).");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }

        public KetQuaXuLy LapPhieuThu(string soPhieu, string soQDKL, DateTime ngayThu, string hinhThucThu, string maNVLap)
        {
            if (KiemTra.Trong(soPhieu) || KiemTra.Trong(hinhThucThu) || KiemTra.Trong(maNVLap))
                return KetQuaXuLy.Fail("Phiếu thu chưa đủ thông tin.");
            if (KiemTra.Trong(soQDKL)) return KetQuaXuLy.Fail("Hãy chọn quyết định kỷ luật trong danh sách.");
            try
            {
                DataTable qd = Db.Query("SELECT SoTienPhat, NgayKy, MaNV FROM QuyetDinhKyLuat WHERE SoQDKL=@s", Db.P("@s", soQDKL));
                if (qd.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy quyết định kỷ luật.");
                decimal soTien = Convert.ToDecimal(qd.Rows[0]["SoTienPhat"]);
                if (soTien <= 0) return KetQuaXuLy.Fail("Quyết định này không phạt tiền nên không cần lập phiếu thu.");
                if (ngayThu.Date < Convert.ToDateTime(qd.Rows[0]["NgayKy"]).Date)
                    return KetQuaXuLy.Fail("Ngày thu không được trước ngày ký quyết định.");
                if (hinhThucThu == "Trừ lương" && qd.Rows[0]["MaNV"] == DBNull.Value)
                    return KetQuaXuLy.Fail("Phạt tập thể phòng ban phải nộp trực tiếp, không trừ vào lương cá nhân.");
                Db.Execute(@"INSERT INTO PhieuThuNopPhat(SoPhieuThu, SoQDKL, NgayThu, HinhThucThu, SoTien, MaNVLap)
                             VALUES(@so, @q, @n, @h, @t, @nl)",
                    Db.P("@so", soPhieu), Db.P("@q", soQDKL), Db.P("@n", ngayThu.Date), Db.P("@h", hinhThucThu),
                    Db.P("@t", soTien), Db.P("@nl", maNVLap));
                return KetQuaXuLy.Ok("Đã lập phiếu thu nộp phạt " + soTien.ToString("N0") + " đ (" + hinhThucThu + ").");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }
    }
}
