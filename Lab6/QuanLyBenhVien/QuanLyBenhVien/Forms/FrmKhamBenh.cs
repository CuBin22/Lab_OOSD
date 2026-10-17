using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmKhamBenh : Form
    {
        readonly DanhMucService dm = new DanhMucService();
        readonly HoSoService hs = new HoSoService();
        readonly KhamBenhService kb = new KhamBenhService();
        readonly XetNghiemService xn = new XetNghiemService();
        readonly BindingList<XetNghiemItem> dsXN = new BindingList<XetNghiemItem>();
        readonly BindingList<ThuocItem> dsToa = new BindingList<ThuocItem>();
        private string maHoSoDangChon = "";

        private void TaiXetNghiemChoKQ()
        {
            dgvXNChoKQ.DataSource = xn.LayChoKetQua();
        }

        private void LamMoiPhieu()
        {
            UiHelper.XoaTrang(txtSoPhieuKham, txtTrieuChung, txtHuyetAp, txtKetLuan, txtMaToa, txtLieuDung, txtCachDung);
            numThanNhiet.Value = 37;
            numSoLuong.Value = 1;
            dtNgayGioKham.Value = DateTime.Now;
            dsXN.Clear();
            dsToa.Clear();
            txtSoPhieuKham.Focus();
        }

        public FrmKhamBenh()
        {
            InitializeComponent();
        }

        private void FrmKhamBenh_Load(object sender, System.EventArgs e)
        {
            dgvXNChon.DataSource = dsXN;
            dgvToaChon.DataSource = dsToa;
            dtNgayGioKham.Value = DateTime.Now;
            dtNgayCoKetQua.Value = DateTime.Today;
            cboLoaiKham.SelectedIndex = 0;
            try
            {
                UiHelper.NapCombo(cboKhoa, dm.LayKhoa(), "TenKhoa", "MaKhoa");
                UiHelper.NapCombo(cboBacSi, dm.LayBacSi(), "HoTen", "MaBS");
                UiHelper.NapCombo(cboNVGhiNhan, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.NapCombo(cboNVXetNghiem, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.NapCombo(cboLoaiXN, dm.LayLoaiXetNghiem(), "TenLoaiXN", "MaLoaiXN");
                UiHelper.NapCombo(cboThuoc, dm.LayThuoc(), "TenThuoc", "MaThuoc");
                UiHelper.ChonNguoiDung(cboNVGhiNhan);
                UiHelper.ChonNguoiDung(cboNVXetNghiem);
                if (PhienLamViec.VaiTro == PhienLamViec.BacSi) cboBacSi.SelectedValue = PhienLamViec.MaNguoi;
                TaiXetNghiemChoKQ();
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
            // Nhân viên xét nghiệm chỉ làm việc ở tab kết quả
            if (PhienLamViec.VaiTro == PhienLamViec.XetNghiem) tabKham.TabPages.Remove(tabPhieuKham);
        }

        private void btnTimHoSo_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtMaHoSo, "Mã hồ sơ")) return;
            try
            {
                KetQuaXuLy k = hs.KiemTraHoSo(txtMaHoSo.Text.Trim(), dtNgayGioKham.Value);
                if (!k.ThanhCong)
                {
                    maHoSoDangChon = "";
                    lblThongTinBN.Text = "Chưa chọn hồ sơ.";
                    dgvLichSu.DataSource = null;
                    UiHelper.Canh(k.ThongBao);
                    return;
                }
                maHoSoDangChon = txtMaHoSo.Text.Trim();
                lblThongTinBN.Text = k.ThongBao;
                dgvLichSu.DataSource = kb.LayLichSu(maHoSoDangChon);
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void cboBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView r = cboBacSi.SelectedItem as DataRowView;
            if (r != null && cboKhoa.DataSource != null && r.Row.Table.Columns.Contains("MaKhoa"))
                cboKhoa.SelectedValue = r["MaKhoa"];
        }

        private void cboLoaiKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool dinhKy = cboLoaiKham.Text == "Khám định kỳ";
            lblTrieuChung.Text = dinhKy ? "Triệu chứng (có thể để trống):" : "Triệu chứng:";
        }

        private void btnThemXN_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuocChon(cboLoaiXN, "Loại xét nghiệm")) return;
            string ma = UiHelper.Gia(cboLoaiXN);
            foreach (var x in dsXN) if (x.MaLoaiXN == ma) { UiHelper.Canh("Loại xét nghiệm này đã có trong danh sách chỉ định."); return; }
            dsXN.Add(new XetNghiemItem { MaLoaiXN = ma, TenLoaiXN = cboLoaiXN.Text });
        }

        private void btnBoXN_Click(object sender, EventArgs e)
        {
            if (dgvXNChon.CurrentRow != null && dgvXNChon.CurrentRow.Index >= 0 && dgvXNChon.CurrentRow.Index < dsXN.Count)
                dsXN.RemoveAt(dgvXNChon.CurrentRow.Index);
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuocChon(cboThuoc, "Thuốc") || !UiHelper.BatBuoc(txtLieuDung, "Liều dùng") || !UiHelper.BatBuoc(txtCachDung, "Cách dùng")) return;
            if (numSoLuong.Value <= 0) { UiHelper.Canh("Số lượng thuốc phải lớn hơn 0."); numSoLuong.Focus(); return; }
            string ma = UiHelper.Gia(cboThuoc);
            foreach (var x in dsToa) if (x.MaThuoc == ma) { UiHelper.Canh("Mỗi thuốc chỉ xuất hiện một lần trong toa."); return; }
            dsToa.Add(new ThuocItem { MaThuoc = ma, TenThuoc = cboThuoc.Text, SoLuong = (int)numSoLuong.Value, LieuDung = txtLieuDung.Text.Trim(), CachDung = txtCachDung.Text.Trim() });
        }

        private void btnBoThuoc_Click(object sender, EventArgs e)
        {
            if (dgvToaChon.CurrentRow != null && dgvToaChon.CurrentRow.Index >= 0 && dgvToaChon.CurrentRow.Index < dsToa.Count)
                dsToa.RemoveAt(dgvToaChon.CurrentRow.Index);
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (maHoSoDangChon == "" || txtMaHoSo.Text.Trim() != maHoSoDangChon)
            {
                UiHelper.Canh("Hãy tra cứu hồ sơ bệnh án của bệnh nhân (nút Tìm hồ sơ) trước khi lập phiếu khám.");
                txtMaHoSo.Focus();
                return;
            }
            if (!UiHelper.BatBuoc(txtSoPhieuKham, "Số phiếu khám") || !UiHelper.BatBuocChon(cboBacSi, "Bác sĩ khám")
                || !UiHelper.BatBuocChon(cboKhoa, "Khoa điều trị") || !UiHelper.BatBuocChon(cboLoaiKham, "Loại khám")
                || !UiHelper.BatBuocChon(cboNVGhiNhan, "Nhân viên ghi nhận")) return;
            if (cboLoaiKham.Text == "Khám bệnh" && !UiHelper.BatBuoc(txtTrieuChung, "Triệu chứng")) return;
            if (dsToa.Count > 0 && !UiHelper.BatBuoc(txtMaToa, "Mã toa thuốc")) return;
            try
            {
                KetQuaXuLy k = kb.LuuPhieuKham(txtSoPhieuKham.Text.Trim(), maHoSoDangChon, UiHelper.Gia(cboBacSi), UiHelper.Gia(cboKhoa),
                    UiHelper.Gia(cboNVGhiNhan), dtNgayGioKham.Value, cboLoaiKham.Text, txtTrieuChung.Text.Trim(), numThanNhiet.Value,
                    txtHuyetAp.Text.Trim(), txtKetLuan.Text.Trim(), txtMaToa.Text.Trim(),
                    new List<ThuocItem>(dsToa), new List<XetNghiemItem>(dsXN));
                if (UiHelper.HienKetQua(k))
                {
                    dgvLichSu.DataSource = kb.LayLichSu(maHoSoDangChon);
                    LamMoiPhieu();
                    TaiXetNghiemChoKQ();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnLamMoiPhieu_Click(object sender, EventArgs e)
        {
            LamMoiPhieu();
        }

        private void dgvXNChoKQ_SelectionChanged(object sender, EventArgs e)
        {
            txtMaXNChon.Text = UiHelper.Cell(dgvXNChoKQ, "MaXN");
            txtKetQua.Text = UiHelper.Cell(dgvXNChoKQ, "KetQua");
        }

        private void btnGhiKetQua_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtMaXNChon, "Xét nghiệm cần ghi kết quả") || !UiHelper.BatBuoc(txtKetQua, "Kết quả")
                || !UiHelper.BatBuocChon(cboNVXetNghiem, "Nhân viên xét nghiệm")) return;
            try
            {
                KetQuaXuLy k = xn.GhiKetQua(txtMaXNChon.Text.Trim(), txtKetQua.Text.Trim(), dtNgayCoKetQua.Value, UiHelper.Gia(cboNVXetNghiem));
                if (UiHelper.HienKetQua(k))
                {
                    TaiXetNghiemChoKQ();
                    txtMaXNChon.Clear();
                    txtKetQua.Clear();
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
