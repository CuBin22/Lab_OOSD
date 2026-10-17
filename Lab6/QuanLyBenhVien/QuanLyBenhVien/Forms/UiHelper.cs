using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBenhVien.Services;

namespace QuanLyBenhVien.Forms
{
    /// <summary>Hàm dùng chung cho các Form: kiểm tra dữ liệu nhập, thông báo, nạp ComboBox.</summary>
    internal static class UiHelper
    {
        public static bool BatBuoc(Control c, string tenTruong)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                Canh(tenTruong + " không được để trống.");
                c.Focus();
                return false;
            }
            return true;
        }

        public static bool BatBuocChon(ComboBox c, string tenTruong)
        {
            if (c.SelectedIndex < 0 || c.SelectedItem == null)
            {
                Canh("Hãy chọn " + tenTruong + ".");
                c.Focus();
                return false;
            }
            return true;
        }

        /// <summary>Giá trị (ValueMember) đang chọn của ComboBox; rỗng nếu chưa chọn.</summary>
        public static string Gia(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        /// <summary>Đọc giá trị một cột của dòng đang chọn trong DataGridView (theo DataPropertyName).</summary>
        public static string Cell(DataGridView g, string col)
        {
            if (g.CurrentRow == null) return "";
            DataRowView rv = g.CurrentRow.DataBoundItem as DataRowView;
            if (rv != null && rv.Row.Table.Columns.Contains(col)) return Convert.ToString(rv[col]);
            foreach (DataGridViewColumn c in g.Columns)
                if (c.DataPropertyName == col) return Convert.ToString(g.CurrentRow.Cells[c.Index].Value);
            return "";
        }

        public static void NapCombo(ComboBox c, DataTable dt, string hienThi, string giaTri)
        {
            c.DataSource = dt;
            c.DisplayMember = hienThi;
            c.ValueMember = giaTri;
            c.SelectedIndex = -1;
        }

        /// <summary>Chọn sẵn người dùng đang đăng nhập (nếu là nhân viên) trong ComboBox nhân viên.</summary>
        public static void ChonNguoiDung(ComboBox c)
        {
            if (PhienLamViec.VaiTro == PhienLamViec.BacSi || c.DataSource == null) return;
            c.SelectedValue = PhienLamViec.MaNguoi;
        }

        public static void XoaTrang(params Control[] cs)
        {
            foreach (Control c in cs)
            {
                TextBox t = c as TextBox;
                if (t != null) t.Clear();
            }
        }

        public static void Thong(string msg)
        {
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Canh(string msg)
        {
            MessageBox.Show(msg, "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Loi(Exception ex)
        {
            MessageBox.Show("Lỗi truy cập dữ liệu: " + ex.Message + "\n\nKiểm tra SQL Server đã chạy, đã chạy script Database\\QuanLyBenhVien.sql và chuỗi kết nối trong App.config.",
                "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool XacNhan(string msg)
        {
            return MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Hiển thị kết quả xử lý (thành công hoặc nguyên nhân từ chối); trả về true nếu thành công.</summary>
        public static bool HienKetQua(KetQuaXuLy k)
        {
            if (k.ThanhCong) Thong(k.ThongBao);
            else Canh(k.ThongBao);
            return k.ThanhCong;
        }
    }
}
