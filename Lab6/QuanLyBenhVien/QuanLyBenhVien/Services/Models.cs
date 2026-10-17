namespace QuanLyBenhVien.Services
{
    /// <summary>Một loại xét nghiệm được chỉ định trong phiếu khám.</summary>
    public class XetNghiemItem
    {
        public string MaLoaiXN { get; set; }
        public string TenLoaiXN { get; set; }
    }

    /// <summary>Một thuốc trong toa.</summary>
    public class ThuocItem
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public string LieuDung { get; set; }
        public string CachDung { get; set; }
    }
}
