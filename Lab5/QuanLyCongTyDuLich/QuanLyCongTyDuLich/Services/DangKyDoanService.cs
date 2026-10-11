using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Services
{
    /// <summary>Dữ liệu nhập khi lập phiếu đăng ký đoàn.</summary>
    public class PhieuDoanInfo
    {
        public string MaKH;
        public string MaTour;
        public DateTime NgayDi;
        public int SoNguoi;
        public string DiaChiDon;
        public bool CoBaoHiem;
        public decimal TienDatCoc;
        public string HinhThuc;
    }

    /// <summary>Nghiệp vụ "Lập phiếu đăng ký tour theo đoàn" (khớp sơ đồ tuần tự).</summary>
    public static class DangKyDoanService
    {
        /// <summary>Khách đăng ký trên số người này được xem là khách đoàn (BR06).</summary>
        public const int NguongDoan = 12;

        public static decimal LayDonGia(string maTour)
        {
            object o = Db.Scalar("SELECT DonGia FROM Tour WHERE MaTour = @t", Hlp.P("@t", maTour));
            if (o == null || o == DBNull.Value) return 0;
            return Convert.ToDecimal(o);
        }

        public static decimal TinhTongTien(decimal donGia, int soNguoi)
        {
            return donGia * soNguoi;
        }

        /// <summary>Phiếu trùng: cùng khách, cùng tour, cùng ngày đi (bỏ qua phiếu đã hủy).</summary>
        public static bool KiemTraTrungPhieu(string maKH, string maTour, DateTime ngayDi)
        {
            object o = Db.Scalar(
                "SELECT COUNT(*) FROM PhieuDangKyDoan d JOIN PhieuDangKy p ON p.SoPhieu = d.SoPhieu " +
                "WHERE p.MaKH = @kh AND d.MaTour = @t AND d.NgayDi = @nd AND p.TrangThai <> N'Đã hủy'",
                Hlp.P("@kh", maKH), Hlp.P("@t", maTour), Hlp.P("@nd", ngayDi.Date));
            return Convert.ToInt32(o) > 0;
        }

        /// <summary>Trả về thông báo lỗi, hoặc null nếu dữ liệu hợp lệ.</summary>
        public static string KiemTraHopLe(PhieuDoanInfo p, int soThanhVien, decimal donGia)
        {
            if (string.IsNullOrEmpty(p.MaKH)) return "Chưa chọn khách đoàn.";
            if (string.IsNullOrEmpty(p.MaTour)) return "Chưa chọn tour.";
            if (p.SoNguoi <= NguongDoan)
                return "Số người phải lớn hơn " + NguongDoan + " để đăng ký theo đoàn (từ " + NguongDoan + " người trở xuống đăng ký theo chuyến).";
            if (p.NgayDi.Date < DateTime.Today) return "Ngày đi không được nằm trong quá khứ.";
            if (string.IsNullOrWhiteSpace(p.DiaChiDon)) return "Chưa nhập địa điểm đón của đoàn.";
            if (p.TienDatCoc <= 0) return "Tiền đặt cọc phải lớn hơn 0.";
            decimal tong = TinhTongTien(donGia, p.SoNguoi);
            if (p.TienDatCoc > tong) return "Tiền đặt cọc không được vượt quá tổng tiền (" + Ui.Tien(tong) + ").";
            if (p.CoBaoHiem && soThanhVien != p.SoNguoi)
                return "Đoàn mua bảo hiểm phải kèm danh sách đủ " + p.SoNguoi + " người đi (hiện có " + soThanhVien + ").";
            if (KiemTraTrungPhieu(p.MaKH, p.MaTour, p.NgayDi))
                return "Phiếu bị trùng: khách này đã đăng ký tour này vào cùng ngày đi.";
            return null;
        }

        /// <summary>
        /// Lập phiếu đăng ký đoàn trong MỘT transaction: phiếu, chi tiết đoàn, thành viên, đặt cọc.
        /// Trả về số phiếu. Ném InvalidOperationException nếu dữ liệu không hợp lệ.
        /// </summary>
        public static string LapPhieuDoan(PhieuDoanInfo p, DataTable dsThanhVien)
        {
            int soTV = (p.CoBaoHiem && dsThanhVien != null) ? dsThanhVien.Rows.Count : 0;
            decimal donGia = LayDonGia(p.MaTour);
            string loi = KiemTraHopLe(p, soTV, donGia);
            if (loi != null) throw new InvalidOperationException(loi);
            decimal tong = TinhTongTien(donGia, p.SoNguoi);

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    int so = Convert.ToInt32(Db.Scalar(tx, "SELECT NEXT VALUE FOR dbo.seq_SoPhieu"));
                    string soPhieu = "PD" + so.ToString().PadLeft(6, '0');

                    Db.Execute(tx,
                        "INSERT INTO PhieuDangKy (SoPhieu, MaKH, LoaiPhieu, NgayLap, TongTien, TrangThai) VALUES (@sp, @kh, N'Đoàn', GETDATE(), @tt, N'Đã đặt cọc')",
                        Hlp.P("@sp", soPhieu), Hlp.P("@kh", p.MaKH), Hlp.P("@tt", tong));

                    Db.Execute(tx,
                        "INSERT INTO PhieuDangKyDoan (SoPhieu, MaTour, NgayDi, SoNguoi, DiaChiDon, CoBaoHiem, TienDatCoc) VALUES (@sp, @t, @nd, @sn, @dc, @bh, @coc)",
                        Hlp.P("@sp", soPhieu), Hlp.P("@t", p.MaTour), Hlp.P("@nd", p.NgayDi.Date), Hlp.P("@sn", p.SoNguoi),
                        Hlp.P("@dc", p.DiaChiDon), Hlp.P("@bh", p.CoBaoHiem), Hlp.P("@coc", p.TienDatCoc));

                    if (soTV > 0)
                    {
                        foreach (DataRow r in dsThanhVien.Rows)
                        {
                            int stv = Convert.ToInt32(Db.Scalar(tx, "SELECT NEXT VALUE FOR dbo.seq_MaTV"));
                            Db.Execute(tx,
                                "INSERT INTO ThanhVienDoan (MaTV, SoPhieu, HoTen, NgaySinh, SoCMND) VALUES (@ma, @sp, @ht, @ns, @cmnd)",
                                Hlp.P("@ma", "TV" + stv.ToString().PadLeft(6, '0')), Hlp.P("@sp", soPhieu),
                                Hlp.P("@ht", r["HoTen"]), Hlp.P("@ns", r["NgaySinh"]), Hlp.P("@cmnd", r["SoCMND"]));
                        }
                    }

                    ThanhToanService.ThemThanhToan(tx, soPhieu, "Đặt cọc", p.HinhThuc, p.TienDatCoc);
                    tx.Commit();
                    return soPhieu;
                }
                catch
                {
                    try { tx.Rollback(); } catch (InvalidOperationException) { }
                    throw;
                }
            }
        }
    }
}
