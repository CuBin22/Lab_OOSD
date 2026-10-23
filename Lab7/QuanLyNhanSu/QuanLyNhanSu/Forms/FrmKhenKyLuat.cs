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
    public partial class FrmKhenKyLuat : Form
    {
        readonly KhenKyLuatService s = new KhenKyLuatService();
        readonly DanhMucService dm = new DanhMucService();
        string soQDKTChon = "";
        string soQDKLChon = "";

        public FrmKhenKyLuat()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            cboKTLoai.SelectedIndex = 0;
            cboHinhThucThu.SelectedIndex = 0;
            rdoKTCaNhan_CheckedChanged(null, EventArgs.Empty);
            rdoKLCaNhan_CheckedChanged(null, EventArgs.Empty);
            // Khen thưởng do giám đốc ký.
            UiHelper.NapCombo(cboKTNguoiKy, dm.LayNhanVienCombo("Giám đốc", null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboKLNguoiKy, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboKTNhanVien, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboKLNhanVien, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboKTPhongBan, dm.LayPhongBan(), "TenPhongBan", "MaPhongBan");
            UiHelper.NapCombo(cboKLPhongBan, dm.LayPhongBan(), "TenPhongBan", "MaPhongBan");
            UiHelper.NapCombo(cboPCNguoiLap, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboTNguoiLap, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            Tai();
        }

        void Tai()
        {
            dgvQDKT.DataSource = s.LayQDKT();
            UiHelper.DatTieuDe(dgvQDKT, "Số QĐ", "Ngày ký", "Loại", "Đối tượng", "Số tiền", "Người ký", "Đã chi");
            dgvQDKL.DataSource = s.LayQDKL();
            UiHelper.DatTieuDe(dgvQDKL, "Số QĐ", "Ngày ký", "Hình thức xử lý", "Đối tượng", "Số tiền phạt", "Người ký", "Đã thu");
        }

        // ---------------------------------------------------------------- Khen thưởng
        private void rdoKTCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            cboKTNhanVien.Enabled = rdoKTCaNhan.Checked;
            cboKTPhongBan.Enabled = !rdoKTCaNhan.Checked;
        }

        private void btnLapQDKT_Click(object sender, EventArgs e)
        {
            bool caNhan = rdoKTCaNhan.Checked;
            KetQuaXuLy k = s.LapQDKT(txtSoQDKT.Text.Trim(), dtKTNgayKy.Value, cboKTLoai.Text,
                caNhan ? UiHelper.Gt(cboKTNhanVien) : null, caNhan ? null : UiHelper.Gt(cboKTPhongBan),
                numKTSoTien.Value, txtKTNoiDung.Text.Trim(), UiHelper.Gt(cboKTNguoiKy));
            if (UiHelper.ThongBao(k))
            {
                Tai();
                txtSoQDKT.Clear();
                txtKTNoiDung.Clear();
                numKTSoTien.Value = numKTSoTien.Minimum;
            }
        }

        private void dgvQDKT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQDKT.CurrentRow == null) return;
            soQDKTChon = UiHelper.GtO(dgvQDKT.CurrentRow, "SoQDKT");
            lblPhieuChi.Text = "Phiếu chi khen thưởng (theo quyết định đang chọn: " + soQDKTChon + "):";
        }

        private void btnLapPhieuChi_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapPhieuChi(txtSoPhieuChi.Text.Trim(), soQDKTChon, dtNgayChi.Value, UiHelper.Gt(cboPCNguoiLap));
            if (UiHelper.ThongBao(k))
            {
                txtSoPhieuChi.Clear();
                Tai();
            }
        }

        // ---------------------------------------------------------------- Kỷ luật
        private void rdoKLCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            cboKLNhanVien.Enabled = rdoKLCaNhan.Checked;
            cboKLPhongBan.Enabled = !rdoKLCaNhan.Checked;
        }

        private void btnLapQDKL_Click(object sender, EventArgs e)
        {
            bool caNhan = rdoKLCaNhan.Checked;
            KetQuaXuLy k = s.LapQDKL(txtSoQDKL.Text.Trim(), dtKLNgayKy.Value, txtKLHinhThuc.Text.Trim(),
                caNhan ? UiHelper.Gt(cboKLNhanVien) : null, caNhan ? null : UiHelper.Gt(cboKLPhongBan),
                numKLSoTienPhat.Value, txtKLLyDo.Text.Trim(), UiHelper.Gt(cboKLNguoiKy));
            if (UiHelper.ThongBao(k))
            {
                Tai();
                txtSoQDKL.Clear();
                txtKLHinhThuc.Clear();
                txtKLLyDo.Clear();
                numKLSoTienPhat.Value = numKLSoTienPhat.Minimum;
            }
        }

        private void dgvQDKL_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQDKL.CurrentRow == null) return;
            soQDKLChon = UiHelper.GtO(dgvQDKL.CurrentRow, "SoQDKL");
            lblPhieuThu.Text = "Phiếu thu nộp phạt (theo quyết định đang chọn: " + soQDKLChon + "):";
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapPhieuThu(txtSoPhieuThu.Text.Trim(), soQDKLChon, dtNgayThu.Value, cboHinhThucThu.Text,
                UiHelper.Gt(cboTNguoiLap));
            if (UiHelper.ThongBao(k))
            {
                txtSoPhieuThu.Clear();
                Tai();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
