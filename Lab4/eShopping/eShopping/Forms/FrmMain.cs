using eShopping.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShopping.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            using (FrmSanPham frm = new FrmSanPham())
            {
                frm.ShowDialog();
            }
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            using (FrmGioHang frm = new FrmGioHang())
            {
                frm.ShowDialog();
            }

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (PhienLamViec.DaDangNhap)
            {
                if (ThongBao.XacNhan("Đăng xuất khỏi tài khoản \"" + PhienLamViec.KhachHangHienTai.HoTen + "\"?"))
                    PhienLamViec.DangXuat();
                return;
            }
            using (FrmDangNhap frm = new FrmDangNhap())
            {
                frm.ShowDialog(this);
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            DieuHuong.MoDatHang(this);      // kiểm tra giỏ + yêu cầu đăng nhập rồi mới mở frmDatHang
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DieuHuong.Den(this, DieuHuong.ThanhToan);   // chỉ mở khi đã lập đơn ở bước Đặt hàng
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
