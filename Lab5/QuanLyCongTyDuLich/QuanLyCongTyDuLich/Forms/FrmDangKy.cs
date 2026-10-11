using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>
    /// Đăng ký tour: tab "Đăng ký đoàn" (nghiệp vụ trọng yếu: lập phiếu đăng ký đoàn)
    /// và tab "Đăng ký chuyến" (khách lẻ, bán vé).
    /// </summary>
    public partial class FrmDangKy : Form
    {
        private DataTable _dtThanhVien;
        private bool _dangNap = false;

        public FrmDangKy()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvThanhVien);
            Ui.DinhDangLuoi(dgvPhieuDoan);
            Ui.DinhDangLuoi(dgvPhieuChuyen);

            Button btnNguoiDi = new Button();
            btnNguoiDi.Text = "Xem người đi";
            btnNguoiDi.Name = "btnXemNguoiDi";
            btnNguoiDi.Size = btnLamMoiDoan.Size;
            btnNguoiDi.Location = new Point(btnLamMoiDoan.Left, btnLamMoiDoan.Bottom + 8);
            btnNguoiDi.UseVisualStyleBackColor = true;
            btnNguoiDi.Click += btnXemNguoiDi_Click;
            btnLamMoiDoan.Parent.Controls.Add(btnNguoiDi);

            _dtThanhVien = new DataTable();
            _dtThanhVien.Columns.Add("HoTen", typeof(string));
            _dtThanhVien.Columns.Add("NgaySinh", typeof(DateTime));
            _dtThanhVien.Columns.Add("SoCMND", typeof(string));
            dgvThanhVien.DataSource = _dtThanhVien;
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            Ui.TieuDe(dgvThanhVien, "HoTen", "Họ tên", "NgaySinh", "Ngày sinh", "SoCMND", "Số CMND");
            Ui.CotNgay(dgvThanhVien, "NgaySinh");
            try
            {
                _dangNap = true;
                Ui.NapCombo(cboKhachDoan, DanhMucService.LayKhachHang("Đoàn"), "HienThi", "MaKH");
                Ui.NapCombo(cboTourDoan, DanhMucService.LayTour(), "HienThi", "MaTour");
                Ui.NapCombo(cboKhachLe, DanhMucService.LayKhachHang("Lẻ"), "HienThi", "MaKH");
                Ui.NapCombo(cboTourLe, DanhMucService.LayTour(), "HienThi", "MaTour");
                Ui.NapCombo(cboDiemBan, DanhMucService.LayDiemBanVe(), "TenDiemBan", "MaDiemBan");
                Ui.NapCombo(cboDiemDon, DanhMucService.LayDiemDon(), "TenDiemDon", "MaDiemDon");
                _dangNap = false;

                cboHinhThuc.SelectedIndex = 0;
                cboHinhThucVe.SelectedIndex = 0;
                LamMoiDoan();
                NapChuyen();
                NapPhieuDoan();
                NapPhieuChuyen();
            }
            catch (Exception ex)
            {
                _dangNap = false;
                Ui.ThongBao(lblThongBao, "Không tải được dữ liệu: " + Hlp.LoiSql(ex), false);
            }
        }

        // ============================== ĐĂNG KÝ ĐOÀN ==============================
        private decimal DonGiaTourDoan()
        {
            DataRowView drv = cboTourDoan.SelectedItem as DataRowView;
            if (drv == null) return 0;
            return Convert.ToDecimal(drv["DonGia"]);
        }

        private void CapNhatTienDoan()
        {
            decimal donGia = DonGiaTourDoan();
            decimal tong = DangKyDoanService.TinhTongTien(donGia, (int)numSoNguoi.Value);
            decimal coc;
            if (!Ui.DocTien(txtTienDatCoc.Text, out coc)) coc = 0;
            txtDonGia.Text = Ui.Tien(donGia);
            txtTongTien.Text = Ui.Tien(tong);
            txtTienConLai.Text = Ui.Tien(tong - coc);
        }

        private void CapNhatSoThanhVien()
        {
            lblDemTV.Text = "Đã nhập: " + _dtThanhVien.Rows.Count + "/" + (int)numSoNguoi.Value + " người";
        }

        private void LamMoiDoan()
        {
            txtDiaChiDon.Clear();
            txtTienDatCoc.Clear();
            numSoNguoi.Value = DangKyDoanService.NguongDoan + 1;
            dtpNgayDi.Value = DateTime.Today.AddDays(14);
            chkCoBaoHiem.Checked = false;
            _dtThanhVien.Clear();
            txtHoTen.Clear();
            txtSoCMND.Clear();
            grpThanhVien.Enabled = false;
            CapNhatTienDoan();
            CapNhatSoThanhVien();
            lblThongBao.Text = "";
        }

        private void NapPhieuDoan()
        {
            dgvPhieuDoan.DataSource = Db.Query(
                "SELECT TOP 200 p.SoPhieu, k.TenKH, t.TenTour, d.NgayDi, d.SoNguoi, d.TienDatCoc, p.TongTien, p.TrangThai " +
                "FROM PhieuDangKy p JOIN PhieuDangKyDoan d ON d.SoPhieu = p.SoPhieu JOIN KhachHang k ON k.MaKH = p.MaKH " +
                "JOIN Tour t ON t.MaTour = d.MaTour ORDER BY p.NgayLap DESC, p.SoPhieu DESC");
            Ui.TieuDe(dgvPhieuDoan, "SoPhieu", "Số phiếu", "TenKH", "Khách đoàn", "TenTour", "Tour", "NgayDi", "Ngày đi",
                "SoNguoi", "Số người", "TienDatCoc", "Tiền đặt cọc", "TongTien", "Tổng tiền", "TrangThai", "Trạng thái");
            Ui.CotNgay(dgvPhieuDoan, "NgayDi");
            Ui.CotTien(dgvPhieuDoan, "TienDatCoc", "TongTien");
        }

        private void cboTourDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            CapNhatTienDoan();
        }

        private void numSoNguoi_ValueChanged(object sender, EventArgs e)
        {
            bool laDoan = numSoNguoi.Value > DangKyDoanService.NguongDoan;
            lblPhanLoai.Text = laDoan ? "> 12 người: khách đoàn" : "≤ 12 người: khách lẻ";
            lblPhanLoai.ForeColor = laDoan ? Color.FromArgb(0, 110, 40) : Color.Firebrick;
            CapNhatTienDoan();
            CapNhatSoThanhVien();
        }

        private void txtTienDatCoc_TextChanged(object sender, EventArgs e)
        {
            CapNhatTienDoan();
        }

        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ui.ChiNhapSo(e);
        }

        private void chkCoBaoHiem_CheckedChanged(object sender, EventArgs e)
        {
            grpThanhVien.Enabled = chkCoBaoHiem.Checked;
            if (!chkCoBaoHiem.Checked) _dtThanhVien.Clear();
            CapNhatSoThanhVien();
        }

        private void btnThemTV_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim().Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Vui lòng nhập họ tên người đi.", false);
                return;
            }
            if (dtpNgaySinh.Value.Date > DateTime.Today)
            {
                Ui.ThongBao(lblThongBao, "Ngày sinh không hợp lệ.", false);
                return;
            }
            if (_dtThanhVien.Rows.Count >= (int)numSoNguoi.Value)
            {
                Ui.ThongBao(lblThongBao, "Danh sách đã đủ " + (int)numSoNguoi.Value + " người.", false);
                return;
            }
            _dtThanhVien.Rows.Add(txtHoTen.Text.Trim(), dtpNgaySinh.Value.Date, txtSoCMND.Text.Trim());
            txtHoTen.Clear();
            txtSoCMND.Clear();
            txtHoTen.Focus();
            CapNhatSoThanhVien();
            lblThongBao.Text = "";
        }

        private void btnXoaTV_Click(object sender, EventArgs e)
        {
            if (dgvThanhVien.CurrentRow == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn người cần xóa khỏi danh sách.", false);
                return;
            }
            DataRowView drv = dgvThanhVien.CurrentRow.DataBoundItem as DataRowView;
            if (drv != null) _dtThanhVien.Rows.Remove(drv.Row);
            CapNhatSoThanhVien();
        }

        private void btnKhachMoi_Click(object sender, EventArgs e)
        {
            using (FrmKhachHang f = new FrmKhachHang())
            {
                f.ShowDialog(this);
            }
            _dangNap = true;
            Ui.NapCombo(cboKhachDoan, DanhMucService.LayKhachHang("Đoàn"), "HienThi", "MaKH");
            Ui.NapCombo(cboKhachLe, DanhMucService.LayKhachHang("Lẻ"), "HienThi", "MaKH");
            _dangNap = false;
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            PhieuDoanInfo p = new PhieuDoanInfo();
            p.MaKH = Ui.GiaTri(cboKhachDoan);
            p.MaTour = Ui.GiaTri(cboTourDoan);
            p.NgayDi = dtpNgayDi.Value.Date;
            p.SoNguoi = (int)numSoNguoi.Value;
            p.DiaChiDon = txtDiaChiDon.Text.Trim();
            p.CoBaoHiem = chkCoBaoHiem.Checked;
            decimal coc;
            if (!Ui.DocTien(txtTienDatCoc.Text, out coc)) coc = 0;
            p.TienDatCoc = coc;
            p.HinhThuc = cboHinhThuc.Text;

            try
            {
                string soPhieu = DangKyDoanService.LapPhieuDoan(p, _dtThanhVien);
                decimal tong = DangKyDoanService.TinhTongTien(DonGiaTourDoan(), p.SoNguoi);
                Ui.ThongBao(lblThongBao, "Lập phiếu thành công: " + soPhieu, true);
                Ui.ThongTin("Lập phiếu đăng ký đoàn thành công!\n\n" +
                            "Số phiếu: " + soPhieu + "\n" +
                            "Khách đoàn: " + cboKhachDoan.Text + "\n" +
                            "Tour: " + cboTourDoan.Text + "\n" +
                            "Ngày đi: " + p.NgayDi.ToString("dd/MM/yyyy") + " - " + p.SoNguoi + " người\n" +
                            "Tổng tiền: " + Ui.Tien(tong) + "\n" +
                            "Tiền đặt cọc: " + Ui.Tien(p.TienDatCoc) + "\n" +
                            "Tiền còn lại: " + Ui.Tien(tong - p.TienDatCoc));
                LamMoiDoan();
                NapPhieuDoan();
                Ui.ThongBao(lblThongBao, "Lập phiếu thành công: " + soPhieu, true);
            }
            catch (InvalidOperationException ex)
            {
                Ui.ThongBao(lblThongBao, ex.Message, false);
                Ui.Loi(ex.Message);
            }
            catch (Exception ex)
            {
                string loi = Hlp.LoiSql(ex);
                Ui.ThongBao(lblThongBao, loi, false);
                Ui.Loi("Không lập được phiếu (đã rollback toàn bộ):\n" + loi);
            }
        }

        private void btnLamMoiDoan_Click(object sender, EventArgs e)
        {
            LamMoiDoan();
        }

        /// <summary>Xem danh sách người cùng đi của phiếu đoàn đang chọn trong lưới (chỉ có khi đoàn mua bảo hiểm).</summary>
        private void btnXemNguoiDi_Click(object sender, EventArgs e)
        {
            if (dgvPhieuDoan.CurrentRow == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn một phiếu đoàn trong danh sách bên dưới.", false);
                return;
            }
            string soPhieu = Convert.ToString(dgvPhieuDoan.CurrentRow.Cells["SoPhieu"].Value);
            try
            {
                object bh = Db.Scalar("SELECT CoBaoHiem FROM PhieuDangKyDoan WHERE SoPhieu = @sp", Hlp.P("@sp", soPhieu));
                if (bh == null || !Convert.ToBoolean(bh))
                {
                    Ui.ThongBao(lblThongBao, "Phiếu " + soPhieu + " không mua bảo hiểm nên không có danh sách người đi.", false);
                    return;
                }
                DataTable dt = Db.Query("SELECT MaTV, HoTen, NgaySinh, SoCMND FROM ThanhVienDoan WHERE SoPhieu = @sp ORDER BY MaTV", Hlp.P("@sp", soPhieu));
                using (FrmXemDanhSach f = new FrmXemDanhSach("Người đi của phiếu " + soPhieu,
                    "Phiếu " + soPhieu + ": " + dt.Rows.Count + " người cùng đi",
                    dt, "MaTV", "Mã", "HoTen", "Họ tên", "NgaySinh", "Ngày sinh", "SoCMND", "Số CMND"))
                {
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        // ============================== ĐĂNG KÝ CHUYẾN ==============================
        private void NapChuyen()
        {
            string maTour = Ui.GiaTri(cboTourLe);
            DataTable dt;
            if (maTour.Length == 0)
            {
                dt = new DataTable();
                dt.Columns.Add("MaChuyen", typeof(string));
                dt.Columns.Add("MoTa", typeof(string));
            }
            else dt = DangKyChuyenService.LayChuyenCon(maTour);
            _dangNap = true;
            Ui.NapCombo(cboChuyen, dt, "MoTa", "MaChuyen");
            _dangNap = false;
            CapNhatTienVe();
        }

        private void CapNhatTienVe()
        {
            DataRowView ch = cboChuyen.SelectedItem as DataRowView;
            DataRowView tour = cboTourLe.SelectedItem as DataRowView;
            decimal donGia = tour == null ? 0 : Convert.ToDecimal(tour["DonGia"]);
            txtChoConLai.Text = ch == null ? "" : Convert.ToString(ch["ConLai"]);
            txtDonGiaVe.Text = Ui.Tien(donGia);
            txtTongTienVe.Text = Ui.Tien(donGia * (int)numSoVe.Value);
        }

        private void NapPhieuChuyen()
        {
            dgvPhieuChuyen.DataSource = Db.Query(
                "SELECT TOP 200 p.SoPhieu, k.TenKH, c.MaChuyen, c.NgayDi, c.NgayVe, kc.SoVe, p.TongTien, p.TrangThai " +
                "FROM PhieuDangKy p JOIN PhieuDangKyChuyen kc ON kc.SoPhieu = p.SoPhieu JOIN KhachHang k ON k.MaKH = p.MaKH " +
                "JOIN ChuyenTour c ON c.MaChuyen = kc.MaChuyen ORDER BY p.NgayLap DESC, p.SoPhieu DESC");
            Ui.TieuDe(dgvPhieuChuyen, "SoPhieu", "Số phiếu", "TenKH", "Khách lẻ", "MaChuyen", "Chuyến", "NgayDi", "Ngày đi",
                "NgayVe", "Ngày về", "SoVe", "Số vé", "TongTien", "Tổng tiền", "TrangThai", "Trạng thái");
            Ui.CotNgay(dgvPhieuChuyen, "NgayDi", "NgayVe");
            Ui.CotTien(dgvPhieuChuyen, "TongTien");
        }

        private void cboTourLe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            try
            {
                NapChuyen();
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void cboChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            CapNhatTienVe();
        }

        private void numSoVe_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTienVe();
        }

        private void btnKhachLeMoi_Click(object sender, EventArgs e)
        {
            btnKhachMoi_Click(sender, e);
        }

        private void btnLapPhieuChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                string soPhieu = DangKyChuyenService.LapPhieuChuyen(Ui.GiaTri(cboKhachLe), Ui.GiaTri(cboChuyen),
                    Ui.GiaTri(cboDiemBan), Ui.GiaTri(cboDiemDon), (int)numSoVe.Value, cboHinhThucVe.Text);
                Ui.ThongTin("Lập phiếu đăng ký chuyến và bán vé thành công!\n\nSố phiếu: " + soPhieu +
                            "\nSố vé: " + (int)numSoVe.Value + "\nĐã thu: " + txtTongTienVe.Text);
                NapChuyen();
                NapPhieuChuyen();
                numSoVe.Value = 1;
                Ui.ThongBao(lblThongBao, "Lập phiếu chuyến thành công: " + soPhieu, true);
            }
            catch (InvalidOperationException ex)
            {
                Ui.ThongBao(lblThongBao, ex.Message, false);
                Ui.Loi(ex.Message);
            }
            catch (Exception ex)
            {
                string loi = Hlp.LoiSql(ex);
                Ui.ThongBao(lblThongBao, loi, false);
                Ui.Loi("Không lập được phiếu (đã rollback toàn bộ):\n" + loi);
            }
        }

        private void btnLamMoiChuyen_Click(object sender, EventArgs e)
        {
            numSoVe.Value = 1;
            cboHinhThucVe.SelectedIndex = 0;
            lblThongBao.Text = "";
            NapChuyen();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
