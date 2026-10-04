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
    public partial class FrmDangKy : Form
    {
        private readonly TaiKhoanService service = new TaiKhoanService();

        /// <summary>Tên đăng nhập vừa đăng ký, để frmDangNhap điền sẵn.</summary>
        public string TenDangNhapMoi { get; private set; }

        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.ReadOnly = true;
            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.MaxDate = DateTime.Today;
            LamMoi();
        }

        private void LamMoi()
        {
            txtHo.Clear();
            txtTen.Clear();
            txtSoCMND.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtNhapLaiMatKhau.Clear();
            dtpNgaySinh.Value = DateTime.Today.AddYears(-25);
            try { txtMaKhachHang.Text = service.LayMaKhachHangKeTiep(); }
            catch (Exception) { txtMaKhachHang.Text = "(tự động)"; }
            txtHo.Focus();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                ThongBao.Canh("Mật khẩu nhập lại không khớp.");
                txtNhapLaiMatKhau.Focus();
                return;
            }
            KhachHang kh = new KhachHang
            {
                Ho = txtHo.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                SoCMND_Passport = txtSoCMND.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhau = txtMatKhau.Text,
                Email = txtEmail.Text.Trim()
            };
            KetQuaXuLy kq = service.DangKy(kh);
            ThongBao.Hien(kq);
            if (!kq.ThanhCong) return;
            TenDangNhapMoi = kh.TenDangNhap;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
