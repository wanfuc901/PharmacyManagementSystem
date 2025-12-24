using DAO;
using System.Data;

namespace BUS
{
    public class CT_PhieuNhapBUS
    {
        public static DataTable LayChiTiet(int maPN)
        {
            return CT_PhieuNhapDAO.LayTheoMaPN(maPN);
        }
    }
}
