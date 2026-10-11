using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Quản lý khách hàng: khách đoàn và khách lẻ.</summary>
    public partial class FrmKhachHang : Form
    {
        private bool _sanSang = false;

        public FrmKhachHang()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvKhachHang);
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            cboLoaiKhach.SelectedIndex = 0;
            cboLocLoai.SelectedIndex = 0;
            _sanSang = true;
            NapLuoi();
            LamMoi();
        }

        private void NapLuoi()
        {
            try
            {
                string sql = "SELECT MaKH, TenKH, LoaiKhach, DiaChi, DienThoai, NguoiDaiDien, SoCMND FROM KhachHang WHERE 1 = 1";
                List<SqlParameter> ps = new List<SqlParameter>();
                if (cboLocLoai.SelectedIndex > 0)
                {
                    sql += " AND LoaiKhach = @lk";
                    ps.Add(Hlp.P("@lk", cboLocLoai.Text));
                }
                string tk = txtTimKiem.Text.Trim();
                if (tk.Length > 0)
                {
                    sql += " AND (MaKH LIKE @tk OR TenKH LIKE @tk OR DienThoai LIKE @tk)";
                    ps.Add(Hlp.P("@tk", "%" + tk + "%"));
                }
                sql += " ORDER BY MaKH";
                dgvKhachHang.DataSource = Db.Query(sql, ps.ToArray());
                Ui.TieuDe(dgvKhachHang, "MaKH", "Mã KH", "TenKH", "Tên khách hàng", "LoaiKhach", "Loại", "DiaChi", "Địa chỉ",
                    "DienThoai", "Điện thoại", "NguoiDaiDien", "Người đại diện", "SoCMND", "Số CMND");
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void LamMoi()
        {
            txtMaKH.ReadOnly = false;
            cboLoaiKhach.Enabled = true;
            txtMaKH.Text = Hlp.MaTiepTheo("KhachHang", "MaKH", "KH", 3);
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtNguoiDaiDien.Clear();
            txtSoCMND.Clear();
            cboLoaiKhach.SelectedIndex = 0;
            lblThongBao.Text = "";
            txtTenKH.Focus();
        }

        private void cboLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool laDoan = cboLoaiKhach.Text == "Đoàn";
            txtNguoiDaiDien.Enabled = laDoan;
            txtSoCMND.Enabled = !laDoan;
            if (laDoan) txtSoCMND.Clear(); else txtNguoiDaiDien.Clear();
        }

        private bool KiemTraForm()
        {
            if (txtMaKH.Text.Trim().Length == 0 || txtTenKH.Text.Trim().Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Vui lòng nhập mã và tên khách hàng.", false);
                return false;
            }
            if (cboLoaiKhach.Text == "Đoàn" && txtNguoiDaiDien.Text.Trim().Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Khách đoàn bắt buộc có người đại diện.", false);
                return false;
            }
            if (cboLoaiKhach.Text == "Lẻ" && txtSoCMND.Text.Trim().Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Khách lẻ bắt buộc có số CMND.", false);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Đang chọn một khách hàng để sửa. Bấm \"Làm mới\" để nhập khách mới.", false);
                return;
            }
            if (!KiemTraForm()) return;
            try
            {
                Db.Execute("INSERT INTO KhachHang (MaKH, TenKH, DiaChi, DienThoai, LoaiKhach, NguoiDaiDien, SoCMND) VALUES (@ma, @ten, @dc, @dt, @loai, @ndd, @cmnd)",
                    Hlp.P("@ma", txtMaKH.Text.Trim()), Hlp.P("@ten", txtTenKH.Text.Trim()), Hlp.P("@dc", txtDiaChi.Text.Trim()),
                    Hlp.P("@dt", txtDienThoai.Text.Trim()), Hlp.P("@loai", cboLoaiKhach.Text),
                    Hlp.P("@ndd", txtNguoiDaiDien.Text.Trim()), Hlp.P("@cmnd", txtSoCMND.Text.Trim()));
                NapLuoi();
                LamMoi();
                Ui.ThongBao(lblThongBao, "Đã thêm khách hàng.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtMaKH.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn khách hàng cần sửa trong danh sách.", false);
                return;
            }
            if (!KiemTraForm()) return;
            try
            {
                Db.Execute("UPDATE KhachHang SET TenKH = @ten, DiaChi = @dc, DienThoai = @dt, NguoiDaiDien = @ndd, SoCMND = @cmnd WHERE MaKH = @ma",
                    Hlp.P("@ma", txtMaKH.Text.Trim()), Hlp.P("@ten", txtTenKH.Text.Trim()), Hlp.P("@dc", txtDiaChi.Text.Trim()),
                    Hlp.P("@dt", txtDienThoai.Text.Trim()), Hlp.P("@ndd", txtNguoiDaiDien.Text.Trim()), Hlp.P("@cmnd", txtSoCMND.Text.Trim()));
                NapLuoi();
                Ui.ThongBao(lblThongBao, "Đã cập nhật khách hàng.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaKH.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn khách hàng cần xóa trong danh sách.", false);
                return;
            }
            if (!Ui.Hoi("Xóa khách hàng \"" + txtTenKH.Text.Trim() + "\"?")) return;
            try
            {
                Db.Execute("DELETE FROM KhachHang WHERE MaKH = @ma", Hlp.P("@ma", txtMaKH.Text.Trim()));
                NapLuoi();
                LamMoi();
                Ui.ThongBao(lblThongBao, "Đã xóa khách hàng.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];
            cboLoaiKhach.SelectedIndex = cboLoaiKhach.FindStringExact(Convert.ToString(r.Cells["LoaiKhach"].Value));
            txtMaKH.Text = Convert.ToString(r.Cells["MaKH"].Value);
            txtTenKH.Text = Convert.ToString(r.Cells["TenKH"].Value);
            txtDiaChi.Text = Convert.ToString(r.Cells["DiaChi"].Value);
            txtDienThoai.Text = Convert.ToString(r.Cells["DienThoai"].Value);
            txtNguoiDaiDien.Text = Convert.ToString(r.Cells["NguoiDaiDien"].Value);
            txtSoCMND.Text = Convert.ToString(r.Cells["SoCMND"].Value);
            txtMaKH.ReadOnly = true;
            cboLoaiKhach.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (_sanSang) NapLuoi();
        }

        private void cboLocLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_sanSang) NapLuoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
