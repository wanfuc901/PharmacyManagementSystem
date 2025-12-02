using System.Data;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class SearchReportDAO
    {
        public static DataTable Search(string keyword)
        {
            string sql = @"
                SELECT hd.mahd, hd.ngaylap, kh.tenkh, kh.sdt AS SDT_KhachHang,
                       t.tenthuoc, t.loaithuoc, cthd.soluong, cthd.giaban,
                       ncc.tenncc, pn.ngaynhap, ctpn.gianhap
                FROM hoadon hd
                LEFT JOIN khachhang kh ON hd.makh = kh.makh
                LEFT JOIN ct_hoadon cthd ON hd.mahd = cthd.mahd
                LEFT JOIN thuoc t ON cthd.mathuoc = t.mathuoc
                LEFT JOIN ct_phieunhap ctpn ON t.mathuoc = ctpn.mathuoc
                LEFT JOIN phieunhap pn ON ctpn.mapn = pn.mapn
                LEFT JOIN nhacungcap ncc ON pn.mancc = ncc.mancc
                WHERE kh.tenkh LIKE @keyword
                   OR t.tenthuoc LIKE @keyword
                   OR ncc.tenncc LIKE @keyword
                   OR CAST(hd.mahd AS NVARCHAR) LIKE @keyword";

            SqlParameter[] parameters =
            {
                new SqlParameter("@keyword", "%" + keyword + "%")
            };

            return DataProvider.TruyVanLayDuLieu(sql, parameters);
        }
    }
}
