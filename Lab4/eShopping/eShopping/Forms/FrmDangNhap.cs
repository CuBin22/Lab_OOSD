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
using static eShopping.Models.Models;

namespace eShopping.Forms
{
    public partial class FrmDangNhap : Form
    {
        private readonly TaiKhoanService service = new TaiKhoanService();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            AcceptButton = btnDangNhap;      // Enter = Đăng nhập
            CancelButton = btnThoat;         // Esc = Thoát
            txtDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KetQuaXuLy kq = service.DangNhap(txtDangNhap.Text, txtMatKhau.Text);
            if (!kq.ThanhCong)
            {
                ThongBao.Hien(kq);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }
            PhienLamViec.DangNhap((KhachHang)kq.Data);     // đồng thời gắn giỏ hàng vào tài khoản (QĐ05)
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (FrmDangKy f = new FrmDangKy())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    txtDangNhap.Text = f.TenDangNhapMoi;
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
