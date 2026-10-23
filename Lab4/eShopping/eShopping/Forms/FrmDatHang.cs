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
    public partial class FrmDatHang : Form
    {
        private readonly DonHangService donSv = new DonHangService();
        private readonly GioHangService gioSv = new GioHangService();
        private DataTable gio, loaiPhieu;
        private decimal tongTienHang, phiGiao;
        private bool phiHopLe;
        private bool dangNap = true;
        private string maDonHang;

        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            if (!PhienLamViec.DaDangNhap)
            {
                ThongBao.Canh("Bạn cần đăng nhập trước khi đặt hàng.");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }
            DieuHuong.GanLienKet(this);
            KhachHang kh = PhienLamViec.KhachHangHienTai;

            foreach (TextBox t in new TextBox[] { txtMaDonHang, txtNguoiMua, txtNgayDat, txtThoiGianXuLy, txtTongTienHang, txtPhiGiaoHang, txtTongGiaTri })
                t.ReadOnly = true;
            LuoiDuLieu.CauHinh(dgvGioHang, true);
            LuoiDuLieu.CauHinh(dgvPhieuDat, true);
            LuoiDuLieu.DinhDangTien(dgvGioHang, "colDonGia");
            LuoiDuLieu.CanPhai(dgvGioHang, "colSoLuong");
            LuoiDuLieu.DinhDangTien(dgvPhieuDat, "colPhiGiaoHang", "colTongGiaTri");
            dgvPhieuDat.Columns["colNgayDat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            radThuong.Tag = DonHangService.THUONG;
            radNhanh.Tag = DonHangService.NHANH;
            radHoaToc.Tag = DonHangService.TRONGNGAY;
            radThuong.Checked = true;

            maDonHang = donSv.TaoMaDonHang();
            txtMaDonHang.Text = maDonHang;
            txtNguoiMua.Text = kh.HoTen;
            txtNgayDat.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Mặc định người nhận = người mua; khách có thể sửa thành người khác (BR12, QĐ14)
            txtHoTenNguoiNhan.Text = kh.HoTen;
            txtDiaChiNguoiNhan.Text = kh.DiaChi;
            txtSDTNguoiNhan.Text = kh.SoDienThoai;

            try
            {
                loaiPhieu = donSv.LayLoaiPhieu();
                cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
                cboKhuVuc.DisplayMember = "TenKhuVuc";
                cboKhuVuc.ValueMember = "MaKhuVuc";
                cboKhuVuc.DataSource = donSv.LayKhuVuc();
                cboKhuVuc.SelectedIndex = -1;
                dgvPhieuDat.DataSource = donSv.LayDonHangCuaKhach(kh.MaKhachHang);
                if (!TaiGio()) { Close(); return; }
            }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); Close(); return; }

            dangNap = false;
            TinhPhi(false);
        }

        /// <summary>Nạp giỏ + giá hiện hành, kiểm tra tồn kho (QĐ03, QĐ04). Trả về false nếu giỏ không hợp lệ.</summary>
        private bool TaiGio()
        {
            gio = gioSv.LayChiTietGio(gioSv.LayMaGioHienTai(false));
            dgvGioHang.DataSource = gio;
            KetQuaXuLy kq = gioSv.KiemTraGioHopLe(gio);
            tongTienHang = GioHangService.TongTamTinh(gio);
            txtTongTienHang.Text = DinhDang.Tien(tongTienHang);
            if (!kq.ThanhCong) { ThongBao.Hien(kq); return false; }
            return true;
        }

        private string LayMaLoaiPhieu()
        {
            if (radNhanh.Checked) return DonHangService.NHANH;
            if (radHoaToc.Checked) return DonHangService.TRONGNGAY;
            return DonHangService.THUONG;
        }

        private void TinhPhi(bool hienLoi)
        {
            string loai = LayMaLoaiPhieu();
            foreach (DataRow r in loaiPhieu.Rows)
                if (Convert.ToString(r["MaLoaiPhieu"]) == loai)
                    txtThoiGianXuLy.Text = Convert.ToString(r["ThoiGianXuLyGio"]) + " giờ";

            phiHopLe = false;
            phiGiao = 0m;
            txtPhiGiaoHang.Text = "0";
            txtTongGiaTri.Text = DinhDang.Tien(tongTienHang);

            if (cboKhuVuc.SelectedIndex < 0 || cboKhuVuc.SelectedValue == null)
            {
                if (hienLoi) ThongBao.Canh("Vui lòng chọn khu vực giao hàng.");
                return;
            }
            KetQuaXuLy kq = donSv.TinhPhiGiaoHang(Convert.ToString(cboKhuVuc.SelectedValue), loai, tongTienHang);
            if (!kq.ThanhCong)
            {
                txtPhiGiaoHang.Text = "Chưa có phí";
                if (hienLoi) ThongBao.Hien(kq);
                return;
            }
            KetQuaPhi p = (KetQuaPhi)kq.Data;
            phiGiao = p.Phi;
            phiHopLe = true;
            txtPhiGiaoHang.Text = p.MienPhi ? "0 (miễn phí)" : DinhDang.Tien(p.Phi);
            txtTongGiaTri.Text = DinhDang.Tien(tongTienHang + p.Phi);
        }

        // Dùng chung cho radThuong/radNhanh/radTrongNgay.CheckedChanged và cboKhuVuc.SelectedIndexChanged
        private void LoaiPhieuHoacKhuVucThayDoi(object sender, EventArgs e)
        {
            if (dangNap) return;
            RadioButton rb = sender as RadioButton;
            if (rb != null && !rb.Checked) return;      // bỏ qua sự kiện của nút vừa bị bỏ chọn
            TinhPhi(false);
        }

        private void btnTinhPhi_Click(object sender, EventArgs e)
        {
            TinhPhi(true);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra lại giỏ + giá ngay trước khi sang bước thanh toán
            try { if (!TaiGio()) return; }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); return; }

            KetQuaXuLy nn = donSv.KiemTraNguoiNhan(txtHoTenNguoiNhan.Text, txtDiaChiNguoiNhan.Text, txtSDTNguoiNhan.Text);
            if (!nn.ThanhCong) { ThongBao.Hien(nn); return; }

            TinhPhi(true);
            if (!phiHopLe) return;

            DonHangDangLap don = new DonHangDangLap
            {
                MaDonHang = maDonHang,
                HoTenNguoiNhan = txtHoTenNguoiNhan.Text.Trim(),
                DiaChiNguoiNhan = txtDiaChiNguoiNhan.Text.Trim(),
                SoDienThoaiNguoiNhan = txtSDTNguoiNhan.Text.Trim(),
                MaKhuVuc = Convert.ToString(cboKhuVuc.SelectedValue),
                MaLoaiPhieu = LayMaLoaiPhieu(),
                TongTienHang = tongTienHang,
                PhiGiaoHang = phiGiao
            };
            PhienLamViec.DonHangDangLap = don;

            if (DieuHuong.MoThanhToan(this, don))
            {
                if (!IsDisposed) Close();            // đã đặt hàng xong
            }
            else
            {
                maDonHang = don.MaDonHang;           // có thể đã được đổi mã nếu trùng
                txtMaDonHang.Text = maDonHang;
            }
        }

        private void btnHuyDatHang_Click(object sender, EventArgs e)
        {
            if (!ThongBao.XacNhan("Hủy đặt hàng và quay lại giỏ hàng?")) return;
            PhienLamViec.DonHangDangLap = null;
            Close();
        }
    }
}
