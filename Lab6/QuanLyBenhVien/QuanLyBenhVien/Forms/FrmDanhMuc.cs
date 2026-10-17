using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService dm = new DanhMucService();

        private void Tai()
        {
            try
            {
                dgvKhoa.DataSource = dm.LayKhoa();
                dgvBS.DataSource = dm.LayBacSi();
                dgvNV.DataSource = dm.LayNhanVien();
                dgvLoaiXN.DataSource = dm.LayLoaiXetNghiem();
                dgvThuoc.DataSource = dm.LayThuoc();
                UiHelper.NapCombo(cboBSKhoa, dm.LayKhoa(), "TenKhoa", "MaKhoa");
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, System.EventArgs e)
        {
            Tai();
            cboNVVaiTro.SelectedIndex = 0;
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtKhoaMa, "Mã khoa") || !UiHelper.BatBuoc(txtKhoaTen, "Tên khoa")) return;
            try
            {
                KetQuaXuLy k = dm.ThemKhoa(txtKhoaMa.Text, txtKhoaTen.Text);
                if (UiHelper.HienKetQua(k))
                {
                    UiHelper.XoaTrang(txtKhoaMa, txtKhoaTen);
                    Tai();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtBSMa, "Mã bác sĩ") || !UiHelper.BatBuoc(txtBSTen, "Họ tên bác sĩ") || !UiHelper.BatBuocChon(cboBSKhoa, "Khoa")) return;
            try
            {
                KetQuaXuLy k = dm.ThemBacSi(txtBSMa.Text, txtBSTen.Text, UiHelper.Gia(cboBSKhoa), txtBSSDT.Text);
                if (UiHelper.HienKetQua(k))
                {
                    UiHelper.XoaTrang(txtBSMa, txtBSTen, txtBSSDT);
                    Tai();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtNVMa, "Mã nhân viên") || !UiHelper.BatBuoc(txtNVTen, "Họ tên nhân viên") || !UiHelper.BatBuocChon(cboNVVaiTro, "Vai trò")) return;
            try
            {
                KetQuaXuLy k = dm.ThemNhanVien(txtNVMa.Text, txtNVTen.Text, cboNVVaiTro.Text, txtNVSDT.Text);
                if (UiHelper.HienKetQua(k))
                {
                    UiHelper.XoaTrang(txtNVMa, txtNVTen, txtNVSDT);
                    Tai();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnThemLoaiXN_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtLoaiXNMa, "Mã loại xét nghiệm") || !UiHelper.BatBuoc(txtLoaiXNTen, "Tên loại xét nghiệm")) return;
            try
            {
                KetQuaXuLy k = dm.ThemLoaiXetNghiem(txtLoaiXNMa.Text, txtLoaiXNTen.Text);
                if (UiHelper.HienKetQua(k))
                {
                    UiHelper.XoaTrang(txtLoaiXNMa, txtLoaiXNTen);
                    Tai();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtThuocMa, "Mã thuốc") || !UiHelper.BatBuoc(txtThuocTen, "Tên thuốc") || !UiHelper.BatBuoc(txtThuocDVT, "Đơn vị tính")) return;
            try
            {
                KetQuaXuLy k = dm.ThemThuoc(txtThuocMa.Text, txtThuocTen.Text, txtThuocDVT.Text, txtThuocPUP.Text);
                if (UiHelper.HienKetQua(k))
                {
                    UiHelper.XoaTrang(txtThuocMa, txtThuocTen, txtThuocDVT, txtThuocPUP);
                    Tai();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
