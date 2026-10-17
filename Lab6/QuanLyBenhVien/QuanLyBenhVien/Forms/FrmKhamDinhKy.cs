using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmKhamDinhKy : Form
    {
        readonly DanhMucService dm = new DanhMucService();
        readonly HoSoService hs = new HoSoService();
        readonly KhamDinhKyService dk = new KhamDinhKyService();
        private string maHoSoHopLe = "";

        private void TaiLich()
        {
            dgvLichHen.DataSource = dk.LayLichHen();
        }

        public FrmKhamDinhKy()
        {
            InitializeComponent();
        }

        private void FrmKhamDinhKy_Load(object sender, System.EventArgs e)
        {
            dtNgayGioHen.Value = DateTime.Now.AddDays(1);
            cboQuy.SelectedIndex = KhamDinhKyService.QuyCua(DateTime.Today) - 1;
            numNamKham.Value = DateTime.Today.Year;
            try
            {
                UiHelper.NapCombo(cboNVHen, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.NapCombo(cboNVDK, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.NapCombo(cboBacSiDK, dm.LayBacSi(), "HoTen", "MaBS");
                UiHelper.NapCombo(cboKhoaDK, dm.LayKhoa(), "TenKhoa", "MaKhoa");
                UiHelper.ChonNguoiDung(cboNVHen);
                UiHelper.ChonNguoiDung(cboNVDK);
                TaiLich();
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnKiemTraHoSo_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtMaHoSoDK, "Mã hồ sơ")) return;
            try
            {
                KetQuaXuLy k = hs.KiemTraHoSo(txtMaHoSoDK.Text.Trim(), null);
                if (!k.ThanhCong)
                {
                    maHoSoHopLe = "";
                    lblKetQuaKiemTra.Text = "Hồ sơ không hợp lệ.";
                    UiHelper.Canh(k.ThongBao);
                    return;
                }
                maHoSoHopLe = txtMaHoSoDK.Text.Trim();
                lblKetQuaKiemTra.Text = "Hồ sơ hợp lệ: " + k.ThongBao;
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void cboQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Đưa ngày hẹn về đầu quý được chọn nếu ngày hiện chọn không thuộc quý đó
            int quyNgay = (dtNgayGioHen.Value.Month - 1) / 3;
            if (cboQuy.SelectedIndex >= 0 && quyNgay != cboQuy.SelectedIndex)
            {
                DateTime moi = new DateTime((int)numNamKham.Value, cboQuy.SelectedIndex * 3 + 1, 1, 8, 0, 0);
                dtNgayGioHen.Value = moi;
            }
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (maHoSoHopLe == "" || txtMaHoSoDK.Text.Trim() != maHoSoHopLe)
            {
                UiHelper.Canh("Hãy kiểm tra hồ sơ của bệnh nhân (nút Kiểm tra hồ sơ) trước khi đặt lịch.");
                txtMaHoSoDK.Focus();
                return;
            }
            if (!UiHelper.BatBuoc(txtMaLichHen, "Mã lịch hẹn") || !UiHelper.BatBuocChon(cboQuy, "Quý khám") || !UiHelper.BatBuocChon(cboNVHen, "Nhân viên nhận hẹn")) return;
            if (dtNgayGioHen.Value <= DateTime.Now) { UiHelper.Canh("Ngày giờ hẹn phải sau thời điểm hiện tại."); dtNgayGioHen.Focus(); return; }
            if (dtNgayGioHen.Value.Year != (int)numNamKham.Value || KhamDinhKyService.QuyCua(dtNgayGioHen.Value) != cboQuy.SelectedIndex + 1)
            { UiHelper.Canh("Ngày hẹn không thuộc quý / năm đã chọn."); dtNgayGioHen.Focus(); return; }
            try
            {
                KetQuaXuLy k = dk.DatLich(txtMaLichHen.Text.Trim(), maHoSoHopLe, cboQuy.SelectedIndex + 1, dtNgayGioHen.Value, UiHelper.Gia(cboNVHen));
                if (UiHelper.HienKetQua(k))
                {
                    txtMaLichHen.Clear();
                    TaiLich();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnHuyLich_Click(object sender, EventArgs e)
        {
            string ma = UiHelper.Cell(dgvLichHen, "MaLichHen");
            if (ma == "") { UiHelper.Canh("Hãy chọn lịch hẹn cần hủy."); return; }
            if (!UiHelper.XacNhan("Hủy lịch hẹn " + ma + "?")) return;
            try
            {
                if (UiHelper.HienKetQua(dk.HuyLich(ma))) TaiLich();
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnLamMoiLich_Click(object sender, EventArgs e)
        {
            UiHelper.XoaTrang(txtMaLichHen, txtSoPhieuKhamDK, txtGhiChuDK, txtLichHenChon);
            chkPhatHien.Checked = false;
            dtNgayGioHen.Value = DateTime.Now.AddDays(1);
            txtMaLichHen.Focus();
        }

        private void chkPhatHien_CheckedChanged(object sender, EventArgs e)
        {
            lblGhiChuDK.Text = chkPhatHien.Checked ? "Mô tả (bắt buộc):" : "Ghi chú:";
        }

        private void btnGhiDotKham_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtLichHenChon, "Lịch hẹn cần ghi nhận (chọn trong danh sách)") || !UiHelper.BatBuoc(txtSoPhieuKhamDK, "Số phiếu khám")
                || !UiHelper.BatBuocChon(cboBacSiDK, "Bác sĩ khám") || !UiHelper.BatBuocChon(cboKhoaDK, "Khoa") || !UiHelper.BatBuocChon(cboNVDK, "Nhân viên ghi nhận")) return;
            if (chkPhatHien.Checked && !UiHelper.BatBuoc(txtGhiChuDK, "Mô tả mầm bệnh phát hiện")) return;
            try
            {
                KetQuaXuLy k = dk.GhiDotKham(txtLichHenChon.Text.Trim(), txtSoPhieuKhamDK.Text.Trim(), UiHelper.Gia(cboBacSiDK), UiHelper.Gia(cboKhoaDK),
                    UiHelper.Gia(cboNVDK), chkPhatHien.Checked, txtGhiChuDK.Text.Trim());
                if (UiHelper.HienKetQua(k))
                {
                    txtSoPhieuKhamDK.Clear();
                    txtGhiChuDK.Clear();
                    chkPhatHien.Checked = false;
                    TaiLich();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void dgvLichHen_SelectionChanged(object sender, EventArgs e)
        {
            txtLichHenChon.Text = UiHelper.Cell(dgvLichHen, "MaLichHen");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
