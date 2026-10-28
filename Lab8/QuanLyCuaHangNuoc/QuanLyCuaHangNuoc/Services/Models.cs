namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Một dòng mặt hàng trong đơn đặt hàng / phiếu giao hàng.</summary>
    public class DongHang
    {
        public string MaNGK { get; set; }
        public string TenNGK { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
    }

    /// <summary>Một dòng trong giỏ hàng / chi tiết hóa đơn.</summary>
    public class DongBan
    {
        public string MaNGK { get; set; }
        public string TenNGK { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongTon { get; set; }
        public decimal ThanhTien { get { return DonGia * SoLuong; } }
        public string TinhTrang
        {
            get { return SoLuong <= SoLuongTon ? "Đủ hàng" : "Thiếu " + (SoLuong - SoLuongTon); }
        }
    }
}
