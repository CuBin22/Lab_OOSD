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
    public partial class FrmTuyenDung : Form
    {
        readonly TuyenDungService s = new TuyenDungService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmTuyenDung()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            dtKetThucThuViec.Value = DateTime.Today.AddMonths(2);
            UiHelper.NapCombo(cboPhongBan, dm.LayPhongBan(), "TenPhongBan", "MaPhongBan");
            UiHelper.NapCombo(cboNguoiKy, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            Tai();
        }

        void Tai()
        {
            dgvQDTD.DataSource = s.LayQuyetDinh();
            UiHelper.DatTieuDe(dgvQDTD, "Số QĐ", "Nhân viên", "Phòng ban", "Ngày ký", "Thử việc từ", "Thử việc đến", "Lương thử việc");
            UiHelper.An(dgvQDTD, "DieuKhoan");
            UiHelper.NapCombo(cboNhanVien, s.LayNhanVienChuaTuyenDung(), "HoTen", "MaNV");
        }

        private void btnLapQD_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.ThemQuyetDinh(txtSoQDTD.Text.Trim(), UiHelper.Gt(cboNhanVien), UiHelper.Gt(cboPhongBan),
                dtNgayKy.Value, dtBatDauThuViec.Value, dtKetThucThuViec.Value, numLuongThuViec.Value,
                txtDieuKhoan.Text.Trim(), UiHelper.Gt(cboNguoiKy));
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoi_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSoQDTD.Clear();
            txtDieuKhoan.Clear();
            numLuongThuViec.Value = numLuongThuViec.Minimum;
            dtNgayKy.Value = DateTime.Today;
            dtBatDauThuViec.Value = DateTime.Today;
            dtKetThucThuViec.Value = DateTime.Today.AddMonths(2);
        }

        // Chọn một quyết định trong lưới -> xem lại điều khoản hai bên.
        private void dgvQDTD_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvQDTD.Focused || dgvQDTD.CurrentRow == null) return;
            txtDieuKhoan.Text = UiHelper.GtO(dgvQDTD.CurrentRow, "DieuKhoan");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
