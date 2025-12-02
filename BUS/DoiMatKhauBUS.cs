using DAO;

namespace BUS
{
    public class DoiMatKhauBUS
    {
        public static bool DoiMatKhau(string tendn, string mkcu, string mkmoi)
        {
            if (!DoiMatKhauDAO.KiemTraMatKhauCu(tendn, mkcu))
                return false;

            return DoiMatKhauDAO.CapNhatMatKhau(tendn, mkmoi);
        }
    }
}
