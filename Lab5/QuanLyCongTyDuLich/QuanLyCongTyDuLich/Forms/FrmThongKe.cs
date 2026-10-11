using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Thống kê đăng ký, doanh thu, phân công, khảo sát theo khoảng thời gian.</summary>
    public partial class FrmThongKe : Form
    {
        private bool _sanSang = false;

        public FrmThongKe()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvKetQua);
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            DateTime dauThang = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTuNgay.Value = dauThang;
            dtpDenNgay.Value = DateTime.Today;
            cboLoaiThongKe.SelectedIndex = 0;
            _sanSang = true;
            ThongKe();
        }

        private void cboLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_sanSang) ThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void ThongKe()
        {
            if (dtpDenNgay.Value.Date < dtpTuNgay.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime tu = dtpTuNgay.Value.Date;
            DateTime den = dtpDenNgay.Value.Date;
            try
            {
                switch (cboLoaiThongKe.SelectedIndex)
                {
                    case 0: ThongKeDangKy(tu, den); break;
                    case 1: ThongKeDoanhThu(tu, den); break;
                    case 2: ThongKePhanCong(tu, den); break;
                    case 3: ThongKeKhaoSat(tu, den); break;
                    case 4: ThongKeTour(tu, den); break;
                    default: ThongKeLuong(tu, den); break;
                }
            }
            catch (Exception ex)
            {
                lblTong.Text = "Lỗi: " + Hlp.LoiSql(ex);
            }
        }

        private void ThongKeDangKy(DateTime tu, DateTime den)
        {
            DataTable dt = Db.Query(
                "SELECT t.MaTour, t.TenTour, " +
                "(SELECT COUNT(*) FROM PhieuDangKyDoan d JOIN PhieuDangKy p ON p.SoPhieu = d.SoPhieu WHERE d.MaTour = t.MaTour AND p.TrangThai <> N'Đã hủy' AND CAST(p.NgayLap AS date) BETWEEN @tu AND @den) AS SoPhieuDoan, " +
                "(SELECT ISNULL(SUM(d.SoNguoi), 0) FROM PhieuDangKyDoan d JOIN PhieuDangKy p ON p.SoPhieu = d.SoPhieu WHERE d.MaTour = t.MaTour AND p.TrangThai <> N'Đã hủy' AND CAST(p.NgayLap AS date) BETWEEN @tu AND @den) AS KhachDoan, " +
                "(SELECT COUNT(*) FROM PhieuDangKyChuyen k JOIN ChuyenTour c ON c.MaChuyen = k.MaChuyen JOIN PhieuDangKy p ON p.SoPhieu = k.SoPhieu WHERE c.MaTour = t.MaTour AND p.TrangThai <> N'Đã hủy' AND CAST(p.NgayLap AS date) BETWEEN @tu AND @den) AS SoPhieuChuyen, " +
                "(SELECT ISNULL(SUM(k.SoVe), 0) FROM PhieuDangKyChuyen k JOIN ChuyenTour c ON c.MaChuyen = k.MaChuyen JOIN PhieuDangKy p ON p.SoPhieu = k.SoPhieu WHERE c.MaTour = t.MaTour AND p.TrangThai <> N'Đã hủy' AND CAST(p.NgayLap AS date) BETWEEN @tu AND @den) AS SoVe " +
                "FROM Tour t ORDER BY t.MaTour", Hlp.P("@tu", tu), Hlp.P("@den", den));
            dgvKetQua.DataSource = dt;
            Ui.TieuDe(dgvKetQua, "MaTour", "Mã tour", "TenTour", "Tên tour", "SoPhieuDoan", "Số phiếu đoàn", "KhachDoan", "Số khách đoàn",
                "SoPhieuChuyen", "Số phiếu chuyến", "SoVe", "Số vé bán");
            long khach = 0;
            foreach (DataRow r in dt.Rows) khach += Convert.ToInt64(r["KhachDoan"]) + Convert.ToInt64(r["SoVe"]);
            lblTong.Text = "Tổng số khách đăng ký: " + khach;
        }

        private void ThongKeDoanhThu(DateTime tu, DateTime den)
        {
            DataTable dt = Db.Query(
                "SELECT t.MaTour, t.TenTour, ISNULL(SUM(x.SoTien), 0) AS DoanhThu, COUNT(x.MaThanhToan) AS SoGiaoDich FROM Tour t LEFT JOIN (" +
                "SELECT tt.MaThanhToan, tt.SoTien, d.MaTour FROM ThanhToan tt JOIN PhieuDangKyDoan d ON d.SoPhieu = tt.SoPhieu " +
                "WHERE CAST(tt.NgayThanhToan AS date) BETWEEN @tu AND @den " +
                "UNION ALL " +
                "SELECT tt.MaThanhToan, tt.SoTien, c.MaTour FROM ThanhToan tt JOIN PhieuDangKyChuyen k ON k.SoPhieu = tt.SoPhieu " +
                "JOIN ChuyenTour c ON c.MaChuyen = k.MaChuyen WHERE CAST(tt.NgayThanhToan AS date) BETWEEN @tu AND @den" +
                ") x ON x.MaTour = t.MaTour GROUP BY t.MaTour, t.TenTour ORDER BY DoanhThu DESC", Hlp.P("@tu", tu), Hlp.P("@den", den));
            dgvKetQua.DataSource = dt;
            Ui.TieuDe(dgvKetQua, "MaTour", "Mã tour", "TenTour", "Tên tour", "DoanhThu", "Doanh thu", "SoGiaoDich", "Số giao dịch");
            Ui.CotTien(dgvKetQua, "DoanhThu");
            decimal tong = 0;
            foreach (DataRow r in dt.Rows) tong += Convert.ToDecimal(r["DoanhThu"]);
            lblTong.Text = "Tổng doanh thu: " + Ui.Tien(tong);
        }

        private void ThongKePhanCong(DateTime tu, DateTime den)
        {
            DataTable dt = Db.Query(
                "SELECT n.MaNV, n.HoTen, COUNT(pc.MaPC) AS SoLuot, ISNULL(SUM(pc.TienCongTour), 0) AS TongTienCong " +
                "FROM NhanVien n LEFT JOIN PhanCong pc ON pc.MaNV = n.MaNV AND pc.NgayBatDau <= @den AND pc.NgayKetThuc >= @tu " +
                "GROUP BY n.MaNV, n.HoTen ORDER BY n.MaNV", Hlp.P("@tu", tu), Hlp.P("@den", den));
            dgvKetQua.DataSource = dt;
            Ui.TieuDe(dgvKetQua, "MaNV", "Mã NV", "HoTen", "Họ tên", "SoLuot", "Số lượt phân công", "TongTienCong", "Tổng tiền công");
            Ui.CotTien(dgvKetQua, "TongTienCong");
            decimal tong = 0;
            foreach (DataRow r in dt.Rows) tong += Convert.ToDecimal(r["TongTienCong"]);
            lblTong.Text = "Tổng tiền công: " + Ui.Tien(tong);
        }

        private void ThongKeKhaoSat(DateTime tu, DateTime den)
        {
            DataTable dt = Db.Query(
                "SELECT t.MaTour, t.TenTour, COUNT(x.MaKS) AS SoPhieuKS, AVG(CAST(x.DiemDanhGia AS float)) AS DiemTrungBinh FROM Tour t LEFT JOIN (" +
                "SELECT s.MaKS, s.DiemDanhGia, d.MaTour FROM PhieuKhaoSat s JOIN PhieuDangKyDoan d ON d.SoPhieu = s.SoPhieu " +
                "WHERE s.DiemDanhGia IS NOT NULL AND s.NgayGui BETWEEN @tu AND @den " +
                "UNION ALL " +
                "SELECT s.MaKS, s.DiemDanhGia, c.MaTour FROM PhieuKhaoSat s JOIN PhieuDangKyChuyen k ON k.SoPhieu = s.SoPhieu " +
                "JOIN ChuyenTour c ON c.MaChuyen = k.MaChuyen WHERE s.DiemDanhGia IS NOT NULL AND s.NgayGui BETWEEN @tu AND @den" +
                ") x ON x.MaTour = t.MaTour GROUP BY t.MaTour, t.TenTour ORDER BY t.MaTour", Hlp.P("@tu", tu), Hlp.P("@den", den));
            dgvKetQua.DataSource = dt;
            Ui.TieuDe(dgvKetQua, "MaTour", "Mã tour", "TenTour", "Tên tour", "SoPhieuKS", "Số phiếu đã trả lời", "DiemTrungBinh", "Điểm trung bình");
            if (dgvKetQua.Columns.Contains("DiemTrungBinh")) dgvKetQua.Columns["DiemTrungBinh"].DefaultCellStyle.Format = "0.00";
            long soPhieu = 0;
            foreach (DataRow r in dt.Rows) soPhieu += Convert.ToInt64(r["SoPhieuKS"]);
            lblTong.Text = "Tổng số phiếu khảo sát đã trả lời: " + soPhieu;
        }

        /// <summary>Thống kê tour: lộ trình, số chuyến khởi hành và số đoàn đi trong khoảng thời gian.</summary>
        private void ThongKeTour(DateTime tu, DateTime den)
        {
            DataTable dt = Db.Query(
                "SELECT t.MaTour, t.TenTour, t.SoNgay, t.SoDem, t.DonGia, " +
                "(SELECT COUNT(*) FROM DungChan x WHERE x.MaTour = t.MaTour) AS SoDungChan, " +
                "(SELECT COUNT(*) FROM ChiTietTourDiemTQ x WHERE x.MaTour = t.MaTour) AS SoDiemTQ, " +
                "(SELECT COUNT(*) FROM ChuyenTour x WHERE x.MaTour = t.MaTour AND x.NgayDi BETWEEN @tu AND @den) AS SoChuyen, " +
                "(SELECT COUNT(*) FROM PhieuDangKyDoan d JOIN PhieuDangKy p ON p.SoPhieu = d.SoPhieu " +
                " WHERE d.MaTour = t.MaTour AND p.TrangThai <> N'Đã hủy' AND d.NgayDi BETWEEN @tu AND @den) AS SoDoan " +
                "FROM Tour t ORDER BY t.MaTour", Hlp.P("@tu", tu), Hlp.P("@den", den));
            dgvKetQua.DataSource = dt;
            Ui.TieuDe(dgvKetQua, "MaTour", "Mã tour", "TenTour", "Tên tour", "SoNgay", "Số ngày", "SoDem", "Số đêm", "DonGia", "Đơn giá/khách",
                "SoDungChan", "Số nơi dừng chân", "SoDiemTQ", "Số điểm tham quan", "SoChuyen", "Số chuyến khởi hành", "SoDoan", "Số đoàn đi");
            Ui.CotTien(dgvKetQua, "DonGia");
            long chuyen = 0, doan = 0;
            foreach (DataRow r in dt.Rows) { chuyen += Convert.ToInt64(r["SoChuyen"]); doan += Convert.ToInt64(r["SoDoan"]); }
            lblTong.Text = "Số tour: " + dt.Rows.Count + " | Chuyến khởi hành trong kỳ: " + chuyen + " | Đoàn đi trong kỳ: " + doan;
        }

        /// <summary>Lương = lương căn bản x số tháng của kỳ + tiền công các tour kết thúc trong kỳ.</summary>
        private void ThongKeLuong(DateTime tu, DateTime den)
        {
            int soThang = (den.Year - tu.Year) * 12 + den.Month - tu.Month + 1;
            DataTable dt = Db.Query(
                "SELECT n.MaNV, n.HoTen, n.LuongCanBan * @st AS LuongCanBanKy, COUNT(pc.MaPC) AS SoTour, " +
                "ISNULL(SUM(pc.TienCongTour), 0) AS LuongTheoTour, " +
                "n.LuongCanBan * @st + ISNULL(SUM(pc.TienCongTour), 0) AS TongLuong " +
                "FROM NhanVien n LEFT JOIN PhanCong pc ON pc.MaNV = n.MaNV AND pc.NgayKetThuc BETWEEN @tu AND @den " +
                "GROUP BY n.MaNV, n.HoTen, n.LuongCanBan ORDER BY n.MaNV",
                Hlp.P("@st", soThang), Hlp.P("@tu", tu), Hlp.P("@den", den));
            dgvKetQua.DataSource = dt;
            Ui.TieuDe(dgvKetQua, "MaNV", "Mã NV", "HoTen", "Họ tên", "LuongCanBanKy", "Lương căn bản (" + soThang + " tháng)",
                "SoTour", "Số tour", "LuongTheoTour", "Lương theo tour", "TongLuong", "Tổng lương");
            Ui.CotTien(dgvKetQua, "LuongCanBanKy", "LuongTheoTour", "TongLuong");
            decimal tong = 0;
            foreach (DataRow r in dt.Rows) tong += Convert.ToDecimal(r["TongLuong"]);
            lblTong.Text = "Tổng lương kỳ (" + soThang + " tháng): " + Ui.Tien(tong);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
