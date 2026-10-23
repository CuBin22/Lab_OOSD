using eShopping.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eShopping.Models.Models;
using eShopping.Models;
namespace eShopping.Forms
{
    public static class DieuHuong
    {
        public const string SanPham = "SanPham";
        public const string GioHang = "GioHang";
        public const string DatHang = "DatHang";
        public const string ThanhToan = "ThanhToan";

        /// <summary>Gọi trong sự kiện Load của form có thanh điều hướng. Không cần gán sự kiện trong Designer.</summary>
        public static void GanLienKet(Form f)
        {
            Gan(f, "lnkSanPham", SanPham);
            Gan(f, "lnkGioHang", GioHang);
            Gan(f, "lnkDatHang", DatHang);
            Gan(f, "lnkThanhToan", ThanhToan);
        }

        private static void Gan(Form f, string tenControl, string dich)
        {
            foreach (Control c in f.Controls.Find(tenControl, true))
            {
                LinkLabel lb = c as LinkLabel;
                if (lb != null) lb.LinkClicked += delegate { Den(f, dich); };
                else c.Click += delegate { Den(f, dich); };
            }
        }

        public static void Den(Form hienTai, string dich)
        {
            if ((dich == SanPham && hienTai is FrmSanPham) || (dich == GioHang && hienTai is FrmGioHang) ||
                (dich == DatHang && hienTai is FrmDatHang) || (dich == ThanhToan && hienTai is FrmThanhToan)) return;

            if (dich == ThanhToan && PhienLamViec.DonHangDangLap == null)
            {
                MessageBox.Show("Hãy nhập thông tin người nhận ở bước Đặt hàng rồi bấm Thanh toán.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // FrmMain là cửa sổ gốc (Application.Run) nên tuyệt đối không được đóng, nếu không chương trình sẽ thoát.
            Form goc = null, chinh = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmMain) goc = f;
                else if (f is FrmSanPham) chinh = f;
            }

            // Đóng mọi form con (form mở sau cùng đóng trước)
            List<Form> con = new List<Form>();
            foreach (Form f in Application.OpenForms) if (f != chinh && f != goc) con.Add(f);
            for (int i = con.Count - 1; i >= 0; i--) con[i].Close();

            if (dich == SanPham && chinh != null) return;      // đã ở sẵn màn hình sản phẩm
            Form chu = chinh ?? goc;
            if (chu == null) return;
            string dichCopy = dich; Form chuCopy = chu;
            chu.BeginInvoke(new Action(delegate { Mo(chuCopy, dichCopy); }));
        }

        private static void Mo(Form chu, string dich)
        {
            switch (dich)
            {
                case SanPham:
                    using (FrmSanPham s = new FrmSanPham()) s.ShowDialog(chu);
                    break;
                case GioHang:
                    using (FrmGioHang g = new FrmGioHang()) g.ShowDialog(chu);
                    break;
                case DatHang:
                    MoDatHang(chu);
                    break;
                case ThanhToan:
                    if (PhienLamViec.DonHangDangLap != null) MoThanhToan(chu, PhienLamViec.DonHangDangLap);
                    break;
            }
        }

        /// <summary>UC6 bước 1-2: giỏ phải hợp lệ, yêu cầu đăng nhập (BR07) rồi mở frmDatHang.</summary>
        public static void MoDatHang(Form chu)
        {
            GioHangService gh = new GioHangService();
            try
            {
                string ma = gh.LayMaGioHienTai(false);
                KetQuaXuLy kq = gh.KiemTraGioHopLe(ma == null ? new DataTable() : gh.LayChiTietGio(ma));
                if (!kq.ThanhCong) { ThongBao.Hien(kq); return; }
            }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); return; }

            if (!PhienLamViec.DaDangNhap)
            {
                using (FrmDangNhap dn = new FrmDangNhap())
                    if (dn.ShowDialog(chu) != DialogResult.OK) return;
            }
            using (FrmDatHang dh = new FrmDatHang()) dh.ShowDialog(chu);
        }

        /// <summary>Mở frmThanhToan; nếu đặt hàng thành công thì mở frmXacNhanDonHang. Trả về true nếu đã ghi đơn.</summary>
        public static bool MoThanhToan(Form chu, DonHangDangLap don)
        {
            string maDon = null;
            using (FrmThanhToan tt = new FrmThanhToan(don))
                if (tt.ShowDialog(chu) == DialogResult.OK) maDon = tt.MaDonHangDaDat;
            if (maDon == null) return false;

            PhienLamViec.DonHangDangLap = null;
            using (FrmXacNhanDonHang xn = new FrmXacNhanDonHang(maDon)) xn.ShowDialog(chu);
            return true;
        }
    }
}
