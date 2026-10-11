using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Services
{
    /// <summary>Nghiệp vụ đăng ký theo chuyến (khách lẻ) và bán vé.</summary>
    public static class DangKyChuyenService
    {
        /// <summary>Các chuyến sắp khởi hành của tour, kèm số chỗ còn lại (cột MoTa dùng để hiển thị).</summary>
        public static DataTable LayChuyenCon(string maTour)
        {
            DataTable dt = Db.Query(
                "SELECT c.MaChuyen, c.NgayDi, c.NgayVe, c.SoChoToiDa, ISNULL(x.DaBan, 0) AS DaBan, c.SoChoToiDa - ISNULL(x.DaBan, 0) AS ConLai " +
                "FROM ChuyenTour c LEFT JOIN (SELECT k.MaChuyen, SUM(k.SoVe) AS DaBan FROM PhieuDangKyChuyen k " +
                "JOIN PhieuDangKy p ON p.SoPhieu = k.SoPhieu AND p.TrangThai <> N'Đã hủy' GROUP BY k.MaChuyen) x ON x.MaChuyen = c.MaChuyen " +
                "WHERE c.MaTour = @t AND c.NgayDi >= CAST(GETDATE() AS date) ORDER BY c.NgayDi",
                Hlp.P("@t", maTour));
            dt.Columns.Add("MoTa", typeof(string));
            foreach (DataRow r in dt.Rows)
            {
                r["MoTa"] = Convert.ToString(r["MaChuyen"]) + " - đi " + Convert.ToDateTime(r["NgayDi"]).ToString("dd/MM/yyyy")
                            + ", về " + Convert.ToDateTime(r["NgayVe"]).ToString("dd/MM/yyyy")
                            + " (còn " + Convert.ToString(r["ConLai"]) + " chỗ)";
            }
            return dt;
        }

        /// <summary>Lập phiếu đăng ký chuyến và thu tiền vé trong một transaction. Trả về số phiếu.</summary>
        public static string LapPhieuChuyen(string maKH, string maChuyen, string maDiemBan, string maDiemDon, int soVe, string hinhThuc)
        {
            if (string.IsNullOrEmpty(maKH)) throw new InvalidOperationException("Chưa chọn khách lẻ.");
            if (string.IsNullOrEmpty(maChuyen)) throw new InvalidOperationException("Chưa chọn chuyến.");
            if (string.IsNullOrEmpty(maDiemBan)) throw new InvalidOperationException("Chưa chọn điểm bán vé.");
            if (string.IsNullOrEmpty(maDiemDon)) throw new InvalidOperationException("Chưa chọn điểm đón.");
            if (soVe <= 0) throw new InvalidOperationException("Số vé phải lớn hơn 0.");
            if (soVe > DangKyDoanService.NguongDoan)
                throw new InvalidOperationException("Khách lẻ đăng ký tối đa " + DangKyDoanService.NguongDoan + " vé; trên mức này hãy đăng ký theo đoàn.");

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    DataTable ck = Db.Query(tx,
                        "SELECT c.NgayDi, t.DonGia, c.SoChoToiDa - ISNULL((SELECT SUM(k.SoVe) FROM PhieuDangKyChuyen k " +
                        "JOIN PhieuDangKy p ON p.SoPhieu = k.SoPhieu AND p.TrangThai <> N'Đã hủy' WHERE k.MaChuyen = c.MaChuyen), 0) AS ConLai " +
                        "FROM ChuyenTour c JOIN Tour t ON t.MaTour = c.MaTour WHERE c.MaChuyen = @c", Hlp.P("@c", maChuyen));
                    if (ck.Rows.Count == 0) throw new InvalidOperationException("Chuyến không tồn tại.");
                    if (Convert.ToDateTime(ck.Rows[0]["NgayDi"]).Date < DateTime.Today)
                        throw new InvalidOperationException("Chuyến đã khởi hành, không thể đăng ký.");
                    int conLai = Convert.ToInt32(ck.Rows[0]["ConLai"]);
                    if (conLai < soVe)
                        throw new InvalidOperationException("Chuyến hết chỗ hoặc không đủ chỗ (còn " + conLai + " chỗ).");

                    object loai = Db.Scalar(tx, "SELECT LoaiKhach FROM KhachHang WHERE MaKH = @kh", Hlp.P("@kh", maKH));
                    if (loai == null || Convert.ToString(loai) != "Lẻ")
                        throw new InvalidOperationException("Khách hàng được chọn không phải khách lẻ.");

                    decimal tong = Convert.ToDecimal(ck.Rows[0]["DonGia"]) * soVe;
                    int so = Convert.ToInt32(Db.Scalar(tx, "SELECT NEXT VALUE FOR dbo.seq_SoPhieu"));
                    string soPhieu = "PC" + so.ToString().PadLeft(6, '0');

                    Db.Execute(tx,
                        "INSERT INTO PhieuDangKy (SoPhieu, MaKH, LoaiPhieu, NgayLap, TongTien, TrangThai) VALUES (@sp, @kh, N'Chuyến', GETDATE(), @tt, N'Đã thanh toán')",
                        Hlp.P("@sp", soPhieu), Hlp.P("@kh", maKH), Hlp.P("@tt", tong));
                    Db.Execute(tx,
                        "INSERT INTO PhieuDangKyChuyen (SoPhieu, MaChuyen, MaDiemBan, MaDiemDon, SoVe) VALUES (@sp, @c, @ban, @don, @sv)",
                        Hlp.P("@sp", soPhieu), Hlp.P("@c", maChuyen), Hlp.P("@ban", maDiemBan), Hlp.P("@don", maDiemDon), Hlp.P("@sv", soVe));
                    ThanhToanService.ThemThanhToan(tx, soPhieu, "Tiền vé", hinhThuc, tong);
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
