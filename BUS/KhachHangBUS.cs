using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
        public static DataTable GetAll()
        {
            return KhachHangDAO.GetAll();
        }




        public static bool Update(KhachHangDTO kh)
        {
            return KhachHangDAO.Update(kh);
        }

        public static bool Delete(int maKH)
        {
            return KhachHangDAO.Delete(maKH);
        }

        public static DataTable Search(KhachHangDTO kh)
        {
            return KhachHangDAO.Search(kh);
        }

        public static DataTable SearchByKeyword(string keyword)
        {
            return KhachHangDAO.SearchByKeyword(keyword);
        }

        public static bool ExistsBySDT(string sdt)
        {
            return KhachHangDAO.ExistsBySDT(sdt);
        }
        public static bool InsertBool(KhachHangDTO kh)
        {
            return KhachHangDAO.InsertBool(kh);
        }
        public static int Insert(KhachHangDTO kh)
        {
            return KhachHangDAO.InsertAndReturnId(kh);
        }




    }
}
