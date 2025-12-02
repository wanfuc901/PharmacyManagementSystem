using DAO;
using System.Data;

namespace BUS
{
    public class PhieuNhapBUS
    {
        public static DataTable LayDanhSach() => PhieuNhapDAO.LayDanhSach();

        public static bool ThemPhieuNhap(int mancc, decimal tongtien)
            => PhieuNhapDAO.Them(mancc, tongtien);

        public static DataTable TimTheoNCC(string kw)
            => PhieuNhapDAO.TimTheoNCC(kw);
    }
}
