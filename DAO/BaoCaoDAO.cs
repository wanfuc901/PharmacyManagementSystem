using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace DAO
{
    public class BaoCaoDAO
    {
        public static DataTable LayDoanhThuTheoKhoang(DateTime from, DateTime to)
        {
            string sql = @"
                SELECT CONVERT(date, ngaylap) AS Ngay, SUM(tongtien) AS DoanhThu
                FROM hoadon
                WHERE ngaylap BETWEEN @from AND @to
                GROUP BY CONVERT(date, ngaylap)
                ORDER BY Ngay";
            SqlParameter[] p = {
                new SqlParameter("@from", from),
                new SqlParameter("@to", to)
            };
            return DataProvider.TruyVanLayDuLieu(sql, p);
        }

        public static DataTable LayNhapHangTheoKhoang(DateTime from, DateTime to)
        {
            string sql = @"
                SELECT CONVERT(date, ngaynhap) AS Ngay, SUM(tongtien) AS TongNhap
                FROM phieunhap
                WHERE ngaynhap BETWEEN @from AND @to
                GROUP BY CONVERT(date, ngaynhap)
                ORDER BY Ngay";
            SqlParameter[] p = {
                new SqlParameter("@from", from),
                new SqlParameter("@to", to)
            };
            return DataProvider.TruyVanLayDuLieu(sql, p);
        }

        public static DataTable LayDoanhThuTheoThang(int nam)
        {
            string sql = @"
                SELECT MONTH(ngaylap) AS Thang, SUM(tongtien) AS DoanhThu
                FROM hoadon
                WHERE YEAR(ngaylap) = @nam
                GROUP BY MONTH(ngaylap)
                ORDER BY Thang";
            SqlParameter[] p = { new SqlParameter("@nam", nam) };
            return DataProvider.TruyVanLayDuLieu(sql, p);
        }

        public static DataTable LayTonKho()
        {
            string sql = @"SELECT mathuoc, tenthuoc, soluong, gia,
                                  (soluong * gia) AS GiaTriTon
                           FROM thuoc ORDER BY tenthuoc";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        public static DataTable LayThuocBanChay()
        {
            string sql = @"
                SELECT TOP 10 t.tenthuoc, SUM(c.soluong) AS SoLuongBan,
                       SUM(c.soluong * c.giaban) AS DoanhThu
                FROM ct_hoadon c
                JOIN thuoc t ON t.mathuoc = c.mathuoc
                GROUP BY t.tenthuoc
                ORDER BY SoLuongBan DESC";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        public static DataTable LayNhapHangTheoThang(int nam)
        {
            string sql = @"
                SELECT MONTH(ngaynhap) AS Thang, SUM(tongtien) AS TongNhap
                FROM phieunhap
                WHERE YEAR(ngaynhap) = @nam
                GROUP BY MONTH(ngaynhap)
                ORDER BY Thang";
            SqlParameter[] p = { new SqlParameter("@nam", nam) };
            return DataProvider.TruyVanLayDuLieu(sql, p);
        }

        public static DataTable LayKhachHangMuaNhieu()
        {
            string sql = @"
                SELECT TOP 10 k.tenkh, COUNT(h.mahd) AS SoHoaDon, SUM(h.tongtien) AS TongChiTieu
                FROM hoadon h
                JOIN khachhang k ON k.makh = h.makh
                GROUP BY k.tenkh
                ORDER BY TongChiTieu DESC";
            return DataProvider.TruyVanLayDuLieu(sql);
        }


        public static List<string> LayDanhSachNhanVien()
        {
            string sql = "SELECT tendn FROM taikhoan WHERE vaitro = 'NhanVien'";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql);

            return dt.AsEnumerable()
                     .Select(r => r["tendn"].ToString())
                     .ToList();
        }

        public static List<string> LayDanhSachKhachHang()
        {
            string sql = "SELECT tenkh FROM khachhang ORDER BY tenkh";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql);

            return dt.AsEnumerable()
                     .Select(r => r["tenkh"].ToString())
                     .ToList();
        }



    }
}

