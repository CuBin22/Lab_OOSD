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
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            dtTu.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            btnThongKe_Click(null, EventArgs.Empty);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.");
                return;
            }
            try
            {
                DataRow r = s.TongHop(dtTu.Value, dtDen.Value).Rows[0];
                lblTongNV.Text = "Tổng nhân viên: " + r["TongNV"];
                lblThuViec.Text = "Đang thử việc: " + r["DangThuViec"];
                lblHopDong.Text = "Hợp đồng hiệu lực: " + r["HopDongHieuLuc"];
                lblTongThucLanh.Text = "Tổng thực lãnh: " + UiHelper.Tien(Convert.ToDecimal(r["TongThucLanh"]));
                lblTongThuong.Text = "Tổng thưởng: " + UiHelper.Tien(Convert.ToDecimal(r["TongThuong"]));
                lblTongPhat.Text = "Tổng tiền phạt: " + UiHelper.Tien(Convert.ToDecimal(r["TongPhat"]));

                dgvTongHop.DataSource = s.LuongTheoThang(dtTu.Value, dtDen.Value);
                UiHelper.DatTieuDe(dgvTongHop, "Tháng/Năm", "Số NV", "Tổng thực lãnh", "Tổng phụ trội");
                dgvPhongBan.DataSource = s.NhanSuTheoPhongBan();
                UiHelper.DatTieuDe(dgvPhongBan, "Mã PB", "Tên phòng ban", "Số nhân viên", "Đang thử việc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Services.Loi.Dich(ex), "Không thống kê được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
