using System;
using System.Data.SqlClient;

namespace QuanLyBenhVien.Services
{
    /// <summary>Kết quả xử lý của một nghiệp vụ: thành công hoặc nêu nguyên nhân từ chối.</summary>
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }

        public static KetQuaXuLy Ok(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao };
        }

        public static KetQuaXuLy Fail(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = false, ThongBao = thongBao };
        }

        /// <summary>Đổi ngoại lệ SQL thành thông báo dễ hiểu.</summary>
        public static KetQuaXuLy Loi(Exception ex)
        {
            SqlException sx = ex as SqlException;
            if (sx != null)
            {
                if (sx.Number == 2627 || sx.Number == 2601)
                    return Fail("Dữ liệu bị trùng (mã đã tồn tại hoặc vi phạm ràng buộc duy nhất).");
                if (sx.Number == 547)
                    return Fail("Dữ liệu vi phạm ràng buộc (khóa ngoại hoặc điều kiện kiểm tra). Chi tiết: " + sx.Message);
                if (sx.Number == 515)
                    return Fail("Thiếu dữ liệu bắt buộc.");
                if (sx.Number == 50000)
                    return Fail(sx.Message);
            }
            return Fail("Không thể xử lý: " + ex.Message);
        }
    }

    /// <summary>Hàm kiểm tra dữ liệu dùng chung cho các Service.</summary>
    public static class KiemTra
    {
        public static bool Rong(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        /// <summary>Chuỗi đã cắt khoảng trắng; null nếu rỗng (để lưu NULL).</summary>
        public static string ChuoiHoacNull(string s)
        {
            return string.IsNullOrWhiteSpace(s) ? null : s.Trim();
        }

        public static bool LaSoDienThoai(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            s = s.Trim();
            if (s.Length < 9 || s.Length > 11) return false;
            foreach (char c in s) if (!char.IsDigit(c)) return false;
            return true;
        }
    }
}
