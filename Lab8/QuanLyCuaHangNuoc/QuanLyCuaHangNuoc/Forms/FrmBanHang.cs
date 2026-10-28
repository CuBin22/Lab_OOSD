using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyCuaHangNuoc.Services;

namespace QuanLyCuaHangNuoc.Forms
{
    public partial class FrmBanHang : Form
    {
        readonly BanHangService sv = new BanHangService();
        readonly DanhMucService dm = new DanhMucService();
        readonly BindingList<DongBan> gio = new BindingList<DongBan>();
        bool dangNap = false;
        bool khachQuen = false;

        public FrmBanHang()
        {
            InitializeComponent();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            foreach (DataGridView g in new[] { dgvHang, dgvGio, dgvHD }) Ui.StyleGrid(g);
            dangNap = true;
            Ui.BindCombo(cboKH, sv.LayKhach(), "HienThi", "MaKH");
            Ui.BindCombo(cboNV, dm.LayNVCombo(), "HienThi", "MaNV");
            dangNap = false;
            dgvGio.DataSource = gio;
            DinhDangGio();
            dtNgayHen.Value = DateTime.Today.AddDays(3);
            dtDuKienTra.Value = DateTime.Today.AddDays(30);
            CapNhatKhach();
            TaiHang();
            TaiHoaDon();
            LamMoi();
        }

        void DinhDangGio()
        {
            Ui.Bind(dgvGio, gio, "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT", "DonGia|Đơn giá|N0", "SoLuong|SL mua|N0",
                "SoLuongTon|Tồn kho|N0", "ThanhTien|Thành tiền|N0", "TinhTrang|Tình trạng");
        }

        void TaiHang()
        {
            Ui.Bind(dgvHang, sv.LayHang(txtTimHang.Text), "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT",
                "DonGia|Đơn giá|N0", "SoLuongTon|Tồn kho|N0");
        }

        void TaiHoaDon()
        {
            Ui.Bind(dgvHD, sv.LayHoaDonGanDay(), "SoHD|Số HD", "HoTen|Khách hàng", "LoaiKhach|Loại khách", "NhanVien|NV lập",
                "NgayLap|Ngày lập|dd/MM/yyyy HH:mm", "TongTien|Tổng tiền|N0", "TinhTrangGiao|Tình trạng giao");
        }

        void LamMoi()
        {
            gio.Clear();
            numSL.Value = 1;
            chkGhiNo.Checked = false;
            txtLyDo.Clear();
            numNo.Value = 0;
            lblTinhTrang.Text = "";
            CapNhatTong();
            CapNhatKhach();
        }

        /// <summary>Cập nhật loại khách và các ô phụ thuộc (hẹn giao, ghi nợ chỉ dành cho khách quen).</summary>
        void CapNhatKhach()
        {
            DataRowView r = cboKH.SelectedItem as DataRowView;
            string loai = r == null ? "" : Convert.ToString(r["LoaiKhach"]);
            khachQuen = loai == BanHangService.KhachQuen;
            lblLoaiKH.Text = "Loại khách: " + (loai == "" ? "-" : loai);
            dtNgayHen.Enabled = khachQuen;
            chkGhiNo.Enabled = khachQuen;
            if (!khachQuen) chkGhiNo.Checked = false;
            ChoPhepNo(chkGhiNo.Checked);
        }

        void ChoPhepNo(bool bat)
        {
            numNo.Enabled = bat; dtDuKienTra.Enabled = bat; txtLyDo.Enabled = bat;
            if (bat && numNo.Value == 0) numNo.Value = Math.Min(TinhTong(), numNo.Maximum);
        }

        decimal TinhTong()
        {
            decimal t = 0;
            foreach (DongBan x in gio) t += x.ThanhTien;
            return t;
        }

        void CapNhatTong()
        {
            lblTong.Text = "Tổng tiền: " + TinhTong().ToString("N0") + " đ";
            if (chkGhiNo.Checked) numNo.Value = Math.Min(TinhTong(), numNo.Maximum);
            HienTinhTrang();
        }

        /// <summary>Hiển thị kết quả kiểm tra tồn kho của giỏ hàng.</summary>
        void HienTinhTrang()
        {
            if (gio.Count == 0) { lblTinhTrang.Text = ""; return; }
            StringBuilder sb = new StringBuilder();
            foreach (DongBan x in gio)
                if (x.SoLuong > x.SoLuongTon) sb.Append(x.TenNGK + " (thiếu " + (x.SoLuong - x.SoLuongTon) + ");  ");
            if (sb.Length == 0)
            {
                lblTinhTrang.ForeColor = Color.FromArgb(0, 128, 0);
                lblTinhTrang.Text = "Đủ hàng trong kho - giao ngay và lập hóa đơn.";
            }
            else
            {
                lblTinhTrang.ForeColor = Color.FromArgb(180, 0, 0);
                lblTinhTrang.Text = "Thiếu hàng: " + sb + (khachQuen ? "\nKhách quen: phần thiếu sẽ được hẹn giao vào ngày hẹn bên dưới."
                                                                  : "\nKhách vãng lai phải nhận hàng ngay - hãy giảm số lượng.");
            }
        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            CapNhatKhach();
            HienTinhTrang();
        }

        private void btnTimHang_Click(object sender, EventArgs e) { TaiHang(); }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvHang.CurrentRow == null) { Ui.Chon("Hãy chọn mặt hàng khách muốn mua."); return; }
            DataGridViewRow r = dgvHang.CurrentRow;
            string ma = Ui.Cell(r, "MaNGK");
            int ton = Convert.ToInt32(r.Cells["SoLuongTon"].Value);
            foreach (DongBan x in gio)
                if (x.MaNGK == ma) { x.SoLuong += (int)numSL.Value; x.SoLuongTon = ton; gio.ResetBindings(); CapNhatTong(); return; }
            gio.Add(new DongBan
            {
                MaNGK = ma,
                TenNGK = Ui.Cell(r, "TenNGK"),
                DonViTinh = Ui.Cell(r, "DonViTinh"),
                DonGia = Convert.ToDecimal(r.Cells["DonGia"].Value),
                SoLuong = (int)numSL.Value,
                SoLuongTon = ton
            });
            CapNhatTong();
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            if (dgvGio.CurrentRow == null || dgvGio.CurrentRow.Index >= gio.Count) return;
            gio.RemoveAt(dgvGio.CurrentRow.Index);
            CapNhatTong();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (gio.Count == 0) { Ui.Chon("Giỏ hàng đang trống."); return; }
            sv.KiemTraTon(new List<DongBan>(gio));   // cập nhật tồn kho mới nhất vào từng dòng
            gio.ResetBindings();
            HienTinhTrang();
        }

        private void chkGhiNo_CheckedChanged(object sender, EventArgs e)
        {
            ChoPhepNo(chkGhiNo.Checked);
            if (!chkGhiNo.Checked) numNo.Value = 0;
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = sv.LapHoaDon(Ui.V(cboKH), Ui.V(cboNV), new List<DongBan>(gio), dtNgayHen.Value,
                chkGhiNo.Checked, numNo.Value, dtDuKienTra.Value, txtLyDo.Text);
            Ui.Show(k);
            if (k.ThanhCong)
            {
                LamMoi();
                TaiHang();
                TaiHoaDon();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e) { LamMoi(); }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}
