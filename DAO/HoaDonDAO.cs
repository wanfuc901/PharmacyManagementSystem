using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT MaHD, NgayLap, MaKH, TongTien FROM HoaDon";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        public static bool Insert(HoaDonDTO hd)
        {
            string sql = "INSERT INTO HoaDon (NgayLap, MaKH, TongTien) VALUES (@NgayLap, @MaKH, @TongTien)";
            SqlParameter[] param =
            {
                new SqlParameter("@NgayLap", hd.NgayLap),
                new SqlParameter("@MaKH", hd.MaKH),
                new SqlParameter("@TongTien", hd.TongTien)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, param) > 0;
        }

        public static bool Update(HoaDonDTO hd)
        {
            string sql = "UPDATE HoaDon SET NgayLap=@NgayLap, MaKH=@MaKH, TongTien=@TongTien WHERE MaHD=@MaHD";
            SqlParameter[] param =
            {
                new SqlParameter("@MaHD", hd.MaHD),
                new SqlParameter("@NgayLap", hd.NgayLap),
                new SqlParameter("@MaKH", hd.MaKH),
                new SqlParameter("@TongTien", hd.TongTien)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, param) > 0;
        }

        public static bool Delete(int maHD)
        {
            string sql = "DELETE FROM HoaDon WHERE MaHD=@MaHD";
            SqlParameter[] param = { new SqlParameter("@MaHD", maHD) };
            return DataProvider.TruyVanKhongLayDuLieu(sql, param) > 0;
        }

        public static DataTable Search(HoaDonDTO hd)
        {
            string sql = "SELECT MaHD, NgayLap, MaKH, TongTien FROM HoaDon WHERE 1=1";
            var list = new List<SqlParameter>();

            if (hd.MaHD > 0)
            {
                sql += " AND MaHD=@MaHD";
                list.Add(new SqlParameter("@MaHD", hd.MaHD));
            }
            if (hd.MaKH > 0)
            {
                sql += " AND MaKH=@MaKH";
                list.Add(new SqlParameter("@MaKH", hd.MaKH));
            }
            if (hd.TongTien > 0)
            {
                sql += " AND TongTien=@TongTien";
                list.Add(new SqlParameter("@TongTien", hd.TongTien));
            }

            return DataProvider.TruyVanLayDuLieu(sql, list.ToArray());
        }
    }
}
