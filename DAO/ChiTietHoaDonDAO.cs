using System.Data;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        public static DataTable GetByHoaDon(int maHD)
        {
            string sql = "SELECT id, MaHD, MaThuoc, SoLuong, GiaBan FROM ct_hoadon WHERE MaHD=@MaHD";
            SqlParameter[] param = { new SqlParameter("@MaHD", maHD) };
            return DataProvider.TruyVanLayDuLieu(sql, param);
        }
    }
}
