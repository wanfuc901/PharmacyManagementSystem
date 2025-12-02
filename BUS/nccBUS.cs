using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class NCCBUS
    {
        public static DataTable GetAll()
        {
            return NCCDAO.GetAll();
        }

        public static bool Insert(NCCDTO ncc)
        {
            return NCCDAO.Insert(ncc);
        }

        public static bool Update(NCCDTO ncc)
        {
            return NCCDAO.Update(ncc);
        }

        public static bool Delete(int maNCC)
        {
            return NCCDAO.Delete(maNCC);
        }

        public static DataTable Search(NCCDTO ncc)
        {
            return NCCDAO.Search(ncc);
        }
    }
}
