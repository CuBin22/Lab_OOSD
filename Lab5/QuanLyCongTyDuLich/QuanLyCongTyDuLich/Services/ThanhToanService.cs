using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Services
{
    /// <summary>Nghiệp vụ thanh toán: đặt cọc, tiền vé, kinh phí đoàn, mất cọc.</summary>
    public static class ThanhToanService
    {
        public static DataTable LayPhieu()
        {
            return Db.Query(
                "SELECT p.SoPhieu, p.SoPhieu + N' - ' + k.TenKH + N' (' + p.LoaiPhieu + N') - ' + CONVERT(nvarchar(30), CAST(p.TongTien AS bigint)) AS HienThi " +
                "FROM PhieuDangKy p JOIN KhachHang k ON k.MaKH = p.MaKH ORDER BY p.NgayLap DESC, p.SoPhieu DESC");
        }

        /// <summary>Thông tin tổng hợp của phiếu: LoaiPhieu, TongTien, TrangThai, DaThanhToan.</summary>
        public static DataRow LayThongTin(string soPhieu)
        {
            DataTable dt = Db.Query(
                "SELECT p.SoPhieu, p.LoaiPhieu, p.TongTien, p.TrangThai, " +
                "ISNULL((SELECT SUM(t.SoTien) FROM ThanhToan t WHERE t.SoPhieu = p.SoPhieu), 0) AS DaThanhToan " +
                "FROM PhieuDangKy p WHERE p.SoPhieu = @sp", Hlp.P("@sp", soPhieu));
            return dt.Rows.Count == 0 ? null : dt.Rows[0];
        }

        public static DataTable LayLichSu(string soPhieu)
        {
            return Db.Query(
                "SELECT MaThanhToan, NgayThanhToan, LoaiThanhToan, HinhThuc, SoTien FROM ThanhToan WHERE SoPhieu = @sp ORDER BY NgayThanhToan, MaThanhToan",
                Hlp.P("@sp", soPhieu));
        }

        /// <summary>Thêm một dòng thanh toán trong transaction đang mở (dùng chung cho đăng ký đoàn/chuyến).</summary>
        public static void ThemThanhToan(SqlTransaction tx, string soPhieu, string loai, string hinhThuc, decimal soTien)
        {
            int so = Convert.ToInt32(Db.Scalar(tx, "SELECT NEXT VALUE FOR dbo.seq_MaThanhToan"));
            string ma = "TT" + so.ToString().PadLeft(6, '0');
            Db.Execute(tx,
                "INSERT INTO ThanhToan (MaThanhToan, SoPhieu, NgayThanhToan, LoaiThanhToan, HinhThuc, SoTien) VALUES (@ma, @sp, GETDATE(), @loai, @ht, @tien)",
                Hlp.P("@ma", ma), Hlp.P("@sp", soPhieu), Hlp.P("@loai", loai), Hlp.P("@ht", hinhThuc), Hlp.P("@tien", soTien));
        }

        /// <summary>Ghi nhận thanh toán cho phiếu đã có. Ném InvalidOperationException nếu vi phạm quy định.</summary>
        public static void GhiNhan(string soPhieu, string loai, string hinhThuc, decimal soTien)
        {
            DataRow r = LayThongTin(soPhieu);
            if (r == null) throw new InvalidOperationException("Không tìm thấy phiếu đăng ký.");

            string loaiPhieu = Convert.ToString(r["LoaiPhieu"]);
            string trangThai = Convert.ToString(r["TrangThai"]);
            decimal tong = Convert.ToDecimal(r["TongTien"]);
            decimal da = Convert.ToDecimal(r["DaThanhToan"]);
            decimal conLai = tong - da;

            if (trangThai == "Đã hủy") throw new InvalidOperationException("Phiếu đã hủy, không thể thanh toán.");
            if (soTien <= 0) throw new InvalidOperationException("Số tiền phải lớn hơn 0.");
            if (loaiPhieu == "Đoàn" && loai == "Tiền vé")
                throw new InvalidOperationException("Phiếu đoàn chỉ thanh toán Đặt cọc hoặc Kinh phí đoàn.");
            if (loaiPhieu == "Chuyến" && loai != "Tiền vé")
                throw new InvalidOperationException("Phiếu đăng ký chuyến (khách lẻ) chỉ thanh toán Tiền vé.");
            if (conLai <= 0) throw new InvalidOperationException("Phiếu đã thanh toán đủ.");
            if (soTien > conLai)
                throw new InvalidOperationException("Số tiền vượt quá số tiền còn lại (" + Ui.Tien(conLai) + ").");

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    ThemThanhToan(tx, soPhieu, loai, hinhThuc, soTien);
                    string moi = trangThai;
                    if (da + soTien >= tong) moi = (loaiPhieu == "Đoàn") ? "Hoàn tất" : "Đã thanh toán";
                    else if (loaiPhieu == "Đoàn" && trangThai == "Mới lập") moi = "Đã đặt cọc";
                    if (moi != trangThai)
                        Db.Execute(tx, "UPDATE PhieuDangKy SET TrangThai = @tt WHERE SoPhieu = @sp", Hlp.P("@tt", moi), Hlp.P("@sp", soPhieu));
                    tx.Commit();
                }
                catch
                {
                    try { tx.Rollback(); } catch (InvalidOperationException) { }
                    throw;
                }
            }
        }

        /// <summary>Đoàn không đi: hủy phiếu và giữ lại tiền cọc (mất cọc).</summary>
        public static void HuyMatCoc(string soPhieu)
        {
            DataRow r = LayThongTin(soPhieu);
            if (r == null) throw new InvalidOperationException("Không tìm thấy phiếu đăng ký.");
            if (Convert.ToString(r["LoaiPhieu"]) != "Đoàn")
                throw new InvalidOperationException("Chỉ áp dụng cho phiếu đăng ký đoàn.");
            string tt = Convert.ToString(r["TrangThai"]);
            if (tt == "Đã hủy") throw new InvalidOperationException("Phiếu đã được hủy trước đó.");
            if (tt == "Hoàn tất") throw new InvalidOperationException("Phiếu đã hoàn tất, không thể hủy.");
            Db.Execute("UPDATE PhieuDangKy SET TrangThai = N'Đã hủy' WHERE SoPhieu = @sp", Hlp.P("@sp", soPhieu));
        }
    }
}
