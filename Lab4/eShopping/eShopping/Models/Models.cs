using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopping.Models
{
    public class Models
    {
        public class SanPham
        {
            public string MaSanPham { get; set; }
            public string MaNhom { get; set; }
            public string TenSanPham { get; set; }
            public string NhaSanXuat { get; set; }
            public string HinhAnh { get; set; }
            public string MoTa { get; set; }
            public string ThongSoKyThuat { get; set; }
            public decimal GiaBan { get; set; }
            public bool ConHang { get; set; }
            public string TinhTrang { get { return ConHang ? "Còn hàng" : "Hết hàng"; } }
        }

        public class KhachHang
        {
            public string MaKhachHang { get; set; }
            public string Ho { get; set; }
            public string Ten { get; set; }
            public DateTime NgaySinh { get; set; }
            public string SoCMND_Passport { get; set; }
            public string DiaChi { get; set; }
            public string SoDienThoai { get; set; }
            public string TenDangNhap { get; set; }
            public string MatKhau { get; set; }      // chỉ dùng khi đăng ký, không lưu vào CSDL (lưu bản băm)
            public string Email { get; set; }
            public string HoTen { get { return (Ho + " " + Ten).Trim(); } }
        }

        public class TheThanhToan
        {
            public string MaLoaiThe { get; set; }
            public string SoThe { get; set; }
            public DateTime NgayHetHan { get; set; }
            public string HoTenChuThe { get; set; }
            public string CSV { get; set; }          // không bao giờ lưu (QĐ09)
        }

        /// <summary>Thông tin đơn đang lập ở frmDatHang, chuyển sang frmThanhToan.</summary>
        public class DonHangDangLap
        {
            public string MaDonHang { get; set; }
            public string HoTenNguoiNhan { get; set; }
            public string DiaChiNguoiNhan { get; set; }
            public string SoDienThoaiNguoiNhan { get; set; }
            public string MaKhuVuc { get; set; }
            public string MaLoaiPhieu { get; set; }
            public decimal TongTienHang { get; set; }
            public decimal PhiGiaoHang { get; set; }
            public decimal TongGiaTri { get { return TongTienHang + PhiGiaoHang; } }
        }

        public class KetQuaPhi
        {
            public decimal Phi { get; set; }
            public bool MienPhi { get; set; }
            public int ThoiGianXuLyGio { get; set; }
        }
    }
}