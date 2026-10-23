using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eShopping.Models.Models;

namespace eShopping.Services
{
    internal class PhienLamViec
    {
        public static readonly string MaPhien = Guid.NewGuid().ToString("N");
        public static KhachHang KhachHangHienTai { get; private set; }
        public static DonHangDangLap DonHangDangLap { get; set; }
        public static bool DaDangNhap { get { return KhachHangHienTai != null; } }

        public static void DangNhap(KhachHang kh)
        {
            KhachHangHienTai = kh;
            try { new GioHangService().GanGioVaoTaiKhoan(MaPhien, kh.MaKhachHang); }   // QĐ05: không mất hàng đã chọn
            catch (Exception) { /* gộp giỏ lỗi không được chặn đăng nhập */ }
        }

        public static void DangXuat()
        {
            KhachHangHienTai = null;
            DonHangDangLap = null;
        }
    }
}
