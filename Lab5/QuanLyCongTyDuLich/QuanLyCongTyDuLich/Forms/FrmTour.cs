using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Quản lý tour, lộ trình (nơi dừng chân, điểm tham quan) và chuyến tour.</summary>
    public partial class FrmTour : Form
    {
        private bool _dangNap = false;

        public FrmTour()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvTour);
            Ui.DinhDangLuoi(dgvDungChan);
            Ui.DinhDangLuoi(dgvDiemTQ);
            Ui.DinhDangLuoi(dgvChuyen);
            ThemNutBoSung();
        }

        /// <summary>Thêm 2 nút bằng code: xuất trang web giới thiệu tour và xem khách đăng ký của chuyến.</summary>
        private void ThemNutBoSung()
        {
            Button btnWeb = new Button();
            btnWeb.Text = "Xuất web";
            btnWeb.Name = "btnXuatWeb";
            btnWeb.Size = btnXoaTour.Size;
            btnWeb.Location = new Point(btnXoaTour.Left - btnWeb.Width - 6, btnXoaTour.Top);
            btnWeb.UseVisualStyleBackColor = true;
            btnWeb.Click += btnXuatWeb_Click;
            tabTour.Controls.Add(btnWeb);

            Button btnKhach = new Button();
            btnKhach.Text = "Khách đăng ký";
            btnKhach.Name = "btnKhachChuyen";
            btnKhach.Size = new Size(120, btnLamMoiChuyen.Height);
            btnKhach.Location = new Point(btnLamMoiChuyen.Right + 6, btnLamMoiChuyen.Top);
            btnKhach.UseVisualStyleBackColor = true;
            btnKhach.Click += btnKhachChuyen_Click;
            tabChuyen.Controls.Add(btnKhach);
        }

        /// <summary>Xuất thông tin tour ra file HTML để đăng lên website công ty.</summary>
        private void btnXuatWeb_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất trang web giới thiệu tour";
                sfd.Filter = "Trang web (*.html)|*.html";
                sfd.FileName = "Tour_VanHoaViet.html";
                if (sfd.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    WebsiteService.XuatTrangTour(sfd.FileName);
                    Ui.ThongBao(lblThongBao, "Đã xuất trang web: " + sfd.FileName, true);
                    if (Ui.Hoi("Đã xuất xong. Mở trang web trong trình duyệt?"))
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (InvalidOperationException ex)
                {
                    Ui.ThongBao(lblThongBao, ex.Message, false);
                }
                catch (Exception ex)
                {
                    Ui.ThongBao(lblThongBao, "Không xuất được trang web: " + Hlp.LoiSql(ex), false);
                }
            }
        }

        /// <summary>Danh sách khách lẻ đã đăng ký của chuyến đang chọn.</summary>
        private void btnKhachChuyen_Click(object sender, EventArgs e)
        {
            if (dgvChuyen.CurrentRow == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn chuyến trong danh sách để xem khách đăng ký.", false);
                return;
            }
            string maChuyen = Convert.ToString(dgvChuyen.CurrentRow.Cells["MaChuyen"].Value);
            try
            {
                DataTable dt = Db.Query(
                    "SELECT p.SoPhieu, k.MaKH, k.TenKH, k.DienThoai, kc.SoVe, bv.TenDiemBan, dd.TenDiemDon, p.TongTien, p.TrangThai " +
                    "FROM PhieuDangKyChuyen kc JOIN PhieuDangKy p ON p.SoPhieu = kc.SoPhieu JOIN KhachHang k ON k.MaKH = p.MaKH " +
                    "JOIN DiemBanVe bv ON bv.MaDiemBan = kc.MaDiemBan JOIN DiemDon dd ON dd.MaDiemDon = kc.MaDiemDon " +
                    "WHERE kc.MaChuyen = @c AND p.TrangThai <> N'Đã hủy' ORDER BY p.SoPhieu", Hlp.P("@c", maChuyen));
                int soVe = 0;
                foreach (DataRow r in dt.Rows) soVe += Convert.ToInt32(r["SoVe"]);
                string tomTat = "Chuyến " + maChuyen + ": " + dt.Rows.Count + " phiếu đăng ký, " + soVe + "/"
                                + Convert.ToString(dgvChuyen.CurrentRow.Cells["SoChoToiDa"].Value) + " chỗ đã bán";
                using (FrmXemDanhSach f = new FrmXemDanhSach("Khách đăng ký chuyến " + maChuyen, tomTat, dt,
                    "SoPhieu", "Số phiếu", "MaKH", "Mã KH", "TenKH", "Khách hàng", "DienThoai", "Điện thoại", "SoVe", "Số vé",
                    "TenDiemBan", "Điểm bán vé", "TenDiemDon", "Điểm đón", "TongTien", "Tổng tiền", "TrangThai", "Trạng thái"))
                {
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void FrmTour_Load(object sender, EventArgs e)
        {
            try
            {
                NapTour();
                NapComboTour();
                _dangNap = true;
                Ui.NapCombo(cboDiaDiem, DanhMucService.LayDiaDiem(), "TenDiaDiem", "MaDiaDiem");
                Ui.NapCombo(cboPhuongTien, DanhMucService.LayPhuongTien(), "TenPT", "MaPT");
                Ui.NapCombo(cboDiemThamQuan, DanhMucService.LayDiemThamQuan(), "TenDiemTQ", "MaDiemTQ");
                _dangNap = false;
                LamMoiTour();
                LamMoiChuyen();
            }
            catch (Exception ex)
            {
                _dangNap = false;
                Ui.ThongBao(lblThongBao, "Không tải được dữ liệu: " + Hlp.LoiSql(ex), false);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            try
            {
                NapComboTour();
                lblThongBao.Text = "";
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        // ============================== TAB TOUR ==============================
        private void NapTour()
        {
            dgvTour.DataSource = Db.Query("SELECT MaTour, TenTour, SoNgay, SoDem, DonGia FROM Tour ORDER BY MaTour");
            Ui.TieuDe(dgvTour, "MaTour", "Mã tour", "TenTour", "Tên tour", "SoNgay", "Số ngày", "SoDem", "Số đêm", "DonGia", "Đơn giá/khách");
            Ui.CotTien(dgvTour, "DonGia");
        }

        /// <summary>Nạp lại hai ComboBox chọn tour (tab Lộ trình và tab Chuyến).</summary>
        private void NapComboTour()
        {
            DataTable dt = DanhMucService.LayTour();
            _dangNap = true;
            Ui.NapCombo(cboTourLoTrinh, dt.Copy(), "HienThi", "MaTour");
            Ui.NapCombo(cboTourChuyen, dt.Copy(), "HienThi", "MaTour");
            _dangNap = false;
            NapDungChan();
            NapDiemTQ();
            NapChuyen();
        }

        private void LamMoiTour()
        {
            txtMaTour.ReadOnly = false;
            txtMaTour.Text = Hlp.MaTiepTheo("Tour", "MaTour", "T", 2);
            txtTenTour.Clear();
            numSoNgay.Value = 1;
            numSoDem.Value = 0;
            txtDonGia.Clear();
            txtTenTour.Focus();
        }

        private bool DocFormTour(out decimal donGia)
        {
            donGia = 0;
            if (txtMaTour.Text.Trim().Length == 0 || txtTenTour.Text.Trim().Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Vui lòng nhập mã tour và tên tour.", false);
                return false;
            }
            if (!Ui.DocTien(txtDonGia.Text, out donGia) || donGia < 0)
            {
                Ui.ThongBao(lblThongBao, "Đơn giá không hợp lệ (phải là số, không âm).", false);
                return false;
            }
            return true;
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            if (txtMaTour.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Đang chọn một tour để sửa. Bấm \"Làm mới\" để nhập tour mới.", false);
                return;
            }
            decimal donGia;
            if (!DocFormTour(out donGia)) return;
            try
            {
                Db.Execute("INSERT INTO Tour (MaTour, TenTour, SoNgay, SoDem, DonGia) VALUES (@ma, @ten, @ngay, @dem, @gia)",
                    Hlp.P("@ma", txtMaTour.Text.Trim()), Hlp.P("@ten", txtTenTour.Text.Trim()),
                    Hlp.P("@ngay", (int)numSoNgay.Value), Hlp.P("@dem", (int)numSoDem.Value), Hlp.P("@gia", donGia));
                NapTour();
                NapComboTour();
                LamMoiTour();
                Ui.ThongBao(lblThongBao, "Đã thêm tour.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            if (!txtMaTour.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn tour cần sửa trong danh sách.", false);
                return;
            }
            decimal donGia;
            if (!DocFormTour(out donGia)) return;
            try
            {
                Db.Execute("UPDATE Tour SET TenTour = @ten, SoNgay = @ngay, SoDem = @dem, DonGia = @gia WHERE MaTour = @ma",
                    Hlp.P("@ma", txtMaTour.Text.Trim()), Hlp.P("@ten", txtTenTour.Text.Trim()),
                    Hlp.P("@ngay", (int)numSoNgay.Value), Hlp.P("@dem", (int)numSoDem.Value), Hlp.P("@gia", donGia));
                NapTour();
                NapComboTour();
                Ui.ThongBao(lblThongBao, "Đã cập nhật tour.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            if (!txtMaTour.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn tour cần xóa trong danh sách.", false);
                return;
            }
            if (!Ui.Hoi("Xóa tour \"" + txtTenTour.Text.Trim() + "\" (kèm lộ trình và danh sách điểm tham quan)?")) return;
            try
            {
                Db.Execute("DELETE FROM Tour WHERE MaTour = @ma", Hlp.P("@ma", txtMaTour.Text.Trim()));
                NapTour();
                NapComboTour();
                LamMoiTour();
                Ui.ThongBao(lblThongBao, "Đã xóa tour.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnLamMoiTour_Click(object sender, EventArgs e)
        {
            LamMoiTour();
            lblThongBao.Text = "";
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvTour.Rows[e.RowIndex];
            txtMaTour.Text = Convert.ToString(r.Cells["MaTour"].Value);
            txtMaTour.ReadOnly = true;
            txtTenTour.Text = Convert.ToString(r.Cells["TenTour"].Value);
            Ui.GanSo(numSoNgay, Convert.ToDecimal(r.Cells["SoNgay"].Value));
            Ui.GanSo(numSoDem, Convert.ToDecimal(r.Cells["SoDem"].Value));
            txtDonGia.Text = Convert.ToDecimal(r.Cells["DonGia"].Value).ToString("0");
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ui.ChiNhapSo(e);
        }

        // ============================== TAB LỘ TRÌNH ==============================
        private void NapDungChan()
        {
            string maTour = Ui.GiaTri(cboTourLoTrinh);
            if (maTour.Length == 0) { dgvDungChan.DataSource = null; return; }
            dgvDungChan.DataSource = Db.Query(
                "SELECT dc.MaDungChan, dc.ThuTu, dd.TenDiaDiem, pt.TenPT, dc.DoiPhuongTien, dc.CoNoiAn, dc.CoKhachSan, dc.LoaiKhachSan " +
                "FROM DungChan dc JOIN DiaDiem dd ON dd.MaDiaDiem = dc.MaDiaDiem JOIN PhuongTien pt ON pt.MaPT = dc.MaPT " +
                "WHERE dc.MaTour = @t ORDER BY dc.ThuTu", Hlp.P("@t", maTour));
            Ui.TieuDe(dgvDungChan, "ThuTu", "Thứ tự", "TenDiaDiem", "Nơi dừng chân", "TenPT", "Phương tiện đến",
                "DoiPhuongTien", "Đổi PT", "CoNoiAn", "Có nơi ăn", "CoKhachSan", "Có khách sạn", "LoaiKhachSan", "Loại KS (sao)");
            Ui.AnCot(dgvDungChan, "MaDungChan");

            object max = Db.Scalar("SELECT ISNULL(MAX(ThuTu), 0) FROM DungChan WHERE MaTour = @t", Hlp.P("@t", maTour));
            Ui.GanSo(numThuTu, Convert.ToDecimal(max) + 1);
        }

        private void NapDiemTQ()
        {
            string maTour = Ui.GiaTri(cboTourLoTrinh);
            if (maTour.Length == 0) { dgvDiemTQ.DataSource = null; return; }
            dgvDiemTQ.DataSource = Db.Query(
                "SELECT d.MaDiemTQ, d.TenDiemTQ, d.DiaDiem FROM ChiTietTourDiemTQ c JOIN DiemThamQuan d ON d.MaDiemTQ = c.MaDiemTQ " +
                "WHERE c.MaTour = @t ORDER BY d.TenDiemTQ", Hlp.P("@t", maTour));
            Ui.TieuDe(dgvDiemTQ, "MaDiemTQ", "Mã điểm TQ", "TenDiemTQ", "Tên điểm tham quan", "DiaDiem", "Địa điểm");
        }

        private void cboTourLoTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            try
            {
                NapDungChan();
                NapDiemTQ();
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void chkCoKhachSan_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiKhachSan.Enabled = chkCoKhachSan.Checked;
            if (chkCoKhachSan.Checked) { if (cboLoaiKhachSan.SelectedIndex < 0) cboLoaiKhachSan.SelectedIndex = 0; }
            else cboLoaiKhachSan.SelectedIndex = -1;
        }

        private void btnThemDungChan_Click(object sender, EventArgs e)
        {
            string maTour = Ui.GiaTri(cboTourLoTrinh);
            if (maTour.Length == 0 || Ui.GiaTri(cboDiaDiem).Length == 0 || Ui.GiaTri(cboPhuongTien).Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn tour, địa điểm và phương tiện.", false);
                return;
            }
            if (chkCoKhachSan.Checked && cboLoaiKhachSan.SelectedIndex < 0)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn loại khách sạn (2 - 5 sao).", false);
                return;
            }
            object sao = null;
            if (chkCoKhachSan.Checked) sao = int.Parse(cboLoaiKhachSan.Text);
            try
            {
                Db.Execute("INSERT INTO DungChan (MaDungChan, MaTour, MaDiaDiem, MaPT, ThuTu, DoiPhuongTien, CoNoiAn, CoKhachSan, LoaiKhachSan) " +
                           "VALUES (@ma, @t, @dd, @pt, @tt, @doi, @an, @ks, @sao)",
                    Hlp.P("@ma", Hlp.MaTiepTheo("DungChan", "MaDungChan", "DC", 4)), Hlp.P("@t", maTour),
                    Hlp.P("@dd", Ui.GiaTri(cboDiaDiem)), Hlp.P("@pt", Ui.GiaTri(cboPhuongTien)),
                    Hlp.P("@tt", (int)numThuTu.Value), Hlp.P("@doi", chkDoiPhuongTien.Checked), Hlp.P("@an", chkCoNoiAn.Checked),
                    Hlp.P("@ks", chkCoKhachSan.Checked), Hlp.P("@sao", sao));
                NapDungChan();
                Ui.ThongBao(lblThongBao, "Đã thêm nơi dừng chân.", true);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    Ui.ThongBao(lblThongBao, "Thứ tự này đã có nơi dừng chân trong tour.", false);
                else
                    Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoaDungChan_Click(object sender, EventArgs e)
        {
            if (dgvDungChan.CurrentRow == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn nơi dừng chân cần xóa.", false);
                return;
            }
            if (!Ui.Hoi("Xóa nơi dừng chân đã chọn?")) return;
            try
            {
                Db.Execute("DELETE FROM DungChan WHERE MaDungChan = @ma", Hlp.P("@ma", dgvDungChan.CurrentRow.Cells["MaDungChan"].Value));
                NapDungChan();
                Ui.ThongBao(lblThongBao, "Đã xóa nơi dừng chân.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnThemDiemTQ_Click(object sender, EventArgs e)
        {
            string maTour = Ui.GiaTri(cboTourLoTrinh);
            string maDiem = Ui.GiaTri(cboDiemThamQuan);
            if (maTour.Length == 0 || maDiem.Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn tour và điểm tham quan.", false);
                return;
            }
            try
            {
                Db.Execute("INSERT INTO ChiTietTourDiemTQ (MaTour, MaDiemTQ) VALUES (@t, @d)", Hlp.P("@t", maTour), Hlp.P("@d", maDiem));
                NapDiemTQ();
                Ui.ThongBao(lblThongBao, "Đã thêm điểm tham quan vào tour.", true);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    Ui.ThongBao(lblThongBao, "Điểm tham quan này đã có trong tour.", false);
                else
                    Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoaDiemTQ_Click(object sender, EventArgs e)
        {
            if (dgvDiemTQ.CurrentRow == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn điểm tham quan cần xóa khỏi tour.", false);
                return;
            }
            try
            {
                Db.Execute("DELETE FROM ChiTietTourDiemTQ WHERE MaTour = @t AND MaDiemTQ = @d",
                    Hlp.P("@t", Ui.GiaTri(cboTourLoTrinh)), Hlp.P("@d", dgvDiemTQ.CurrentRow.Cells["MaDiemTQ"].Value));
                NapDiemTQ();
                Ui.ThongBao(lblThongBao, "Đã xóa điểm tham quan khỏi tour.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        // ============================== TAB CHUYẾN ==============================
        private void NapChuyen()
        {
            string maTour = Ui.GiaTri(cboTourChuyen);
            if (maTour.Length == 0) { dgvChuyen.DataSource = null; return; }
            dgvChuyen.DataSource = Db.Query("SELECT MaChuyen, NgayDi, NgayVe, SoChoToiDa FROM ChuyenTour WHERE MaTour = @t ORDER BY NgayDi",
                Hlp.P("@t", maTour));
            Ui.TieuDe(dgvChuyen, "MaChuyen", "Mã chuyến", "NgayDi", "Ngày đi", "NgayVe", "Ngày về", "SoChoToiDa", "Số chỗ tối đa");
            Ui.CotNgay(dgvChuyen, "NgayDi", "NgayVe");
        }

        private void cboTourChuyen_SelectedIndexChanged(object sender, EventArgs e)
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

        private void LamMoiChuyen()
        {
            txtMaChuyen.ReadOnly = false;
            txtMaChuyen.Text = Hlp.MaTiepTheo("ChuyenTour", "MaChuyen", "CH", 4);
            dtpNgayDi.Value = DateTime.Today.AddDays(7);
            dtpNgayVe.Value = DateTime.Today.AddDays(9);
            numSoCho.Value = 40;
        }

        private bool KiemTraFormChuyen(bool laThem)
        {
            if (Ui.GiaTri(cboTourChuyen).Length == 0 || txtMaChuyen.Text.Trim().Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn tour và nhập mã chuyến.", false);
                return false;
            }
            if (dtpNgayVe.Value.Date < dtpNgayDi.Value.Date)
            {
                Ui.ThongBao(lblThongBao, "Ngày về phải lớn hơn hoặc bằng ngày đi.", false);
                return false;
            }
            if (laThem && dtpNgayDi.Value.Date < DateTime.Today)
            {
                Ui.ThongBao(lblThongBao, "Ngày đi không được nằm trong quá khứ.", false);
                return false;
            }
            return true;
        }

        private void btnThemChuyen_Click(object sender, EventArgs e)
        {
            if (txtMaChuyen.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Đang chọn một chuyến để sửa. Bấm \"Làm mới\" để nhập chuyến mới.", false);
                return;
            }
            if (!KiemTraFormChuyen(true)) return;
            try
            {
                Db.Execute("INSERT INTO ChuyenTour (MaChuyen, MaTour, NgayDi, NgayVe, SoChoToiDa) VALUES (@ma, @t, @di, @ve, @cho)",
                    Hlp.P("@ma", txtMaChuyen.Text.Trim()), Hlp.P("@t", Ui.GiaTri(cboTourChuyen)),
                    Hlp.P("@di", dtpNgayDi.Value.Date), Hlp.P("@ve", dtpNgayVe.Value.Date), Hlp.P("@cho", (int)numSoCho.Value));
                NapChuyen();
                LamMoiChuyen();
                Ui.ThongBao(lblThongBao, "Đã thêm chuyến tour.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnSuaChuyen_Click(object sender, EventArgs e)
        {
            if (!txtMaChuyen.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn chuyến cần sửa trong danh sách.", false);
                return;
            }
            if (!KiemTraFormChuyen(false)) return;
            try
            {
                object daBan = Db.Scalar(
                    "SELECT ISNULL(SUM(k.SoVe), 0) FROM PhieuDangKyChuyen k JOIN PhieuDangKy p ON p.SoPhieu = k.SoPhieu AND p.TrangThai <> N'Đã hủy' WHERE k.MaChuyen = @ma",
                    Hlp.P("@ma", txtMaChuyen.Text.Trim()));
                if (Convert.ToInt32(daBan) > (int)numSoCho.Value)
                {
                    Ui.ThongBao(lblThongBao, "Số chỗ tối đa không được nhỏ hơn số vé đã bán (" + Convert.ToInt32(daBan) + ").", false);
                    return;
                }
                Db.Execute("UPDATE ChuyenTour SET NgayDi = @di, NgayVe = @ve, SoChoToiDa = @cho WHERE MaChuyen = @ma",
                    Hlp.P("@ma", txtMaChuyen.Text.Trim()), Hlp.P("@di", dtpNgayDi.Value.Date),
                    Hlp.P("@ve", dtpNgayVe.Value.Date), Hlp.P("@cho", (int)numSoCho.Value));
                NapChuyen();
                Ui.ThongBao(lblThongBao, "Đã cập nhật chuyến tour.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoaChuyen_Click(object sender, EventArgs e)
        {
            if (!txtMaChuyen.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn chuyến cần xóa trong danh sách.", false);
                return;
            }
            if (!Ui.Hoi("Xóa chuyến \"" + txtMaChuyen.Text.Trim() + "\"?")) return;
            try
            {
                Db.Execute("DELETE FROM ChuyenTour WHERE MaChuyen = @ma", Hlp.P("@ma", txtMaChuyen.Text.Trim()));
                NapChuyen();
                LamMoiChuyen();
                Ui.ThongBao(lblThongBao, "Đã xóa chuyến tour.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnLamMoiChuyen_Click(object sender, EventArgs e)
        {
            LamMoiChuyen();
            lblThongBao.Text = "";
        }

        private void dgvChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvChuyen.Rows[e.RowIndex];
            txtMaChuyen.Text = Convert.ToString(r.Cells["MaChuyen"].Value);
            txtMaChuyen.ReadOnly = true;
            dtpNgayDi.Value = Convert.ToDateTime(r.Cells["NgayDi"].Value);
            dtpNgayVe.Value = Convert.ToDateTime(r.Cells["NgayVe"].Value);
            Ui.GanSo(numSoCho, Convert.ToDecimal(r.Cells["SoChoToiDa"].Value));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
