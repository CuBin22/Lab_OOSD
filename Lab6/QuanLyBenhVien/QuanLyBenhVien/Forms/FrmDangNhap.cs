using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmDangNhap : Form
    {
        readonly DanhMucService dm = new DanhMucService();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, System.EventArgs e)
        {
            AcceptButton = btnDangNhap;
            cboVaiTro.SelectedIndex = 0;
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UiHelper.NapCombo(cboNguoi, dm.LayNguoiTheoVaiTro(cboVaiTro.Text), "HoTen", "Ma");
                if (cboNguoi.Items.Count > 0) cboNguoi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuocChon(cboVaiTro, "vai trò") || !UiHelper.BatBuocChon(cboNguoi, "người dùng")) return;
            PhienLamViec.DangNhap(UiHelper.Gia(cboNguoi), cboNguoi.Text, cboVaiTro.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
