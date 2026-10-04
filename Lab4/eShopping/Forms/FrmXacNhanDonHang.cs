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

namespace eShopping.Forms
{
    public partial class FrmXacNhanDonHang : Form
    {
        private readonly string maDonHang;
        private readonly DonHangService donSv = new DonHangService();
        private readonly EmailService emailSv = new EmailService();
        private readonly Timer tmrEmail = new Timer();     // tạo bằng code, không cần kéo vào Designer
        private string maEmail;
        private int soLanKiemTra;

        public FrmXacNhanDonHang(string maDonHang)
        {
            InitializeComponent();
            this.maDonHang = maDonHang;
            tmrEmail.Interval = 2000;
            tmrEmail.Tick += tmrEmail_Tick;
        }

        private void FrmXacNhanDonHang_Load(object sender, EventArgs e)
        {
            DieuHuong.GanLienKet(this);
            foreach (TextBox t in new TextBox[] { txtMaDonHang, txtNgayDat, txtNguoiMua, txtNguoiNhan, txtSoDienThoai, txtLoaiPhieu,
                                                  txtDiaChiNhan, txtKhuVuc, txtEmailNhan, txtTrangThai,
                                                  txtTongTienHang, txtPhiGiaoHang, txtTongGiaTri })
                t.ReadOnly = true;
            LuoiDuLieu.CauHinh(dgvChiTietDonHang, true);
            LuoiDuLieu.DinhDangTien(dgvChiTietDonHang, "colDonGia", "colThanhTien");
            LuoiDuLieu.CanPhai(dgvChiTietDonHang, "colSoLuong");

            if (!PhienLamViec.DaDangNhap) { ThongBao.Canh("Bạn cần đăng nhập để xem đơn hàng."); Close(); return; }
            try
            {
                string maKH = PhienLamViec.KhachHangHienTai.MaKhachHang;
                DataTable don = donSv.LayDonHang(maDonHang, maKH);        // NFR08: chỉ xem đơn của mình
                if (don.Rows.Count == 0) { ThongBao.Canh("Không tìm thấy đơn hàng."); Close(); return; }
                DataRow d = don.Rows[0];
                txtMaDonHang.Text = Convert.ToString(d["MaDonHang"]);
                txtNgayDat.Text = Convert.ToDateTime(d["NgayDat"]).ToString("dd/MM/yyyy HH:mm");
                txtNguoiMua.Text = Convert.ToString(d["HoTenNguoiMua"]);
                txtNguoiNhan.Text = Convert.ToString(d["HoTenNguoiNhan"]);
                txtSoDienThoai.Text = Convert.ToString(d["SoDienThoaiNguoiNhan"]);
                txtLoaiPhieu.Text = Convert.ToString(d["TenLoaiPhieu"]);
                txtDiaChiNhan.Text = Convert.ToString(d["DiaChiNguoiNhan"]);
                txtKhuVuc.Text = Convert.ToString(d["TenKhuVuc"]);
                txtTongTienHang.Text = DinhDang.Tien(Convert.ToDecimal(d["TongTienHang"]));
                txtPhiGiaoHang.Text = DinhDang.Tien(Convert.ToDecimal(d["PhiGiaoHang"]));
                txtTongGiaTri.Text = DinhDang.Tien(Convert.ToDecimal(d["TongGiaTri"]));
                dgvChiTietDonHang.DataSource = donSv.LayChiTietDonHang(maDonHang);
                TaiTrangThaiEmail();
            }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); return; }

            if (maEmail != null && txtTrangThai.Text != "DaGui") tmrEmail.Start();
        }

        private void TaiTrangThaiEmail()
        {
            DataTable nk = donSv.LayNhatKyEmail(maDonHang);
            if (nk.Rows.Count == 0)                      // khách không cung cấp email
            {
                maEmail = null;
                txtEmailNhan.Text = "(Khách không cung cấp email)";
                txtTrangThai.Text = "";
                btnGuiLaiEmail.Enabled = false;
                return;
            }
            DataRow r = nk.Rows[0];
            maEmail = Convert.ToString(r["MaEmail"]);
            txtEmailNhan.Text = Convert.ToString(r["EmailNhan"]);
            txtTrangThai.Text = Convert.ToString(r["TrangThai"]);
            btnGuiLaiEmail.Enabled = txtTrangThai.Text != "DaGui";
        }

        // Email gửi ở luồng nền: kiểm tra định kỳ để cập nhật trạng thái (tối đa ~1 phút)
        private void tmrEmail_Tick(object sender, EventArgs e)
        {
            soLanKiemTra++;
            try { TaiTrangThaiEmail(); } catch (Exception) { tmrEmail.Stop(); return; }
            if (txtTrangThai.Text == "DaGui" || txtTrangThai.Text == "Loi" || soLanKiemTra >= 30) tmrEmail.Stop();
        }

        private void btnGuiLaiEmail_Click(object sender, EventArgs e)
        {
            if (maEmail == null) return;
            KetQuaXuLy kq = emailSv.GuiLai(maEmail);
            ThongBao.Hien(kq);
            if (kq.ThanhCong)
            {
                soLanKiemTra = 0;
                tmrEmail.Start();
                TaiTrangThaiEmail();
            }
        }

        private void btnTiepTucMua_Click(object sender, EventArgs e)
        {
            DieuHuong.Den(this, DieuHuong.SanPham);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmXacNhanDonHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrEmail.Stop();
            tmrEmail.Dispose();
        }
    }
}
