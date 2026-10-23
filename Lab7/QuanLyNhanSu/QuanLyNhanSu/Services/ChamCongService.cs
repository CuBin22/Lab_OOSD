using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>Kế hoạch phân công hằng tuần, phiếu chấm công và phiếu ghi nhận giờ phụ trội.</summary>
    public class ChamCongService
    {
        // ------------------------------------------------------------ Phân công
        public DataTable LayKeHoach()
        {
            return Db.Query(@"SELECT k.SoKeHoach, n.HoTen AS NguoiLap, p.TenPhongBan, k.TuNgay, k.DenNgay
                              FROM KeHoachPhanCong k
                              JOIN NhanVien n ON n.MaNV = k.MaNguoiLap
                              JOIN PhongBan p ON p.MaPhongBan = k.MaPhongBan
                              ORDER BY k.TuNgay DESC, k.SoKeHoach");
        }

        public KetQuaXuLy LapKeHoach(string soKH, string maNguoiLap, string maPhongBan, DateTime tu, DateTime den,
            List<PhanCongItem> ds)
        {
            if (KiemTra.Trong(soKH) || KiemTra.Trong(maNguoiLap) || KiemTra.Trong(maPhongBan))
                return KetQuaXuLy.Fail("Kế hoạch chưa đủ thông tin (số kế hoạch, người lập, phòng/ban).");
            if (den.Date < tu.Date) return KetQuaXuLy.Fail("Đến ngày không được trước từ ngày.");
            if ((den.Date - tu.Date).Days > 6) return KetQuaXuLy.Fail("Kế hoạch phân công lập theo tuần (tối đa 7 ngày).");
            if (ds == null || ds.Count == 0) return KetQuaXuLy.Fail("Chưa có nhân viên nào được phân công.");

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    int truongBP = Convert.ToInt32(Db.Scalar(tx,
                        "SELECT COUNT(*) FROM NhanVien WHERE MaNV=@m AND VaiTro LIKE N'Trưởng%'", Db.P("@m", maNguoiLap)));
                    if (truongBP == 0)
                        return KetQuaXuLy.Fail("Kế hoạch phân công do trưởng phòng/ban/phân xưởng lập.");

                    foreach (PhanCongItem x in ds)
                    {
                        if (x.Ngay.Date < tu.Date || x.Ngay.Date > den.Date)
                            return KetQuaXuLy.Fail("Ngày làm việc của " + x.HoTen + " (" + x.Ngay.ToString("dd/MM/yyyy") + ") nằm ngoài tuần của kế hoạch.");
                        int thuoc = Convert.ToInt32(Db.Scalar(tx,
                            "SELECT COUNT(*) FROM NhanVien WHERE MaNV=@m AND MaPhongBan=@pb", Db.P("@m", x.MaNV), Db.P("@pb", maPhongBan)));
                        if (thuoc == 0)
                            return KetQuaXuLy.Fail(x.HoTen + " không thuộc phòng/ban của kế hoạch.");
                    }

                    Db.Execute(tx, @"INSERT INTO KeHoachPhanCong(SoKeHoach, MaNguoiLap, MaPhongBan, TuNgay, DenNgay)
                                     VALUES(@so, @nl, @pb, @tu, @den)",
                        Db.P("@so", soKH), Db.P("@nl", maNguoiLap), Db.P("@pb", maPhongBan), Db.P("@tu", tu.Date), Db.P("@den", den.Date));
                    foreach (PhanCongItem x in ds)
                    {
                        Db.Execute(tx, @"INSERT INTO ChiTietPhanCong(SoKeHoach, MaNV, NgayLamViec, Ca, CoPhuTroi)
                                         VALUES(@so, @m, @n, @ca, @pt)",
                            Db.P("@so", soKH), Db.P("@m", x.MaNV), Db.P("@n", x.Ngay.Date), Db.P("@ca", x.Ca), Db.P("@pt", x.PhuTroi));
                    }
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập kế hoạch phân công. Chuyển kế hoạch cho ban chấm công theo dõi.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(Loi.Dich(ex));
                }
            }
        }

        // ------------------------------------------------------------ Chấm công
        public DataTable LayChamCong()
        {
            return Db.Query(@"SELECT c.SoPhieuCC, n.HoTen AS NhanVien, c.NgayCong, c.Ca, c.SoGioLam, l.HoTen AS NguoiLap, c.GhiChu
                              FROM PhieuChamCong c
                              JOIN NhanVien n ON n.MaNV = c.MaNV
                              JOIN NhanVien l ON l.MaNV = c.MaNVLap
                              ORDER BY c.NgayCong DESC, c.SoPhieuCC");
        }

        public KetQuaXuLy LapPhieuChamCong(string so, string maNV, string maNVLap, DateTime ngay, string ca,
            decimal soGio, string ghiChu)
        {
            if (KiemTra.Trong(so) || KiemTra.Trong(maNV) || KiemTra.Trong(maNVLap) || KiemTra.Trong(ca))
                return KetQuaXuLy.Fail("Phiếu chấm công chưa đủ thông tin.");
            if (soGio <= 0 || soGio > 24) return KetQuaXuLy.Fail("Số giờ làm phải lớn hơn 0 và không quá 24.");
            try
            {
                if (!KiemTra.CoVaiTro(maNVLap, "Ban chấm công"))
                    return KetQuaXuLy.Fail("Phiếu chấm công do ban chấm công lập.");
                int phanCong = Convert.ToInt32(Db.Scalar(
                    "SELECT COUNT(*) FROM ChiTietPhanCong WHERE MaNV=@m AND NgayLamViec=@n AND Ca=@ca",
                    Db.P("@m", maNV), Db.P("@n", ngay.Date), Db.P("@ca", ca)));
                if (phanCong == 0)
                    return KetQuaXuLy.Fail("Nhân viên chưa được phân công làm ca này trong ngày đã chọn (chấm công theo kế hoạch phân công).");
                Db.Execute(@"INSERT INTO PhieuChamCong(SoPhieuCC, MaNV, MaNVLap, NgayCong, Ca, SoGioLam, GhiChu)
                             VALUES(@so, @m, @nl, @n, @ca, @g, @gc)",
                    Db.P("@so", so), Db.P("@m", maNV), Db.P("@nl", maNVLap), Db.P("@n", ngay.Date), Db.P("@ca", ca),
                    Db.P("@g", soGio), Db.P("@gc", KiemTra.Trong(ghiChu) ? null : ghiChu));
                return KetQuaXuLy.Ok("Đã lập phiếu chấm công.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }

        // ------------------------------------------------------------ Phụ trội
        public DataTable LayPhieuPhuTroi()
        {
            return Db.Query(@"SELECT p.SoPhieuPT, p.NgayPhuTroi, p.SoGioPhuTroi, p.HinhThuc, p.HeSoPhuTroi, n.HoTen AS NguoiLap
                              FROM PhieuPhuTroi p JOIN NhanVien n ON n.MaNV = p.MaNVLap
                              ORDER BY p.NgayPhuTroi DESC, p.SoPhieuPT");
        }

        public KetQuaXuLy LapPhieuPhuTroi(string so, DateTime ngay, decimal soGio, string hinhThuc, string maNVLap,
            List<NhanVienItem> ds)
        {
            if (KiemTra.Trong(so) || KiemTra.Trong(hinhThuc) || KiemTra.Trong(maNVLap))
                return KetQuaXuLy.Fail("Phiếu phụ trội chưa đủ thông tin.");
            if (soGio <= 0 || soGio > 24) return KetQuaXuLy.Fail("Số giờ phụ trội phải lớn hơn 0 và không quá 24.");
            if (ds == null || ds.Count == 0) return KetQuaXuLy.Fail("Phiếu phụ trội phải có ít nhất một nhân viên tham gia.");

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    int bcc = Convert.ToInt32(Db.Scalar(tx,
                        "SELECT COUNT(*) FROM NhanVien WHERE MaNV=@m AND VaiTro LIKE N'Ban chấm công'", Db.P("@m", maNVLap)));
                    if (bcc == 0) return KetQuaXuLy.Fail("Phiếu ghi nhận phụ trội do ban chấm công lập.");

                    // Giờ phụ trội được tính bằng 1.5 lần giờ lao động bình thường.
                    Db.Execute(tx, @"INSERT INTO PhieuPhuTroi(SoPhieuPT, NgayPhuTroi, SoGioPhuTroi, HinhThuc, HeSoPhuTroi, MaNVLap)
                                     VALUES(@so, @n, @g, @ht, 1.5, @nl)",
                        Db.P("@so", so), Db.P("@n", ngay.Date), Db.P("@g", soGio), Db.P("@ht", hinhThuc), Db.P("@nl", maNVLap));
                    foreach (NhanVienItem x in ds)
                        Db.Execute(tx, "INSERT INTO ChiTietPhieuPhuTroi(SoPhieuPT, MaNV) VALUES(@so, @m)",
                            Db.P("@so", so), Db.P("@m", x.MaNV));
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập phiếu ghi nhận phụ trội (hệ số 1.5).");
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
