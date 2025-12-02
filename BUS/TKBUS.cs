using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class TKBUS
    {
        public static DataTable GetAll()
        {
            return TKDAO.GetAll();
        }

        public static bool Insert(TKDTO tk)
        {
            if (TKDAO.Exists(tk.TenDN)) return false;
            return TKDAO.Insert(tk);
        }

        public static bool Update(TKDTO tk)
        {
            return TKDAO.Update(tk);
        }

        public static bool Delete(int id)
        {
            return TKDAO.Delete(id);
        }

        public static DataTable Search(string keyword)
        {
            return TKDAO.Search(keyword);
        }
    }
}
