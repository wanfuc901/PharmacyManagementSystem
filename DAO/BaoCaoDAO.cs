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
        SELECT 
            CONVERT(date, h.ngaylap) AS Ngay,
            h.ca AS Ca,
            h.nhanvien AS NhanVien,
            h.thanhtoan AS ThanhToan,
            SUM(h.tongtien) AS DoanhThu
        FROM hoadon h
        WHERE h.ngaylap BETWEEN @from AND @to
        GROUP BY CONVERT(date, h.ngaylap), h.ca, h.nhanvien, h.thanhtoan
        ORDER BY Ngay
    ";

            SqlParameter[] p = {
        new SqlParameter("@from", from),
        new SqlParameter("@to", to)
    };

            return DataProvider.TruyVanLayDuLieu(sql, p);
        }


        public static DataTable LayNhapHangTheoKhoang(DateTime from, DateTime to)
        {
            string sql = @"
        SELECT 
            CONVERT(date, pn.ngaynhap) AS Ngay,
            ncc.tenncc AS NCC,
            t.tenthuoc AS TenThuoc,
            ctpn.soluong AS SoLuong,
            ctpn.gianhap AS GiaNhap,
            (ctpn.soluong * ctpn.gianhap) AS ThanhTien
        FROM phieunhap pn
        JOIN nhacungcap ncc ON pn.mancc = ncc.mancc
        JOIN ct_phieunhap ctpn ON pn.mapn = ctpn.mapn
        JOIN thuoc t ON ctpn.mathuoc = t.mathuoc
        WHERE pn.ngaynhap BETWEEN @from AND @to
        ORDER BY Ngay, ncc.tenncc, t.tenthuoc
    ";

            SqlParameter[] p =
            {
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
            string sql = @"
        SELECT 
            mathuoc,
            tenthuoc,
            nhom AS Nhom,
            soluong,
            gia,
            (soluong * gia) AS GiaTriTon
        FROM thuoc
        ORDER BY tenthuoc
    ";

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

