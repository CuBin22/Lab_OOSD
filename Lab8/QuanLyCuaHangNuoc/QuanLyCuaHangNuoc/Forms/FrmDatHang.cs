using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNuoc.Services;

namespace QuanLyCuaHangNuoc.Forms
{
    public partial class FrmDatHang : Form
    {
        readonly DatHangService sv = new DatHangService();
        readonly DanhMucService dm = new DanhMucService();
        readonly BindingList<DongHang> chon = new BindingList<DongHang>();
        bool dangNap = false;
        string dangSua = null;      // số đơn đang sửa (null = đang lập đơn mới)

        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            foreach (DataGridView g in new[] { dgvNGK, dgvChon, dgvDon, dgvCT }) Ui.StyleGrid(g);
            dangNap = true;
            Ui.BindCombo(cboNCC, sv.LayNCC(), "TenNCC", "MaNCC");
            Ui.BindCombo(cboNV, dm.LayNVCombo(), "HienThi", "MaNV");
            dangNap = false;
            dgvChon.DataSource = chon;
            DinhDangChon();
            dtTu.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtDen.Value = new DateTime(DateTime.Today.Year, 12, 31);
            LamMoi();
            TaiHang();
            TaiDon();
        }

        void DinhDangChon()
        {
            Ui.Bind(dgvChon, chon, "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT", "SoLuong|SL đặt|N0");
        }

        void LamMoi()
        {
            dangSua = null;
            txtSoDDH.Text = sv.MaMoi();
            chon.Clear();
            cboNCC.Enabled = true;
            dtNgayDat.Value = DateTime.Today;
            dtNgayNhan.Value = DateTime.Today.AddDays(7);
            numSL.Value = 1;
            btnLuuDon.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoaDon.Enabled = false;
        }

        void TaiHang()
        {
            string ncc = Ui.V(cboNCC);
            if (ncc == "") { dgvNGK.DataSource = null; return; }
            Ui.Bind(dgvNGK, sv.LayHangTheoNCC(ncc), "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT");
        }

        void TaiDon()
        {
            if (dtDen.Value.Date < dtTu.Value.Date) { Ui.Chon("Đến ngày không được trước từ ngày."); return; }
            Ui.Bind(dgvDon, sv.LayDon(txtTim.Text, dtTu.Value, dtDen.Value),
                "SoDDH|Số đơn", "MaNCC|-", "TenNCC|Nhà cung ứng", "MaNV|-", "NhanVien|NV lập", "NgayDat|Ngày đặt|dd/MM/yyyy",
                "NgayNhanDuKien|Ngày nhận DK|dd/MM/yyyy", "SoDotGiao|Số đợt đã giao");
            dgvCT.DataSource = null;
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            TaiHang();
            if (dangSua == null) chon.Clear();   // mặt hàng của NCC cũ không còn hợp lệ
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (dgvNGK.CurrentRow == null) { Ui.Chon("Hãy chọn mặt hàng cần đặt."); return; }
            string ma = Ui.Cell(dgvNGK.CurrentRow, "MaNGK");
            foreach (DongHang x in chon)
                if (x.MaNGK == ma) { x.SoLuong += (int)numSL.Value; chon.ResetBindings(); return; }
            chon.Add(new DongHang
            {
                MaNGK = ma,
                TenNGK = Ui.Cell(dgvNGK.CurrentRow, "TenNGK"),
                DonViTinh = Ui.Cell(dgvNGK.CurrentRow, "DonViTinh"),
                SoLuong = (int)numSL.Value
            });
        }

        private void btnBoMH_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow == null || dgvChon.CurrentRow.Index >= chon.Count) return;
            chon.RemoveAt(dgvChon.CurrentRow.Index);
        }

        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = sv.LapDon(txtSoDDH.Text, Ui.V(cboNCC), Ui.V(cboNV), dtNgayDat.Value, dtNgayNhan.Value, new System.Collections.Generic.List<DongHang>(chon));
            Ui.Show(k);
            if (k.ThanhCong) { LamMoi(); TaiDon(); }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dangSua == null) { Ui.Chon("Hãy chọn một đơn trong danh sách để cập nhật."); return; }
            KetQuaXuLy k = sv.CapNhatDon(dangSua, Ui.V(cboNV), dtNgayDat.Value, dtNgayNhan.Value, new System.Collections.Generic.List<DongHang>(chon));
            Ui.Show(k);
            if (k.ThanhCong) { LamMoi(); TaiDon(); }
        }

        private void btnXoaDon_Click(object sender, EventArgs e)
        {
            if (dangSua == null) { Ui.Chon("Hãy chọn một đơn trong danh sách để xóa."); return; }
            if (!Ui.XacNhan("Xóa đơn đặt hàng " + dangSua + "?")) return;
            KetQuaXuLy k = sv.XoaDon(dangSua);
            Ui.Show(k);
            if (k.ThanhCong) { LamMoi(); TaiDon(); }
        }

        private void btnMoi_Click(object sender, EventArgs e) { LamMoi(); TaiHang(); }

        private void btnTim_Click(object sender, EventArgs e) { TaiDon(); }

        private void dgvDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvDon.Rows[e.RowIndex];
            string so = Ui.Cell(r, "SoDDH");
            Ui.Bind(dgvCT, sv.LayChiTiet(so), "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT", "SoLuongDat|SL đặt|N0");

            // nạp đơn lên vùng nhập để sửa/xóa
            dangNap = true;
            dangSua = so;
            txtSoDDH.Text = so;
            cboNCC.SelectedValue = Ui.Cell(r, "MaNCC");
            cboNV.SelectedValue = Ui.Cell(r, "MaNV");
            dtNgayDat.Value = Convert.ToDateTime(r.Cells["NgayDat"].Value);
            dtNgayNhan.Value = Convert.ToDateTime(r.Cells["NgayNhanDuKien"].Value);
            dangNap = false;
            cboNCC.Enabled = false;
            TaiHang();
            chon.Clear();
            foreach (DataRow d in sv.LayChiTiet(so).Rows)
                chon.Add(new DongHang { MaNGK = Convert.ToString(d["MaNGK"]), TenNGK = Convert.ToString(d["TenNGK"]),
                                        DonViTinh = Convert.ToString(d["DonViTinh"]), SoLuong = Convert.ToInt32(d["SoLuongDat"]) });
            bool daGiao = Convert.ToInt32(r.Cells["SoDotGiao"].Value) > 0;
            btnLuuDon.Enabled = false;
            btnCapNhat.Enabled = !daGiao;     // đã có phiếu giao thì không sửa/xóa
            btnXoaDon.Enabled = !daGiao;
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}
