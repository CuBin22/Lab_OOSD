using eShopping.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eShopping.Services
{
    internal class EmailService
    {
        private const int SoLanThuToiDa = 3;

        public void GuiBatDongBo(string maEmail)
        {
            Task.Run(() => XuLyGui(maEmail));
        }

        /// <summary>Dùng cho nút "Gửi lại email" khi trạng thái là Loi hoặc ChoGui.</summary>
        public KetQuaXuLy GuiLai(string maEmail)
        {
            try
            {
                DataTable dt = Db.Query("SELECT TrangThai FROM NhatKyEmail WHERE MaEmail=@m", new SqlParameter("@m", maEmail ?? ""));
                if (dt.Rows.Count == 0) return KetQuaXuLy.Loi("Không tìm thấy email cần gửi.");
                if (Convert.ToString(dt.Rows[0]["TrangThai"]) == "DaGui") return KetQuaXuLy.Loi("Email này đã được gửi.");
                Db.Execute("UPDATE NhatKyEmail SET TrangThai=N'ChoGui' WHERE MaEmail=@m", new SqlParameter("@m", maEmail));
                GuiBatDongBo(maEmail);
                return KetQuaXuLy.Ok("Đang gửi lại email...");
            }
            catch (SqlException ex) { return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message); }
        }

        private void XuLyGui(string maEmail)
        {
            try
            {
                DataTable nk = Db.Query("SELECT MaDonHang, EmailNhan FROM NhatKyEmail WHERE MaEmail=@m", new SqlParameter("@m", maEmail));
                if (nk.Rows.Count == 0) return;
                string maDon = Convert.ToString(nk.Rows[0]["MaDonHang"]);
                string den = Convert.ToString(nk.Rows[0]["EmailNhan"]);

                for (int lan = 1; lan <= SoLanThuToiDa; lan++)
                {
                    Db.Execute("UPDATE NhatKyEmail SET SoLanThu = SoLanThu + 1 WHERE MaEmail=@m", new SqlParameter("@m", maEmail));
                    try
                    {
                        string noiDung = DungNoiDung(maDon);
                        Gui(den, "Xác nhận đơn hàng " + maDon + " - Cửa hàng ABC", noiDung, maDon);
                        Db.Execute("UPDATE NhatKyEmail SET TrangThai=N'DaGui', NgayGui=GETDATE() WHERE MaEmail=@m", new SqlParameter("@m", maEmail));
                        return;
                    }
                    catch (Exception)
                    {
                        if (lan < SoLanThuToiDa) Thread.Sleep(2000 * lan);
                    }
                }
                Db.Execute("UPDATE NhatKyEmail SET TrangThai=N'Loi' WHERE MaEmail=@m", new SqlParameter("@m", maEmail));
            }
            catch (Exception) { /* email chỉ là thông báo, không được làm hỏng đơn hàng (QĐ13) */ }
        }

        private static string DungNoiDung(string maDon)
        {
            DonHangService dh = new DonHangService();
            DataTable don = dh.LayDonHang(maDon, null);
            if (don.Rows.Count == 0) throw new InvalidOperationException("Không tìm thấy đơn hàng.");
            DataRow d = don.Rows[0];
            DataTable ct = dh.LayChiTietDonHang(maDon);

            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body style='font-family:Segoe UI,Arial'>");
            sb.Append("<h2>Cảm ơn bạn đã đặt hàng tại Cửa hàng ABC</h2>");
            sb.AppendFormat("<p>Mã đơn hàng: <b>{0}</b><br/>Ngày đặt: {1:dd/MM/yyyy HH:mm}<br/>Người mua: {2}</p>",
                H(d["MaDonHang"]), Convert.ToDateTime(d["NgayDat"]), H(d["HoTenNguoiMua"]));
            sb.AppendFormat("<p><b>Người nhận:</b> {0} - {1}<br/>Địa chỉ: {2} ({3})<br/>Hình thức giao: {4} (xử lý dự kiến {5} giờ)</p>",
                H(d["HoTenNguoiNhan"]), H(d["SoDienThoaiNguoiNhan"]), H(d["DiaChiNguoiNhan"]), H(d["TenKhuVuc"]),
                H(d["TenLoaiPhieu"]), H(d["ThoiGianXuLyGio"]));
            sb.Append("<table border='1' cellpadding='6' cellspacing='0'><tr><th>Mã SP</th><th>Sản phẩm</th><th>SL</th><th>Đơn giá</th><th>Thành tiền</th></tr>");
            foreach (DataRow r in ct.Rows)
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td align='right'>{2}</td><td align='right'>{3}</td><td align='right'>{4}</td></tr>",
                    H(r["MaSanPham"]), H(r["TenSanPham"]), H(r["SoLuong"]),
                    DinhDang.Tien(Convert.ToDecimal(r["DonGia"])), DinhDang.Tien(Convert.ToDecimal(r["ThanhTien"])));
            sb.Append("</table>");
            sb.AppendFormat("<p>Tiền hàng: {0} đ<br/>Phí giao hàng: {1} đ<br/><b>Tổng giá trị: {2} đ</b></p>",
                DinhDang.Tien(Convert.ToDecimal(d["TongTienHang"])), DinhDang.Tien(Convert.ToDecimal(d["PhiGiaoHang"])),
                DinhDang.Tien(Convert.ToDecimal(d["TongGiaTri"])));
            sb.Append("<p><i>Vì lý do an ninh, email này không hiển thị thông tin thẻ thanh toán.</i></p></body></html>");
            return sb.ToString();
        }

        private static string H(object o) { return WebUtility.HtmlEncode(Convert.ToString(o)); }

        private static void Gui(string den, string tieuDe, string html, string maDon)
        {
            string host = ConfigurationManager.AppSettings["SmtpHost"];
            if (string.IsNullOrWhiteSpace(host))
            {
                string thuMuc = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Emails");
                Directory.CreateDirectory(thuMuc);
                File.WriteAllText(Path.Combine(thuMuc, maDon + ".html"),
                    "<!-- To: " + den + " | Subject: " + tieuDe + " -->\r\n" + html, Encoding.UTF8);
                return;
            }
            string from = ConfigurationManager.AppSettings["SmtpFrom"];
            using (MailMessage mm = new MailMessage(from, den, tieuDe, html))
            using (SmtpClient sc = new SmtpClient(host, int.Parse(ConfigurationManager.AppSettings["SmtpPort"] ?? "587")))
            {
                mm.IsBodyHtml = true;
                mm.BodyEncoding = Encoding.UTF8;
                mm.SubjectEncoding = Encoding.UTF8;
                sc.EnableSsl = string.Equals(ConfigurationManager.AppSettings["SmtpSsl"], "true", StringComparison.OrdinalIgnoreCase);
                sc.Timeout = 15000;
                string user = ConfigurationManager.AppSettings["SmtpUser"];
                if (!string.IsNullOrEmpty(user))
                    sc.Credentials = new NetworkCredential(user, ConfigurationManager.AppSettings["SmtpPassword"]);
                sc.Send(mm);
            }
        }
    }
}
