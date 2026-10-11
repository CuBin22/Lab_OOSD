using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Phân công hướng dẫn viên, quản lý nhân viên và tính lương tháng.</summary>
    public partial class FrmPhanCong : Form
    {
        private bool _dangNap = false;

        public FrmPhanCong()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvPhanCong);
            Ui.DinhDangLuoi(dgvNhanVien);
            Ui.DinhDangLuoi(dgvLuong);
        }

        private void FrmPhanCong_Load(object sender, EventArgs e)
        {
            try
            {
                NapNhanVien();
                NapDoiTuong();
                NapNhanVienGrid();
                LamMoiNV();
                numThang.Value = DateTime.Today.Month;
                Ui.GanSo(numNam, DateTime.Today.Year);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, "Không tải được dữ liệu: " + Hlp.LoiSql(ex), false);
            }
        }

        // ============================== TAB PHÂN CÔNG ==============================
        private void NapNhanVien()
        {
            _dangNap = true;
            Ui.NapCombo(cboNhanVien, DanhMucService.LayNhanVien(), "HienThi", "MaNV");
            _dangNap = false;
            NapLich();
        }

        private void NapDoiTuong()
        {
            DataTable dt = rdoChuyen.Checked ? PhanCongService.LayChuyen() : PhanCongService.LayDoan();
            _dangNap = true;
            Ui.NapCombo(cboDoiTuong, dt, "HienThi", "Ma");
            _dangNap = false;
            DatNgayTheoDoiTuong();
        }

        private void DatNgayTheoDoiTuong()
        {
            DataRowView drv = cboDoiTuong.SelectedItem as DataRowView;
            if (drv == null) return;
            dtpTuNgay.Value = Convert.ToDateTime(drv["NgayDi"]);
            dtpDenNgay.Value = Convert.ToDateTime(drv["NgayVe"]);
        }

        private void NapLich()
        {
            string maNV = Ui.GiaTri(cboNhanVien);
            if (maNV.Length == 0) { dgvPhanCong.DataSource = null; return; }
            dgvPhanCong.DataSource = PhanCongService.LayLich(maNV);
            Ui.TieuDe(dgvPhanCong, "MaPC", "Mã phân công", "DoiTuong", "Chuyến / Đoàn", "NgayBatDau", "Từ ngày",
                "NgayKetThuc", "Đến ngày", "TienCongTour", "Tiền công tour");
            Ui.CotNgay(dgvPhanCong, "NgayBatDau", "NgayKetThuc");
            Ui.CotTien(dgvPhanCong, "TienCongTour");
        }

        private void rdoChuyen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                NapDoiTuong();
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void cboDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            DatNgayTheoDoiTuong();
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            try
            {
                NapLich();
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void txtTienCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ui.ChiNhapSo(e);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            decimal tienCong = 0;
            if (txtTienCong.Text.Trim().Length > 0 && !Ui.DocTien(txtTienCong.Text, out tienCong))
            {
                Ui.ThongBao(lblThongBao, "Tiền công không hợp lệ.", false);
                return;
            }
            try
            {
                if (rdoChuyen.Checked)
                    PhanCongService.PhanCongChuyen(Ui.GiaTri(cboNhanVien), Ui.GiaTri(cboDoiTuong), dtpTuNgay.Value, dtpDenNgay.Value, tienCong);
                else
                    PhanCongService.PhanCongDoan(Ui.GiaTri(cboNhanVien), Ui.GiaTri(cboDoiTuong), dtpTuNgay.Value, dtpDenNgay.Value, tienCong);
                NapLich();
                Ui.ThongBao(lblThongBao, "Đã phân công hướng dẫn viên.", true);
            }
            catch (InvalidOperationException ex)
            {
                Ui.ThongBao(lblThongBao, ex.Message, false);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoaPhanCong_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.CurrentRow == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn dòng phân công cần xóa.", false);
                return;
            }
            if (!Ui.Hoi("Xóa phân công đã chọn?")) return;
            try
            {
                Db.Execute("DELETE FROM PhanCong WHERE MaPC = @ma", Hlp.P("@ma", dgvPhanCong.CurrentRow.Cells["MaPC"].Value));
                NapLich();
                Ui.ThongBao(lblThongBao, "Đã xóa phân công.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        // ============================== TAB NHÂN VIÊN ==============================
        private void NapNhanVienGrid()
        {
            dgvNhanVien.DataSource = Db.Query("SELECT MaNV, HoTen, DiaChi, DienThoai, LuongCanBan FROM NhanVien ORDER BY MaNV");
            Ui.TieuDe(dgvNhanVien, "MaNV", "Mã NV", "HoTen", "Họ tên", "DiaChi", "Địa chỉ", "DienThoai", "Điện thoại", "LuongCanBan", "Lương căn bản");
            Ui.CotTien(dgvNhanVien, "LuongCanBan");
        }

        private void LamMoiNV()
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Text = Hlp.MaTiepTheo("NhanVien", "MaNV", "NV", 3);
            txtHoTenNV.Clear();
            txtDiaChiNV.Clear();
            txtDienThoaiNV.Clear();
            txtLuongCanBan.Clear();
            txtHoTenNV.Focus();
        }

        private bool DocFormNV(out decimal luong)
        {
            luong = 0;
            if (txtMaNV.Text.Trim().Length == 0 || txtHoTenNV.Text.Trim().Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Vui lòng nhập mã và họ tên nhân viên.", false);
                return false;
            }
            if (txtLuongCanBan.Text.Trim().Length > 0 && !Ui.DocTien(txtLuongCanBan.Text, out luong))
            {
                Ui.ThongBao(lblThongBao, "Lương căn bản không hợp lệ.", false);
                return false;
            }
            return true;
        }

        private void txtLuongCanBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ui.ChiNhapSo(e);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Đang chọn một nhân viên để sửa. Bấm \"Làm mới\" để nhập nhân viên mới.", false);
                return;
            }
            decimal luong;
            if (!DocFormNV(out luong)) return;
            try
            {
                Db.Execute("INSERT INTO NhanVien (MaNV, HoTen, DiaChi, DienThoai, LuongCanBan) VALUES (@ma, @ten, @dc, @dt, @luong)",
                    Hlp.P("@ma", txtMaNV.Text.Trim()), Hlp.P("@ten", txtHoTenNV.Text.Trim()), Hlp.P("@dc", txtDiaChiNV.Text.Trim()),
                    Hlp.P("@dt", txtDienThoaiNV.Text.Trim()), Hlp.P("@luong", luong));
                NapNhanVienGrid();
                NapNhanVien();
                LamMoiNV();
                Ui.ThongBao(lblThongBao, "Đã thêm nhân viên.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (!txtMaNV.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn nhân viên cần sửa trong danh sách.", false);
                return;
            }
            decimal luong;
            if (!DocFormNV(out luong)) return;
            try
            {
                Db.Execute("UPDATE NhanVien SET HoTen = @ten, DiaChi = @dc, DienThoai = @dt, LuongCanBan = @luong WHERE MaNV = @ma",
                    Hlp.P("@ma", txtMaNV.Text.Trim()), Hlp.P("@ten", txtHoTenNV.Text.Trim()), Hlp.P("@dc", txtDiaChiNV.Text.Trim()),
                    Hlp.P("@dt", txtDienThoaiNV.Text.Trim()), Hlp.P("@luong", luong));
                NapNhanVienGrid();
                NapNhanVien();
                Ui.ThongBao(lblThongBao, "Đã cập nhật nhân viên.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (!txtMaNV.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn nhân viên cần xóa trong danh sách.", false);
                return;
            }
            if (!Ui.Hoi("Xóa nhân viên \"" + txtHoTenNV.Text.Trim() + "\"?")) return;
            try
            {
                Db.Execute("DELETE FROM NhanVien WHERE MaNV = @ma", Hlp.P("@ma", txtMaNV.Text.Trim()));
                NapNhanVienGrid();
                NapNhanVien();
                LamMoiNV();
                Ui.ThongBao(lblThongBao, "Đã xóa nhân viên.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            LamMoiNV();
            lblThongBao.Text = "";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = Convert.ToString(r.Cells["MaNV"].Value);
            txtMaNV.ReadOnly = true;
            txtHoTenNV.Text = Convert.ToString(r.Cells["HoTen"].Value);
            txtDiaChiNV.Text = Convert.ToString(r.Cells["DiaChi"].Value);
            txtDienThoaiNV.Text = Convert.ToString(r.Cells["DienThoai"].Value);
            txtLuongCanBan.Text = Convert.ToDecimal(r.Cells["LuongCanBan"].Value).ToString("0");
        }

        // ============================== TAB LƯƠNG ==============================
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = PhanCongService.TinhLuong((int)numThang.Value, (int)numNam.Value);
                dgvLuong.DataSource = dt;
                Ui.TieuDe(dgvLuong, "MaNV", "Mã NV", "HoTen", "Họ tên", "LuongCanBan", "Lương căn bản", "SoTour", "Số tour trong tháng",
                    "LuongTheoTour", "Lương theo tour", "TongLuong", "Tổng lương");
                Ui.CotTien(dgvLuong, "LuongCanBan", "LuongTheoTour", "TongLuong");
                object tong = dt.Compute("SUM(TongLuong)", "");
                decimal t = (tong == null || tong == DBNull.Value) ? 0 : Convert.ToDecimal(tong);
                txtTongLuong.Text = Ui.Tien(t);
                Ui.ThongBao(lblThongBao, "Đã tính lương tháng " + numThang.Value + "/" + numNam.Value + " (" + dt.Rows.Count + " nhân viên).", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
