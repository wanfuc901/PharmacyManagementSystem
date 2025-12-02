using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {
        public static DataTable GetAll()
        {
            return HoaDonDAO.GetAll();
        }

        public static bool Insert(HoaDonDTO hd)
        {
            return HoaDonDAO.Insert(hd);
        }

        public static bool Update(HoaDonDTO hd)
        {
            return HoaDonDAO.Update(hd);
        }

        public static bool Delete(int maHD)
        {
            return HoaDonDAO.Delete(maHD);
        }

        public static DataTable Search(HoaDonDTO hd)
        {
            return HoaDonDAO.Search(hd);
        }
    }
}
