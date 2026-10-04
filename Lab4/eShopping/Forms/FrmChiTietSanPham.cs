using eShopping.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eShopping.Models.Models;

namespace eShopping.Forms
{
    public partial class FrmChiTietSanPham : Form
    {
        private readonly string maSanPham;
        private readonly SanPhamService sanPhamSv = new SanPhamService();
        private readonly GioHangService gioSv = new GioHangService();

        public FrmChiTietSanPham(string maSanPham)
        {
            InitializeComponent();
            this.maSanPham = maSanPham;
        }

        private void FrmChiTietSanPham_Load(object sender, EventArgs e)
        {
            nudSoLuong.Minimum = 1;
            nudSoLuong.Maximum = GioHangService.SoLuongToiDa;
            nudSoLuong.Value = 1;
            foreach (TextBox t in new TextBox[] { txtMaSanPham, txtTenSanPham, txtNhaSanXuat, txtGiaHienHanh, txtTinhTrang, txtMoTa, txtThongSoKyThuat })
                t.ReadOnly = true;
            txtMoTa.Multiline = true;
            txtThongSoKyThuat.Multiline = true;
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtThongSoKyThuat.ScrollBars = ScrollBars.Vertical;
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;

            SanPham sp;
            try { sp = sanPhamSv.LayChiTiet(maSanPham); }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); Close(); return; }
            if (sp == null) { ThongBao.Canh("Không tìm thấy sản phẩm."); Close(); return; }

            txtMaSanPham.Text = sp.MaSanPham;
            txtTenSanPham.Text = sp.TenSanPham;
            txtNhaSanXuat.Text = sp.NhaSanXuat;
            txtGiaHienHanh.Text = DinhDang.Tien(sp.GiaBan);
            txtTinhTrang.Text = sp.TinhTrang;
            txtMoTa.Text = sp.MoTa;
            txtThongSoKyThuat.Text = sp.ThongSoKyThuat;
            NapHinh(sp.HinhAnh);

            bool con = sp.ConHang;                       // BR05
            btnThemVaoGio.Enabled = con;
            nudSoLuong.Enabled = con;
            txtTinhTrang.ForeColor = con ? Color.DarkGreen : Color.Firebrick;
        }

        private void NapHinh(string duongDan)
        {
            picHinhAnh.Image = null;
            if (string.IsNullOrWhiteSpace(duongDan) || !File.Exists(duongDan)) return;
            using (FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read))
            using (Image img = Image.FromStream(fs))
                picHinhAnh.Image = new Bitmap(img);      // sao chép để không khóa file
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            ThongBao.Hien(gioSv.ThemSanPham(maSanPham, (int)nudSoLuong.Value));
        }

        private void btnXemGioHang_Click(object sender, EventArgs e)
        {
            DieuHuong.Den(this, DieuHuong.GioHang);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
