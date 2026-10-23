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
    public partial class FrmGioHang : Form
    {
        private readonly GioHangService service = new GioHangService();
        private DataTable gio;
        private string maGio;

        public FrmGioHang()
        {
            InitializeComponent();
        }

        private void FrmGioHang_Load(object sender, EventArgs e)
        {
            DieuHuong.GanLienKet(this);
            LuoiDuLieu.CauHinh(dgvGioHang, false);
            foreach (DataGridViewColumn c in dgvGioHang.Columns) c.ReadOnly = c.Name != "colSoLuong";   // chỉ sửa được Số lượng
            LuoiDuLieu.DinhDangTien(dgvGioHang, "colDonGia", "colThanhTien");
            LuoiDuLieu.CanPhai(dgvGioHang, "colSoLuong");
            txtMaGioHang.ReadOnly = true;
            txtKhachHang.ReadOnly = true;
            dtpNgayTao.Enabled = false;
            txtTongTamTinh.ReadOnly = true;
            txtKhachHang.Text = PhienLamViec.DaDangNhap ? PhienLamViec.KhachHangHienTai.HoTen : "(Chưa đăng nhập)";
            TaiGio();
        }

        private void TaiGio()
        {
            try
            {
                maGio = service.LayMaGioHienTai(false);
                gio = service.LayChiTietGio(maGio);          // giá luôn là giá hiện hành (BR04)
                dgvGioHang.DataSource = gio;
                txtMaGioHang.Text = maGio ?? "(chưa có)";
                DateTime? ngay = service.LayNgayTao(maGio);
                dtpNgayTao.Value = ngay.HasValue ? ngay.Value : DateTime.Now;
                CapNhatTong();
            }
            catch (Exception ex) { ThongBao.LoiHeThong(ex); }
        }

        private void CapNhatTong()
        {
            txtTongTamTinh.Text = DinhDang.Tien(GioHangService.TongTamTinh(gio));
        }

        private void ShowResult(KetQuaXuLy kq)
        {
            ThongBao.Hien(kq);
            if (kq.ThanhCong) TaiGio();
        }

        private string MaChiTietDangChon()
        {
            DataRowView r = dgvGioHang.CurrentRow == null ? null : dgvGioHang.CurrentRow.DataBoundItem as DataRowView;
            return r == null ? null : Convert.ToString(r["MaChiTiet"]);
        }

        // Tính lại thành tiền và tổng ngay khi sửa số lượng
        private void dgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvGioHang.Columns[e.ColumnIndex].Name != "colSoLuong") return;
            DataRowView r = dgvGioHang.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (r == null) return;
            r.EndEdit();
            int sl = Convert.ToInt32(r["SoLuong"]);
            if (sl < 1 || sl > GioHangService.SoLuongToiDa)
            {
                ThongBao.Canh("Số lượng phải là số nguyên từ 1 đến " + GioHangService.SoLuongToiDa + ".");
                r["SoLuong"] = r.Row["SoLuong", DataRowVersion.Original];
                sl = Convert.ToInt32(r["SoLuong"]);
            }
            r["ThanhTien"] = sl * Convert.ToDecimal(r["DonGia"]);
            CapNhatTong();
        }

        private void dgvGioHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ThongBao.Canh("Số lượng phải là số nguyên từ 1 đến " + GioHangService.SoLuongToiDa + ".");
            e.ThrowException = false;
            dgvGioHang.CancelEdit();
        }

        private Dictionary<string, int> LaySoLuongThayDoi()
        {
            dgvGioHang.EndEdit();
            Dictionary<string, int> kq = new Dictionary<string, int>();
            if (gio == null) return kq;
            foreach (DataRow r in gio.Rows)
            {
                if (r.RowState != DataRowState.Modified) continue;
                int moi = Convert.ToInt32(r["SoLuong"]);
                int cu = Convert.ToInt32(r["SoLuong", DataRowVersion.Original]);
                if (moi != cu) kq[Convert.ToString(r["MaChiTiet"])] = moi;
            }
            return kq;
        }

        private void btnCapNhatSoLuong_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> doi = LaySoLuongThayDoi();
            if (doi.Count == 0) { ThongBao.Canh("Chưa có số lượng nào thay đổi."); return; }
            ShowResult(service.CapNhatSoLuong(doi));
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            string ma = MaChiTietDangChon();
            if (ma == null) { ThongBao.Canh("Vui lòng chọn sản phẩm cần xóa."); return; }
            if (ThongBao.XacNhan("Xóa sản phẩm đang chọn khỏi giỏ hàng?"))
                ShowResult(service.XoaSanPham(ma));
        }

        private void btnTiepTucMua_Click(object sender, EventArgs e)
        {
            DieuHuong.Den(this, DieuHuong.SanPham);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (gio == null || gio.Rows.Count == 0) { ThongBao.Canh("Giỏ hàng đang trống."); return; }

            Dictionary<string, int> doi = LaySoLuongThayDoi();
            if (doi.Count > 0)
            {
                if (!ThongBao.XacNhan("Bạn đã sửa số lượng nhưng chưa cập nhật. Cập nhật ngay và tiếp tục tính tiền?")) return;
                KetQuaXuLy cn = service.CapNhatSoLuong(doi);
                if (!cn.ThanhCong) { ThongBao.Hien(cn); return; }
                TaiGio();
            }

            DieuHuong.MoDatHang(this);       // kiểm tra giỏ + yêu cầu đăng nhập + mở frmDatHang
            TaiGio();                        // đặt xong thì giỏ đã trống
            txtKhachHang.Text = PhienLamViec.DaDangNhap ? PhienLamViec.KhachHangHienTai.HoTen : "(Chưa đăng nhập)";
        }
    }
}
