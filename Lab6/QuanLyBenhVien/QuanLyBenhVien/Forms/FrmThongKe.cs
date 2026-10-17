using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService tk = new ThongKeService();
        private bool daThongKe = false;

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, System.EventArgs e)
        {
            dtTu.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtDen.Value = DateTime.Today;
            try
            {
                UiHelper.NapCombo(cboBacSiLoc, tk.LayBacSiLoc(), "HoTen", "MaBS");
                cboBacSiLoc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void cboBacSiLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (daThongKe) btnThongKe_Click(sender, e);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date) { UiHelper.Canh("Đến ngày không được trước từ ngày."); dtDen.Focus(); return; }
            try
            {
                string bs = UiHelper.Gia(cboBacSiLoc);
                DataRow r = tk.TongHop(dtTu.Value, dtDen.Value).Rows[0];
                lblSoHoSoMoi.Text = "Hồ sơ mới: " + r["SoHoSoMoi"];
                lblSoPhieuKham.Text = "Phiếu khám: " + r["SoPhieuKham"];
                lblKhamDinhKy.Text = "Khám định kỳ: " + r["SoKhamDinhKy"];
                lblTongLePhi.Text = "Tổng lệ phí: " + string.Format("{0:N0}", r["TongLePhi"]) + " đ";
                lblTongVienPhi.Text = "Tổng viện phí: " + string.Format("{0:N0}", r["TongVienPhi"]) + " đ";
                dgvBacSi.DataSource = tk.TheoBacSi(dtTu.Value, dtDen.Value, bs);
                dgvThuoc.DataSource = tk.TheoThuoc(dtTu.Value, dtDen.Value, bs);
                dgvDieuTri.DataSource = tk.TheoHoSo(dtTu.Value, dtDen.Value, bs);
                daThongKe = true;
            }
            catch (Exception ex)
            {
                UiHelper.Loi(ex);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
