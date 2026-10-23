using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    /// <summary>Hàm tiện ích dùng chung cho các Form (nạp ComboBox, định dạng DataGridView, hiển thị thông báo).</summary>
    public static class UiHelper
    {
        public static void NapCombo(ComboBox cbo, DataTable dt, string hienThi, string giaTri)
        {
            cbo.DataSource = null;
            cbo.DisplayMember = hienThi;
            cbo.ValueMember = giaTri;
            cbo.DataSource = dt;
            if (dt != null && dt.Rows.Count == 0) cbo.SelectedIndex = -1;
        }

        public static string Gt(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        public static string Chu(ComboBox c)
        {
            return c.SelectedItem == null ? "" : c.Text;
        }

        public static void DatTieuDe(DataGridView dgv, params string[] tieuDe)
        {
            for (int i = 0; i < tieuDe.Length && i < dgv.Columns.Count; i++)
                dgv.Columns[i].HeaderText = tieuDe[i];
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (c.ValueType == typeof(DateTime)) c.DefaultCellStyle.Format = "dd/MM/yyyy";
                else if (c.ValueType == typeof(decimal) || c.ValueType == typeof(double))
                    c.DefaultCellStyle.Format = "#,##0.##";
            }
        }

        public static void An(DataGridView dgv, string tenCot)
        {
            if (dgv.Columns.Contains(tenCot)) dgv.Columns[tenCot].Visible = false;
        }

        /// <summary>Hiển thị kết quả; trả về true nếu thành công.</summary>
        public static bool ThongBao(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, k.ThanhCong ? "Thành công" : "Không thực hiện được",
                MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            return k.ThanhCong;
        }

        public static string Tien(decimal v)
        {
            return v.ToString("N0") + " đ";
        }

        public static string GtO(DataGridViewRow r, string cot)
        {
            return r.Cells[cot].Value == null ? "" : Convert.ToString(r.Cells[cot].Value);
        }
    }
}
