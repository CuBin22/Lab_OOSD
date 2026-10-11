using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Danh mục: địa điểm, phương tiện, điểm tham quan, điểm bán vé, điểm đón.</summary>
    public partial class FrmDanhMuc : Form
    {
        private class CauHinh
        {
            public string Ten;
            public string Bang;
            public string TienTo;
            public string[] Cot;      // Cot[0] = mã (khóa), Cot[1] = tên, Cot[2..] = thông tin thêm
            public string[] TieuDe;
            public string[] Nhan;     // nhãn cho ô Thông tin 1..3
        }

        private CauHinh _cfg;

        public FrmDanhMuc()
        {
            InitializeComponent();
            Ui.DinhDangLuoi(dgvDanhMuc);
        }

        private CauHinh LayCauHinh(string loai)
        {
            CauHinh c = new CauHinh();
            c.Ten = loai;
            switch (loai)
            {
                case "PhuongTien":
                    c.Bang = "PhuongTien"; c.TienTo = "PT";
                    c.Cot = new string[] { "MaPT", "TenPT" };
                    c.TieuDe = new string[] { "Mã phương tiện", "Tên phương tiện" };
                    c.Nhan = new string[0];
                    break;
                case "DiemThamQuan":
                    c.Bang = "DiemThamQuan"; c.TienTo = "TQ";
                    c.Cot = new string[] { "MaDiemTQ", "TenDiemTQ", "DiaDiem", "NoiDung", "YNghia" };
                    c.TieuDe = new string[] { "Mã điểm TQ", "Tên điểm tham quan", "Địa điểm", "Nội dung", "Ý nghĩa" };
                    c.Nhan = new string[] { "Địa điểm", "Nội dung", "Ý nghĩa" };
                    break;
                case "DiemBanVe":
                    c.Bang = "DiemBanVe"; c.TienTo = "BV";
                    c.Cot = new string[] { "MaDiemBan", "TenDiemBan", "DiaChi", "DienThoai" };
                    c.TieuDe = new string[] { "Mã điểm bán", "Tên điểm bán vé", "Địa chỉ", "Điện thoại" };
                    c.Nhan = new string[] { "Địa chỉ", "Điện thoại" };
                    break;
                case "DiemDon":
                    c.Bang = "DiemDon"; c.TienTo = "DO";
                    c.Cot = new string[] { "MaDiemDon", "TenDiemDon", "DiaChi" };
                    c.TieuDe = new string[] { "Mã điểm đón", "Tên điểm đón", "Địa chỉ" };
                    c.Nhan = new string[] { "Địa chỉ" };
                    break;
                default:
                    c.Ten = "DiaDiem";
                    c.Bang = "DiaDiem"; c.TienTo = "DD";
                    c.Cot = new string[] { "MaDiaDiem", "TenDiaDiem" };
                    c.TieuDe = new string[] { "Mã địa điểm", "Tên địa điểm" };
                    c.Nhan = new string[0];
                    break;
            }
            return c;
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            ChonLoai("DiaDiem");
        }

        private void ChonLoai(string loai)
        {
            _cfg = LayCauHinh(loai);

            Label[] nhan = new Label[] { lblThongTin1, lblThongTin2, lblThongTin3 };
            TextBox[] o = new TextBox[] { txtThongTin1, txtThongTin2, txtThongTin3 };
            for (int i = 0; i < 3; i++)
            {
                bool co = i < _cfg.Nhan.Length;
                nhan[i].Visible = co;
                o[i].Visible = co;
                if (co) nhan[i].Text = _cfg.Nhan[i] + ":";
            }

            LinkLabel[] links = new LinkLabel[] { lnkDiaDiem, lnkPhuongTien, lnkDiemThamQuan, lnkDiemBanVe, lnkDiemDon };
            foreach (LinkLabel l in links)
            {
                bool dangChon = (l.Name == "lnk" + _cfg.Ten);
                l.Font = new Font(l.Font, dangChon ? FontStyle.Bold : FontStyle.Regular);
            }

            LamMoi();
            NapLuoi();
        }

        private void NapLuoi()
        {
            try
            {
                DataTable dt = Db.Query("SELECT " + string.Join(", ", _cfg.Cot) + " FROM " + _cfg.Bang + " ORDER BY " + _cfg.Cot[0]);
                dgvDanhMuc.DataSource = dt;
                for (int i = 0; i < _cfg.Cot.Length; i++)
                    dgvDanhMuc.Columns[_cfg.Cot[i]].HeaderText = _cfg.TieuDe[i];
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void LamMoi()
        {
            txtMa.ReadOnly = false;
            txtMa.Text = Hlp.MaTiepTheo(_cfg.Bang, _cfg.Cot[0], _cfg.TienTo, 2);
            txtTen.Clear();
            txtThongTin1.Clear();
            txtThongTin2.Clear();
            txtThongTin3.Clear();
            lblThongBao.Text = "";
            txtTen.Focus();
        }

        private string[] LayGiaTri()
        {
            TextBox[] o = new TextBox[] { txtMa, txtTen, txtThongTin1, txtThongTin2, txtThongTin3 };
            string[] kq = new string[_cfg.Cot.Length];
            for (int i = 0; i < kq.Length; i++) kq[i] = o[i].Text.Trim();
            return kq;
        }

        private SqlParameter[] TaoThamSo(string[] gt)
        {
            SqlParameter[] ps = new SqlParameter[gt.Length];
            for (int i = 0; i < gt.Length; i++) ps[i] = Hlp.P("@p" + i, gt[i]);
            return ps;
        }

        private void lnkDiaDiem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChonLoai("DiaDiem");
        }

        private void lnkPhuongTien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChonLoai("PhuongTien");
        }

        private void lnkDiemThamQuan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChonLoai("DiemThamQuan");
        }

        private void lnkDiemBanVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChonLoai("DiemBanVe");
        }

        private void lnkDiemDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChonLoai("DiemDon");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string[] gt = LayGiaTri();
            if (gt[0].Length == 0 || gt[1].Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Vui lòng nhập mã và tên.", false);
                return;
            }
            if (txtMa.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Đang chọn một dòng để sửa. Bấm \"Làm mới\" để nhập mục mới.", false);
                return;
            }
            string[] ten = new string[gt.Length];
            string[] giaTri = new string[gt.Length];
            for (int i = 0; i < gt.Length; i++) { ten[i] = "@p" + i; giaTri[i] = gt[i]; }
            try
            {
                Db.Execute("INSERT INTO " + _cfg.Bang + " (" + string.Join(", ", _cfg.Cot) + ") VALUES (" + string.Join(", ", ten) + ")", TaoThamSo(gt));
                NapLuoi();
                LamMoi();
                Ui.ThongBao(lblThongBao, "Đã thêm mục mới.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtMa.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn dòng cần sửa trong danh sách.", false);
                return;
            }
            string[] gt = LayGiaTri();
            if (gt[1].Length == 0)
            {
                Ui.ThongBao(lblThongBao, "Vui lòng nhập tên.", false);
                return;
            }
            string[] gan = new string[_cfg.Cot.Length - 1];
            for (int i = 1; i < _cfg.Cot.Length; i++) gan[i - 1] = _cfg.Cot[i] + " = @p" + i;
            try
            {
                Db.Execute("UPDATE " + _cfg.Bang + " SET " + string.Join(", ", gan) + " WHERE " + _cfg.Cot[0] + " = @p0", TaoThamSo(gt));
                NapLuoi();
                Ui.ThongBao(lblThongBao, "Đã cập nhật.", true);
            }
            catch (Exception ex)
            {
                Ui.ThongBao(lblThongBao, Hlp.LoiSql(ex), false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!txtMa.ReadOnly)
            {
                Ui.ThongBao(lblThongBao, "Hãy chọn dòng cần xóa trong danh sách.", false);
                return;
            }
            if (!Ui.Hoi("Xóa mục \"" + txtTen.Text.Trim() + "\"?")) return;
            try
            {
                Db.Execute("DELETE FROM " + _cfg.Bang + " WHERE " + _cfg.Cot[0] + " = @ma", Hlp.P("@ma", txtMa.Text.Trim()));
                NapLuoi();
                LamMoi();
                Ui.ThongBao(lblThongBao, "Đã xóa.", true);
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

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvDanhMuc.Rows[e.RowIndex];
            TextBox[] o = new TextBox[] { txtMa, txtTen, txtThongTin1, txtThongTin2, txtThongTin3 };
            for (int i = 0; i < _cfg.Cot.Length; i++)
                o[i].Text = Convert.ToString(r.Cells[_cfg.Cot[i]].Value);
            txtMa.ReadOnly = true;
            lblThongBao.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
