using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using QuanLyCongTyDuLich.Data;
using QuanLyCongTyDuLich.Helpers;

namespace QuanLyCongTyDuLich.Services
{
    /// <summary>
    /// Xuất thông tin các tour ra một trang HTML tĩnh để đăng lên website công ty
    /// (đề bài: "cung cấp thông tin các tour du lịch để quảng cáo trên website").
    /// </summary>
    public static class WebsiteService
    {
        private static string H(object o)
        {
            return WebUtility.HtmlEncode(Convert.ToString(o));
        }

        /// <summary>Tạo file HTML chứa toàn bộ tour: giá, lộ trình, điểm tham quan, các chuyến sắp khởi hành.</summary>
        public static void XuatTrangTour(string duongDan)
        {
            DataTable tours = Db.Query("SELECT MaTour, TenTour, SoNgay, SoDem, DonGia FROM Tour ORDER BY MaTour");
            if (tours.Rows.Count == 0)
                throw new InvalidOperationException("Chưa có tour nào để xuất.");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"vi\"><head><meta charset=\"utf-8\">");
            sb.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">");
            sb.AppendLine("<title>Các tour du lịch - Công ty Văn Hóa Việt</title>");
            sb.AppendLine("<style>");
            sb.AppendLine("body{font-family:Segoe UI,Arial,sans-serif;background:#f3f6fa;color:#222;margin:0}");
            sb.AppendLine("header{background:#1f5fa8;color:#fff;padding:22px 32px}");
            sb.AppendLine("header h1{margin:0;font-size:26px}header p{margin:6px 0 0}");
            sb.AppendLine("main{max-width:960px;margin:20px auto;padding:0 16px}");
            sb.AppendLine(".tour{background:#fff;border-radius:8px;box-shadow:0 1px 4px rgba(0,0,0,.15);margin-bottom:20px;padding:18px 22px}");
            sb.AppendLine(".tour h2{margin:0 0 6px;color:#1f5fa8}");
            sb.AppendLine(".gia{font-size:20px;color:#c0392b;font-weight:bold}");
            sb.AppendLine("h3{margin:16px 0 6px;font-size:15px;color:#444}");
            sb.AppendLine("ol,ul{margin:0;padding-left:22px}li{margin:3px 0}");
            sb.AppendLine("small{color:#666}");
            sb.AppendLine("footer{text-align:center;color:#777;padding:16px;font-size:13px}");
            sb.AppendLine("</style></head><body>");
            sb.AppendLine("<header><h1>Công ty du lịch Văn Hóa Việt TP.HCM</h1>");
            sb.AppendLine("<p>Các tour du lịch khởi hành và kết thúc tại TP.HCM</p></header><main>");

            foreach (DataRow t in tours.Rows)
            {
                string maTour = Convert.ToString(t["MaTour"]);
                sb.AppendLine("<section class=\"tour\">");
                sb.AppendLine("<h2>" + H(t["TenTour"]) + " <small>(" + H(maTour) + ")</small></h2>");
                sb.AppendLine("<div>" + H(t["SoNgay"]) + " ngày " + H(t["SoDem"]) + " đêm &middot; <span class=\"gia\">"
                              + Ui.Tien(Convert.ToDecimal(t["DonGia"])) + " đ</span> / khách</div>");

                // Lộ trình: các nơi dừng chân theo thứ tự, cuối cùng về TP.HCM
                DataTable dc = Db.Query(
                    "SELECT dc.ThuTu, dd.TenDiaDiem, pt.TenPT, dc.DoiPhuongTien, dc.CoNoiAn, dc.CoKhachSan, dc.LoaiKhachSan " +
                    "FROM DungChan dc JOIN DiaDiem dd ON dd.MaDiaDiem = dc.MaDiaDiem JOIN PhuongTien pt ON pt.MaPT = dc.MaPT " +
                    "WHERE dc.MaTour = @t ORDER BY dc.ThuTu", Hlp.P("@t", maTour));
                sb.AppendLine("<h3>Lộ trình (khởi hành từ TP.HCM)</h3>");
                if (dc.Rows.Count == 0)
                {
                    sb.AppendLine("<small>Đang cập nhật lộ trình.</small>");
                }
                else
                {
                    sb.AppendLine("<ol>");
                    foreach (DataRow r in dc.Rows)
                    {
                        StringBuilder dong = new StringBuilder();
                        dong.Append("<b>" + H(r["TenDiaDiem"]) + "</b> - đi bằng " + H(r["TenPT"]));
                        if (Convert.ToBoolean(r["DoiPhuongTien"])) dong.Append(" (đổi phương tiện)");
                        if (Convert.ToBoolean(r["CoNoiAn"])) dong.Append("; có nơi ăn");
                        if (Convert.ToBoolean(r["CoKhachSan"])) dong.Append("; ở khách sạn " + H(r["LoaiKhachSan"]) + " sao");
                        sb.AppendLine("<li>" + dong + "</li>");
                    }
                    sb.AppendLine("</ol>");
                }

                // Điểm tham quan
                DataTable tq = Db.Query(
                    "SELECT d.TenDiemTQ, d.DiaDiem, d.NoiDung, d.YNghia FROM ChiTietTourDiemTQ c " +
                    "JOIN DiemThamQuan d ON d.MaDiemTQ = c.MaDiemTQ WHERE c.MaTour = @t ORDER BY d.TenDiemTQ", Hlp.P("@t", maTour));
                if (tq.Rows.Count > 0)
                {
                    sb.AppendLine("<h3>Điểm tham quan</h3><ul>");
                    foreach (DataRow r in tq.Rows)
                    {
                        string them = "";
                        if (Convert.ToString(r["DiaDiem"]).Length > 0) them += " (" + H(r["DiaDiem"]) + ")";
                        if (Convert.ToString(r["NoiDung"]).Length > 0) them += ": " + H(r["NoiDung"]) + ".";
                        if (Convert.ToString(r["YNghia"]).Length > 0) them += " <small>Ý nghĩa: " + H(r["YNghia"]) + "</small>";
                        sb.AppendLine("<li><b>" + H(r["TenDiemTQ"]) + "</b>" + them + "</li>");
                    }
                    sb.AppendLine("</ul>");
                }

                // Các chuyến sắp khởi hành (khách lẻ)
                DataTable ch = DangKyChuyenService.LayChuyenCon(maTour);
                sb.AppendLine("<h3>Chuyến sắp khởi hành</h3>");
                if (ch.Rows.Count == 0)
                {
                    sb.AppendLine("<small>Hiện chưa có chuyến mới. Khách đi đoàn vui lòng liên hệ để chọn ngày đi.</small>");
                }
                else
                {
                    sb.AppendLine("<ul>");
                    foreach (DataRow r in ch.Rows)
                    {
                        sb.AppendLine("<li>Đi " + Convert.ToDateTime(r["NgayDi"]).ToString("dd/MM/yyyy") + " - về "
                                      + Convert.ToDateTime(r["NgayVe"]).ToString("dd/MM/yyyy") + " <small>(còn "
                                      + H(r["ConLai"]) + " chỗ)</small></li>");
                    }
                    sb.AppendLine("</ul>");
                }
                sb.AppendLine("</section>");
            }

            sb.AppendLine("</main><footer>Cập nhật ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "</footer></body></html>");
            File.WriteAllText(duongDan, sb.ToString(), new UTF8Encoding(false));
        }
    }
}
