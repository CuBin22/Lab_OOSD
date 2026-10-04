using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopping.Services
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }
        public object Data { get; set; }

        public static KetQuaXuLy Ok(string thongBao) { return new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao }; }
        public static KetQuaXuLy Ok(string thongBao, object data) { return new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao, Data = data }; }
        public static KetQuaXuLy Loi(string thongBao) { return new KetQuaXuLy { ThanhCong = false, ThongBao = thongBao }; }
    }
}
