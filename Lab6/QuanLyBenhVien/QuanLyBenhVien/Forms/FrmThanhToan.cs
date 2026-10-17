using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmThanhToan : Form
    {
        readonly DanhMucService dm = new DanhMucService();
        readonly ThanhToanService tt = new ThanhToanService();
        readonly KhamBenhService kb = new KhamBenhService();
        private bool dangNap = false;

        private void TaiPhieu()
        {
            try
            {
                dgvPhieuKham.DataSource = tt.LayPhieuKham(txtLocSoPhieu.Text.Trim(), cboLocTT.Text);
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        public FrmThanhToan()
        {
            InitializeComponent();
        }

        private void FrmThanhToan_Load(object sender, System.EventArgs e)
        {
            dangNap = true;
            cboLocTT.SelectedIndex = 0;
            cboHinhThuc.SelectedIndex = 0;
            dtNgayThanhToan.Value = DateTime.Now;
            btnThanhToan.Enabled = btnXuatVien.Enabled = PhienLamViec.LaVaiTro(PhienLamViec.ThanhToan, PhienLamViec.QuanLy);
            btnGhiNhan.Enabled = PhienLamViec.LaVaiTro(PhienLamViec.ChamSoc, PhienLamViec.QuanLy);
            try
            {
                UiHelper.NapCombo(cboNVThu, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.NapCombo(cboNVGhiNhanHS, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.ChonNguoiDung(cboNVThu);
                UiHelper.ChonNguoiDung(cboNVGhiNhanHS);
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
            dangNap = false;
            TaiPhieu();
        }

        private void cboLocTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangNap) TaiPhieu();
        }

        private void btnTaiPhieu_Click(object sender, EventArgs e)
        {
            TaiPhieu();
        }

        private void dgvPhieuKham_SelectionChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            string so = UiHelper.Cell(dgvPhieuKham, "SoPhieuKham");
            txtSoPhieuChon.Text = so;
            if (so == "")
            {
                lblTrangThaiTT.Text = "Trạng thái: chưa chọn phiếu.";
                dgvToaXem.DataSource = null;
                dgvXNXem.DataSource = null;
                return;
            }
            lblTrangThaiTT.Text = "Trạng thái: " + UiHelper.Cell(dgvPhieuKham, "TrangThaiTT");
            try
            {
                dgvToaXem.DataSource = kb.LayToaThuoc(so);
                dgvXNXem.DataSource = kb.LayXetNghiem(so);
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtSoPhieuChon, "Phiếu khám cần thanh toán") || !UiHelper.BatBuoc(txtSoBienLai, "Số biên lai")
                || !UiHelper.BatBuocChon(cboHinhThuc, "Hình thức thanh toán") || !UiHelper.BatBuocChon(cboNVThu, "Nhân viên thu")) return;
            if (numSoTienTT.Value <= 0) { UiHelper.Canh("Số tiền thanh toán phải lớn hơn 0."); numSoTienTT.Focus(); return; }
            try
            {
                KetQuaXuLy k = tt.ThanhToan(txtSoBienLai.Text.Trim(), txtSoPhieuChon.Text.Trim(), dtNgayThanhToan.Value, cboHinhThuc.Text, numSoTienTT.Value, UiHelper.Gia(cboNVThu));
                if (UiHelper.HienKetQua(k))
                {
                    txtSoBienLai.Clear();
                    numSoTienTT.Value = 0;
                    TaiPhieu();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnXuatVien_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtSoPhieuChon, "Phiếu khám cần xuất viện")) return;
            try
            {
                if (UiHelper.HienKetQua(tt.XuatVien(txtSoPhieuChon.Text.Trim()))) TaiPhieu();
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtSoPhieuChon, "Phiếu khám cần ghi nhận") || !UiHelper.BatBuocChon(cboNVGhiNhanHS, "Nhân viên ghi nhận")) return;
            try
            {
                if (UiHelper.HienKetQua(tt.GhiNhanVaoHoSo(txtSoPhieuChon.Text.Trim(), UiHelper.Gia(cboNVGhiNhanHS), txtGhiChuHS.Text.Trim())))
                {
                    txtGhiChuHS.Clear();
                    TaiPhieu();
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
