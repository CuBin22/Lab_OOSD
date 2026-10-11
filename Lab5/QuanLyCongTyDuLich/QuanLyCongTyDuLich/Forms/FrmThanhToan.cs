using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Thanh toán: đặt cọc, tiền vé, kinh phí đoàn, xử lý mất cọc, in biên nhận.</summary>
    public partial class FrmThanhToan : Form
    {
        private bool _dangNap = false;
        private decimal _conLai = 0;

        public FrmThanhToan()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvThanhToan);
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            cboLoaiThanhToan.SelectedIndex = 0;
            cboHinhThuc.SelectedIndex = 0;
            try
            {
                NapPhieu();
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, "Không tải được dữ liệu: " + Hlp.LoiSql(ex), false);
            }
        }

        private void NapPhieu()
        {
            _dangNap = true;
            Ui.NapCombo(cboPhieu, ThanhToanService.LayPhieu(), "HienThi", "SoPhieu");
            _dangNap = false;
            HienThongTin();
        }

        private void HienThongTin()
        {
            string so = Ui.GiaTri(cboPhieu);
            if (so.Length == 0)
            {
                txtLoaiPhieu.Clear(); txtTongTien.Clear(); txtDaThanhToan.Clear(); txtConLai.Clear(); txtTrangThai.Clear();
                dgvThanhToan.DataSource = null;
                _conLai = 0;
                return;
            }
            DataRow r = ThanhToanService.LayThongTin(so);
            if (r == null) return;
            decimal tong = Convert.ToDecimal(r["TongTien"]);
            decimal da = Convert.ToDecimal(r["DaThanhToan"]);
            _conLai = tong - da;
            string loai = Convert.ToString(r["LoaiPhieu"]);
            txtLoaiPhieu.Text = loai;
            txtTongTien.Text = Ui.Tien(tong);
            txtDaThanhToan.Text = Ui.Tien(da);
            txtConLai.Text = Ui.Tien(_conLai);
            txtTrangThai.Text = Convert.ToString(r["TrangThai"]);

            dgvThanhToan.DataSource = ThanhToanService.LayLichSu(so);
            Ui.TieuDe(dgvThanhToan, "MaThanhToan", "Mã thanh toán", "NgayThanhToan", "Ngày thanh toán", "LoaiThanhToan", "Loại",
                "HinhThuc", "Hình thức", "SoTien", "Số tiền");
            Ui.CotTien(dgvThanhToan, "SoTien");

            // gợi ý loại thanh toán theo loại phiếu
            _dangNap = true;
            cboLoaiThanhToan.SelectedIndex = (loai == "Chuyến") ? 1 : 2;
            _dangNap = false;
            GoiYSoTien();
        }

        private void GoiYSoTien()
        {
            txtSoTien.Text = _conLai > 0 ? _conLai.ToString("0") : "";
        }

        private void cboPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            try
            {
                HienThongTin();
                lblThongBao.Text = "";
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void cboLoaiThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            GoiYSoTien();
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ui.ChiNhapSo(e);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string so = Ui.GiaTri(cboPhieu);
            decimal soTien;
            if (so.Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn phiếu đăng ký.", false);
                return;
            }
            if (!Ui.DocTien(txtSoTien.Text, out soTien) || soTien <= 0)
            {
                Ui.ThongBao(lblThongBao, "Số tiền không hợp lệ (phải lớn hơn 0).", false);
                return;
            }
            try
            {
                ThanhToanService.GhiNhan(so, cboLoaiThanhToan.Text, cboHinhThuc.Text, soTien);
                NapPhieu();
                Ui.ThongBao(lblThongBao, "Đã ghi nhận thanh toán " + Ui.Tien(soTien) + " (" + cboLoaiThanhToan.Text + ").", true);
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

        private void btnHuyMatCoc_Click(object sender, EventArgs e)
        {
            string so = Ui.GiaTri(cboPhieu);
            if (so.Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn phiếu đăng ký.", false);
                return;
            }
            if (!Ui.Hoi("Đoàn không đi: hủy phiếu " + so + " và giữ lại tiền đặt cọc (mất cọc)?")) return;
            try
            {
                ThanhToanService.HuyMatCoc(so);
                NapPhieu();
                Ui.ThongBao(lblThongBao, "Đã hủy phiếu " + so + " (mất cọc).", true);
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

        private void btnInBienNhan_Click(object sender, EventArgs e)
        {
            if (dgvThanhToan.CurrentRow == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn một dòng trong lịch sử thanh toán để in biên nhận.", false);
                return;
            }
            DataGridViewRow r = dgvThanhToan.CurrentRow;
            string noiDung = "BIÊN NHẬN THANH TOÁN\n\n" +
                             "Phiếu đăng ký: " + Ui.GiaTri(cboPhieu) + " (" + txtLoaiPhieu.Text + ")\n" +
                             "Mã thanh toán: " + Convert.ToString(r.Cells["MaThanhToan"].Value) + "\n" +
                             "Ngày: " + Convert.ToDateTime(r.Cells["NgayThanhToan"].Value).ToString("dd/MM/yyyy HH:mm") + "\n" +
                             "Loại: " + Convert.ToString(r.Cells["LoaiThanhToan"].Value) + "\n" +
                             "Hình thức: " + Convert.ToString(r.Cells["HinhThuc"].Value) + "\n" +
                             "Số tiền: " + Ui.Tien(Convert.ToDecimal(r.Cells["SoTien"].Value)) + "\n\n" +
                             "Tổng tiền phiếu: " + txtTongTien.Text + "\n" +
                             "Đã thanh toán: " + txtDaThanhToan.Text + "\n" +
                             "Còn lại: " + txtConLai.Text;
            MessageBox.Show(noiDung, "Biên nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
