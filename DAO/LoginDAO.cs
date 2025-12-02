using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public static string? KiemTraDangNhap(string user, string pass)
        {
            string sql = "SELECT vaitro FROM taikhoan WHERE tendn=@user AND matkhau=@pass";

            SqlParameter[] parameters =
            {
                new SqlParameter("@user", user),
                new SqlParameter("@pass", pass)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, parameters);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["vaitro"].ToString();

            return null; // không tìm thấy
        }

        public static bool Insert(TaiKhoanDTO tk)
        {
            string sql = "INSERT INTO taikhoan (tendn, matkhau, vaitro) VALUES (@user, @pass, @role)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@user", tk.TenDN),
                new SqlParameter("@pass", tk.MatKhau),
                new SqlParameter("@role", tk.VaiTro)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        public static bool Exists(string user)
        {
            string sql = "SELECT COUNT(*) FROM taikhoan WHERE tendn=@user";
            SqlParameter[] parameters =
            {
        new SqlParameter("@user", user)
    };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, parameters);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }

    }
}
