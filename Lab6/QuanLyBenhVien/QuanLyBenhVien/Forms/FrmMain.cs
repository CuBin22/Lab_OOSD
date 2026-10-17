using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmMain : Form
    {
        /// <summary>Hiển thị người dùng và bật/tắt các chức năng theo vai trò.</summary>
        private void HienThiNguoiDung()
        {
            lblNguoiDung.Text = "Người dùng: " + PhienLamViec.HoTen + "  |  Vai trò: " + PhienLamViec.VaiTro;
            btnDanhMuc.Enabled = PhienLamViec.CoQuyen("FrmDanhMuc");
            btnDangKy.Enabled = PhienLamViec.CoQuyen("FrmDangKyHoSo");
            btnKhamBenh.Enabled = PhienLamViec.CoQuyen("FrmKhamBenh");
            btnThanhToan.Enabled = PhienLamViec.CoQuyen("FrmThanhToan");
            btnTraCuu.Enabled = PhienLamViec.CoQuyen("FrmTraCuu");
            btnKhamDinhKy.Enabled = PhienLamViec.CoQuyen("FrmKhamDinhKy");
            btnThongKe.Enabled = PhienLamViec.CoQuyen("FrmThongKe");
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            HienThiNguoiDung();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDangKyHoSo()) f.ShowDialog(this);
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            using (var f = new FrmKhamBenh()) f.ShowDialog(this);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThanhToan()) f.ShowDialog(this);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTraCuu()) f.ShowDialog(this);
        }

        private void btnKhamDinhKy_Click(object sender, EventArgs e)
        {
            using (var f = new FrmKhamDinhKy()) f.ShowDialog(this);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnDoiNguoi_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDangNhap())
            {
                if (f.ShowDialog(this) == DialogResult.OK) HienThiNguoiDung();
            }
        }
    }
}
