using System.Data;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class DoiMatKhauDAO
    {
        // ✅ Kiểm tra mật khẩu cũ có đúng không
        public static bool KiemTraMatKhauCu(string tendn, string mkcu)
        {
            string sql = "SELECT COUNT(*) FROM taikhoan WHERE tendn=@tendn AND matkhau=@mkcu";
            SqlParameter[] p =
            {
                new SqlParameter("@tendn", tendn),
                new SqlParameter("@mkcu", mkcu)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, p);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }

        // ✅ Cập nhật mật khẩu mới
        public static bool CapNhatMatKhau(string tendn, string mkmoi)
        {
            string sql = "UPDATE taikhoan SET matkhau=@mkmoi WHERE tendn=@tendn";
            SqlParameter[] p =
            {
                new SqlParameter("@mkmoi", mkmoi),
                new SqlParameter("@tendn", tendn)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, p) > 0;
        }
    }
}
