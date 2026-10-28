using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangNuoc.Services;

namespace QuanLyCuaHangNuoc.Forms
{
    /// <summary>Hàm dùng chung cho các Form (định dạng lưới, ComboBox, thông báo).</summary>
    public static class Ui
    {
        public const string DinhDangTien = "N0";
        public const string DinhDangNgay = "dd/MM/yyyy";

        public static void StyleGrid(DataGridView g)
        {
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 59, 122);
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 26;
            g.GridColor = Color.FromArgb(215, 222, 232);
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 249, 253);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 205, 240);
            g.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        /// <summary>Gán nguồn dữ liệu và đặt tiêu đề cột. Mỗi phần tử: "Cột|Tiêu đề|Định dạng" ("-" = ẩn cột).</summary>
        public static void Bind(DataGridView g, object data, params string[] cot)
        {
            g.DataSource = data;
            foreach (string c in cot)
            {
                string[] p = c.Split('|');
                if (!g.Columns.Contains(p[0])) continue;
                DataGridViewColumn col = g.Columns[p[0]];
                if (p.Length > 1)
                {
                    if (p[1] == "-") col.Visible = false; else col.HeaderText = p[1];
                }
                if (p.Length > 2)
                {
                    col.DefaultCellStyle.Format = p[2];
                    if (p[2].StartsWith("N")) col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        public static void BindCombo(ComboBox c, DataTable dt, string hienThi, string giaTri)
        {
            c.DataSource = null;
            c.DisplayMember = hienThi;
            c.ValueMember = giaTri;
            c.DataSource = dt;
            if (dt != null && dt.Rows.Count > 0) c.SelectedIndex = 0;
        }

        /// <summary>Giá trị (ValueMember) đang chọn của ComboBox, "" nếu chưa chọn.</summary>
        public static string V(ComboBox c)
        {
            object v = c.SelectedValue;
            if (v == null || v is DataRowView) return "";
            return v.ToString();
        }

        public static string Cell(DataGridViewRow r, string cot)
        {
            object v = r.Cells[cot].Value;
            return v == null || v == DBNull.Value ? "" : Convert.ToString(v);
        }

        public static void Show(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, k.ThanhCong ? "Thành công" : "Không thực hiện được",
                MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        public static bool XacNhan(string noiDung)
        {
            return MessageBox.Show(noiDung, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void Chon(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
