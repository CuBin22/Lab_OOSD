using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNuoc.Services;

namespace QuanLyCuaHangNuoc.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService sv = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            foreach (DataGridView g in new[] { dgvBan, dgvTon, dgvNhap, dgvNo, dgvHenCG }) Ui.StyleGrid(g);
            dtTu.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtDen.Value = DateTime.Today;
            ThongKe();
        }

        void ThongKe()
        {
            if (dtDen.Value.Date < dtTu.Value.Date) { Ui.Chon("Đến ngày không được trước từ ngày."); return; }
            DateTime tu = dtTu.Value, den = dtDen.Value;
            DataRow r = sv.TongHop(tu, den).Rows[0];
            lblDonDat.Text = "Đơn đặt hàng: " + r["SoDonDat"];
            lblPhieuGiao.Text = "Phiếu giao hàng: " + r["SoPhieuGiao"];
            lblHoaDon.Text = "Hóa đơn: " + r["SoHoaDon"];
            lblDoanhThu.Text = "Doanh thu: " + Convert.ToDecimal(r["DoanhThu"]).ToString("N0") + " đ";
            lblHenChua.Text = "Phiếu hẹn chưa giao: " + r["SoHenChuaGiao"];
            lblGhiNo.Text = "Phiếu ghi nợ: " + r["SoPhieuNo"] + " - Tổng nợ: " + Convert.ToDecimal(r["TongNo"]).ToString("N0") + " đ";

            Ui.Bind(dgvBan, sv.DoanhSoTheoHang(tu, den), "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "TenLoai|Nhãn hiệu",
                "SoLuongBan|Số lượng bán|N0", "DoanhThu|Doanh thu|N0");
            Ui.Bind(dgvTon, sv.TonKho(), "MaNGK|Mã NGK", "TenNGK|Tên nước giải khát", "TenLoai|Nhãn hiệu", "TenNCC|Nhà cung ứng",
                "DonViTinh|ĐVT", "SoLuongTon|Tồn kho|N0");
            Ui.Bind(dgvNhap, sv.DatHangNhanHang(tu, den), "SoDDH|Số đơn", "TenNCC|Nhà cung ứng", "NgayDat|Ngày đặt|dd/MM/yyyy",
                "NgayNhanDuKien|Ngày nhận DK|dd/MM/yyyy", "SoDotGiao|Số đợt giao", "TongTienPhaiTra|Tổng tiền phải trả|N0");
            Ui.Bind(dgvNo, sv.CongNo(tu, den), "MaKH|Mã KH", "HoTen|Khách hàng", "SoPhieu|Số phiếu nợ", "TongNo|Tổng nợ|N0",
                "NgayTraSomNhat|Ngày trả sớm nhất|dd/MM/yyyy");
            Ui.Bind(dgvHenCG, sv.HenChuaGiao(), "SoPhieuHen|Số phiếu hẹn", "SoHD|Số HD", "HoTen|Khách hàng",
                "NgayHen|Ngày hẹn|dd/MM/yyyy", "TongSoLuong|Tổng số lượng|N0");
        }

        private void btnTK_Click(object sender, EventArgs e) { ThongKe(); }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}
