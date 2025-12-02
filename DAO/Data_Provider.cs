using System.Data;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        // Chuỗi kết nối tới SQL Server
        private static string connectionString =
            @"Data Source=HOANGPHUCPC\SQLEXPRESS;Initial Catalog=QL_NhaThuoc;Integrated Security=True;TrustServerCertificate=True";

        // Mở kết nối
        public static SqlConnection MoKetNoi()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // Đóng kết nối
        public static void DongKetNoi(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        // SELECT → trả về DataTable
        public static DataTable TruyVanLayDuLieu(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = MoKetNoi())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        // INSERT, UPDATE, DELETE → trả về số dòng ảnh hưởng
        public static int TruyVanKhongLayDuLieu(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = MoKetNoi())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
