using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ThuocDAO
    {
        // Lấy toàn bộ thuốc
        public static DataTable GetAll()
        {
            string sql = "SELECT * FROM Thuoc";
            return DataProvider.TruyVanLayDuLieu(sql);
        }

        // Thêm thuốc
        public static bool Insert(ThuocDTO thuoc)
        {
            string sql = @"INSERT INTO Thuoc(tenthuoc, loaithuoc, nsx, hansudung, gia, soluong, ghichu)
                           VALUES (@TenThuoc,@LoaiThuoc,@NSX,@HanSuDung,@Gia,@SoLuong,@GhiChu)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenThuoc", thuoc.TenThuoc),
                new SqlParameter("@LoaiThuoc", thuoc.LoaiThuoc),
                new SqlParameter("@NSX", (object?)thuoc.NSX ?? DBNull.Value),
                new SqlParameter("@HanSuDung", (object?)thuoc.HanSuDung ?? DBNull.Value),
                new SqlParameter("@Gia", thuoc.Gia),
                new SqlParameter("@SoLuong", thuoc.SoLuong),
                new SqlParameter("@GhiChu", thuoc.GhiChu ?? (object)DBNull.Value)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        // Cập nhật thuốc
        public static bool Update(ThuocDTO thuoc)
        {
            string sql = @"UPDATE Thuoc 
                           SET tenthuoc=@TenThuoc, loaithuoc=@LoaiThuoc, 
                               nsx=@NSX, hansudung=@HanSuDung, 
                               gia=@Gia, soluong=@SoLuong, ghichu=@GhiChu
                           WHERE mathuoc=@MaThuoc";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaThuoc", thuoc.MaThuoc),
                new SqlParameter("@TenThuoc", thuoc.TenThuoc),
                new SqlParameter("@LoaiThuoc", thuoc.LoaiThuoc),
                new SqlParameter("@NSX", (object?)thuoc.NSX ?? DBNull.Value),
                new SqlParameter("@HanSuDung", (object?)thuoc.HanSuDung ?? DBNull.Value),
                new SqlParameter("@Gia", thuoc.Gia),
                new SqlParameter("@SoLuong", thuoc.SoLuong),
                new SqlParameter("@GhiChu", thuoc.GhiChu ?? (object)DBNull.Value)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        // Xóa thuốc
        public static bool Delete(int maThuoc)
        {
            string sql = "DELETE FROM Thuoc WHERE mathuoc=@MaThuoc";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaThuoc", maThuoc)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        // Tìm kiếm thuốc
        public static DataTable Search(string keyword)
        {
            string sql = @"SELECT * FROM Thuoc 
                           WHERE tenthuoc LIKE @kw OR loaithuoc LIKE @kw";

            SqlParameter[] parameters =
            {
                new SqlParameter("@kw", "%" + keyword + "%")
            };

            return DataProvider.TruyVanLayDuLieu(sql, parameters);
        }

        // ------------------------------
               // CÁC HÀM BỔ SUNG
        // ------------------------------

        // Lấy thuốc theo mã
        public static ThuocDTO GetById(int maThuoc)
        {
            string sql = "SELECT * FROM Thuoc WHERE mathuoc=@MaThuoc";
            SqlParameter[] parameters = { new SqlParameter("@MaThuoc", maThuoc) };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new ThuocDTO
            {
                MaThuoc = (int)row["mathuoc"],
                TenThuoc = row["tenthuoc"].ToString(),
                LoaiThuoc = row["loaithuoc"].ToString(),
                NSX = row["nsx"] == DBNull.Value ? null : (DateTime?)row["nsx"],
                HanSuDung = row["hansudung"] == DBNull.Value ? null : (DateTime?)row["hansudung"],
                Gia = (decimal)row["gia"],
                SoLuong = (int)row["soluong"],
                GhiChu = row["ghichu"].ToString()
            };
        }

        // Cập nhật số lượng (dùng cho bán hàng/nhập kho)
        public static bool UpdateSoLuong(int maThuoc, int soLuongThayDoi)
        {
            string sql = "UPDATE Thuoc SET soluong = soluong + @SoLuongThayDoi WHERE mathuoc=@MaThuoc";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoLuongThayDoi", soLuongThayDoi),
                new SqlParameter("@MaThuoc", maThuoc)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sql, parameters) > 0;
        }

        public static List<string> LayDanhSachNhom()
        {
            string sql = "SELECT DISTINCT loaithuoc FROM thuoc ORDER BY loaithuoc";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql);

            return dt.AsEnumerable()
                     .Select(r => r["loaithuoc"].ToString())
                     .ToList();
        }


        // Trả về List<ThuocDTO> để tiện bind lên UI
        public static List<ThuocDTO> GetList()
        {
            DataTable dt = GetAll();
            List<ThuocDTO> list = new List<ThuocDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ThuocDTO
                {
                    MaThuoc = (int)row["mathuoc"],
                    TenThuoc = row["tenthuoc"].ToString(),
                    LoaiThuoc = row["loaithuoc"].ToString(),
                    NSX = row["nsx"] == DBNull.Value ? null : (DateTime?)row["nsx"],
                    HanSuDung = row["hansudung"] == DBNull.Value ? null : (DateTime?)row["hansudung"],
                    Gia = (decimal)row["gia"],
                    SoLuong = (int)row["soluong"],
                    GhiChu = row["ghichu"].ToString()
                });
            }
            return list;
        }
    }
}
