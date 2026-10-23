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
    public partial class FrmQuyetDinh : Form
    {
        readonly QuyetDinhService s = new QuyetDinhService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmQuyetDinh()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            Tai();
        }

        void Tai()
        {
            dgvCV.DataSource = s.LayChucVu();
            UiHelper.DatTieuDe(dgvCV, "Số QĐ", "Nhân viên", "Chức vụ", "Phụ cấp chức vụ", "Ngày hiệu lực", "Người ký");
            dgvL.DataSource = s.LayLuong();
            UiHelper.DatTieuDe(dgvL, "Số QĐ", "Nhân viên", "Lương cơ bản", "Phụ cấp lương", "Phụ cấp độc hại", "Ngày hiệu lực");
            // Chỉ nhân viên đã ký hợp đồng chính thức mới được ra quyết định.
            UiHelper.NapCombo(cboCVNhanVien, s.LayNhanVienChinhThuc(), "HoTen", "MaNV");
            UiHelper.NapCombo(cboLNhanVien, s.LayNhanVienChinhThuc(), "HoTen", "MaNV");
            UiHelper.NapCombo(cboCVNguoiKy, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
            UiHelper.NapCombo(cboLNguoiKy, dm.LayNhanVienCombo(null, null), "HoTen", "MaNV");
        }

        private void btnLapCV_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapChucVu(txtSoQDCV.Text.Trim(), UiHelper.Gt(cboCVNhanVien), txtCVChucVu.Text.Trim(),
                numCVPhuCap.Value, dtCVHieuLuc.Value, UiHelper.Gt(cboCVNguoiKy));
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoiCV_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiCV_Click(object sender, EventArgs e)
        {
            txtSoQDCV.Clear();
            txtCVChucVu.Clear();
            numCVPhuCap.Value = numCVPhuCap.Minimum;
            dtCVHieuLuc.Value = DateTime.Today;
        }

        private void btnLapL_Click(object sender, EventArgs e)
        {
            KetQuaXuLy k = s.LapLuong(txtSoQDL.Text.Trim(), UiHelper.Gt(cboLNhanVien), numLCoBan.Value, numLPhuCap.Value,
                numLDocHai.Value, dtLHieuLuc.Value, UiHelper.Gt(cboLNguoiKy));
            if (UiHelper.ThongBao(k))
            {
                Tai();
                btnLamMoiL_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiL_Click(object sender, EventArgs e)
        {
            txtSoQDL.Clear();
            numLCoBan.Value = numLCoBan.Minimum;
            numLPhuCap.Value = numLPhuCap.Minimum;
            numLDocHai.Value = numLDocHai.Minimum;
            dtLHieuLuc.Value = DateTime.Today;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
