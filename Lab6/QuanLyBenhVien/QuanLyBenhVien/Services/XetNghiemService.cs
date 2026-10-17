using System;
using System.Data;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>Ghi nhận kết quả xét nghiệm (nhân viên xét nghiệm).</summary>
    public class XetNghiemService
    {
        /// <summary>Các xét nghiệm đã chỉ định nhưng chưa có kết quả.</summary>
        public DataTable LayChoKetQua()
        {
            return Db.Query(@"SELECT x.MaXN, x.SoPhieuKham, b.HoTen, l.TenLoaiXN,
                                     CONVERT(varchar(10), x.NgayChiDinh, 103) AS NgayChiDinh,
                                     ISNULL(x.KetQua, N'') AS KetQua, N'' AS NgayCoKetQua
                              FROM XetNghiem x
                              JOIN LoaiXetNghiem l ON l.MaLoaiXN = x.MaLoaiXN
                              JOIN PhieuKham p ON p.SoPhieuKham = x.SoPhieuKham
                              JOIN HoSoBenhAn h ON h.MaHoSo = p.MaHoSo
                              JOIN BenhNhan b ON b.MaBN = h.MaBN
                              WHERE x.KetQua IS NULL
                              ORDER BY x.NgayChiDinh, x.MaXN");
        }

        public KetQuaXuLy GhiKetQua(string maXN, string ketQua, DateTime ngayCoKetQua, string maNV)
        {
            if (KiemTra.Rong(maXN) || KiemTra.Rong(ketQua) || KiemTra.Rong(maNV)) return KetQuaXuLy.Fail("Thông tin kết quả chưa đầy đủ.");
            try
            {
                DataTable dt = Db.Query("SELECT NgayChiDinh, KetQua FROM XetNghiem WHERE MaXN = @m", Db.P("@m", maXN.Trim()));
                if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy xét nghiệm " + maXN.Trim() + ".");
                if (dt.Rows[0]["KetQua"] != DBNull.Value) return KetQuaXuLy.Fail("Xét nghiệm này đã có kết quả.");
                if (ngayCoKetQua.Date < Convert.ToDateTime(dt.Rows[0]["NgayChiDinh"]).Date)
                    return KetQuaXuLy.Fail("Ngày có kết quả không được trước ngày chỉ định.");
                int n = Db.Execute("UPDATE XetNghiem SET KetQua = @k, NgayCoKetQua = @n, MaNV = @nv WHERE MaXN = @m AND KetQua IS NULL",
                    Db.P("@k", ketQua.Trim()), Db.P("@n", ngayCoKetQua.Date), Db.P("@nv", maNV), Db.P("@m", maXN.Trim()));
                return n > 0 ? KetQuaXuLy.Ok("Đã ghi kết quả xét nghiệm.") : KetQuaXuLy.Fail("Không ghi được kết quả.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi(ex);
            }
        }
    }
}
