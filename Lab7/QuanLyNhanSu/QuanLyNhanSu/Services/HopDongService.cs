using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    /// <summary>Hợp đồng (dài hạn/ngắn hạn) và hồ sơ BHYT, BHXH.</summary>
    public class HopDongService
    {
        public DataTable LayHopDong()
        {
            return Db.Query(@"SELECT h.SoHopDong, n.HoTen AS NhanVien, h.SoQDTD, h.LoaiHopDong, h.NgayKy,
                                     h.NgayBatDau, h.NgayKetThuc, h.TrangThai
                              FROM HopDong h JOIN NhanVien n ON n.MaNV = h.MaNV
                              ORDER BY h.NgayKy DESC, h.SoHopDong");
        }

        /// <summary>Nhân viên đã có quyết định tuyển dụng (đủ điều kiện ký hợp đồng sau thử việc).</summary>
        public DataTable LayNhanVienCoQDTD()
        {
            return Db.Query(@"SELECT n.MaNV, n.HoTen FROM NhanVien n
                              WHERE n.TrangThai <> N'Đã nghỉ'
                                AND EXISTS(SELECT 1 FROM QuyetDinhTuyenDung q WHERE q.MaNV = n.MaNV)
                              ORDER BY n.HoTen");
        }

        public DataTable LayQDTDCuaNhanVien(string maNV)
        {
            return Db.Query("SELECT SoQDTD, NgayKetThucThuViec FROM QuyetDinhTuyenDung WHERE MaNV=@m", Db.P("@m", maNV));
        }

        public KetQuaXuLy LapHopDong(string soHD, string maNV, string soQDTD, string loai, DateTime ngayKy,
            DateTime batDau, DateTime? ketThuc)
        {
            if (KiemTra.Trong(soHD) || KiemTra.Trong(maNV) || KiemTra.Trong(soQDTD) || KiemTra.Trong(loai))
                return KetQuaXuLy.Fail("Hợp đồng chưa đủ thông tin (số hợp đồng, nhân viên, quyết định tuyển dụng, loại hợp đồng).");
            if (batDau.Date < ngayKy.Date)
                return KetQuaXuLy.Fail("Ngày bắt đầu hợp đồng không được trước ngày ký.");
            if (loai == "Ngắn hạn" && !ketThuc.HasValue)
                return KetQuaXuLy.Fail("Hợp đồng ngắn hạn phải có ngày kết thúc.");
            if (ketThuc.HasValue && ketThuc.Value.Date < batDau.Date)
                return KetQuaXuLy.Fail("Ngày kết thúc phải sau hoặc bằng ngày bắt đầu hợp đồng.");

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    DataTable qd = Db.Query(tx, "SELECT NgayKetThucThuViec FROM QuyetDinhTuyenDung WHERE SoQDTD=@q AND MaNV=@m",
                        Db.P("@q", soQDTD), Db.P("@m", maNV));
                    if (qd.Rows.Count == 0)
                        return KetQuaXuLy.Fail("Quyết định tuyển dụng không thuộc nhân viên đã chọn.");
                    DateTime hetThuViec = Convert.ToDateTime(qd.Rows[0][0]);
                    if (ngayKy.Date < hetThuViec.Date)
                        return KetQuaXuLy.Fail("Chỉ được ký hợp đồng chính thức sau khi hết thời gian thử việc (" + hetThuViec.ToString("dd/MM/yyyy") + ").");

                    // Hợp đồng cũ (ngắn hạn) đã quá hạn thì chuyển sang "Hết hạn" để ký hợp đồng mới.
                    Db.Execute(tx, @"UPDATE HopDong SET TrangThai=N'Hết hạn'
                                     WHERE MaNV=@m AND TrangThai=N'Hiệu lực' AND NgayKetThuc IS NOT NULL AND NgayKetThuc < @bd",
                        Db.P("@m", maNV), Db.P("@bd", batDau.Date));

                    Db.Execute(tx, @"INSERT INTO HopDong(SoHopDong, MaNV, SoQDTD, LoaiHopDong, NgayKy, NgayBatDau, NgayKetThuc, TrangThai)
                                     VALUES(@so, @m, @q, @l, @ky, @bd, @kt, N'Hiệu lực')",
                        Db.P("@so", soHD), Db.P("@m", maNV), Db.P("@q", soQDTD), Db.P("@l", loai),
                        Db.P("@ky", ngayKy.Date), Db.P("@bd", batDau.Date),
                        Db.P("@kt", ketThuc.HasValue ? (object)ketThuc.Value.Date : null));

                    Db.Execute(tx, "UPDATE NhanVien SET TrangThai=N'Chính thức' WHERE MaNV=@m", Db.P("@m", maNV));
                    tx.Commit();
                    string them = loai == "Dài hạn"
                        ? " Hợp đồng dài hạn: hãy lập hồ sơ BHYT và BHXH cho nhân viên ở tab Bảo hiểm."
                        : "";
                    return KetQuaXuLy.Ok("Đã lập hợp đồng. Nhân viên chuyển sang chính thức." + them);
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(Loi.Dich(ex));
                }
            }
        }

        // ------------------------------------------------------------ Bảo hiểm
        public DataTable LayHopDongDaiHan()
        {
            return Db.Query(@"SELECT h.SoHopDong, h.MaNV, n.HoTen FROM HopDong h
                              JOIN NhanVien n ON n.MaNV = h.MaNV
                              WHERE h.LoaiHopDong = N'Dài hạn' AND h.TrangThai = N'Hiệu lực'
                              ORDER BY h.SoHopDong");
        }

        public DataTable LayHoSoBaoHiem()
        {
            return Db.Query(@"SELECT b.MaHoSoBH, n.HoTen AS NhanVien, b.SoHopDong, b.LoaiBaoHiem, b.SoSoBH, b.NgayLap, b.MucDong
                              FROM HoSoBaoHiem b JOIN NhanVien n ON n.MaNV = b.MaNV
                              ORDER BY b.MaHoSoBH DESC");
        }

        public KetQuaXuLy LapHoSoBaoHiem(string soHD, string loaiBH, string soSo, DateTime ngayLap, decimal mucDong)
        {
            if (KiemTra.Trong(soHD) || KiemTra.Trong(loaiBH))
                return KetQuaXuLy.Fail("Chưa chọn hợp đồng hoặc loại bảo hiểm.");
            if (mucDong < 0 || mucDong > 100)
                return KetQuaXuLy.Fail("Mức đóng phải từ 0 đến 100 (%).");
            try
            {
                DataTable hd = Db.Query("SELECT MaNV, LoaiHopDong FROM HopDong WHERE SoHopDong=@s", Db.P("@s", soHD));
                if (hd.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy hợp đồng.");
                if (Convert.ToString(hd.Rows[0]["LoaiHopDong"]) != "Dài hạn")
                    return KetQuaXuLy.Fail("Chỉ làm hồ sơ BHYT/BHXH cho nhân viên có hợp đồng dài hạn.");
                string maNV = Convert.ToString(hd.Rows[0]["MaNV"]);
                Db.Execute(@"INSERT INTO HoSoBaoHiem(MaNV, SoHopDong, LoaiBaoHiem, SoSoBH, NgayLap, MucDong)
                             VALUES(@m, @hd, @l, @so, @n, @md)",
                    Db.P("@m", maNV), Db.P("@hd", soHD), Db.P("@l", loaiBH),
                    Db.P("@so", KiemTra.Trong(soSo) ? null : soSo), Db.P("@n", ngayLap.Date), Db.P("@md", mucDong));
                return KetQuaXuLy.Ok("Đã lập hồ sơ " + loaiBH + ". Mức đóng sẽ được trích trừ trong bảng lương hằng tháng.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(Loi.Dich(ex)); }
        }
    }
}
