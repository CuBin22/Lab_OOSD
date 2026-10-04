using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace eShopping.Data
{
    /// <summary>Lớp truy cập dữ liệu dùng chung (giống Db trong dự án mẫu QuanLyThuVien).</summary>
    public static class Db
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["eShoppingDB"].ConnectionString; }
        }

        public static SqlConnection MoKetNoi()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        // ---------- Không giao dịch ----------
        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                cn.Open();
                return cmd.ExecuteScalar();
            }
        }

        // ---------- Có giao dịch (dùng cho ghi đơn hàng - QĐ12) ----------
        public static DataTable Query(SqlTransaction tx, string sql, params SqlParameter[] ps)
        {
            using (SqlCommand cmd = new SqlCommand(sql, tx.Connection, tx))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Execute(SqlTransaction tx, string sql, params SqlParameter[] ps)
        {
            using (SqlCommand cmd = new SqlCommand(sql, tx.Connection, tx))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(SqlTransaction tx, string sql, params SqlParameter[] ps)
        {
            using (SqlCommand cmd = new SqlCommand(sql, tx.Connection, tx))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteScalar();
            }
        }
    }
}
