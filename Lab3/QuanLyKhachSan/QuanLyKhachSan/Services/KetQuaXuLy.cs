namespace QuanLyKhachSan.Services
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; }
        public string ThongBao { get; }

        private KetQuaXuLy(bool thanhCong, string thongBao)
        {
            ThanhCong = thanhCong;
            ThongBao = thongBao;
        }

        public static KetQuaXuLy Ok(string thongBao)
        {
            return new KetQuaXuLy(true, thongBao);
        }

        public static KetQuaXuLy Fail(string thongBao)
        {
            return new KetQuaXuLy(false, thongBao);
        }
    }
}