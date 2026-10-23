using eShopping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShopping.Forms
{
    public static class LuoiDuLieu
    {
        /// <summary>Cấu hình chung cho DataGridView (cột đã thiết kế sẵn trong Designer với DataPropertyName).</summary>
        public static void CauHinh(DataGridView g, bool chiDoc)
        {
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.ReadOnly = chiDoc;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>Định dạng cột tiền: 1.250.000, căn phải.</summary>
        public static void DinhDangTien(DataGridView g, params string[] tenCot)
        {
            foreach (string ten in tenCot)
            {
                DataGridViewColumn c = g.Columns[ten];
                if (c == null) continue;
                c.DefaultCellStyle.Format = "N0";
                c.DefaultCellStyle.FormatProvider = DinhDang.VN;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        public static void CanPhai(DataGridView g, params string[] tenCot)
        {
            foreach (string ten in tenCot)
            {
                DataGridViewColumn c = g.Columns[ten];
                if (c != null) c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }

    public static class ThongBao
    {
        public static void Hien(KetQuaXuLy kq)
        {
            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        public static void Canh(string noiDung)
        {
            MessageBox.Show(noiDung, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>NFR10: hệ thống ngoài/CSDL lỗi thì báo rõ ràng, không làm mất giỏ hàng.</summary>
        public static void LoiHeThong(Exception ex)
        {
            MessageBox.Show("Không thể kết nối dữ liệu/hệ thống ngoài. Giỏ hàng của bạn vẫn được giữ nguyên.\n\nChi tiết: " + ex.Message,
                "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool XacNhan(string noiDung)
        {
            return MessageBox.Show(noiDung, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
