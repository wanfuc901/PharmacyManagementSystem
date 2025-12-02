using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT MaKH, TenKH, DiaChi, SDT, Email FROM KhachHang";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        public static bool Insert(KhachHangDTO kh)
        {
            string sql = "INSERT INTO KhachHang (TenKH, DiaChi, SDT, Email) VALUES (@TenKH,@DiaChi,@SDT,@Email)";
            SqlParameter[] param =
            {
                new SqlParameter("@TenKH", kh.TenKH),
                new SqlParameter("@DiaChi", kh.DiaChi),
                new SqlParameter("@SDT", kh.SDT),
                new SqlParameter("@Email", kh.Email)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, param) > 0;
        }

        public static bool Update(KhachHangDTO kh)
        {
            string sql = "UPDATE KhachHang SET TenKH=@TenKH, DiaChi=@DiaChi, SDT=@SDT, Email=@Email WHERE MaKH=@MaKH";
            SqlParameter[] param =
            {
                new SqlParameter("@MaKH", kh.MaKH),
                new SqlParameter("@TenKH", kh.TenKH),
                new SqlParameter("@DiaChi", kh.DiaChi),
                new SqlParameter("@SDT", kh.SDT),
                new SqlParameter("@Email", kh.Email)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, param) > 0;
        }

        public static bool Delete(int maKH)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
            SqlParameter[] param = { new SqlParameter("@MaKH", maKH) };
            return DataProvider.TruyVanKhongLayDuLieu(sql, param) > 0;
        }

        public static DataTable Search(KhachHangDTO kh)
        {
            string sql = "SELECT MaKH, TenKH, DiaChi, SDT, Email FROM KhachHang WHERE 1=1";
            var list = new List<SqlParameter>();

            if (kh.MaKH > 0)
            {
                sql += " AND MaKH=@MaKH";
                list.Add(new SqlParameter("@MaKH", kh.MaKH));
            }
            if (!string.IsNullOrEmpty(kh.TenKH))
            {
                sql += " AND TenKH LIKE @TenKH";
                list.Add(new SqlParameter("@TenKH", "%" + kh.TenKH + "%"));
            }
            if (!string.IsNullOrEmpty(kh.DiaChi))
            {
                sql += " AND DiaChi LIKE @DiaChi";
                list.Add(new SqlParameter("@DiaChi", "%" + kh.DiaChi + "%"));
            }
            if (!string.IsNullOrEmpty(kh.SDT))
            {
                sql += " AND SDT LIKE @SDT";
                list.Add(new SqlParameter("@SDT", "%" + kh.SDT + "%"));
            }
            if (!string.IsNullOrEmpty(kh.Email))
            {
                sql += " AND Email LIKE @Email";
                list.Add(new SqlParameter("@Email", "%" + kh.Email + "%"));
            }

            return DataProvider.TruyVanLayDuLieu(sql, list.ToArray());
        }
        public static DataTable SearchByKeyword(string keyword)
        {
            string sql = @"SELECT MaKH, TenKH, DiaChi, SDT, Email 
                   FROM KhachHang 
                   WHERE TenKH LIKE @kw OR SDT LIKE @kw";

            SqlParameter[] param =
            {
        new SqlParameter("@kw", "%" + keyword + "%")
    };

            return DataProvider.TruyVanLayDuLieu(sql, param);
        }

        public static bool ExistsBySDT(string sdt)
        {
            string sql = "SELECT COUNT(*) FROM KhachHang WHERE SDT=@sdt";
            SqlParameter[] param = { new SqlParameter("@sdt", sdt) };

            object result = DataProvider.TruyVanLayDuLieu(sql, param).Rows[0][0];
            return Convert.ToInt32(result) > 0;
        }


    }
}
