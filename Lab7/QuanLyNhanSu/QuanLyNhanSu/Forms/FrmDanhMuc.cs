using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            cboNVGioiTinh.SelectedIndex = 0;
            cboNVVaiTro.SelectedIndex = 3;      // Nhân viên
            cboNVTrangThai.SelectedIndex = 0;   // Thử việc
            dtNVNgaySinh.Value = DateTime.Today.AddYears(-25);
            Tai();
        }

        void Tai()
        {
            dgvPB.DataSource = s.LayPhongBan();
            UiHelper.DatTieuDe(dgvPB, "Mã", "Tên phòng ban", "Mô tả");
            dgvNV.DataSource = s.LayNhanVien();
            UiHelper.DatTieuDe(dgvNV, "Mã NV", "Họ tên", "CCCD", "Ngày sinh", "Giới tính", "Phòng ban", "Vai trò", "Trạng thái");
            UiHelper.NapCombo(cboNVPhongBan, s.LayPhongBan(), "TenPhongBan", "MaPhongBan");
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            if (UiHelper.ThongBao(s.ThemPhongBan(txtPBMa.Text.Trim(), txtPBTen.Text.Trim(), txtPBMoTa.Text.Trim())))
            {
                Tai();
                btnLamMoiPB_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiPB_Click(object sender, EventArgs e)
        {
            txtPBMa.Clear();
            txtPBTen.Clear();
            txtPBMoTa.Clear();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVHoTen.Text.Trim(), txtNVCCCD.Text.Trim(),
                dtNVNgaySinh.Value, UiHelper.Chu(cboNVGioiTinh), txtNVSDT.Text.Trim(), UiHelper.Gt(cboNVPhongBan),
                UiHelper.Chu(cboNVVaiTro), UiHelper.Chu(cboNVTrangThai), txtNVDiaChi.Text.Trim());
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoiNV_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            txtNVMa.Clear();
            txtNVHoTen.Clear();
            txtNVCCCD.Clear();
            txtNVSDT.Clear();
            txtNVDiaChi.Clear();
            dtNVNgaySinh.Value = DateTime.Today.AddYears(-25);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
