using Microsoft.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class PhieuNhapDAO
    {
        public static DataTable LayDanhSach()
        {
            string sql = @"SELECT p.mapn, p.ngaynhap, n.tenncc, p.tongtien
                           FROM phieunhap p JOIN nhacungcap n ON p.mancc = n.mancc
                           ORDER BY p.mapn DESC";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        public static bool Them(int mancc, decimal tongtien)
        {
            string sql = "INSERT INTO phieunhap(mancc, tongtien, ngaynhap) VALUES(@mancc, @tongtien, GETDATE())";
            SqlParameter[] p =
            {
                new SqlParameter("@mancc", mancc),
                new SqlParameter("@tongtien", tongtien)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, p) > 0;
        }

        public static DataTable TimTheoNCC(string kw)
        {
            string sql = @"SELECT p.mapn, p.ngaynhap, n.tenncc, p.tongtien
                           FROM phieunhap p JOIN nhacungcap n ON p.mancc = n.mancc
                           WHERE n.tenncc LIKE @kw";
            SqlParameter[] p = { new SqlParameter("@kw", "%" + kw + "%") };
            return DataProvider.TruyVanLayDuLieu(sql, p);
        }
    }
}
