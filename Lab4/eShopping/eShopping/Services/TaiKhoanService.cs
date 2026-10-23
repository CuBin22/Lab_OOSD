using eShopping.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static eShopping.Models.Models;

namespace eShopping.Services
{
    internal class TaiKhoanService
    {
        private class LanSai { public int So; public DateTime Cuoi; }
        private const int SoLanSaiToiDa = 5;                                   // NFR07
        private static readonly TimeSpan ThoiGianKhoa = TimeSpan.FromMinutes(5);
        private static readonly Dictionary<string, LanSai> saiMatKhau = new Dictionary<string, LanSai>();
        private static readonly object khoa = new object();

        // ---------------- Đăng ký (UC5) ----------------
        public string LayMaKhachHangKeTiep()
        {
            object o = Db.Scalar(@"SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaKhachHang,3,18) AS INT)),0) + 1
                                   FROM KhachHang
                                   WHERE MaKhachHang LIKE 'KH[0-9]%' AND LEN(MaKhachHang) <= 11
                                     AND SUBSTRING(MaKhachHang,3,18) NOT LIKE '%[^0-9]%'");
            return "KH" + Convert.ToInt32(o).ToString("D3");
        }

        public KetQuaXuLy DangKy(KhachHang kh)
        {
            if (kh == null) return KetQuaXuLy.Loi("Thiếu thông tin đăng ký.");
            if (string.IsNullOrWhiteSpace(kh.Ho) || string.IsNullOrWhiteSpace(kh.Ten))
                return KetQuaXuLy.Loi("Vui lòng nhập họ và tên.");
            if (kh.NgaySinh.Date > DateTime.Today || kh.NgaySinh.Year < 1900)
                return KetQuaXuLy.Loi("Ngày sinh không hợp lệ.");
            if (string.IsNullOrWhiteSpace(kh.SoCMND_Passport) || !Regex.IsMatch(kh.SoCMND_Passport.Trim(), "^[A-Za-z0-9]{8,20}$"))
                return KetQuaXuLy.Loi("Số CMND/Passport phải gồm 8-20 chữ hoặc số.");
            if (string.IsNullOrWhiteSpace(kh.DiaChi)) return KetQuaXuLy.Loi("Vui lòng nhập địa chỉ.");
            if (string.IsNullOrWhiteSpace(kh.SoDienThoai) || !Regex.IsMatch(kh.SoDienThoai.Trim(), @"^\d{9,11}$"))
                return KetQuaXuLy.Loi("Số điện thoại phải gồm 9-11 chữ số.");
            if (string.IsNullOrWhiteSpace(kh.TenDangNhap) || !Regex.IsMatch(kh.TenDangNhap.Trim(), @"^[A-Za-z0-9_.]{4,50}$"))
                return KetQuaXuLy.Loi("Tên đăng nhập gồm 4-50 ký tự (chữ, số, dấu _ hoặc .), không dấu, không khoảng trắng.");
            if (string.IsNullOrEmpty(kh.MatKhau) || kh.MatKhau.Length < 6)
                return KetQuaXuLy.Loi("Mật khẩu phải có ít nhất 6 ký tự.");
            if (!string.IsNullOrWhiteSpace(kh.Email) && !Regex.IsMatch(kh.Email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return KetQuaXuLy.Loi("Địa chỉ email không hợp lệ.");

            try
            {
                if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM KhachHang WHERE TenDangNhap=@u", new SqlParameter("@u", kh.TenDangNhap.Trim()))) > 0)
                    return KetQuaXuLy.Loi("Tên đăng nhập đã tồn tại.");

                string hash = BamMatKhau(kh.MatKhau);
                for (int lan = 0; lan < 3; lan++)          // thử lại nếu trùng mã do hai người đăng ký cùng lúc
                {
                    string ma = LayMaKhachHangKeTiep();
                    try
                    {
                        Db.Execute(@"INSERT INTO KhachHang (MaKhachHang, Ho, Ten, NgaySinh, SoCMND_Passport, DiaChi, SoDienThoai, TenDangNhap, MatKhauHash, Email)
                                     VALUES (@Ma,@Ho,@Ten,@NS,@CMND,@DC,@SDT,@TDN,@Hash,@Email)",
                            new SqlParameter("@Ma", ma),
                            new SqlParameter("@Ho", kh.Ho.Trim()),
                            new SqlParameter("@Ten", kh.Ten.Trim()),
                            new SqlParameter("@NS", kh.NgaySinh.Date),
                            new SqlParameter("@CMND", kh.SoCMND_Passport.Trim()),
                            new SqlParameter("@DC", kh.DiaChi.Trim()),
                            new SqlParameter("@SDT", kh.SoDienThoai.Trim()),
                            new SqlParameter("@TDN", kh.TenDangNhap.Trim()),
                            new SqlParameter("@Hash", hash),
                            new SqlParameter("@Email", string.IsNullOrWhiteSpace(kh.Email) ? (object)DBNull.Value : kh.Email.Trim()));
                        kh.MaKhachHang = ma;
                        return KetQuaXuLy.Ok("Đăng ký tài khoản thành công. Mã khách hàng: " + ma, ma);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number != 2627 && ex.Number != 2601) throw;
                        if (ex.Message.Contains("UQ_KhachHang_TenDangNhap")) return KetQuaXuLy.Loi("Tên đăng nhập đã tồn tại.");
                        if (ex.Message.Contains("UQ_KhachHang_CMND")) return KetQuaXuLy.Loi("Số CMND/Passport này đã được đăng ký.");
                        // trùng khóa chính -> vòng lặp sinh mã mới
                    }
                }
                return KetQuaXuLy.Loi("Không tạo được mã khách hàng, vui lòng thử lại.");
            }
            catch (SqlException ex)
            {
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        // ---------------- Đăng nhập (UC6) ----------------
        public KetQuaXuLy DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                return KetQuaXuLy.Loi("Vui lòng nhập tên đăng nhập và mật khẩu.");
            string key = tenDangNhap.Trim().ToLowerInvariant();

            lock (khoa)
            {
                LanSai ls;
                if (saiMatKhau.TryGetValue(key, out ls) && ls.So >= SoLanSaiToiDa)
                {
                    if (DateTime.Now - ls.Cuoi < ThoiGianKhoa)
                        return KetQuaXuLy.Loi("Đăng nhập sai quá nhiều lần. Vui lòng thử lại sau vài phút.");
                    saiMatKhau.Remove(key);
                }
            }

            try
            {
                DataTable dt = Db.Query(@"SELECT MaKhachHang, Ho, Ten, NgaySinh, SoCMND_Passport, DiaChi, SoDienThoai, TenDangNhap, MatKhauHash, Email
                                          FROM KhachHang WHERE TenDangNhap=@u", new SqlParameter("@u", tenDangNhap.Trim()));
                bool ok = dt.Rows.Count == 1 && XacMinhMatKhau(matKhau, Convert.ToString(dt.Rows[0]["MatKhauHash"]));
                if (!ok)
                {
                    lock (khoa)
                    {
                        LanSai ls;
                        if (!saiMatKhau.TryGetValue(key, out ls)) { ls = new LanSai(); saiMatKhau[key] = ls; }
                        ls.So++; ls.Cuoi = DateTime.Now;
                    }
                    return KetQuaXuLy.Loi("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
                lock (khoa) { saiMatKhau.Remove(key); }
                return KetQuaXuLy.Ok("Đăng nhập thành công.", TuDong(dt.Rows[0]));
            }
            catch (SqlException ex)
            {
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        private static KhachHang TuDong(DataRow r)
        {
            return new KhachHang
            {
                MaKhachHang = Convert.ToString(r["MaKhachHang"]),
                Ho = Convert.ToString(r["Ho"]),
                Ten = Convert.ToString(r["Ten"]),
                NgaySinh = Convert.ToDateTime(r["NgaySinh"]),
                SoCMND_Passport = Convert.ToString(r["SoCMND_Passport"]),
                DiaChi = Convert.ToString(r["DiaChi"]),
                SoDienThoai = Convert.ToString(r["SoDienThoai"]),
                TenDangNhap = Convert.ToString(r["TenDangNhap"]),
                Email = r["Email"] == DBNull.Value ? null : Convert.ToString(r["Email"])
            };
        }

        // ---------------- Băm mật khẩu (QĐ10): PBKDF2 + salt ngẫu nhiên ----------------
        private const int VongLap = 10000;

        private static string BamMatKhau(string matKhau)
        {
            byte[] salt = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create()) rng.GetBytes(salt);
            byte[] h;
            using (Rfc2898DeriveBytes kdf = new Rfc2898DeriveBytes(matKhau, salt, VongLap)) h = kdf.GetBytes(32);
            return "PBKDF2$" + VongLap + "$" + Convert.ToBase64String(salt) + "$" + Convert.ToBase64String(h);
        }

        private static bool XacMinhMatKhau(string matKhau, string luu)
        {
            try
            {
                string[] p = (luu ?? "").Split('$');
                if (p.Length != 4 || p[0] != "PBKDF2") return false;
                int vong = int.Parse(p[1]);
                byte[] salt = Convert.FromBase64String(p[2]);
                byte[] goc = Convert.FromBase64String(p[3]);
                byte[] h;
                using (Rfc2898DeriveBytes kdf = new Rfc2898DeriveBytes(matKhau, salt, vong)) h = kdf.GetBytes(goc.Length);
                int diff = 0;
                for (int i = 0; i < goc.Length; i++) diff |= goc[i] ^ h[i];   // so sánh thời gian cố định
                return diff == 0;
            }
            catch (FormatException) { return false; }
        }
    }
}
