using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNuoc.Services;

namespace QuanLyCuaHangNuoc.Forms
{
    public partial class FrmHenNo : Form
    {
        readonly HenNoService sv = new HenNoService();
        readonly DanhMucService dm = new DanhMucService();
        bool dangNap = false;

        public FrmHenNo()
        {
            InitializeComponent();
        }

        private void FrmHenNo_Load(object sender, EventArgs e)
        {
            foreach (DataGridView g in new[] { dgvHen, dgvCTHen, dgvNo }) Ui.StyleGrid(g);
            cboTT.Items.AddRange(new object[] { "Tất cả", HenNoService.ChuaGiao, HenNoService.DaGiao });
            cboTT.SelectedIndex = 1;
            dtNgayHen.Value = DateTime.Today.AddDays(1);
            dtNgayTach.Value = DateTime.Today.AddDays(2);

            dangNap = true;
            Ui.BindCombo(cboNVNo, dm.LayNVCombo(), "HienThi", "MaNV");
            dangNap = false;
            NapHoaDonNo();
            MoiNo();
            TaiHen();
            TaiNo();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }

        // ======================= Phiếu hẹn =======================
        void TaiHen()
        {
            string tt = cboTT.SelectedIndex <= 0 ? "" : cboTT.Text;
            Ui.Bind(dgvHen, sv.LayPhieuHen(tt), "SoPhieuHen|Số phiếu hẹn", "SoHD|Số HD", "HoTen|Khách hàng",
                "NgayHen|Ngày hẹn|dd/MM/yyyy", "TrangThai|Trạng thái", "TinhTrangHD|Tình trạng hóa đơn");
            NapChiTietHen();
        }

        void NapChiTietHen()
        {
            if (dgvHen.CurrentRow == null) { dgvCTHen.DataSource = null; return; }
            Ui.Bind(dgvCTHen, sv.LayChiTietHen(Ui.Cell(dgvHen.CurrentRow, "SoPhieuHen")),
                "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT", "SoLuongHen|SL hẹn|N0", "SoLuongTon|Tồn kho|N0");
        }

        private void btnLoc_Click(object sender, EventArgs e) { TaiHen(); }

        private void dgvHen_SelectionChanged(object sender, EventArgs e) { NapChiTietHen(); }

        string PhieuHenChon()
        {
            if (dgvHen.CurrentRow == null) { Ui.Chon("Hãy chọn một phiếu hẹn."); return ""; }
            return Ui.Cell(dgvHen.CurrentRow, "SoPhieuHen");
        }

        private void btnDoiNgay_Click(object sender, EventArgs e)
        {
            string so = PhieuHenChon(); if (so == "") return;
            KetQuaXuLy k = sv.DoiNgayHen(so, dtNgayHen.Value);
            Ui.Show(k);
            if (k.ThanhCong) TaiHen();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            string so = PhieuHenChon(); if (so == "") return;
            if (dgvCTHen.CurrentRow == null) { Ui.Chon("Hãy chọn mặt hàng trong chi tiết phiếu hẹn để tách đợt."); return; }
            KetQuaXuLy k = sv.TachDot(so, Ui.Cell(dgvCTHen.CurrentRow, "MaNGK"), (int)numTach.Value, dtNgayTach.Value);
            Ui.Show(k);
            if (k.ThanhCong) TaiHen();
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            string so = PhieuHenChon(); if (so == "") return;
            if (!Ui.XacNhan("Xác nhận đã giao hàng theo phiếu hẹn " + so + "? Tồn kho sẽ bị trừ.")) return;
            KetQuaXuLy k = sv.XacNhanGiao(so);
            Ui.Show(k);
            if (k.ThanhCong) TaiHen();
        }

        // ======================= Phiếu ghi nợ =======================
        void NapHoaDonNo()
        {
            dangNap = true;
            Ui.BindCombo(cboHDNo, sv.LayHoaDonKhachQuen(), "HienThi", "SoHD");
            dangNap = false;
            HienThongTinHD();
        }

        void HienThongTinHD()
        {
            string so = Ui.V(cboHDNo);
            if (so == "") { lblThongTinHD.Text = "Chưa có hóa đơn của khách quen."; return; }
            DataTable t = sv.LayThongTinHD(so);
            if (t.Rows.Count == 0) return;
            DataRow r = t.Rows[0];
            decimal conLai = Convert.ToDecimal(r["ConLai"]);
            lblThongTinHD.Text = "Khách: " + r["HoTen"] + "   |   Tổng tiền: " + Convert.ToDecimal(r["TongTien"]).ToString("N0")
                + " đ   |   Đã ghi nợ: " + Convert.ToDecimal(r["DaGhiNo"]).ToString("N0") + " đ   |   Còn có thể ghi nợ: " + conLai.ToString("N0") + " đ";
            numNo.Value = Math.Min(Math.Max(conLai, 0), numNo.Maximum);
        }

        private void cboHDNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            HienThongTinHD();
        }

        void MoiNo()
        {
            txtSoNo.Text = sv.MaNoMoi();
            txtLyDo.Clear();
            dtNgayLapNo.Value = DateTime.Today;
            dtDuKien.Value = DateTime.Today.AddDays(30);
        }

        void TaiNo()
        {
            Ui.Bind(dgvNo, sv.LayGhiNo(txtTimNo.Text), "SoPhieuNo|Số phiếu nợ", "SoHD|Số HD", "HoTen|Khách hàng", "NhanVien|NV lập",
                "NgayLap|Ngày lập|dd/MM/yyyy", "SoTienNo|Số tiền nợ|N0", "NgayDuKienTra|Ngày dự kiến trả|dd/MM/yyyy", "LyDo|Lý do nợ");
        }

        private void btnLapNo_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = sv.LapGhiNo(txtSoNo.Text, Ui.V(cboHDNo), Ui.V(cboNVNo), dtNgayLapNo.Value, numNo.Value, dtDuKien.Value, txtLyDo.Text);
            Ui.Show(k);
            if (k.ThanhCong) { MoiNo(); HienThongTinHD(); TaiNo(); }
        }

        private void btnMoiNo_Click(object sender, EventArgs e) { MoiNo(); HienThongTinHD(); }

        private void btnTimNo_Click(object sender, EventArgs e) { TaiNo(); }
    }
}
