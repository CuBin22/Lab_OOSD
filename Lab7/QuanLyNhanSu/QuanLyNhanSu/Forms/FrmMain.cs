using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object s, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }

        private void btnTuyenDung_Click(object s, EventArgs e)
        {
            using (var f = new FrmTuyenDung()) f.ShowDialog(this);
        }

        private void btnHopDong_Click(object s, EventArgs e)
        {
            using (var f = new FrmHopDong()) f.ShowDialog(this);
        }

        private void btnQuyetDinh_Click(object s, EventArgs e)
        {
            using (var f = new FrmQuyetDinh()) f.ShowDialog(this);
        }

        private void btnChamCong_Click(object s, EventArgs e)
        {
            using (var f = new FrmChamCong()) f.ShowDialog(this);
        }

        private void btnBangLuong_Click(object s, EventArgs e)
        {
            using (var f = new FrmBangLuong()) f.ShowDialog(this);
        }

        private void btnKhenKyLuat_Click(object s, EventArgs e)
        {
            using (var f = new FrmKhenKyLuat()) f.ShowDialog(this);
        }

        private void btnThongKe_Click(object s, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }

        private void btnThoat_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }
    }
}