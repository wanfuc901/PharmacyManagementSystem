using System.Data;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class PhieuTraDAO
    {
        // ===== LẤY DANH SÁCH PHIẾU TRẢ =====
        public static DataTable LayDanhSach()
        {
            string sql = @"
                SELECT pt.matra, pt.ngaytra, ncc.tenncc, pt.tongtien
                FROM phieutra pt
                JOIN nhacungcap ncc ON pt.mancc = ncc.mancc
                ORDER BY pt.matra DESC";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        // ===== THÊM PHIẾU TRẢ =====
        public static bool ThemPhieuTra(int mancc, decimal tongtien)
        {
            string sql = "INSERT INTO phieutra(mancc, tongtien, ngaytra) VALUES(@mancc, @tongtien, GETDATE())";
            SqlParameter[] pr =
            {
                new SqlParameter("@mancc", mancc),
                new SqlParameter("@tongtien", tongtien)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, pr) > 0;
        }

        // ===== TÌM THEO NHÀ CUNG CẤP =====
        public static DataTable TimTheoNCC(string keyword)
        {
            string sql = @"
                SELECT pt.matra, pt.ngaytra, ncc.tenncc, pt.tongtien
                FROM phieutra pt
                JOIN nhacungcap ncc ON pt.mancc = ncc.mancc
                WHERE ncc.tenncc LIKE @kw";
            SqlParameter[] pr = { new SqlParameter("@kw", "%" + keyword + "%") };
            return DataProvider.TruyVanLayDuLieu(sql, pr);
        }

        // ===== GIẢM TỒN KHO KHI TRẢ HÀNG =====
        public static bool GiamTonKho(int matra)
        {
            string sql = @"
                UPDATE t
                SET t.soluong = t.soluong - ctp.soluong
                FROM thuoc t
                JOIN ct_phieutra ctp ON t.mathuoc = ctp.mathuoc
                WHERE ctp.matra = @matra";
            SqlParameter[] pr = { new SqlParameter("@matra", matra) };
            return DataProvider.TruyVanKhongLayDuLieu(sql, pr) > 0;
        }
    }
}
