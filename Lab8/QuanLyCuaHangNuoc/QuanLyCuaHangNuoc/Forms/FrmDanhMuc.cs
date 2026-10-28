using System;
using System.Windows.Forms;
using QuanLyCuaHangNuoc.Services;

namespace QuanLyCuaHangNuoc.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService sv = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            foreach (DataGridView g in new[] { dgvLoai, dgvNCC, dgvNGK, dgvNV, dgvKH }) Ui.StyleGrid(g);
            cboKHLoai.Items.AddRange(new object[] { "Khách quen", "Khách vãng lai" });
            cboKHLoai.SelectedIndex = 0;
            TaiLoai(); TaiNCC(); TaiNGK(); TaiNV(); TaiKH();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }

        // ======================= Nhãn hiệu =======================
        void TaiLoai()
        {
            Ui.Bind(dgvLoai, sv.LayLoai(txtLoaiTim.Text), "MaLoai|Mã loại", "TenLoai|Tên loại / nhãn hiệu");
            NapComboNGK();
        }
        void MoiLoai() { txtLoaiMa.Clear(); txtLoaiTen.Clear(); txtLoaiMa.ReadOnly = false; txtLoaiMa.Focus(); }
        void XuLyLoai(KetQuaXuLy k) { Ui.Show(k); if (k.ThanhCong) { MoiLoai(); TaiLoai(); } }
        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvLoai.Rows[e.RowIndex];
            txtLoaiMa.Text = Ui.Cell(r, "MaLoai"); txtLoaiTen.Text = Ui.Cell(r, "TenLoai");
            txtLoaiMa.ReadOnly = true;   // khóa mã khi sửa
        }
        private void btnLoaiThem_Click(object sender, EventArgs e) { XuLyLoai(sv.ThemLoai(txtLoaiMa.Text, txtLoaiTen.Text)); }
        private void btnLoaiSua_Click(object sender, EventArgs e) { XuLyLoai(sv.SuaLoai(txtLoaiMa.Text, txtLoaiTen.Text)); }
        private void btnLoaiXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoaiMa.Text)) { Ui.Chon("Hãy chọn nhãn hiệu cần xóa."); return; }
            if (Ui.XacNhan("Xóa nhãn hiệu " + txtLoaiMa.Text + "?")) XuLyLoai(sv.XoaLoai(txtLoaiMa.Text));
        }
        private void btnLoaiMoi_Click(object sender, EventArgs e) { txtLoaiTim.Clear(); MoiLoai(); TaiLoai(); }
        private void btnLoaiTim_Click(object sender, EventArgs e) { TaiLoai(); }

        // ======================= Nhà cung ứng =======================
        void TaiNCC()
        {
            Ui.Bind(dgvNCC, sv.LayNCC(txtNCCTim.Text), "MaNCC|Mã NCC", "TenNCC|Tên nhà cung ứng", "DiaChi|Địa chỉ", "DienThoai|Điện thoại");
            NapComboNGK();
        }
        void MoiNCC() { txtNCCMa.Clear(); txtNCCTen.Clear(); txtNCCDT.Clear(); txtNCCDiaChi.Clear(); txtNCCMa.ReadOnly = false; txtNCCMa.Focus(); }
        void XuLyNCC(KetQuaXuLy k) { Ui.Show(k); if (k.ThanhCong) { MoiNCC(); TaiNCC(); } }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvNCC.Rows[e.RowIndex];
            txtNCCMa.Text = Ui.Cell(r, "MaNCC"); txtNCCTen.Text = Ui.Cell(r, "TenNCC");
            txtNCCDiaChi.Text = Ui.Cell(r, "DiaChi"); txtNCCDT.Text = Ui.Cell(r, "DienThoai");
            txtNCCMa.ReadOnly = true;
        }
        private void btnNCCThem_Click(object sender, EventArgs e) { XuLyNCC(sv.ThemNCC(txtNCCMa.Text, txtNCCTen.Text, txtNCCDiaChi.Text, txtNCCDT.Text)); }
        private void btnNCCSua_Click(object sender, EventArgs e) { XuLyNCC(sv.SuaNCC(txtNCCMa.Text, txtNCCTen.Text, txtNCCDiaChi.Text, txtNCCDT.Text)); }
        private void btnNCCXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNCCMa.Text)) { Ui.Chon("Hãy chọn nhà cung ứng cần xóa."); return; }
            if (Ui.XacNhan("Xóa nhà cung ứng " + txtNCCMa.Text + "?")) XuLyNCC(sv.XoaNCC(txtNCCMa.Text));
        }
        private void btnNCCMoi_Click(object sender, EventArgs e) { txtNCCTim.Clear(); MoiNCC(); TaiNCC(); }
        private void btnNCCTim_Click(object sender, EventArgs e) { TaiNCC(); }

        // ======================= Nước giải khát =======================
        void NapComboNGK()
        {
            if (cboNGKLoai == null || cboNGKNCC == null) return;
            string loai = Ui.V(cboNGKLoai), ncc = Ui.V(cboNGKNCC);
            Ui.BindCombo(cboNGKLoai, sv.LayLoai(), "TenLoai", "MaLoai");
            Ui.BindCombo(cboNGKNCC, sv.LayNCC(), "TenNCC", "MaNCC");
            if (loai != "") cboNGKLoai.SelectedValue = loai;
            if (ncc != "") cboNGKNCC.SelectedValue = ncc;
        }
        void TaiNGK()
        {
            Ui.Bind(dgvNGK, sv.LayNGK(txtNGKTim.Text), "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT",
                "MaLoai|-", "TenLoai|Nhãn hiệu", "MaNCC|-", "TenNCC|Nhà cung ứng", "DonGia|Đơn giá|N0", "SoLuongTon|Tồn kho|N0");
        }
        void MoiNGK() { txtNGKMa.Clear(); txtNGKTen.Clear(); txtNGKDVT.Clear(); numNGKGia.Value = 0; txtNGKMa.ReadOnly = false; txtNGKMa.Focus(); }
        void XuLyNGK(KetQuaXuLy k) { Ui.Show(k); if (k.ThanhCong) { MoiNGK(); TaiNGK(); } }
        private void dgvNGK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvNGK.Rows[e.RowIndex];
            txtNGKMa.Text = Ui.Cell(r, "MaNGK"); txtNGKTen.Text = Ui.Cell(r, "TenNGK"); txtNGKDVT.Text = Ui.Cell(r, "DonViTinh");
            cboNGKLoai.SelectedValue = Ui.Cell(r, "MaLoai"); cboNGKNCC.SelectedValue = Ui.Cell(r, "MaNCC");
            numNGKGia.Value = Convert.ToDecimal(r.Cells["DonGia"].Value);
            txtNGKMa.ReadOnly = true;
        }
        private void btnNGKThem_Click(object sender, EventArgs e) { XuLyNGK(sv.ThemNGK(txtNGKMa.Text, txtNGKTen.Text, txtNGKDVT.Text, Ui.V(cboNGKLoai), Ui.V(cboNGKNCC), numNGKGia.Value)); }
        private void btnNGKSua_Click(object sender, EventArgs e) { XuLyNGK(sv.SuaNGK(txtNGKMa.Text, txtNGKTen.Text, txtNGKDVT.Text, Ui.V(cboNGKLoai), Ui.V(cboNGKNCC), numNGKGia.Value)); }
        private void btnNGKXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNGKMa.Text)) { Ui.Chon("Hãy chọn mặt hàng cần xóa."); return; }
            if (Ui.XacNhan("Xóa mặt hàng " + txtNGKMa.Text + "?")) XuLyNGK(sv.XoaNGK(txtNGKMa.Text));
        }
        private void btnNGKMoi_Click(object sender, EventArgs e) { txtNGKTim.Clear(); MoiNGK(); TaiNGK(); }
        private void btnNGKTim_Click(object sender, EventArgs e) { TaiNGK(); }

        // ======================= Nhân viên =======================
        void TaiNV()
        {
            Ui.Bind(dgvNV, sv.LayNV(txtNVTim.Text), "MaNV|Mã NV", "HoTen|Họ tên", "ChucVu|Chức vụ", "DiaChi|Địa chỉ", "DienThoai|Điện thoại");
        }
        void MoiNV() { txtNVMa.Clear(); txtNVTen.Clear(); txtNVChucVu.Clear(); txtNVDiaChi.Clear(); txtNVDT.Clear(); txtNVMa.ReadOnly = false; txtNVMa.Focus(); }
        void XuLyNV(KetQuaXuLy k) { Ui.Show(k); if (k.ThanhCong) { MoiNV(); TaiNV(); } }
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvNV.Rows[e.RowIndex];
            txtNVMa.Text = Ui.Cell(r, "MaNV"); txtNVTen.Text = Ui.Cell(r, "HoTen"); txtNVChucVu.Text = Ui.Cell(r, "ChucVu");
            txtNVDiaChi.Text = Ui.Cell(r, "DiaChi"); txtNVDT.Text = Ui.Cell(r, "DienThoai");
            txtNVMa.ReadOnly = true;
        }
        private void btnNVThem_Click(object sender, EventArgs e) { XuLyNV(sv.ThemNV(txtNVMa.Text, txtNVTen.Text, txtNVChucVu.Text, txtNVDiaChi.Text, txtNVDT.Text)); }
        private void btnNVSua_Click(object sender, EventArgs e) { XuLyNV(sv.SuaNV(txtNVMa.Text, txtNVTen.Text, txtNVChucVu.Text, txtNVDiaChi.Text, txtNVDT.Text)); }
        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text)) { Ui.Chon("Hãy chọn nhân viên cần xóa."); return; }
            if (Ui.XacNhan("Xóa nhân viên " + txtNVMa.Text + "?")) XuLyNV(sv.XoaNV(txtNVMa.Text));
        }
        private void btnNVMoi_Click(object sender, EventArgs e) { txtNVTim.Clear(); MoiNV(); TaiNV(); }
        private void btnNVTim_Click(object sender, EventArgs e) { TaiNV(); }

        // ======================= Khách hàng =======================
        void TaiKH()
        {
            Ui.Bind(dgvKH, sv.LayKH(txtKHTim.Text), "MaKH|Mã KH", "HoTen|Họ tên", "DiaChi|Địa chỉ", "DienThoai|Điện thoại", "LoaiKhach|Loại khách");
        }
        void MoiKH() { txtKHMa.Clear(); txtKHTen.Clear(); txtKHDiaChi.Clear(); txtKHDT.Clear(); cboKHLoai.SelectedIndex = 0; txtKHMa.ReadOnly = false; txtKHMa.Focus(); }
        void XuLyKH(KetQuaXuLy k) { Ui.Show(k); if (k.ThanhCong) { MoiKH(); TaiKH(); } }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvKH.Rows[e.RowIndex];
            txtKHMa.Text = Ui.Cell(r, "MaKH"); txtKHTen.Text = Ui.Cell(r, "HoTen");
            txtKHDiaChi.Text = Ui.Cell(r, "DiaChi"); txtKHDT.Text = Ui.Cell(r, "DienThoai");
            cboKHLoai.SelectedItem = Ui.Cell(r, "LoaiKhach");
            txtKHMa.ReadOnly = true;
        }
        private void btnKHThem_Click(object sender, EventArgs e) { XuLyKH(sv.ThemKH(txtKHMa.Text, txtKHTen.Text, txtKHDiaChi.Text, txtKHDT.Text, cboKHLoai.Text)); }
        private void btnKHSua_Click(object sender, EventArgs e) { XuLyKH(sv.SuaKH(txtKHMa.Text, txtKHTen.Text, txtKHDiaChi.Text, txtKHDT.Text, cboKHLoai.Text)); }
        private void btnKHXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKHMa.Text)) { Ui.Chon("Hãy chọn khách hàng cần xóa."); return; }
            if (Ui.XacNhan("Xóa khách hàng " + txtKHMa.Text + "?")) XuLyKH(sv.XoaKH(txtKHMa.Text));
        }
        private void btnKHMoi_Click(object sender, EventArgs e) { txtKHTim.Clear(); MoiKH(); TaiKH(); }
        private void btnKHTim_Click(object sender, EventArgs e) { TaiKH(); }
    }
}
