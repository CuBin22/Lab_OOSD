using System;
using System.Windows.Forms;

namespace QuanLyCuaHangNuoc.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) { }

        private void btnDanhMuc_Click(object sender, EventArgs e) { using (var f = new FrmDanhMuc()) f.ShowDialog(this); }
        private void btnDatHang_Click(object sender, EventArgs e) { using (var f = new FrmDatHang()) f.ShowDialog(this); }
        private void btnNhanHang_Click(object sender, EventArgs e) { using (var f = new FrmNhanHang()) f.ShowDialog(this); }
        private void btnBanHang_Click(object sender, EventArgs e) { using (var f = new FrmBanHang()) f.ShowDialog(this); }
        private void btnHenNo_Click(object sender, EventArgs e) { using (var f = new FrmHenNo()) f.ShowDialog(this); }
        private void btnThongKe_Click(object sender, EventArgs e) { using (var f = new FrmThongKe()) f.ShowDialog(this); }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (Ui.XacNhan("Bạn có thực sự muốn thoát?")) Close();
        }
    }
}
