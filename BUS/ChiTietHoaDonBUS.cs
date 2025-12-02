using System.Data;
using DAO;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        public static DataTable GetByHoaDon(int maHD)
        {
            return ChiTietHoaDonDAO.GetByHoaDon(maHD);
        }
    }
}
