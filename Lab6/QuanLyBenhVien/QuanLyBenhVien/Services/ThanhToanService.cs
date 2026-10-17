using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>
    /// Thanh toán viện phí -> làm thủ tục xuất viện -> ghi nhận vào hồ sơ (BR07: thanh toán xong mới ghi nhận).
    /// </summary>
    public class ThanhToanService
    {
        public static readonly string[] HinhThucHopLe = { "Tiền mặt", "Chuyển khoản", "Thẻ", "Ví điện tử" };

        public DataTable LayPhieuKham(string tuKhoa, string trangThai)
        {
            return Db.Query(@"SELECT p.SoPhieuKham, p.MaHoSo, b.HoTen, FORMAT(p.NgayGioKham, 'dd/MM/yyyy HH:mm') AS NgayGioKham, bs.HoTen AS TenBS,
                                     CASE WHEN p.NgayGhiNhan IS NOT NULL THEN N'Đã ghi nhận'
                                          WHEN p.NgayXuatVien IS NOT NULL THEN N'Đã xuất viện'
                                          WHEN t.SoBienLai IS NOT NULL THEN N'Đã thanh toán'
                                          ELSE N'Chưa thanh toán' END AS TrangThaiTT
                              FROM PhieuKham p
                              JOIN HoSoBenhAn h ON h.MaHoSo = p.MaHoSo
                              JOIN BenhNhan b ON b.MaBN = h.MaBN
                              JOIN BacSi bs ON bs.MaBS = p.MaBS
                              LEFT JOIN ThanhToanVienPhi t ON t.SoPhieuKham = p.SoPhieuKham
                              WHERE (@k = N'' OR p.SoPhieuKham LIKE N'%' + @k + N'%' OR p.MaHoSo LIKE N'%' + @k + N'%' OR b.HoTen LIKE N'%' + @k + N'%')
                                AND (@tt = N'Tất cả'
                                     OR (@tt = N'Chưa thanh toán' AND t.SoBienLai IS NULL)
                                     OR (@tt = N'Đã thanh toán' AND t.SoBienLai IS NOT NULL))
                              ORDER BY p.NgayGioKham DESC",
                Db.P("@k", (tuKhoa ?? "").Trim()), Db.P("@tt", KiemTra.Rong(trangThai) ? "Tất cả" : trangThai));
        }

        public KetQuaXuLy ThanhToan(string soBienLai, string soPhieuKham, DateTime ngay, string hinhThuc, decimal soTien, string maNV)
        {
            if (KiemTra.Rong(soBienLai) || KiemTra.Rong(soPhieuKham) || KiemTra.Rong(hinhThuc) || KiemTra.Rong(maNV))
                return KetQuaXuLy.Fail("Thông tin thanh toán chưa đầy đủ.");
            if (soTien <= 0) return KetQuaXuLy.Fail("Số tiền thanh toán phải lớn hơn 0.");
            if (Array.IndexOf(HinhThucHopLe, hinhThuc) < 0) return KetQuaXuLy.Fail("Hình thức thanh toán không hợp lệ.");
            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM PhieuKham WHERE SoPhieuKham = @m", soPhieuKham.Trim()) == 0)
                        return KetQuaXuLy.Fail("Không tìm thấy phiếu khám.");
                    if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM ThanhToanVienPhi WHERE SoPhieuKham = @m", soPhieuKham.Trim()) > 0)
                        return KetQuaXuLy.Fail("Phiếu khám này đã thanh toán viện phí.");
                    if (HoSoService.Dem(tx, "SELECT COUNT(*) FROM ThanhToanVienPhi WHERE SoBienLai = @m", soBienLai.Trim()) > 0)
                        return KetQuaXuLy.Fail("Số biên lai đã tồn tại.");
                    Db.Execute(tx, "INSERT INTO ThanhToanVienPhi(SoBienLai, SoPhieuKham, NgayThanhToan, HinhThuc, SoTien, MaNV) VALUES(@b, @p, @n, @h, @s, @nv)",
                        Db.P("@b", soBienLai.Trim()), Db.P("@p", soPhieuKham.Trim()), Db.P("@n", ngay), Db.P("@h", hinhThuc), Db.P("@s", soTien), Db.P("@nv", maNV));
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã ghi nhận thanh toán viện phí bằng " + hinhThuc + " (biên lai " + soBienLai.Trim() + ").");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Loi(ex);
                }
            }
        }

        /// <summary>Làm thủ tục xuất viện - chỉ khi đã thanh toán viện phí.</summary>
        public KetQuaXuLy XuatVien(string soPhieuKham)
        {
            if (KiemTra.Rong(soPhieuKham)) return KetQuaXuLy.Fail("Chưa chọn phiếu khám.");
            try
            {
                DataTable dt = Db.Query(@"SELECT p.NgayXuatVien, (SELECT COUNT(*) FROM ThanhToanVienPhi t WHERE t.SoPhieuKham = p.SoPhieuKham) AS DaTT
                                          FROM PhieuKham p WHERE p.SoPhieuKham = @m", Db.P("@m", soPhieuKham.Trim()));
                if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy phiếu khám.");
                if (Convert.ToInt32(dt.Rows[0]["DaTT"]) == 0) return KetQuaXuLy.Fail("Chưa thanh toán viện phí, không thể làm thủ tục xuất viện.");
                if (dt.Rows[0]["NgayXuatVien"] != DBNull.Value) return KetQuaXuLy.Fail("Phiếu khám này đã làm thủ tục xuất viện.");
                Db.Execute("UPDATE PhieuKham SET NgayXuatVien = GETDATE() WHERE SoPhieuKham = @m AND NgayXuatVien IS NULL", Db.P("@m", soPhieuKham.Trim()));
                return KetQuaXuLy.Ok("Đã hoàn tất thủ tục xuất viện.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi(ex);
            }
        }

        /// <summary>Phòng CSKH ghi nhận thông tin khám vào hồ sơ - chỉ sau khi đã xuất viện và thanh toán viện phí.</summary>
        public KetQuaXuLy GhiNhanVaoHoSo(string soPhieuKham, string maNV, string ghiChu)
        {
            if (KiemTra.Rong(soPhieuKham) || KiemTra.Rong(maNV)) return KetQuaXuLy.Fail("Thông tin ghi nhận chưa đầy đủ.");
            try
            {
                DataTable dt = Db.Query(@"SELECT p.NgayXuatVien, p.NgayGhiNhan, (SELECT COUNT(*) FROM ThanhToanVienPhi t WHERE t.SoPhieuKham = p.SoPhieuKham) AS DaTT
                                          FROM PhieuKham p WHERE p.SoPhieuKham = @m", Db.P("@m", soPhieuKham.Trim()));
                if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy phiếu khám.");
                DataRow r = dt.Rows[0];
                if (Convert.ToInt32(r["DaTT"]) == 0) return KetQuaXuLy.Fail("Chưa thanh toán viện phí, chưa được ghi nhận vào hồ sơ.");
                if (r["NgayXuatVien"] == DBNull.Value) return KetQuaXuLy.Fail("Bệnh nhân chưa làm thủ tục xuất viện, chưa được ghi nhận vào hồ sơ.");
                if (r["NgayGhiNhan"] != DBNull.Value) return KetQuaXuLy.Fail("Phiếu khám này đã được ghi nhận vào hồ sơ.");
                Db.Execute(@"UPDATE PhieuKham SET NgayGhiNhan = GETDATE(), MaNVGhiNhan = @nv, GhiChuGhiNhan = @g
                             WHERE SoPhieuKham = @m AND NgayGhiNhan IS NULL",
                    Db.P("@nv", maNV), Db.P("@g", KiemTra.ChuoiHoacNull(ghiChu)), Db.P("@m", soPhieuKham.Trim()));
                return KetQuaXuLy.Ok("Đã ghi nhận thông tin khám vào hồ sơ bệnh án.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi(ex);
            }
        }
    }
}
