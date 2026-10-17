using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmDangKyHoSo : Form
    {
        readonly DanhMucService dm = new DanhMucService();
        readonly HoSoService hs = new HoSoService();

        private void TaiDanhSach()
        {
            try
            {
                string tt = cboLocTrangThai.SelectedIndex <= 0 ? null : cboLocTrangThai.Text;
                dgvHoSo.DataSource = hs.LayDanhSach(tt);
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private byte[] AnhBytes()
        {
            if (picAnh.Image == null) return null;
            using (var ms = new System.IO.MemoryStream())
            {
                picAnh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public FrmDangKyHoSo()
        {
            InitializeComponent();
        }

        private void FrmDangKyHoSo_Load(object sender, System.EventArgs e)
        {
            dtNgaySinh.MaxDate = DateTime.Today.AddDays(-1);
            dtNgayDangKy.Value = DateTime.Today;
            numNamApDung.Value = DateTime.Today.Year;
            numNamGH.Value = DateTime.Today.Year;
            cboLocTrangThai.SelectedIndex = 0;
            try
            {
                UiHelper.NapCombo(cboNVTiepNhan, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.NapCombo(cboNVThuLP, dm.LayNhanVien(), "HoTen", "MaNV");
                UiHelper.ChonNguoiDung(cboNVTiepNhan);
                UiHelper.ChonNguoiDung(cboNVThuLP);
                TaiDanhSach();
                dgvHoSoMoi.DataSource = hs.LayHoSoMoi(10);
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh 3x4";
                dlg.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                if (picAnh.Image != null) { picAnh.Image.Dispose(); picAnh.Image = null; }
                using (var img = Image.FromFile(dlg.FileName)) picAnh.Image = new Bitmap(img);
            }
        }

        private void btnCapHoSo_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtMaBN, "Mã bệnh nhân") || !UiHelper.BatBuoc(txtHoTen, "Họ tên")
                || !UiHelper.BatBuoc(txtDienThoai, "Điện thoại") || !UiHelper.BatBuoc(txtDiaChi, "Địa chỉ")
                || !UiHelper.BatBuoc(txtSoPhieuDK, "Số phiếu đăng ký") || !UiHelper.BatBuocChon(cboNVTiepNhan, "Nhân viên tiếp nhận")
                || !UiHelper.BatBuoc(txtMaLePhi, "Mã lệ phí") || !UiHelper.BatBuoc(txtMaHoSo, "Mã hồ sơ")) return;
            if (dtNgaySinh.Value.Date >= DateTime.Today) { UiHelper.Canh("Ngày sinh phải nhỏ hơn ngày hiện tại."); dtNgaySinh.Focus(); return; }
            if (picAnh.Image == null) { UiHelper.Canh("Phiếu đăng ký cần có ảnh 3x4."); btnChonAnh.Focus(); return; }
            if (numSoTien.Value <= 0) { UiHelper.Canh("Lệ phí phải lớn hơn 0 (chỉ cấp hồ sơ khi đã đóng lệ phí)."); numSoTien.Focus(); return; }
            try
            {
                KetQuaXuLy k = hs.DangKyVaCapHoSo(txtMaBN.Text.Trim(), txtHoTen.Text.Trim(), dtNgaySinh.Value.Date, txtDiaChi.Text.Trim(),
                    txtDienThoai.Text.Trim(), AnhBytes(), txtSoPhieuDK.Text.Trim(), dtNgayDangKy.Value.Date, UiHelper.Gia(cboNVTiepNhan),
                    txtMaLePhi.Text.Trim(), (int)numNamApDung.Value, numSoTien.Value, txtMaHoSo.Text.Trim());
                if (UiHelper.HienKetQua(k))
                {
                    dgvHoSoMoi.DataSource = hs.LayHoSoMoi(10);
                    TaiDanhSach();
                    btnLamMoiDK_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnLamMoiDK_Click(object sender, EventArgs e)
        {
            UiHelper.XoaTrang(txtMaBN, txtHoTen, txtDienThoai, txtDiaChi, txtSoPhieuDK, txtMaLePhi, txtMaHoSo);
            numSoTien.Value = 0;
            dtNgaySinh.Value = dtNgaySinh.MaxDate;
            dtNgayDangKy.Value = DateTime.Today;
            if (picAnh.Image != null) { picAnh.Image.Dispose(); picAnh.Image = null; }
            UiHelper.ChonNguoiDung(cboNVTiepNhan);
            txtMaBN.Focus();
        }

        private void btnTimHoSoLP_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtMaHoSoLP, "Mã hồ sơ")) return;
            try
            {
                DataTable dt = hs.TimTheoMa(txtMaHoSoLP.Text.Trim());
                if (dt.Rows.Count == 0)
                {
                    lblThongTinLP.Text = "Không tìm thấy hồ sơ.";
                    dgvLePhi.DataSource = null;
                    UiHelper.Canh("Không tìm thấy hồ sơ " + txtMaHoSoLP.Text.Trim() + ".");
                    return;
                }
                DataRow r = dt.Rows[0];
                lblThongTinLP.Text = Convert.ToString(r["HoTen"]) + " - sinh " + Convert.ToString(r["NgaySinh"]) + " - trạng thái: " + Convert.ToString(r["TrangThai"]);
                dgvLePhi.DataSource = hs.LayLePhi(txtMaHoSoLP.Text.Trim());
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnThuLePhi_Click(object sender, EventArgs e)
        {
            if (!UiHelper.BatBuoc(txtMaHoSoLP, "Mã hồ sơ") || !UiHelper.BatBuoc(txtMaLePhiGH, "Mã lệ phí") || !UiHelper.BatBuocChon(cboNVThuLP, "Nhân viên thu")) return;
            if (numSoTienGH.Value <= 0) { UiHelper.Canh("Lệ phí phải lớn hơn 0."); numSoTienGH.Focus(); return; }
            try
            {
                KetQuaXuLy k = hs.ThuLePhi(txtMaLePhiGH.Text.Trim(), txtMaHoSoLP.Text.Trim(), (int)numNamGH.Value, numSoTienGH.Value, UiHelper.Gia(cboNVThuLP));
                if (UiHelper.HienKetQua(k))
                {
                    txtMaLePhiGH.Clear();
                    numSoTienGH.Value = 0;
                    btnTimHoSoLP_Click(sender, e);
                    TaiDanhSach();
                }
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDanhSach();
        }

        private void btnTaiDS_Click(object sender, EventArgs e)
        {
            TaiDanhSach();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
