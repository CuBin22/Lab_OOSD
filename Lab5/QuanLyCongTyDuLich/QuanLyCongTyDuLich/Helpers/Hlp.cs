using System;
using System.Data.SqlClient;
using QuanLyCongTyDuLich.Data;

namespace QuanLyCongTyDuLich.Helpers
{
    /// <summary>Tiện ích truy cập dữ liệu dùng chung.</summary>
    public static class Hlp
    {
        /// <summary>Tạo SqlParameter; chuỗi rỗng hoặc null được chuyển thành DBNull.</summary>
        public static SqlParameter P(string ten, object giaTri)
        {
            if (giaTri == null) return new SqlParameter(ten, DBNull.Value);
            string s = giaTri as string;
            if (s != null && s.Trim().Length == 0) return new SqlParameter(ten, DBNull.Value);
            return new SqlParameter(ten, giaTri);
        }

        /// <summary>Sinh mã kế tiếp, ví dụ MaTiepTheo("Tour","MaTour","T",2) -> T03.</summary>
        public static string MaTiepTheo(string bang, string cot, string tienTo, int doRong)
        {
            string sql = "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(" + cot + ", " + (tienTo.Length + 1) + ", 20) AS int)), 0) + 1 FROM "
                         + bang + " WHERE " + cot + " LIKE @pre";
            object o = Db.Scalar(sql, new SqlParameter("@pre", tienTo + "%"));
            int n = Convert.ToInt32(o);
            return tienTo + n.ToString().PadLeft(doRong, '0');
        }

        /// <summary>Đổi lỗi SQL thành thông báo dễ hiểu.</summary>
        public static string LoiSql(Exception ex)
        {
            SqlException s = ex as SqlException;
            if (s == null) return ex.Message;
            if (s.Number == 2627 || s.Number == 2601) return "Mã hoặc giá trị bị trùng, dữ liệu đã tồn tại.";
            if (s.Number == 547)
            {
                if (s.Message.IndexOf("DELETE", StringComparison.OrdinalIgnoreCase) >= 0)
                    return "Dữ liệu đã phát sinh nghiệp vụ (đang được sử dụng ở nơi khác) nên không thể xóa.";
                return "Dữ liệu vi phạm ràng buộc: " + s.Message;
            }
            if (s.Number >= 50000) return s.Message;
            return "Lỗi cơ sở dữ liệu: " + s.Message;
        }
    }
}
