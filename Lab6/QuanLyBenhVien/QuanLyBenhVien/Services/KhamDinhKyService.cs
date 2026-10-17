using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>
    /// Khám sức khỏe định kỳ theo quý (miễn phí): hẹn lịch qua phòng CSKH và ghi nhận đợt khám như một lần điều trị.
    /// </summary>
    public class KhamDinhKyService
    {
        public DataTable LayLichHen()
        {
            return Db.Query(@"SELECT l.MaLichHen, l.MaHoSo, b.HoTen, N'Quý ' + CAST(l.Quy AS nvarchar(1)) AS Quy,
                                     FORMAT(l.NgayGioHen, 'dd/MM/yyyy HH:mm') AS NgayGioHen, l.TrangThai
                              FROM LichHen l
                              JOIN HoSoBenhAn h ON h.MaHoSo = l.MaHoSo
                              JOIN BenhNhan b ON b.MaBN = h.MaBN
                              ORDER BY l.NgayGioHen DESC");
        }

        public static int QuyCua(DateTime ngay)
        {
            return (ngay.Month - 1) / 3 + 1;
        }

        public KetQuaXuLy DatLich(string maLichHen, string maHoSo, int quy, DateTime ngayGioHen, string maNV)
        {
            if (KiemTra.Rong(maLichHen) || KiemTra.Rong(maHoSo) || KiemTra.Rong(maNV)) return KetQuaXuLy.Fail("Thông tin lịch hẹn chưa đầy đủ.");
            if (quy < 1 || quy > 4) return KetQuaXuLy.Fail("Quý phải từ 1 đến 4.");
            if (ngayGioHen <= DateTime.Now) return KetQuaXuLy.Fail("Ngày giờ hẹn phải sau thời điểm hiện tại.");
            if (QuyCua(ngayGioHen) != quy) return KetQuaXuLy.Fail("Ngày hẹn không thuộc quý " + quy + ".");
            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    string loi = HoSoService.KiemTraConHieuLuc(tx, maHoSo.Trim());
                    if (loi != null) return KetQuaXuLy.Fail(loi);
                    if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM LichHen WHERE MaLichHen = @m", maLichHen.Trim()) > 0)
                        return KetQuaXuLy.Fail("Mã lịch hẹn đã tồn tại.");
                    int daCo = Convert.ToInt32(Db.Scalar(tx,
                        @"SELECT COUNT(*) FROM LichHen WHERE MaHoSo = @h AND Quy = @q AND YEAR(NgayGioHen) = @y AND TrangThai IN (N'Đã hẹn', N'Đã khám')",
                        Db.P("@h", maHoSo.Trim()), Db.P("@q", quy), Db.P("@y", ngayGioHen.Year)));
                    if (daCo > 0) return KetQuaXuLy.Fail("Hồ sơ đã có lịch khám định kỳ trong quý " + quy + "/" + ngayGioHen.Year + " (mỗi quý khám một lần).");
                    Db.Execute(tx, "INSERT INTO LichHen(MaLichHen, MaHoSo, Quy, NgayGioHen, TrangThai, MaNV) VALUES(@m, @h, @q, @n, N'Đã hẹn', @nv)",
                        Db.P("@m", maLichHen.Trim()), Db.P("@h", maHoSo.Trim()), Db.P("@q", quy), Db.P("@n", ngayGioHen), Db.P("@nv", maNV));
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã hẹn lịch khám định kỳ " + maLichHen.Trim() + " (không thu phí).");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Loi(ex);
                }
            }
        }

        public KetQuaXuLy HuyLich(string maLichHen)
        {
            if (KiemTra.Rong(maLichHen)) return KetQuaXuLy.Fail("Chưa chọn lịch hẹn.");
            try
            {
                int n = Db.Execute("UPDATE LichHen SET TrangThai = N'Đã hủy' WHERE MaLichHen = @m AND TrangThai = N'Đã hẹn'", Db.P("@m", maLichHen.Trim()));
                return n > 0 ? KetQuaXuLy.Ok("Đã hủy lịch hẹn " + maLichHen.Trim() + ".")
                             : KetQuaXuLy.Fail("Chỉ hủy được lịch hẹn ở trạng thái \"Đã hẹn\".");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi(ex);
            }
        }

        /// <summary>
        /// Ghi nhận đợt khám định kỳ như một lần điều trị: lập phiếu khám loại "Khám định kỳ" (không bệnh hoặc phát hiện mầm bệnh sớm)
        /// và chuyển lịch hẹn sang "Đã khám" - cùng một transaction.
        /// </summary>
        public KetQuaXuLy GhiDotKham(string maLichHen, string soPhieuKham, string maBS, string maKhoa, string maNV, bool phatHienMamBenh, string ghiChu)
        {
            if (KiemTra.Rong(maLichHen) || KiemTra.Rong(soPhieuKham)) return KetQuaXuLy.Fail("Thông tin đợt khám chưa đầy đủ.");
            if (phatHienMamBenh && KiemTra.Rong(ghiChu)) return KetQuaXuLy.Fail("Hãy mô tả mầm bệnh đã phát hiện.");
            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    DataTable dt = Db.Query(tx, "SELECT MaHoSo, Quy, NgayGioHen, TrangThai FROM LichHen WHERE MaLichHen = @m", Db.P("@m", maLichHen.Trim()));
                    if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy lịch hẹn.");
                    DataRow r = dt.Rows[0];
                    if (Convert.ToString(r["TrangThai"]) != "Đã hẹn") return KetQuaXuLy.Fail("Lịch hẹn đang ở trạng thái \"" + Convert.ToString(r["TrangThai"]) + "\", không ghi nhận được.");
                    DateTime hen = Convert.ToDateTime(r["NgayGioHen"]);
                    DateTime nay = DateTime.Now;
                    if (nay.Year != hen.Year || QuyCua(nay) != Convert.ToInt32(r["Quy"]))
                        return KetQuaXuLy.Fail("Hôm nay không thuộc quý " + Convert.ToInt32(r["Quy"]) + "/" + hen.Year + " của lịch hẹn.");

                    string ketLuan = phatHienMamBenh
                        ? "Phát hiện mầm bệnh sớm: " + ghiChu.Trim()
                        : (KiemTra.Rong(ghiChu) ? "Không phát hiện bệnh." : "Không phát hiện bệnh. " + ghiChu.Trim());
                    string loi = KhamBenhService.TaoPhieuKham(tx, soPhieuKham, Convert.ToString(r["MaHoSo"]), maBS, maKhoa, maNV, nay,
                        "Khám định kỳ", null, null, null, ketLuan, maLichHen.Trim(), null, null, null);
                    if (loi != null) return KetQuaXuLy.Fail(loi);
                    Db.Execute(tx, "UPDATE LichHen SET TrangThai = N'Đã khám' WHERE MaLichHen = @m", Db.P("@m", maLichHen.Trim()));
                    tx.Commit();
                    return KetQuaXuLy.Ok(phatHienMamBenh ? "Đã ghi nhận đợt khám định kỳ (phát hiện mầm bệnh sớm)." : "Đã ghi nhận đợt khám định kỳ (không phát hiện bệnh).");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Loi(ex);
                }
            }
        }
    }
}
