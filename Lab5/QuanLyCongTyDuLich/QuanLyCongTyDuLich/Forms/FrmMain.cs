using System;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Forms
{
    /// <summary>Màn hình chính: điều hướng tới các form chức năng (FrmMain trong sơ đồ kiến trúc).</summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnDanhMuc.Image = Ui.Icon("icon_danhmuc.png");
            btnTour.Image = Ui.Icon("icon_tour.png");
            btnKhachHang.Image = Ui.Icon("icon_khachhang.png");
            btnDangKy.Image = Ui.Icon("icon_dangky.png");
            btnThanhToan.Image = Ui.Icon("icon_thanhtoan.png");
            btnPhanCong.Image = Ui.Icon("icon_phancong.png");
            btnKhaoSat.Image = Ui.Icon("icon_khaosat.png");
            btnThongKe.Image = Ui.Icon("icon_thongke.png");
            btnThoat.Image = Ui.Icon("icon_thoat.png");

            try
            {
                Db.Scalar("SELECT 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu QuanLyCongTyDuLich.\n" +
                                "Hãy chạy script Database\\Script_Tao_CSDL_Cong_Ty_Du_Lich.sql và kiểm tra chuỗi kết nối trong App.config.\n\n" + ex.Message,
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MoForm(Form f)
        {
            using (f)
            {
                f.ShowDialog(this);
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            MoForm(new FrmDanhMuc());
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            MoForm(new FrmTour());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MoForm(new FrmKhachHang());
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            MoForm(new FrmDangKy());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MoForm(new FrmThanhToan());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            MoForm(new FrmPhanCong());
        }

        private void btnKhaoSat_Click(object sender, EventArgs e)
        {
            MoForm(new FrmKhaoSat());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MoForm(new FrmThongKe());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (Ui.Hoi("Bạn có muốn thoát chương trình?")) this.Close();
        }
    }
}
