using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TKDAO
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT id, tendn, matkhau, vaitro FROM taikhoan";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        public static bool Insert(TKDTO tk)
        {
            string sql = "INSERT INTO taikhoan (tendn, matkhau, vaitro) VALUES (@tendn, @matkhau, @vaitro)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@tendn", tk.TenDN),
                new SqlParameter("@matkhau", tk.MatKhau),
                new SqlParameter("@vaitro", tk.VaiTro)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        public static bool Update(TKDTO tk)
        {
            string sql = "UPDATE taikhoan SET matkhau=@matkhau, vaitro=@vaitro WHERE id=@id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@matkhau", tk.MatKhau),
                new SqlParameter("@vaitro", tk.VaiTro),
                new SqlParameter("@id", tk.Id)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        public static bool Delete(int id)
        {
            string sql = "DELETE FROM taikhoan WHERE id=@id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        public static DataTable Search(string keyword)
        {
            string sql = "SELECT id, tendn, matkhau, vaitro FROM taikhoan WHERE tendn LIKE @kw";
            SqlParameter[] parameters =
            {
                new SqlParameter("@kw", "%" + keyword + "%")
            };
            return DataProvider.TruyVanLayDuLieu(sql, parameters);
        }

        public static bool Exists(string tendn)
        {
            string sql = "SELECT COUNT(*) FROM taikhoan WHERE tendn=@tendn";
            SqlParameter[] parameters =
            {
                new SqlParameter("@tendn", tendn)
            };
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, parameters);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }
    }
}
