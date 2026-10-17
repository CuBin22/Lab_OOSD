using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhVien.Forms;

namespace QuanLyBenhVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var dn = new FrmDangNhap())
            {
                if (dn.ShowDialog() != DialogResult.OK) return;
            }
            Application.Run(new FrmMain());
        }
    }
}
