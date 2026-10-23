using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChamCong : Form
    {
        readonly ChamCongService s = new ChamCongService();
        readonly DanhMucService dm = new DanhMucService();
        readonly BindingList<PhanCongItem> pcChon = new BindingList<PhanCongItem>();
        readonly BindingList<NhanVienItem> ptChon = new BindingList<NhanVienItem>();

        public FrmChamCong()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            // Tuần hiện tại: từ thứ Hai đến Chủ nhật.
            int lui = ((int)DateTime.Today.DayOfWeek + 6) % 7;
            dtKHTuNgay.Value = DateTime.Today.AddDays(-lui);
            dtKHDenNgay.Value = DateTime.Today.AddDays(6 - lui);
            dtPCNgay.Value = dtKHTuNgay.Value;
            cboPCCa.SelectedIndex = 0;
            cboCCCa.SelectedIndex = 0;
            cboPTHinhThuc.SelectedIndex = 0;

            dgvPCChon.DataSource = pcChon;
            dgvPTChon.DataSource = ptChon;
            UiHelper.DatTieuDe(dgvPCChon, "Nhân viên", "Ngày", "Ca", "Phụ trội");
            UiHelper.DatTieuDe(dgvPTChon, "Mã NV", "Họ tên");

            // Người lập kế hoạch: trưởng phòng/ban/phân xưởng. Người chấm công, lập phiếu phụ trội: ban chấm công.
            UiHelper.NapCombo(cboKHNguoiLap, dm.LayNhanVienCombo("Trưởng%", null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboCCNguoiLap, dm.LayNhanVienCombo("Ban chấm công", null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboPTNguoiLap, dm.LayNhanVienCombo("Ban chấm công", null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboCCNhanVien, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboPTNhanVien, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");

            cboKHPhongBan.SelectedIndexChanged += cboKHPhongBan_SelectedIndexChanged;
            UiHelper.NapCombo(cboKHPhongBan, dm.LayPhongBan(), "TenPhongBan", "MaPhongBan");
            Tai();
        }

        void Tai()
        {
            dgvKH.DataSource = s.LayKeHoach();
            UiHelper.DatTieuDe(dgvKH, "Số KH", "Người lập", "Phòng/Ban", "Từ ngày", "Đến ngày");
            dgvCC.DataSource = s.LayChamCong();
            UiHelper.DatTieuDe(dgvCC, "Số phiếu", "Nhân viên", "Ngày công", "Ca", "Số giờ làm", "Người lập", "Ghi chú");
            dgvPT.DataSource = s.LayPhieuPhuTroi();
            UiHelper.DatTieuDe(dgvPT, "Số phiếu", "Ngày", "Số giờ", "Hình thức", "Hệ số", "Người lập");
        }

        // Đổi phòng/ban -> chỉ phân công nhân viên thuộc phòng/ban đó; xóa danh sách đang chọn.
        private void cboKHPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pb = UiHelper.Gt(cboKHPhongBan);
            UiHelper.NapCombo(cboPCNhanVien, dm.LayNhanVienCombo(null, pb == "" ? "-" : pb), "HoTen", "MaNV");
            pcChon.Clear();
        }

        // ---------------------------------------------------------------- Phân công
        private void btnThemPC_Click(object sender, EventArgs e)
        {
            if (UiHelper.Gt(cboPCNhanVien) == "") { MessageBox.Show("Chưa chọn nhân viên."); return; }
            if (dtKHDenNgay.Value.Date < dtKHTuNgay.Value.Date) { MessageBox.Show("Đến ngày không được trước từ ngày."); return; }
            DateTime ngay = dtPCNgay.Value.Date;
            if (ngay < dtKHTuNgay.Value.Date || ngay > dtKHDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày làm việc phải nằm trong tuần của kế hoạch.");
                return;
            }
            string ma = UiHelper.Gt(cboPCNhanVien);
            foreach (PhanCongItem x in pcChon)
                if (x.MaNV == ma && x.Ngay == ngay && x.Ca == cboPCCa.Text)
                {
                    MessageBox.Show("Nhân viên đã được phân công ca này trong ngày.");
                    return;
                }
            pcChon.Add(new PhanCongItem
            {
                MaNV = ma,
                HoTen = cboPCNhanVien.Text,
                Ngay = ngay,
                Ca = cboPCCa.Text,
                PhuTroi = chkPCPhuTroi.Checked
            });
        }

        private void btnBoPC_Click(object sender, EventArgs e)
        {
            if (dgvPCChon.CurrentRow != null && dgvPCChon.CurrentRow.Index >= 0 && dgvPCChon.CurrentRow.Index < pcChon.Count)
                pcChon.RemoveAt(dgvPCChon.CurrentRow.Index);
        }

        private void btnLapKH_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapKeHoach(txtSoKH.Text.Trim(), UiHelper.Gt(cboKHNguoiLap), UiHelper.Gt(cboKHPhongBan),
                dtKHTuNgay.Value, dtKHDenNgay.Value, new List<PhanCongItem>(pcChon));
            if (UiHelper.ThongBao(k))
            {
                pcChon.Clear();
                txtSoKH.Clear();
                Tai();
            }
        }

        // ---------------------------------------------------------------- Chấm công
        private void btnLapCC_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapPhieuChamCong(txtSoCC.Text.Trim(), UiHelper.Gt(cboCCNhanVien), UiHelper.Gt(cboCCNguoiLap),
                dtCCNgay.Value, cboCCCa.Text, numCCSoGio.Value, txtCCGhiChu.Text.Trim());
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoiCC_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiCC_Click(object sender, EventArgs e)
        {
            txtSoCC.Clear();
            txtCCGhiChu.Clear();
            numCCSoGio.Value = numCCSoGio.Minimum;
            dtCCNgay.Value = DateTime.Today;
        }

        // ---------------------------------------------------------------- Phụ trội
        private void btnThemPTNV_Click(object sender, EventArgs e)
        {
            string ma = UiHelper.Gt(cboPTNhanVien);
            if (ma == "") { MessageBox.Show("Chưa chọn nhân viên."); return; }
            foreach (NhanVienItem x in ptChon)
                if (x.MaNV == ma) { MessageBox.Show("Nhân viên đã có trong phiếu phụ trội."); return; }
            ptChon.Add(new NhanVienItem { MaNV = ma, HoTen = cboPTNhanVien.Text });
        }

        private void btnBoPTNV_Click(object sender, EventArgs e)
        {
            if (dgvPTChon.CurrentRow != null && dgvPTChon.CurrentRow.Index >= 0 && dgvPTChon.CurrentRow.Index < ptChon.Count)
                ptChon.RemoveAt(dgvPTChon.CurrentRow.Index);
        }

        private void btnLapPT_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapPhieuPhuTroi(txtSoPT.Text.Trim(), dtPTNgay.Value, numPTSoGio.Value, cboPTHinhThuc.Text,
                UiHelper.Gt(cboPTNguoiLap), new List<NhanVienItem>(ptChon));
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoiPT_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiPT_Click(object sender, EventArgs e)
        {
            txtSoPT.Clear();
            numPTSoGio.Value = numPTSoGio.Minimum;
            dtPTNgay.Value = DateTime.Today;
            ptChon.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
