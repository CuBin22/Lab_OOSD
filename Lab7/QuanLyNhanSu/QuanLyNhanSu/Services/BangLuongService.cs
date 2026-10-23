using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>
    /// Tính và lưu bảng lương hằng tháng dựa vào: quyết định lương, quyết định chức vụ,
    /// phiếu chấm công, phiếu phụ trội, hồ sơ bảo hiểm, khen thưởng và kỷ luật.
    /// </summary>
    public class BangLuongService
    {
        /// <summary>Số ngày công chuẩn của một tháng (giả định, đề không quy định).</summary>
        public const decimal NgayCongChuan = 26m;
        /// <summary>Số giờ của một ngày công.</summary>
        public const decimal GioMotNgay = 8m;

        public DataTable LayBangLuong()
        {
            return Db.Query(@"SELECT b.SoBangLuong, n.HoTen AS NhanVien, b.Thang, b.Nam, b.LuongCoBan, b.PhuCap,
                                     b.TienPhuTroi, b.TienThuong, b.KhoanTruBaoHiem, b.TienPhat, b.ThucLanh
                              FROM BangLuong b JOIN NhanVien n ON n.MaNV = b.MaNV
                              ORDER BY b.Nam DESC, b.Thang DESC, b.MaNV");
        }

        private static decimal Tong(object o)
        {
            return (o == null || o == DBNull.Value) ? 0m : Convert.ToDecimal(o);
        }

        public KetQuaXuLy Tinh(string maNV, int thang, int nam, out BangLuongTinh kq)
        {
            kq = null;
            if (KiemTra.Trong(maNV)) return KetQuaXuLy.Fail("Chưa chọn nhân viên.");
            if (thang < 1 || thang > 12 || nam <= 0) return KetQuaXuLy.Fail("Tháng/năm không hợp lệ.");
            try
            {
                DateTime dau = new DateTime(nam, thang, 1);
                DateTime cuoi = dau.AddMonths(1).AddDays(-1);

                // 1) Quyết định lương hiệu lực tại cuối tháng
                DataTable ql = Db.Query(@"SELECT TOP 1 LuongCoBan, PhuCapLuong, PhuCapDocHai FROM QuyetDinhLuong
                                          WHERE MaNV=@m AND NgayHieuLuc <= @cuoi ORDER BY NgayHieuLuc DESC",
                    Db.P("@m", maNV), Db.P("@cuoi", cuoi));
                if (ql.Rows.Count == 0)
                    return KetQuaXuLy.Fail("Nhân viên chưa có quyết định lương hiệu lực đến tháng " + thang + "/" + nam + ".");
                decimal luongQD = Convert.ToDecimal(ql.Rows[0]["LuongCoBan"]);
                decimal phuCapLuong = Convert.ToDecimal(ql.Rows[0]["PhuCapLuong"]);
                decimal phuCapDocHai = Convert.ToDecimal(ql.Rows[0]["PhuCapDocHai"]);

                // 2) Quyết định chức vụ -> phụ cấp chức vụ (nếu có)
                decimal phuCapCV = Tong(Db.Scalar(@"SELECT TOP 1 PhuCapChucVu FROM QuyetDinhChucVu
                                                    WHERE MaNV=@m AND NgayHieuLuc <= @cuoi ORDER BY NgayHieuLuc DESC",
                    Db.P("@m", maNV), Db.P("@cuoi", cuoi)));

                // 3) Bảng chấm công -> ngày công thực tế
                decimal gioLam = Tong(Db.Scalar(@"SELECT SUM(SoGioLam) FROM PhieuChamCong
                                                  WHERE MaNV=@m AND NgayCong BETWEEN @dau AND @cuoi",
                    Db.P("@m", maNV), Db.P("@dau", dau), Db.P("@cuoi", cuoi)));
                decimal ngayCong = Math.Min(gioLam / GioMotNgay, NgayCongChuan);

                // 4) Phiếu phụ trội: giờ phụ trội x 1.5 lần giờ lao động bình thường
                decimal gioQuyDoi = Tong(Db.Scalar(@"SELECT SUM(p.SoGioPhuTroi * p.HeSoPhuTroi)
                                                     FROM PhieuPhuTroi p JOIN ChiTietPhieuPhuTroi c ON c.SoPhieuPT = p.SoPhieuPT
                                                     WHERE c.MaNV=@m AND p.NgayPhuTroi BETWEEN @dau AND @cuoi",
                    Db.P("@m", maNV), Db.P("@dau", dau), Db.P("@cuoi", cuoi)));
                decimal luongGio = luongQD / NgayCongChuan / GioMotNgay;

                // 5) Khen thưởng cá nhân trong tháng chưa chi riêng bằng phiếu chi -> tính vào lương
                decimal thuong = Tong(Db.Scalar(@"SELECT SUM(q.SoTien) FROM QuyetDinhKhenThuong q
                                                  WHERE q.MaNV=@m AND q.NgayKy BETWEEN @dau AND @cuoi
                                                    AND NOT EXISTS(SELECT 1 FROM PhieuChiKhenThuong c WHERE c.SoQDKT = q.SoQDKT)",
                    Db.P("@m", maNV), Db.P("@dau", dau), Db.P("@cuoi", cuoi)));

                // 6) Tiền phạt trừ lương (phiếu thu hình thức "Trừ lương") trong tháng
                decimal phat = Tong(Db.Scalar(@"SELECT SUM(t.SoTien) FROM PhieuThuNopPhat t
                                                JOIN QuyetDinhKyLuat k ON k.SoQDKL = t.SoQDKL
                                                WHERE k.MaNV=@m AND t.HinhThucThu = N'Trừ lương' AND t.NgayThu BETWEEN @dau AND @cuoi",
                    Db.P("@m", maNV), Db.P("@dau", dau), Db.P("@cuoi", cuoi)));

                // 7) BHYT, BHXH trích trừ theo mức đóng (% lương cơ bản theo quyết định)
                decimal tyLeBH = Tong(Db.Scalar("SELECT SUM(MucDong) FROM HoSoBaoHiem WHERE MaNV=@m", Db.P("@m", maNV)));

                kq = new BangLuongTinh
                {
                    MaNV = maNV, Thang = thang, Nam = nam,
                    LuongQuyetDinh = luongQD,
                    NgayCong = Math.Round(ngayCong, 2),
                    LuongCoBan = Math.Round(luongQD / NgayCongChuan * ngayCong, 0),
                    PhuCap = phuCapLuong + phuCapDocHai + phuCapCV,
                    TienPhuTroi = Math.Round(luongGio * gioQuyDoi, 0),
                    TienThuong = thuong,
                    KhoanTruBaoHiem = Math.Round(luongQD * tyLeBH / 100m, 0),
                    TienPhat = phat
                };
                return KetQuaXuLy.Ok("Đã tính lương tháng " + thang + "/" + nam + ": " + kq.NgayCong.ToString("0.##") + " ngày công / "
                    + NgayCongChuan + " ngày chuẩn.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }

        public KetQuaXuLy Luu(string soBL, BangLuongTinh t)
        {
            if (KiemTra.Trong(soBL)) return KetQuaXuLy.Fail("Số bảng lương không được để trống.");
            if (t == null) return KetQuaXuLy.Fail("Hãy bấm Tính lương trước khi lưu.");
            try
            {
                Db.Execute(@"INSERT INTO BangLuong(SoBangLuong, MaNV, Thang, Nam, LuongCoBan, PhuCap, TienPhuTroi, TienThuong,
                                 KhoanTruBaoHiem, TienPhat)
                             VALUES(@so, @m, @th, @nam, @lcb, @pc, @pt, @tg, @bh, @ph)",
                    Db.P("@so", soBL), Db.P("@m", t.MaNV), Db.P("@th", t.Thang), Db.P("@nam", t.Nam),
                    Db.P("@lcb", t.LuongCoBan), Db.P("@pc", t.PhuCap), Db.P("@pt", t.TienPhuTroi),
                    Db.P("@tg", t.TienThuong), Db.P("@bh", t.KhoanTruBaoHiem), Db.P("@ph", t.TienPhat));
                return KetQuaXuLy.Ok("Đã lưu bảng lương.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }
    }
}
