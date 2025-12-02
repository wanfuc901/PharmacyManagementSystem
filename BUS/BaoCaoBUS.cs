using System.Data;
using DAO;

namespace BUS
{
    public class BaoCaoBUS
    {
        public static DataTable DoanhThu(int nam) => BaoCaoDAO.LayDoanhThuTheoThang(nam);
        public static DataTable TonKho() => BaoCaoDAO.LayTonKho();
        public static DataTable ThuocBanChay() => BaoCaoDAO.LayThuocBanChay();
        public static DataTable NhapHang(int nam) => BaoCaoDAO.LayNhapHangTheoThang(nam);
        public static DataTable KhachHangMuaNhieu() => BaoCaoDAO.LayKhachHangMuaNhieu();
    }
}
