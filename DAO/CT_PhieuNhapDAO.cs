using System.Data;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class CT_PhieuNhapDAO
    {
        public static DataTable LayTheoMaPN(int maPN)
        {
            string sql = @"
                SELECT 
                    c.id,
                    c.mapn,
                    c.mathuoc,
                    t.tenthuoc,
                    c.soluong,
                    c.gianhap,
                    (c.soluong * c.gianhap) AS thanhtien
                FROM ct_phieunhap c
                JOIN thuoc t ON c.mathuoc = t.mathuoc
                WHERE c.mapn = @mapn
            ";

            SqlParameter[] parameters =
            {
                new SqlParameter("@mapn", maPN)
            };

            return DataProvider.TruyVanLayDuLieu(sql, parameters);
        }
    }
}
