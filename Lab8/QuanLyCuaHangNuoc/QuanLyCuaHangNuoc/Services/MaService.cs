using System;
using System.Data.SqlClient;
using QuanLyCuaHangNuoc.Data;

namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Sinh mã chứng từ tự động (DDH004, HD005, ...).</summary>
    public static class MaService
    {
        public static string Tiep(string bang, string cot, string tienTo, int doDai, SqlTransaction tx = null)
        {
            string sql = "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(" + cot + "," + (tienTo.Length + 1) + ",20) AS INT)),0) FROM "
                         + bang + " WHERE " + cot + " LIKE @p";
            SqlParameter p = Db.P("@p", tienTo + "%");
            object o = tx == null ? Db.Scalar(sql, p) : Db.Scalar(tx, sql, p);
            int n = Convert.ToInt32(o) + 1;
            return tienTo + n.ToString().PadLeft(doDai, '0');
        }
    }
}
