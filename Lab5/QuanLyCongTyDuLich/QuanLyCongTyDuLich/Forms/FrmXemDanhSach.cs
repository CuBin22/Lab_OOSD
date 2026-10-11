using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Hộp thoại chỉ đọc hiển thị một danh sách (DataGridView) kèm dòng tóm tắt.</summary>
    public class FrmXemDanhSach : Form
    {
        private readonly Label lblTomTat;
        private readonly DataGridView dgv;
        private readonly Button btnDong;

        /// <param name="tieuDe">Tiêu đề cửa sổ.</param>
        /// <param name="tomTat">Dòng tóm tắt phía trên danh sách.</param>
        /// <param name="dt">Dữ liệu hiển thị.</param>
        /// <param name="tieuDeCot">Cặp (tên cột, tiêu đề hiển thị) nối tiếp nhau.</param>
        public FrmXemDanhSach(string tieuDe, string tomTat, DataTable dt, params string[] tieuDeCot)
        {
            this.Text = tieuDe;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(860, 420);
            this.MinimumSize = new Size(500, 300);
            this.Font = new Font("Segoe UI", 9F);
            this.ShowInTaskbar = false;

            lblTomTat = new Label();
            lblTomTat.AutoSize = false;
            lblTomTat.Dock = DockStyle.Top;
            lblTomTat.Height = 34;
            lblTomTat.TextAlign = ContentAlignment.MiddleLeft;
            lblTomTat.Padding = new Padding(10, 0, 10, 0);
            lblTomTat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTomTat.Text = tomTat;

            btnDong = new Button();
            btnDong.Text = "Đóng";
            btnDong.Size = new Size(85, 28);
            btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDong.Location = new Point(this.ClientSize.Width - 95, this.ClientSize.Height - 38);
            btnDong.Click += delegate { this.Close(); };

            dgv = new DataGridView();
            dgv.Location = new Point(10, 40);
            dgv.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 88);
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            Ui.DinhDangLuoi(dgv);
            dgv.DataSource = dt;
            Ui.TieuDe(dgv, tieuDeCot);
            Ui.CotTien(dgv, "TongTien", "SoTien");
            Ui.CotNgay(dgv, "NgaySinh", "NgayDi", "NgayVe");

            this.Controls.Add(dgv);
            this.Controls.Add(btnDong);
            this.Controls.Add(lblTomTat);
            this.CancelButton = btnDong;
        }
    }
}
