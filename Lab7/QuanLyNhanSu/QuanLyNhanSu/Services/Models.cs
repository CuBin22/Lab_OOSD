using System;
using System.ComponentModel;

namespace QuanLyNhanSu.Services
{
    /// <summary>Một dòng phân công trong kế hoạch tuần (đang chọn, chưa lưu).</summary>
    public class PhanCongItem
    {
        [Browsable(false)] public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime Ngay { get; set; }
        public string Ca { get; set; }
        public bool PhuTroi { get; set; }
    }

    /// <summary>Nhân viên tham gia một phiếu phụ trội (đang chọn, chưa lưu).</summary>
    public class NhanVienItem
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
    }

    /// <summary>Kết quả tính lương một nhân viên trong một tháng.</summary>
    public class BangLuongTinh
    {
        public string MaNV { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal LuongQuyetDinh { get; set; }   // mức lương theo quyết định lương
        public decimal NgayCong { get; set; }         // số ngày công thực tế (tối đa 26)
        public decimal LuongCoBan { get; set; }       // lương cơ bản theo ngày công
        public decimal PhuCap { get; set; }           // phụ cấp lương + độc hại + chức vụ
        public decimal TienPhuTroi { get; set; }
        public decimal TienThuong { get; set; }
        public decimal KhoanTruBaoHiem { get; set; }
        public decimal TienPhat { get; set; }

        public decimal ThucLanh
        {
            get { return LuongCoBan + PhuCap + TienPhuTroi + TienThuong - KhoanTruBaoHiem - TienPhat; }
        }
    }
}
