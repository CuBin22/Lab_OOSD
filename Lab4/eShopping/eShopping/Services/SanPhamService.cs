using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eShopping.Models.Models;

namespace eShopping.Services
{
    internal class SanPhamService
    {
        private static readonly List<SanPham> kho = new List<SanPham>
        {
            Sp("SP001","CAYTHONG","Cây thông Noel 1m2","Công ty ABC",650000m,true,"Cây thông nhân tạo cao 1m2, tán dày, kèm chân đế.","Chiều cao 1,2 m; chất liệu PVC; có chân đế kim loại."),
            Sp("SP002","CAYTHONG","Cây thông Noel 1m8","Công ty ABC",1250000m,true,"Cây thông nhân tạo cao 1m8, dễ lắp ráp.","Chiều cao 1,8 m; chất liệu PVC; 600 nhánh."),
            Sp("SP003","CAYTHONG","Cây thông Noel 2m4","Công ty ABC",2800000m,true,"Cây thông cao 2m4 cho phòng khách lớn.","Chiều cao 2,4 m; 900 nhánh; lắp ghép 3 tầng."),
            Sp("SP004","CAYTHONG","Cây thông tuyết phủ 3m","Winter Home",5600000m,true,"Cây thông cao cấp phủ tuyết nhân tạo.","Chiều cao 3 m; tuyết phủ; kèm đèn LED."),
            Sp("SP005","DEN","Đèn LED dây 10m","Sáng Việt",120000m,true,"Đèn LED dây trang trí 8 chế độ nháy.","Dài 10 m; nguồn 220V; 8 chế độ."),
            Sp("SP006","DEN","Đèn nháy đa sắc 20m","Sáng Việt",185000m,false,"Đèn nháy nhiều màu dùng trong nhà và ngoài trời.","Dài 20 m; chống nước IP44."),
            Sp("SP007","DEN","Đèn ngôi sao treo cửa sổ","Sáng Việt",210000m,true,"Ngôi sao LED treo cửa sổ.","Đường kính 40 cm; pin AA."),
            Sp("SP008","QUA","Ông già Noel bông 60cm","Quà Xinh",350000m,true,"Ông già Noel nhồi bông cao 60 cm.","Cao 60 cm; vải nhung."),
            Sp("SP009","QUA","Hộp nhạc tuyết rơi","Quà Xinh",890000m,true,"Hộp nhạc quả cầu tuyết phát nhạc Giáng Sinh.","Chạy cót; chất liệu thủy tinh và gỗ."),
            Sp("SP010","QUA","Set bánh quy Giáng Sinh","Bánh Ngọt Mùa Đông",250000m,true,"Hộp 24 bánh quy bơ trang trí.","Khối lượng 400 g; hạn dùng 3 tháng."),
            Sp("SP011","QUA","Tất Noel treo quà","Quà Xinh",45000m,true,"Tất treo quà vải len.","Dài 45 cm."),
            Sp("SP012","DEN","Vòng hoa Giáng Sinh 50cm","Công ty ABC",280000m,true,"Vòng hoa treo cửa trang trí.","Đường kính 50 cm; có nơ đỏ.")
        };

        private static SanPham Sp(string ma, string nhom, string ten, string nsx, decimal gia, bool con, string moTa, string thongSo)
        {
            return new SanPham { MaSanPham = ma, MaNhom = nhom, TenSanPham = ten, NhaSanXuat = nsx, GiaBan = gia, ConHang = con, MoTa = moTa, ThongSoKyThuat = thongSo, HinhAnh = "" };
        }

        public DataTable LayNhomSanPham()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNhom", typeof(string));
            dt.Columns.Add("TenNhom", typeof(string));
            dt.Rows.Add("CAYTHONG", "Cây thông Noel");
            dt.Rows.Add("DEN", "Đèn trang trí");
            dt.Rows.Add("QUA", "Quà tặng Giáng Sinh");
            return dt;
        }

        public DataTable LaySanPhamTheoNhom(string maNhom)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSanPham", typeof(string));
            dt.Columns.Add("TenSanPham", typeof(string));
            dt.Columns.Add("NhaSanXuat", typeof(string));
            dt.Columns.Add("GiaBan", typeof(decimal));
            dt.Columns.Add("TinhTrang", typeof(string));
            foreach (SanPham s in kho)
                if (s.MaNhom == maNhom)
                    dt.Rows.Add(s.MaSanPham, s.TenSanPham, s.NhaSanXuat, s.GiaBan, s.TinhTrang);
            return dt;
        }

        /// <summary>Trả về null nếu không có sản phẩm. Có thể ném Exception nếu hệ thống ngoài không phản hồi.</summary>
        public SanPham LayChiTiet(string maSanPham)
        {
            foreach (SanPham s in kho)
                if (string.Equals(s.MaSanPham, maSanPham, StringComparison.OrdinalIgnoreCase)) return s;
            return null;
        }
    }
}
