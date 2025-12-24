using System.Data;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class CT_PhieuTraDAO
    {
        public static DataTable LayTheoMaPhieuTra(int maTra)
        {
            string sql = @"
                SELECT 
                    c.id,
                    c.matra,
                    t.tenthuoc,
                    c.soluong,
                    c.giatra,
                    (c.soluong * c.giatra) AS thanhtien
                FROM ct_phieutra c
                JOIN thuoc t ON c.mathuoc = t.mathuoc
                WHERE c.matra = @matra
            ";

            SqlParameter[] p =
            {
                new SqlParameter("@matra", maTra)
            };

            return DataProvider.TruyVanLayDuLieu(sql, p);
        }
    }
}
