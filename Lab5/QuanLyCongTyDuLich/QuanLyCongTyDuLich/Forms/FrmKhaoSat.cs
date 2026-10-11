using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Gửi phiếu khảo sát sau tour và ghi nhận góp ý của khách hàng.</summary>
    public partial class FrmKhaoSat : Form
    {
        private string _maKS = null;     // phiếu khảo sát đang chọn trong lưới

        public FrmKhaoSat()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvKhaoSat);
        }

        private void FrmKhaoSat_Load(object sender, EventArgs e)
        {
            dtpNgayGui.Value = DateTime.Today;
            dtpNgayTraLoi.Checked = false;
            try
            {
                NapPhieu();
                NapLuoi();
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, "Không tải được dữ liệu: " + Hlp.LoiSql(ex), false);
            }
        }

        private void NapPhieu()
        {
            string sql =
                "SELECT p.SoPhieu, p.SoPhieu + N' - ' + k.TenKH + N' (' + p.LoaiPhieu + N')' AS HienThi " +
                "FROM PhieuDangKy p JOIN KhachHang k ON k.MaKH = p.MaKH " +
                "WHERE p.TrangThai <> N'Đã hủy' AND NOT EXISTS (SELECT 1 FROM PhieuKhaoSat s WHERE s.SoPhieu = p.SoPhieu)";
            if (!chkTatCa.Checked) sql += " AND p.TrangThai IN (N'Đã thanh toán', N'Hoàn tất')";
            sql += " ORDER BY p.SoPhieu DESC";
            Ui.NapCombo(cboPhieu, Db.Query(sql), "HienThi", "SoPhieu");
        }

        private void NapLuoi()
        {
            dgvKhaoSat.DataSource = Db.Query(
                "SELECT s.MaKS, s.SoPhieu, k.TenKH, s.NgayGui, s.NgayTraLoi, s.DiemDanhGia, s.GopY " +
                "FROM PhieuKhaoSat s JOIN PhieuDangKy p ON p.SoPhieu = s.SoPhieu JOIN KhachHang k ON k.MaKH = p.MaKH " +
                "ORDER BY s.NgayGui DESC, s.MaKS DESC");
            Ui.TieuDe(dgvKhaoSat, "MaKS", "Mã KS", "SoPhieu", "Số phiếu", "TenKH", "Khách hàng", "NgayGui", "Ngày gửi",
                "NgayTraLoi", "Ngày trả lời", "DiemDanhGia", "Điểm", "GopY", "Góp ý");
            Ui.CotNgay(dgvKhaoSat, "NgayGui", "NgayTraLoi");
        }

        private void chkTatCa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                NapPhieu();
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnGuiKhaoSat_Click(object sender, EventArgs e)
        {
            string so = Ui.GiaTri(cboPhieu);
            if (so.Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn phiếu đăng ký cần gửi khảo sát (hoặc tick \"Hiện tất cả phiếu\").", false);
                return;
            }
            object ngayTL = null, diem = null, gopY = null;
            if (dtpNgayTraLoi.Checked)
            {
                if (dtpNgayTraLoi.Value.Date < dtpNgayGui.Value.Date)
                {
                    Ui.ThongBao(lblThongBao, "Ngày trả lời phải lớn hơn hoặc bằng ngày gửi.", false);
                    return;
                }
                ngayTL = dtpNgayTraLoi.Value.Date;
                diem = (int)numDiem.Value;
                gopY = txtGopY.Text.Trim();
            }
            try
            {
                Db.Execute("INSERT INTO PhieuKhaoSat (MaKS, SoPhieu, NgayGui, NgayTraLoi, DiemDanhGia, GopY) VALUES (@ma, @sp, @gui, @tl, @diem, @gy)",
                    Hlp.P("@ma", Hlp.MaTiepTheo("PhieuKhaoSat", "MaKS", "KS", 5)), Hlp.P("@sp", so), Hlp.P("@gui", dtpNgayGui.Value.Date),
                    Hlp.P("@tl", ngayTL), Hlp.P("@diem", diem), Hlp.P("@gy", gopY));
                NapPhieu();
                NapLuoi();
                LamMoi();
                Ui.ThongBao(lblThongBao, "Đã gửi phiếu khảo sát cho phiếu " + so + ".", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnGhiNhanGopY_Click(object sender, EventArgs e)
        {
            if (_maKS == null)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn phiếu khảo sát trong danh sách để ghi nhận góp ý.", false);
                return;
            }
            if (!dtpNgayTraLoi.Checked)
            {
                Ui.ThongBao(lblThongBao, "Hãy tick chọn ngày trả lời của khách hàng.", false);
                return;
            }
            if (dtpNgayTraLoi.Value.Date < dtpNgayGui.Value.Date)
            {
                Ui.ThongBao(lblThongBao, "Ngày trả lời phải lớn hơn hoặc bằng ngày gửi.", false);
                return;
            }
            try
            {
                Db.Execute("UPDATE PhieuKhaoSat SET NgayTraLoi = @tl, DiemDanhGia = @diem, GopY = @gy WHERE MaKS = @ma",
                    Hlp.P("@ma", _maKS), Hlp.P("@tl", dtpNgayTraLoi.Value.Date), Hlp.P("@diem", (int)numDiem.Value), Hlp.P("@gy", txtGopY.Text.Trim()));
                NapLuoi();
                Ui.ThongBao(lblThongBao, "Đã ghi nhận góp ý của khách hàng.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void LamMoi()
        {
            _maKS = null;
            dtpNgayGui.Value = DateTime.Today;
            dtpNgayTraLoi.Checked = false;
            numDiem.Value = 5;
            txtGopY.Clear();
            lblThongBao.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvKhaoSat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvKhaoSat.Rows[e.RowIndex];
            _maKS = Convert.ToString(r.Cells["MaKS"].Value);
            dtpNgayGui.Value = Convert.ToDateTime(r.Cells["NgayGui"].Value);
            object tl = r.Cells["NgayTraLoi"].Value;
            if (tl == null || tl == DBNull.Value)
            {
                dtpNgayTraLoi.Checked = false;
            }
            else
            {
                dtpNgayTraLoi.Value = Convert.ToDateTime(tl);
                dtpNgayTraLoi.Checked = true;
            }
            object d = r.Cells["DiemDanhGia"].Value;
            Ui.GanSo(numDiem, (d == null || d == DBNull.Value) ? 5 : Convert.ToDecimal(d));
            txtGopY.Text = Convert.ToString(r.Cells["GopY"].Value);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
