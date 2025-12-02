using System.Data;
using DAO;

namespace BUS
{
    public class PhieuTraBUS
    {
        public static DataTable LayDanhSach()
        {
            return PhieuTraDAO.LayDanhSach();
        }

        public static bool ThemPhieuTra(int mancc, decimal tongtien)
        {
            return PhieuTraDAO.ThemPhieuTra(mancc, tongtien);
        }

        public static DataTable TimTheoNCC(string keyword)
        {
            return PhieuTraDAO.TimTheoNCC(keyword);
        }

        public static bool CapNhatTonKhoSauTra(int matra)
        {
            return PhieuTraDAO.GiamTonKho(matra);
        }
    }
}
