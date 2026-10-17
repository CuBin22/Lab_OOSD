using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyBenhVien.Data;

namespace QuanLyBenhVien.Services
{
    /// <summary>Đăng ký, cấp hồ sơ bệnh án, lệ phí hằng năm, tra cứu hồ sơ.</summary>
    public class HoSoService
    {
        /// <summary>Truy vấn dùng chung: trang bìa hồ sơ (cột trùng tên với DataGridView).</summary>
        internal const string SelectHoSo =
            @"SELECT h.MaHoSo, h.MaBN, b.HoTen, CONVERT(varchar(10), b.NgaySinh, 103) AS NgaySinh, b.DiaChi, b.DienThoai,
                     CONVERT(varchar(10), h.NgayCap, 103) AS NgayCap, h.TrangThai
              FROM HoSoBenhAn h JOIN BenhNhan b ON b.MaBN = h.MaBN ";

        // Hồ sơ "Còn hiệu lực" khi có lệ phí của năm hiện tại (hoặc sau đó); ngược lại "Hết hạn".
        const string SqlHetHan =
            @"UPDATE HoSoBenhAn SET TrangThai = N'Hết hạn'
              WHERE TrangThai = N'Còn hiệu lực'
                AND NOT EXISTS (SELECT 1 FROM LePhi l WHERE l.MaHoSo = HoSoBenhAn.MaHoSo AND l.NamApDung >= YEAR(GETDATE()))";
        const string SqlConHan =
            @"UPDATE HoSoBenhAn SET TrangThai = N'Còn hiệu lực'
              WHERE TrangThai = N'Hết hạn'
                AND EXISTS (SELECT 1 FROM LePhi l WHERE l.MaHoSo = HoSoBenhAn.MaHoSo AND l.NamApDung >= YEAR(GETDATE()))";

        public void DongBoTrangThai()
        {
            Db.Execute(SqlHetHan);
            Db.Execute(SqlConHan);
        }

        public DataTable LayDanhSach(string trangThai)
        {
            DongBoTrangThai();
            if (KiemTra.Rong(trangThai))
                return Db.Query(SelectHoSo + "ORDER BY h.NgayCap DESC, h.MaHoSo DESC");
            return Db.Query(SelectHoSo + "WHERE h.TrangThai = @t ORDER BY h.NgayCap DESC, h.MaHoSo DESC", Db.P("@t", trangThai));
        }

        public DataTable LayHoSoMoi(int soLuong)
        {
            return Db.Query(SelectHoSo.Replace("SELECT h.MaHoSo", "SELECT TOP (@n) h.MaHoSo") + "ORDER BY h.NgayCap DESC, h.MaHoSo DESC",
                Db.P("@n", soLuong));
        }

        public DataTable TimTheoMa(string maHoSo)
        {
            return Db.Query(SelectHoSo + "WHERE h.MaHoSo = @m", Db.P("@m", maHoSo));
        }

        public DataTable LayLePhi(string maHoSo)
        {
            return Db.Query(@"SELECT MaLePhi, MaHoSo, NamApDung, SoTien, FORMAT(NgayDong, 'dd/MM/yyyy HH:mm') AS NgayDong
                              FROM LePhi WHERE MaHoSo = @m ORDER BY NamApDung DESC", Db.P("@m", maHoSo));
        }

        /// <summary>
        /// Lưu bệnh nhân + phiếu đăng ký + hồ sơ + lệ phí năm đầu trong 1 transaction.
        /// Chỉ cấp hồ sơ khi có phiếu đăng ký và đã đóng lệ phí (BR01-BR04).
        /// </summary>
        public KetQuaXuLy DangKyVaCapHoSo(string maBN, string hoTen, DateTime ngaySinh, string diaChi, string dienThoai, byte[] anh,
            string soPhieuDK, DateTime ngayDangKy, string maNV, string maLePhi, int namApDung, decimal soTien, string maHoSo)
        {
            if (KiemTra.Rong(maBN) || KiemTra.Rong(hoTen) || KiemTra.Rong(diaChi) || KiemTra.Rong(dienThoai) ||
                KiemTra.Rong(soPhieuDK) || KiemTra.Rong(maNV) || KiemTra.Rong(maLePhi) || KiemTra.Rong(maHoSo))
                return KetQuaXuLy.Fail("Thông tin đăng ký chưa đầy đủ.");
            if (ngaySinh.Date >= DateTime.Today) return KetQuaXuLy.Fail("Ngày sinh phải nhỏ hơn ngày hiện tại.");
            if (!KiemTra.LaSoDienThoai(dienThoai)) return KetQuaXuLy.Fail("Số điện thoại phải gồm 9-11 chữ số.");
            if (anh == null || anh.Length == 0) return KetQuaXuLy.Fail("Phiếu đăng ký cần có ảnh 3x4.");
            if (soTien <= 0) return KetQuaXuLy.Fail("Lệ phí phải lớn hơn 0 (chỉ cấp hồ sơ khi đã đóng lệ phí).");
            if (namApDung != ngayDangKy.Year) return KetQuaXuLy.Fail("Năm áp dụng lệ phí phải trùng năm đăng ký (" + ngayDangKy.Year + ").");

            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    if (Dem(tx, "SELECT COUNT(*) FROM BenhNhan WHERE MaBN = @m", maBN) > 0) return KetQuaXuLy.Fail("Mã bệnh nhân đã tồn tại.");
                    if (Dem(tx, "SELECT COUNT(*) FROM HoSoBenhAn WHERE MaHoSo = @m", maHoSo) > 0) return KetQuaXuLy.Fail("Mã hồ sơ đã tồn tại (mã hồ sơ phải không trùng).");
                    if (Dem(tx, "SELECT COUNT(*) FROM PhieuDangKy WHERE SoPhieuDK = @m", soPhieuDK) > 0) return KetQuaXuLy.Fail("Số phiếu đăng ký đã tồn tại.");
                    if (Dem(tx, "SELECT COUNT(*) FROM LePhi WHERE MaLePhi = @m", maLePhi) > 0) return KetQuaXuLy.Fail("Mã lệ phí đã tồn tại.");
                    if (Dem(tx, "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @m", maNV) == 0) return KetQuaXuLy.Fail("Không tìm thấy nhân viên tiếp nhận.");

                    SqlParameter pAnh = new SqlParameter("@anh", SqlDbType.VarBinary, -1);
                    pAnh.Value = anh;
                    Db.Execute(tx, "INSERT INTO BenhNhan(MaBN, HoTen, NgaySinh, DiaChi, DienThoai, Anh) VALUES(@m, @t, @ns, @dc, @dt, @anh)",
                        Db.P("@m", maBN.Trim()), Db.P("@t", hoTen.Trim()), Db.P("@ns", ngaySinh.Date), Db.P("@dc", diaChi.Trim()),
                        Db.P("@dt", dienThoai.Trim()), pAnh);
                    Db.Execute(tx, "INSERT INTO PhieuDangKy(SoPhieuDK, MaBN, MaNV, NgayDangKy) VALUES(@p, @b, @nv, @n)",
                        Db.P("@p", soPhieuDK.Trim()), Db.P("@b", maBN.Trim()), Db.P("@nv", maNV), Db.P("@n", ngayDangKy.Date));
                    Db.Execute(tx, "INSERT INTO HoSoBenhAn(MaHoSo, MaBN, NgayCap, TrangThai) VALUES(@h, @b, @n, N'Còn hiệu lực')",
                        Db.P("@h", maHoSo.Trim()), Db.P("@b", maBN.Trim()), Db.P("@n", ngayDangKy.Date));
                    Db.Execute(tx, "INSERT INTO LePhi(MaLePhi, MaHoSo, NamApDung, SoTien, NgayDong, MaNV) VALUES(@l, @h, @y, @s, GETDATE(), @nv)",
                        Db.P("@l", maLePhi.Trim()), Db.P("@h", maHoSo.Trim()), Db.P("@y", namApDung), Db.P("@s", soTien), Db.P("@nv", maNV));
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã đăng ký, thu lệ phí và cấp hồ sơ " + maHoSo.Trim() + " cho bệnh nhân " + hoTen.Trim() + ".");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Loi(ex);
                }
            }
        }

        /// <summary>Thu lệ phí năm mới cho hồ sơ đã có (mỗi hồ sơ chỉ đóng 1 lần/năm).</summary>
        public KetQuaXuLy ThuLePhi(string maLePhi, string maHoSo, int nam, decimal soTien, string maNV)
        {
            if (KiemTra.Rong(maLePhi) || KiemTra.Rong(maHoSo) || KiemTra.Rong(maNV)) return KetQuaXuLy.Fail("Thông tin lệ phí chưa đầy đủ.");
            if (soTien <= 0) return KetQuaXuLy.Fail("Lệ phí phải lớn hơn 0.");
            if (nam > DateTime.Today.Year + 1) return KetQuaXuLy.Fail("Chỉ thu lệ phí tối đa cho năm kế tiếp.");
            using (SqlConnection cn = Db.MoKetNoi())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    DataTable dt = Db.Query(tx, "SELECT TrangThai, YEAR(NgayCap) AS NamCap FROM HoSoBenhAn WHERE MaHoSo = @m", Db.P("@m", maHoSo.Trim()));
                    if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy hồ sơ " + maHoSo.Trim() + ".");
                    if (Convert.ToString(dt.Rows[0]["TrangThai"]) == "Đã đóng") return KetQuaXuLy.Fail("Hồ sơ đã đóng, không thu thêm lệ phí.");
                    if (nam < Convert.ToInt32(dt.Rows[0]["NamCap"])) return KetQuaXuLy.Fail("Năm áp dụng không được trước năm cấp hồ sơ.");
                    if (Dem(tx, "SELECT COUNT(*) FROM LePhi WHERE MaHoSo = @m AND NamApDung = " + nam, maHoSo.Trim()) > 0)
                        return KetQuaXuLy.Fail("Hồ sơ đã đóng lệ phí năm " + nam + " (mỗi hồ sơ chỉ đóng 1 lần/năm).");
                    Db.Execute(tx, "INSERT INTO LePhi(MaLePhi, MaHoSo, NamApDung, SoTien, NgayDong, MaNV) VALUES(@l, @h, @y, @s, GETDATE(), @nv)",
                        Db.P("@l", maLePhi.Trim()), Db.P("@h", maHoSo.Trim()), Db.P("@y", nam), Db.P("@s", soTien), Db.P("@nv", maNV));
                    Db.Execute(tx, SqlConHan);
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã thu lệ phí năm " + nam + " cho hồ sơ " + maHoSo.Trim() + ".");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Loi(ex);
                }
            }
        }

        /// <summary>
        /// Kiểm tra hồ sơ trước khi khám/hẹn: tồn tại, "Còn hiệu lực" và (nếu có ngày khám) đã có lệ phí của năm khám.
        /// Thành công: ThongBao là thông tin trang bìa để hiển thị.
        /// </summary>
        public KetQuaXuLy KiemTraHoSo(string maHoSo, DateTime? ngayKham)
        {
            if (KiemTra.Rong(maHoSo)) return KetQuaXuLy.Fail("Mã hồ sơ không được để trống.");
            try
            {
                using (SqlConnection cn = Db.MoKetNoi())
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    string loi = ngayKham.HasValue
                        ? KiemTraDuDieuKienKham(tx, maHoSo.Trim(), ngayKham.Value)
                        : KiemTraConHieuLuc(tx, maHoSo.Trim());
                    tx.Commit();
                    if (loi != null) return KetQuaXuLy.Fail(loi);
                    DataTable dt = TimTheoMa(maHoSo.Trim());
                    DataRow r = dt.Rows[0];
                    return KetQuaXuLy.Ok(Convert.ToString(r["HoTen"]) + " - sinh " + Convert.ToString(r["NgaySinh"]) + " - ĐT " + Convert.ToString(r["DienThoai"]));
                }
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi(ex);
            }
        }

        internal static string KiemTraConHieuLuc(SqlTransaction tx, string maHoSo)
        {
            Db.Execute(tx, SqlHetHan);
            Db.Execute(tx, SqlConHan);
            DataTable dt = Db.Query(tx, "SELECT TrangThai FROM HoSoBenhAn WHERE MaHoSo = @m", Db.P("@m", maHoSo));
            if (dt.Rows.Count == 0) return "Không tìm thấy hồ sơ " + maHoSo + ".";
            string tt = Convert.ToString(dt.Rows[0]["TrangThai"]);
            if (tt != "Còn hiệu lực")
                return "Hồ sơ " + maHoSo + " đang ở trạng thái \"" + tt + "\". Hãy thu lệ phí năm mới trước khi khám.";
            return null;
        }

        /// <summary>Chỉ lập phiếu khám khi hồ sơ còn hiệu lực và đã có lệ phí của năm khám.</summary>
        internal static string KiemTraDuDieuKienKham(SqlTransaction tx, string maHoSo, DateTime ngayKham)
        {
            string loi = KiemTraConHieuLuc(tx, maHoSo);
            if (loi != null) return loi;
            DataTable dt = Db.Query(tx, "SELECT NgayCap FROM HoSoBenhAn WHERE MaHoSo = @m", Db.P("@m", maHoSo));
            if (ngayKham.Date < Convert.ToDateTime(dt.Rows[0]["NgayCap"]).Date)
                return "Ngày khám không được trước ngày cấp hồ sơ.";
            if (Dem(tx, "SELECT COUNT(*) FROM LePhi WHERE MaHoSo = @m AND NamApDung = " + ngayKham.Year, maHoSo) == 0)
                return "Hồ sơ " + maHoSo + " chưa có lệ phí của năm " + ngayKham.Year + ".";
            return null;
        }

        internal static int Dem(SqlTransaction tx, string sql, string thamSo)
        {
            return Convert.ToInt32(Db.Scalar(tx, sql, Db.P("@m", thamSo)));
        }
    }
}
