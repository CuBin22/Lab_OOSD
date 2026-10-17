using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmTraCuu : Form
    {
        readonly TraCuuService tc = new TraCuuService();
        readonly KhamBenhService kb = new KhamBenhService();

        public FrmTraCuu()
        {
            InitializeComponent();
        }

        private void FrmTraCuu_Load(object sender, System.EventArgs e)
        {
            cboTieuChi.SelectedIndex = 0;
            txtTuKhoa.Focus();
        }

        private void cboTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            txtTuKhoa.Focus();
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnTim.PerformClick(); }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtTuKhoa, "Từ khóa tìm kiếm")) return;
            string tuKhoa = txtTuKhoa.Text.Trim();
            if (cboTieuChi.Text == "Ngày sinh")
            {
                DateTime ns;
                if (!DateTime.TryParseExact(tuKhoa, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out ns))
                { UiHelper.Canh("Ngày sinh phải theo định dạng dd/MM/yyyy."); txtTuKhoa.Focus(); return; }
            }
            if (cboTieuChi.Text == "Điện thoại")
            {
                foreach (char c in tuKhoa) if (!char.IsDigit(c)) { UiHelper.Canh("Số điện thoại chỉ gồm chữ số."); txtTuKhoa.Focus(); return; }
            }
            try
            {
                DataTable dt = tc.TimHoSo(cboTieuChi.Text, tuKhoa);
                dgvHoSo.DataSource = dt;
                lblSoKetQua.Text = "Tìm thấy: " + dt.Rows.Count + " hồ sơ";
                if (dt.Rows.Count == 0)
                {
                    dgvLichSu.DataSource = null; dgvToa.DataSource = null; dgvXN.DataSource = null;
                    UiHelper.Thong("Không tìm thấy hồ sơ phù hợp.");
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            dgvHoSo.DataSource = null; dgvLichSu.DataSource = null; dgvToa.DataSource = null; dgvXN.DataSource = null;
            lblSoKetQua.Text = "Tìm thấy: 0 hồ sơ";
            txtTuKhoa.Focus();
        }

        private void dgvHoSo_SelectionChanged(object sender, EventArgs e)
        {
            string maHoSo = UiHelper.Cell(dgvHoSo, "MaHoSo");
            if (maHoSo == "") { dgvLichSu.DataSource = null; return; }
            try
            {
                dgvLichSu.DataSource = kb.LayLichSu(maHoSo);
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void dgvLichSu_SelectionChanged(object sender, EventArgs e)
        {
            string soPhieu = UiHelper.Cell(dgvLichSu, "SoPhieuKham");
            if (soPhieu == "") { dgvToa.DataSource = null; dgvXN.DataSource = null; return; }
            try
            {
                dgvToa.DataSource = kb.LayToaThuoc(soPhieu);
                dgvXN.DataSource = kb.LayXetNghiem(soPhieu);
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
