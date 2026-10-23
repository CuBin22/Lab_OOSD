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
    public partial class FrmBangLuong : Form
    {
        readonly BangLuongService s = new BangLuongService();
        readonly QuyetDinhService qd = new QuyetDinhService();
        BangLuongTinh daTinh;

        public FrmBangLuong()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            numBLThang.Value = DateTime.Today.Month;
            numBLNam.Value = DateTime.Today.Year;
            UiHelper.NapCombo(cboBLNhanVien, qd.LayNhanVienChinhThuc(), "HoTen", "MaNV");
            Tai();
        }

        void Tai()
        {
            dgvBL.DataSource = s.LayBangLuong();
            UiHelper.DatTieuDe(dgvBL, "Số BL", "Nhân viên", "Tháng", "Năm", "Lương cơ bản", "Phụ cấp", "Phụ trội",
                "Thưởng", "Trừ BH", "Phạt", "Thực lãnh");
            dgvBL.Columns["Nam"].DefaultCellStyle.Format = "0";
        }

        void HienThi(decimal lcb, decimal pc, decimal pt, decimal th, decimal bh, decimal ph, decimal tl)
        {
            txtBLLuongCoBan.Text = lcb.ToString("N0");
            txtBLPhuCap.Text = pc.ToString("N0");
            txtBLPhuTroi.Text = pt.ToString("N0");
            txtBLThuong.Text = th.ToString("N0");
            txtBLTruBH.Text = bh.ToString("N0");
            txtBLPhat.Text = ph.ToString("N0");
            txtBLThucLanh.Text = tl.ToString("N0");
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            BangLuongTinh kq;
            KetQuaXuLy k = s.Tinh(UiHelper.Gt(cboBLNhanVien), (int)numBLThang.Value, (int)numBLNam.Value, out kq);
            if (!k.ThanhCong)
            {
                daTinh = null;
                UiHelper.ThongBao(k);
                return;
            }
            daTinh = kq;
            HienThi(kq.LuongCoBan, kq.PhuCap, kq.TienPhuTroi, kq.TienThuong, kq.KhoanTruBaoHiem, kq.TienPhat, kq.ThucLanh);
            MessageBox.Show(k.ThongBao + "\nThực lãnh: " + UiHelper.Tien(kq.ThucLanh) + ". Bấm \"Lưu bảng lương\" để ghi nhận.",
                "Kết quả tính lương", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuuBL_Click(object sender, EventArgs e)
        {
            if (UiHelper.ThongBao(s.Luu(txtSoBL.Text.Trim(), daTinh)))
            {
                Tai();
                btnLamMoiBL_Click(null, EventArgs.Empty);
            }
        }

        private void btnLamMoiBL_Click(object sender, EventArgs e)
        {
            txtSoBL.Clear();
            HienThi(0, 0, 0, 0, 0, 0, 0);
            daTinh = null;
        }

        // Chọn một bảng lương đã lập trong lưới -> xem lại các khoản.
        private void dgvBL_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvBL.Focused || dgvBL.CurrentRow == null) return;
            DataGridViewRow r = dgvBL.CurrentRow;
            Func<string, decimal> g = c => Convert.ToDecimal(r.Cells[c].Value);
            HienThi(g("LuongCoBan"), g("PhuCap"), g("TienPhuTroi"), g("TienThuong"), g("KhoanTruBaoHiem"), g("TienPhat"), g("ThucLanh"));
            daTinh = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
