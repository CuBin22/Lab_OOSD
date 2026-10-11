using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Helpers
{
    /// <summary>Tiện ích giao diện dùng chung cho các Form.</summary>
    public static class Ui
    {
        /// <summary>Đọc ảnh nhúng trong thư mục Images (Build Action = Embedded Resource).</summary>
        public static Image Icon(string tenFile)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            using (Stream s = asm.GetManifestResourceStream("QuanLyCongTyDuLich.Images." + tenFile))
            {
                if (s == null) return null;
                using (Bitmap goc = new Bitmap(s))
                {
                    return new Bitmap(goc);
                }
            }
        }

        /// <summary>Định dạng DataGridView giống mẫu (tiêu đề xanh nhạt, chọn nguyên dòng).</summary>
        public static void DinhDangLuoi(DataGridView g)
        {
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 232, 247);
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 26;
            g.GridColor = Color.FromArgb(225, 225, 225);
            g.BorderStyle = BorderStyle.FixedSingle;
            g.RowTemplate.Height = 24;
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 205, 240);
            g.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        /// <summary>Đặt tiêu đề cột: truyền theo cặp (tên cột, tiêu đề).</summary>
        public static void TieuDe(DataGridView g, params string[] cap)
        {
            for (int i = 0; i + 1 < cap.Length; i += 2)
            {
                if (g.Columns.Contains(cap[i])) g.Columns[cap[i]].HeaderText = cap[i + 1];
            }
        }

        public static void AnCot(DataGridView g, params string[] cot)
        {
            foreach (string c in cot)
            {
                if (g.Columns.Contains(c)) g.Columns[c].Visible = false;
            }
        }

        /// <summary>Định dạng cột số tiền (canh phải, có dấu phân cách hàng nghìn).</summary>
        public static void CotTien(DataGridView g, params string[] cot)
        {
            foreach (string c in cot)
            {
                if (!g.Columns.Contains(c)) continue;
                g.Columns[c].DefaultCellStyle.Format = "N0";
                g.Columns[c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        public static void CotNgay(DataGridView g, params string[] cot)
        {
            foreach (string c in cot)
            {
                if (g.Columns.Contains(c)) g.Columns[c].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        /// <summary>Nạp dữ liệu cho ComboBox, giữ lại lựa chọn cũ nếu còn tồn tại.</summary>
        public static void NapCombo(ComboBox c, DataTable dt, string hienThi, string giaTri)
        {
            object cu = c.SelectedValue;
            c.DataSource = null;
            c.DisplayMember = hienThi;
            c.ValueMember = giaTri;
            c.DataSource = dt;
            if (cu != null && dt.Rows.Count > 0) c.SelectedValue = cu;
            if (c.SelectedIndex < 0 && dt.Rows.Count > 0) c.SelectedIndex = 0;
        }

        public static string GiaTri(ComboBox c)
        {
            return Convert.ToString(c.SelectedValue);
        }

        /// <summary>Gán giá trị cho NumericUpDown, tự cắt về khoảng Minimum..Maximum.</summary>
        public static void GanSo(NumericUpDown n, decimal v)
        {
            if (v < n.Minimum) v = n.Minimum;
            if (v > n.Maximum) v = n.Maximum;
            n.Value = v;
        }

        public static void Loi(string noiDung)
        {
            MessageBox.Show(noiDung, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ThongTin(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Hoi(string noiDung)
        {
            return MessageBox.Show(noiDung, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Hiển thị thông báo trạng thái (xanh = thành công, đỏ = từ chối/lỗi).</summary>
        public static void ThongBao(Label lbl, string noiDung, bool thanhCong)
        {
            lbl.ForeColor = thanhCong ? Color.FromArgb(0, 110, 40) : Color.Firebrick;
            lbl.Text = noiDung;
        }

        // ----- số tiền -----
        public static bool DocTien(string s, out decimal v)
        {
            v = 0;
            if (string.IsNullOrWhiteSpace(s)) return false;
            string sach = s.Replace(".", "").Replace(",", "").Replace(" ", "");
            return decimal.TryParse(sach, NumberStyles.Integer, CultureInfo.InvariantCulture, out v);
        }

        public static string Tien(decimal v)
        {
            return v.ToString("N0", CultureInfo.CurrentCulture);
        }

        /// <summary>Dùng trong sự kiện KeyPress: chỉ cho nhập chữ số.</summary>
        public static void ChiNhapSo(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
