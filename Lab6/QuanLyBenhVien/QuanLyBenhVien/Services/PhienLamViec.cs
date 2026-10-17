using System.Linq;

namespace QuanLyBenhVien.Services
{
    /// <summary>Người dùng đang đăng nhập và phân quyền theo vai trò.</summary>
    public static class PhienLamViec
    {
        public const string BacSi = "Bác sĩ";
        public const string ChamSoc = "Chăm sóc khách hàng";
        public const string XetNghiem = "Xét nghiệm";
        public const string ThanhToan = "Thanh toán";
        public const string QuanLy = "Quản lý";

        public static readonly string[] DanhSachVaiTro = { BacSi, ChamSoc, XetNghiem, ThanhToan, QuanLy };

        public static string MaNguoi { get; private set; }
        public static string HoTen { get; private set; }
        public static string VaiTro { get; private set; }

        static PhienLamViec()
        {
            MaNguoi = ""; HoTen = ""; VaiTro = "";
        }

        public static void DangNhap(string ma, string hoTen, string vaiTro)
        {
            MaNguoi = ma; HoTen = hoTen; VaiTro = vaiTro;
        }

        public static bool LaVaiTro(params string[] cacVaiTro)
        {
            return cacVaiTro.Contains(VaiTro);
        }

        /// <summary>Vai trò nào được mở Form nào.</summary>
        public static bool CoQuyen(string tenForm)
        {
            if (VaiTro == QuanLy) return true;
            switch (tenForm)
            {
                case "FrmDanhMuc": return VaiTro == ChamSoc;
                case "FrmDangKyHoSo": return VaiTro == ChamSoc;
                case "FrmKhamBenh": return VaiTro == BacSi || VaiTro == ChamSoc || VaiTro == XetNghiem;
                case "FrmThanhToan": return VaiTro == ThanhToan || VaiTro == ChamSoc;
                case "FrmTraCuu": return VaiTro == BacSi || VaiTro == ChamSoc;
                case "FrmKhamDinhKy": return VaiTro == ChamSoc;
                case "FrmThongKe": return false;
                default: return false;
            }
        }
    }
}
