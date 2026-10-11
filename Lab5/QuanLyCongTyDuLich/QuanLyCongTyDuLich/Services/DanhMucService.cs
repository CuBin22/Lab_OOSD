using System.Data;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Services
{
    /// <summary>Truy vấn các danh mục dùng để nạp ComboBox.</summary>
    public static class DanhMucService
    {
        public static DataTable LayTour()
        {
            return Db.Query("SELECT MaTour, TenTour, SoNgay, SoDem, DonGia, MaTour + N' - ' + TenTour AS HienThi FROM Tour ORDER BY MaTour");
        }

        /// <summary>loai = "Đoàn" hoặc "Lẻ".</summary>
        public static DataTable LayKhachHang(string loai)
        {
            return Db.Query("SELECT MaKH, TenKH, MaKH + N' - ' + TenKH AS HienThi FROM KhachHang WHERE LoaiKhach = @l ORDER BY MaKH",
                Hlp.P("@l", loai));
        }

        public static DataTable LayDiaDiem()
        {
            return Db.Query("SELECT MaDiaDiem, TenDiaDiem FROM DiaDiem ORDER BY TenDiaDiem");
        }

        public static DataTable LayPhuongTien()
        {
            return Db.Query("SELECT MaPT, TenPT FROM PhuongTien ORDER BY TenPT");
        }

        public static DataTable LayDiemThamQuan()
        {
            return Db.Query("SELECT MaDiemTQ, TenDiemTQ FROM DiemThamQuan ORDER BY TenDiemTQ");
        }

        public static DataTable LayDiemBanVe()
        {
            return Db.Query("SELECT MaDiemBan, TenDiemBan FROM DiemBanVe ORDER BY TenDiemBan");
        }

        public static DataTable LayDiemDon()
        {
            return Db.Query("SELECT MaDiemDon, TenDiemDon FROM DiemDon ORDER BY TenDiemDon");
        }

        public static DataTable LayNhanVien()
        {
            return Db.Query("SELECT MaNV, HoTen, MaNV + N' - ' + HoTen AS HienThi FROM NhanVien ORDER BY MaNV");
        }
    }
}
