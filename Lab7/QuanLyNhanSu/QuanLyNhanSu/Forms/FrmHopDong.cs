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
    public partial class FrmHopDong : Form
    {
        readonly HopDongService s = new HopDongService();

        public FrmHopDong()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            cboLoaiHD.SelectedIndex = 0;
            cboBHLoai.SelectedIndex = 0;
            // Ngày bắt đầu mặc định bằng ngày ký.
            dtHDNgayKy.ValueChanged += (a, b) => dtHDBatDau.Value = dtHDNgayKy.Value;
            cboHDNhanVien.SelectedIndexChanged += cboHDNhanVien_SelectedIndexChanged;
            chkHDKhongThoiHan_CheckedChanged(null, EventArgs.Empty);
            Tai();
        }

        void Tai()
        {
            dgvHD.DataSource = s.LayHopDong();
            UiHelper.DatTieuDe(dgvHD, "Số HĐ", "Nhân viên", "Số QĐTD", "Loại", "Ngày ký", "Bắt đầu", "Kết thúc", "Trạng thái");
            dgvBH.DataSource = s.LayHoSoBaoHiem();
            UiHelper.DatTieuDe(dgvBH, "Mã hồ sơ", "Nhân viên", "Số HĐ", "Loại BH", "Số sổ", "Ngày lập", "Mức đóng (%)");
            UiHelper.NapCombo(cboHDNhanVien, s.LayNhanVienCoQDTD(), "HoTen", "MaNV");
            UiHelper.NapCombo(cboBHHopDong, s.LayHopDongDaiHan(), "SoHopDong", "SoHopDong");
            cboHDNhanVien_SelectedIndexChanged(null, EventArgs.Empty);
            cboBHHopDong_SelectedIndexChanged(null, EventArgs.Empty);
        }

        // Chọn nhân viên -> nạp quyết định tuyển dụng của nhân viên đó.
        private void cboHDNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = UiHelper.Gt(cboHDNhanVien);
            if (ma == "") { cboHDQDTD.DataSource = null; return; }
            UiHelper.NapCombo(cboHDQDTD, s.LayQDTDCuaNhanVien(ma), "SoQDTD", "SoQDTD");
        }

        private void chkHDKhongThoiHan_CheckedChanged(object sender, EventArgs e)
        {
            dtHDKetThuc.Enabled = !chkHDKhongThoiHan.Checked;
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            DateTime? ketThuc = chkHDKhongThoiHan.Checked ? (DateTime?)null : dtHDKetThuc.Value.Date;
            KetQuaXuLy k = s.LapHopDong(txtSoHD.Text.Trim(), UiHelper.Gt(cboHDNhanVien), UiHelper.Gt(cboHDQDTD),
                UiHelper.Chu(cboLoaiHD), dtHDNgayKy.Value, dtHDBatDau.Value, ketThuc);
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoiHD_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            txtSoHD.Clear();
            dtHDNgayKy.Value = DateTime.Today;
            dtHDBatDau.Value = DateTime.Today;
            dtHDKetThuc.Value = DateTime.Today;
            chkHDKhongThoiHan.Checked = false;
        }

        private void cboBHHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView r = cboBHHopDong.SelectedItem as DataRowView;
            txtBHNhanVien.Text = r == null ? "" : Convert.ToString(r["HoTen"]);
        }

        private void btnLapBH_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapHoSoBaoHiem(UiHelper.Gt(cboBHHopDong), UiHelper.Chu(cboBHLoai), txtBHSoSo.Text.Trim(),
                dtBHNgayLap.Value, numBHMucDong.Value);
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoiBH_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiBH_Click(object sender, EventArgs e)
        {
            txtBHSoSo.Clear();
            numBHMucDong.Value = numBHMucDong.Minimum;
            dtBHNgayLap.Value = DateTime.Today;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
