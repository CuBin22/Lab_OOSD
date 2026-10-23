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
    public partial class FrmSanPham : Form
    {
        private readonly SanPhamService sanPhamSv = new SanPhamService();
        private readonly GioHangService gioSv = new GioHangService();

        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            DieuHuong.GanLienKet(this);
            LuoiDuLieu.CauHinh(dgvSanPham, true);
            LuoiDuLieu.DinhDangTien(dgvSanPham, "colGiaBan");
            txtKhachHang.ReadOnly = true;
            nudSoLuong.Minimum = 1;
            nudSoLuong.Maximum = GioHangService.SoLuongToiDa;
            nudSoLuong.Value = 1;
            try
            {
                cboNhomSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
                cboNhomSanPham.DisplayMember = "TenNhom";
                cboNhomSanPham.ValueMember = "MaNhom";
                cboNhomSanPham.DataSource = sanPhamSv.LayNhomSanPham();
                TaiSanPham();
            }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); }
            CapNhatKhach();
        }

        // Cập nhật tên khách mỗi khi quay lại form chính (sau đăng nhập/đăng xuất ở form con)
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            if (txtKhachHang != null) CapNhatKhach();
        }

        private void CapNhatKhach()
        {
            txtKhachHang.Text = PhienLamViec.DaDangNhap ? PhienLamViec.KhachHangHienTai.HoTen : "(Chưa đăng nhập)";
        }

        private void TaiSanPham()
        {
            string maNhom = Convert.ToString(cboNhomSanPham.SelectedValue);
            if (string.IsNullOrEmpty(maNhom)) { dgvSanPham.DataSource = null; return; }
            dgvSanPham.DataSource = sanPhamSv.LaySanPhamTheoNhom(maNhom);
        }

        private string MaSanPhamDangChon()
        {
            DataRowView r = dgvSanPham.CurrentRow == null ? null : dgvSanPham.CurrentRow.DataBoundItem as DataRowView;
            return r == null ? null : Convert.ToString(r["MaSanPham"]);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try { TaiSanPham(); }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            string ma = MaSanPhamDangChon();
            if (ma == null) { ThongBao.Canh("Vui lòng chọn một sản phẩm trong danh sách."); return; }
            using (FrmChiTietSanPham f = new FrmChiTietSanPham(ma)) f.ShowDialog(this);
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnXemChiTiet_Click(sender, EventArgs.Empty);
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            string ma = MaSanPhamDangChon();
            if (ma == null) { ThongBao.Canh("Vui lòng chọn một sản phẩm trong danh sách."); return; }
            ThongBao.Hien(gioSv.ThemSanPham(ma, (int)nudSoLuong.Value));
        }

        private void btnXemGioHang_Click(object sender, EventArgs e)
        {
            using (FrmGioHang f = new FrmGioHang()) f.ShowDialog(this);
        }
    }
}
