using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NCCDAO
    {
        // Lấy toàn bộ danh sách
        public static DataTable GetAll()
        {
            string sql = "SELECT mancc, tenncc, sdt, diachi FROM nhacungcap";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        // Thêm NCC
        public static bool Insert(NCCDTO ncc)
        {
            string sql = @"INSERT INTO nhacungcap (tenncc, sdt, diachi) 
                           VALUES (@TenNCC, @SDT, @DiaChi)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenNCC", ncc.TenNCC),
                new SqlParameter("@SDT", ncc.SDT),
                new SqlParameter("@DiaChi", ncc.DiaChi)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        // Cập nhật NCC
        public static bool Update(NCCDTO ncc)
        {
            string sql = @"UPDATE nhacungcap 
                           SET tenncc=@TenNCC, sdt=@SDT, diachi=@DiaChi
                           WHERE mancc=@MaNCC";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", ncc.MaNCC),
                new SqlParameter("@TenNCC", ncc.TenNCC),
                new SqlParameter("@SDT", ncc.SDT),
                new SqlParameter("@DiaChi", ncc.DiaChi)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        // Xóa NCC
        public static bool Delete(int maNCC)
        {
            string sql = "DELETE FROM nhacungcap WHERE mancc=@MaNCC";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", maNCC)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        public static List<string> LayDanhSach()
        {
            string sql = "SELECT tenncc FROM nhacungcap ORDER BY tenncc";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql);

            return dt.AsEnumerable()
                     .Select(r => r["tenncc"].ToString())
                     .ToList();
        }

        // Tìm kiếm NCC
        public static DataTable Search(NCCDTO ncc)
        {
            string sql = "SELECT mancc, tenncc, sdt, diachi FROM nhacungcap WHERE 1=1";
            var parameters = new List<SqlParameter>();

            if (ncc.MaNCC > 0)
            {
                sql += " AND mancc=@MaNCC";
                parameters.Add(new SqlParameter("@MaNCC", ncc.MaNCC));
            }
            if (!string.IsNullOrWhiteSpace(ncc.TenNCC))
            {
                sql += " AND tenncc LIKE @TenNCC";
                parameters.Add(new SqlParameter("@TenNCC", "%" + ncc.TenNCC + "%"));
            }
            if (!string.IsNullOrWhiteSpace(ncc.SDT))
            {
                sql += " AND sdt LIKE @SDT";
                parameters.Add(new SqlParameter("@SDT", "%" + ncc.SDT + "%"));
            }
            if (!string.IsNullOrWhiteSpace(ncc.DiaChi))
            {
                sql += " AND diachi LIKE @DiaChi";
                parameters.Add(new SqlParameter("@DiaChi", "%" + ncc.DiaChi + "%"));
            }

            return DataProvider.TruyVanLayDuLieu(sql, parameters.ToArray());
        }
    }
}
