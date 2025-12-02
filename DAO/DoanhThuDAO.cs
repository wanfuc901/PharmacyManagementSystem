using Microsoft.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DoanhThuDAO
    {
        public static DataTable LayDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
                SELECT CONVERT(date, ngaylap) AS Ngay,
                       COUNT(mahd) AS SoHoaDon,
                       SUM(tongtien) AS TongTien
                FROM hoadon
                WHERE ngaylap BETWEEN @tuNgay AND @denNgay
                GROUP BY CONVERT(date, ngaylap)
                ORDER BY Ngay";
            SqlParameter[] p =
            {
                new SqlParameter("@tuNgay", tuNgay),
                new SqlParameter("@denNgay", denNgay)
            };
            return DataProvider.TruyVanLayDuLieu(sql, p);
        }
    }
}
