using eShopping.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static eShopping.Models.Models;

namespace eShopping.Services
{
    public interface IPaymentGateway
    {
        /// <summary>Kiểm tra thẻ hợp lệ và đủ khả năng thanh toán số tiền soTien.</summary>
        KetQuaXuLy KiemTraThe(TheThanhToan the, decimal soTien);
    }

    /// <summary>
    /// Cổng thanh toán GIẢ LẬP để chạy bài lab. Quy ước thử nghiệm:
    ///  - Số thẻ sai thuật toán Luhn  -> "thẻ không hợp lệ".
    ///  - Số thẻ kết thúc bằng 0000   -> "không đủ khả năng thanh toán".
    ///  - Còn lại                     -> thành công.
    /// Thẻ thử: Visa 4111111111111111, Amex 378282246310005.
    /// </summary>
    public class MockPaymentGateway : IPaymentGateway
    {
        public KetQuaXuLy KiemTraThe(TheThanhToan the, decimal soTien)
        {
            Thread.Sleep(800);   // giả lập độ trễ mạng
            if (!Luhn(the.SoThe)) return KetQuaXuLy.Loi("Số thẻ không hợp lệ (không qua kiểm tra của ngân hàng).");
            if (the.SoThe.EndsWith("0000")) return KetQuaXuLy.Loi("Thẻ không đủ khả năng thanh toán số tiền này.");
            return KetQuaXuLy.Ok("Thẻ hợp lệ.");
        }

        private static bool Luhn(string so)
        {
            int tong = 0; bool nhan2 = false;
            for (int i = so.Length - 1; i >= 0; i--)
            {
                int d = so[i] - '0';
                if (nhan2) { d *= 2; if (d > 9) d -= 9; }
                tong += d; nhan2 = !nhan2;
            }
            return tong % 10 == 0;
        }
    }
    internal class ThanhToanService
    {
        /// <summary>Thay bằng cổng thanh toán thật khi triển khai.</summary>
        public static IPaymentGateway Gateway = new MockPaymentGateway();
        private static readonly TimeSpan ThoiGianChoToiDa = TimeSpan.FromSeconds(10);   // NFR02

        public DataTable LayLoaiThe()
        {
            return Db.Query("SELECT MaLoaiThe, TenLoaiThe, SoChuSoThe, SoChuSoCSV, LePhi FROM LoaiThe ORDER BY TenLoaiThe");
        }

        public decimal LayLePhi(string maLoaiThe)
        {
            object o = Db.Scalar("SELECT LePhi FROM LoaiThe WHERE MaLoaiThe=@m", new SqlParameter("@m", maLoaiThe ?? ""));
            return o == null || o == DBNull.Value ? 0m : Convert.ToDecimal(o);
        }

        /// <summary>QĐ08: kiểm tra định dạng thẻ (BR13-BR16) trước khi gọi hệ thống thanh toán.</summary>
        public KetQuaXuLy KiemTraDinhDang(TheThanhToan the)
        {
            if (the == null) return KetQuaXuLy.Loi("Chưa nhập thông tin thẻ.");
            if (string.IsNullOrWhiteSpace(the.MaLoaiThe)) return KetQuaXuLy.Loi("Vui lòng chọn loại thẻ.");
            DataTable lt = Db.Query("SELECT SoChuSoThe, SoChuSoCSV, TenLoaiThe FROM LoaiThe WHERE MaLoaiThe=@m", new SqlParameter("@m", the.MaLoaiThe));
            if (lt.Rows.Count == 0) return KetQuaXuLy.Loi("Chỉ chấp nhận thẻ Visa, Master, Discover hoặc American Express.");
            int soSo = Convert.ToInt32(lt.Rows[0]["SoChuSoThe"]);
            int soCsv = Convert.ToInt32(lt.Rows[0]["SoChuSoCSV"]);
            string ten = Convert.ToString(lt.Rows[0]["TenLoaiThe"]);

            the.SoThe = Regex.Replace(the.SoThe ?? "", @"[\s-]", "");
            if (!Regex.IsMatch(the.SoThe, "^[0-9]{" + soSo + "}$"))
                return KetQuaXuLy.Loi("Số thẻ " + ten + " phải gồm đúng " + soSo + " chữ số.");
            if (!Regex.IsMatch(the.CSV ?? "", "^[0-9]{" + soCsv + "}$"))
                return KetQuaXuLy.Loi("Mã CSV của thẻ " + ten + " phải gồm đúng " + soCsv + " chữ số.");
            if (string.IsNullOrWhiteSpace(the.HoTenChuThe) || the.HoTenChuThe.Trim().Length < 2)
                return KetQuaXuLy.Loi("Vui lòng nhập họ tên chủ thẻ.");
            DateTime dauThang = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            if (new DateTime(the.NgayHetHan.Year, the.NgayHetHan.Month, 1) < dauThang)
                return KetQuaXuLy.Loi("Thẻ đã hết hạn.");
            return KetQuaXuLy.Ok("Định dạng thẻ hợp lệ.");
        }

        /// <summary>Gọi hệ thống thanh toán trực tuyến, có thời gian chờ tối đa (NFR02, NFR10).</summary>
        public KetQuaXuLy KiemTraTheOnline(TheThanhToan the, decimal soTien)
        {
            try
            {
                Task<KetQuaXuLy> t = Task.Run(() => Gateway.KiemTraThe(the, soTien));
                if (!t.Wait(ThoiGianChoToiDa))
                    return KetQuaXuLy.Loi("Hệ thống thanh toán không phản hồi. Giỏ hàng vẫn được giữ, vui lòng thử lại sau.");
                return t.Result;
            }
            catch (AggregateException ex)
            {
                return KetQuaXuLy.Loi("Không kết nối được hệ thống thanh toán: " + ex.GetBaseException().Message);
            }
        }
    }
}
