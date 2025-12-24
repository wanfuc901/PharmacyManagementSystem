using System.Data;
using DAO;

namespace BUS
{
    public class CT_PhieuTraBUS
    {
        public static DataTable LayChiTiet(int maTra)
        {
            return CT_PhieuTraDAO.LayTheoMaPhieuTra(maTra);
        }
    }
}
