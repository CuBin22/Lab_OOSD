using eShopping.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eShopping.Models.Models;

namespace eShopping.Forms
{

    public partial class FrmThanhToan : Form
    {
        private readonly DonHangDangLap don;
        private readonly ThanhToanService thanhToanSv = new ThanhToanService();
        private readonly DonHangService donSv = new DonHangService();
        private decimal lePhi;
        private bool dangXuLy;
        private bool dangNap = true;

        /// <summary>Mã đơn đã ghi thành công (đọc sau khi DialogResult = OK).</summary>
        public string MaDonHangDaDat { get; private set; }

        public FrmThanhToan(DonHangDangLap don)
        {
            InitializeComponent();
            this.don = don;
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            if (don == null) { Close(); return; }
            DieuHuong.GanLienKet(this);
            foreach (TextBox t in new TextBox[] { txtMaDonHang, txtTongGiaTriDon, txtLePhi, txtTongThanhToan, txtTrangThai })
                t.ReadOnly = true;
            txtCSV.UseSystemPasswordChar = true;                      // không hiện CSV (QĐ09)
            dtpNgayHetHan.Format = DateTimePickerFormat.Custom;
            dtpNgayHetHan.CustomFormat = "MM/yyyy";
            dtpNgayHetHan.ShowUpDown = true;
            dtpNgayHetHan.MinDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpNgayHetHan.Value = DateTime.Today.AddYears(2);

            txtMaDonHang.Text = don.MaDonHang;
            txtTongGiaTriDon.Text = DinhDang.Tien(don.TongGiaTri);

            try
            {
                cboLoaiThe.DropDownStyle = ComboBoxStyle.DropDownList;
                cboLoaiThe.DisplayMember = "TenLoaiThe";
                cboLoaiThe.ValueMember = "MaLoaiThe";
                cboLoaiThe.DataSource = thanhToanSv.LayLoaiThe();
            }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); Close(); return; }
            dangNap = false;
            CapNhatTheoLoai();
            txtTrangThai.Text = "Chưa kiểm tra";
        }

        // BR14/BR15/BR17: số chữ số thẻ, CSV và lệ phí phụ thuộc loại thẻ
        private void CapNhatTheoLoai()
        {
            DataRowView r = cboLoaiThe.SelectedItem as DataRowView;
            if (r == null) return;
            txtSoThe.MaxLength = Convert.ToInt32(r["SoChuSoThe"]);
            txtCSV.MaxLength = Convert.ToInt32(r["SoChuSoCSV"]);
            if (txtSoThe.Text.Length > txtSoThe.MaxLength) txtSoThe.Clear();
            if (txtCSV.Text.Length > txtCSV.MaxLength) txtCSV.Clear();
            lePhi = Convert.ToDecimal(r["LePhi"]);
            txtLePhi.Text = DinhDang.Tien(lePhi);
            // Giả định: lệ phí thẻ cộng vào số tiền khách thanh toán (vấn đề cần xác nhận số 1); lưu riêng ở bảng ThanhToan
            txtTongThanhToan.Text = DinhDang.Tien(don.TongGiaTri + lePhi);
        }

        private void cboLoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangNap) CapNhatTheoLoai();
        }

        private void SoChiNhapChuSo(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtSoThe_KeyPress(object sender, KeyPressEventArgs e) { SoChiNhapChuSo(e); }
        private void txtCSV_KeyPress(object sender, KeyPressEventArgs e) { SoChiNhapChuSo(e); }

        private void DatNut(bool batTat)
        {
            btnThanhToan.Enabled = batTat;
            btnNhapLai.Enabled = batTat;
            btnHuy.Enabled = batTat;
            cboLoaiThe.Enabled = batTat;
        }

        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dangXuLy) return;                                    // NFR09: chống bấm nhiều lần

            TheThanhToan the = new TheThanhToan
            {
                MaLoaiThe = Convert.ToString(cboLoaiThe.SelectedValue),
                SoThe = txtSoThe.Text.Trim(),
                NgayHetHan = dtpNgayHetHan.Value,
                HoTenChuThe = txtHoTenChuThe.Text.Trim(),
                CSV = txtCSV.Text.Trim()
            };

            KetQuaXuLy dinhDang;
            try { dinhDang = thanhToanSv.KiemTraDinhDang(the); }     // QĐ08: kiểm tra định dạng trước
            catch (Exception ex) { ThongBao.LoiHeThong(ex); return; }
            if (!dinhDang.ThanhCong)
            {
                txtTrangThai.Text = dinhDang.ThongBao;
                ThongBao.Hien(dinhDang);
                return;
            }

            dangXuLy = true;
            DatNut(false);
            txtTrangThai.Text = "Đang kiểm tra thẻ và ghi nhận đơn hàng...";

            KetQuaXuLy kq;
            try { kq = await System.Threading.Tasks.Task.Run(() => donSv.DatHang(don, the)); }
            catch (Exception ex) { kq = KetQuaXuLy.Loi("Lỗi hệ thống: " + ex.Message); }
            finally { the.CSV = null; txtCSV.Clear(); }              // QĐ09: không giữ CSV

            dangXuLy = false;
            if (kq.ThanhCong)
            {
                MaDonHangDaDat = Convert.ToString(kq.Data);
                txtTrangThai.Text = "Thanh toán thành công";
                ThongBao.Hien(kq);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            // QĐ11: thất bại -> không tạo đơn, giữ giỏ, cho nhập lại hoặc đổi thẻ
            txtTrangThai.Text = "Thất bại: " + kq.ThongBao;
            DatNut(true);
            ThongBao.Hien(kq);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSoThe.Clear();
            txtCSV.Clear();
            txtHoTenChuThe.Clear();
            dtpNgayHetHan.Value = DateTime.Today.AddYears(2);
            txtTrangThai.Text = "Chưa kiểm tra";
            txtSoThe.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Không cho đóng form khi đang gọi hệ thống thanh toán
        private void frmThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangXuLy) e.Cancel = true;
        }
    }
}
