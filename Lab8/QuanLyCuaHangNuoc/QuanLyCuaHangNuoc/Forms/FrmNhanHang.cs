using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNuoc.Services;

namespace QuanLyCuaHangNuoc.Forms
{
    public partial class FrmNhanHang : Form
    {
        readonly NhanHangService sv = new NhanHangService();
        readonly BindingList<DongHang> giao = new BindingList<DongHang>();
        bool dangNap = false;

        public FrmNhanHang()
        {
            InitializeComponent();
        }

        private void FrmNhanHang_Load(object sender, EventArgs e)
        {
            foreach (DataGridView g in new[] { dgvTienDo, dgvGiao, dgvPhieu, dgvCTPhieu }) Ui.StyleGrid(g);
            dgvGiao.DataSource = giao;
            DinhDangGiao();
            NapDon(null);
        }

        void DinhDangGiao()
        {
            Ui.Bind(dgvGiao, giao, "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT", "SoLuong|SL giao|N0");
        }

        /// <summary>Nạp lại danh sách đơn (giữ lựa chọn) rồi nạp tiến độ nhận hàng.</summary>
        void NapDon(string giuLai)
        {
            dangNap = true;
            Ui.BindCombo(cboDDH, sv.LayDon(), "HienThi", "SoDDH");
            if (!string.IsNullOrEmpty(giuLai)) cboDDH.SelectedValue = giuLai;
            dangNap = false;
            NapTienDo();
        }

        void NapTienDo()
        {
            string so = Ui.V(cboDDH);
            giao.Clear();
            numTien.Value = 0;
            if (so == "")
            {
                dgvTienDo.DataSource = null; dgvPhieu.DataSource = null; dgvCTPhieu.DataSource = null;
                lblDot.Text = "Chưa có đơn đặt hàng";
                return;
            }
            Ui.Bind(dgvTienDo, sv.LayTienDo(so), "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT",
                "SoLuongDat|Đã đặt|N0", "DaGiao|Đã nhận|N0", "ConLai|Còn phải nhận|N0");
            Ui.Bind(dgvPhieu, sv.LayPhieu(so), "SoPhieuGiao|Số phiếu", "DotGiao|Đợt", "NgayGiao|Ngày giao|dd/MM/yyyy", "SoTienPhaiTra|Số tiền phải trả|N0");
            int dot = sv.SoDotDaGiao(so) + 1;
            if (dot > NhanHangService.ToiDaDot)
                lblDot.Text = "Đơn đã giao đủ " + NhanHangService.ToiDaDot + " đợt - không nhận thêm";
            else
                lblDot.Text = "Đợt giao tiếp theo: " + dot + "/" + NhanHangService.ToiDaDot;
            txtSoPG.Text = sv.MaMoi();
            dtNgayGiao.Value = DateTime.Today;
        }

        private void cboDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            NapTienDo();
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (dgvTienDo.CurrentRow == null) { Ui.Chon("Hãy chọn mặt hàng trong bảng tiến độ."); return; }
            string ma = Ui.Cell(dgvTienDo.CurrentRow, "MaNGK");
            int conLai = Convert.ToInt32(dgvTienDo.CurrentRow.Cells["ConLai"].Value);
            int daChon = 0;
            DongHang co = null;
            foreach (DongHang x in giao) if (x.MaNGK == ma) { co = x; daChon = x.SoLuong; }
            if (daChon + (int)numSL.Value > conLai)
            {
                Ui.Chon("Số lượng giao vượt số còn phải nhận (" + conLai + ") của mặt hàng này.");
                return;
            }
            if (co != null) { co.SoLuong += (int)numSL.Value; giao.ResetBindings(); return; }
            giao.Add(new DongHang
            {
                MaNGK = ma,
                TenNGK = Ui.Cell(dgvTienDo.CurrentRow, "TenNGK"),
                DonViTinh = Ui.Cell(dgvTienDo.CurrentRow, "DonViTinh"),
                SoLuong = (int)numSL.Value
            });
        }

        private void btnBoMH_Click(object sender, EventArgs e)
        {
            if (dgvGiao.CurrentRow == null || dgvGiao.CurrentRow.Index >= giao.Count) return;
            giao.RemoveAt(dgvGiao.CurrentRow.Index);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            string so = Ui.V(cboDDH);
            KetQuaXuLy k = sv.LapPhieu(txtSoPG.Text, so, dtNgayGiao.Value, numTien.Value, new List<DongHang>(giao));
            Ui.Show(k);
            if (k.ThanhCong) NapDon(so);
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null) { dgvCTPhieu.DataSource = null; return; }
            Ui.Bind(dgvCTPhieu, sv.LayChiTietPhieu(Ui.Cell(dgvPhieu.CurrentRow, "SoPhieuGiao")),
                "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "DonViTinh|ĐVT", "SoLuongGiao|SL giao|N0");
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}
