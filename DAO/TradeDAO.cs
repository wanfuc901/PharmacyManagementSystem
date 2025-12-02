using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TradeDAO
    {
        public static int TaoHoaDon(TradeDTO trade, List<TradeDTO> chiTiet)
        {
            string sqlHD = @"INSERT INTO hoadon(ngaylap, makh, tongtien)
                             OUTPUT INSERTED.mahd
                             VALUES(@ngaylap, @makh, @tong)";

            decimal tongTien = 0;
            foreach (var ct in chiTiet)
                tongTien += ct.ThanhTien;

            using (SqlConnection conn = DataProvider.MoKetNoi())
            using (SqlCommand cmd = new SqlCommand(sqlHD, conn))
            {
                cmd.Parameters.AddWithValue("@ngaylap", trade.NgayLap);
                cmd.Parameters.AddWithValue("@makh", (object)trade.MaKH ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@tong", tongTien);

                int mahd = (int)cmd.ExecuteScalar();

                foreach (var ct in chiTiet)
                {
                    string sqlCT = @"INSERT INTO ct_hoadon(mahd, mathuoc, soluong, giaban)
                                     VALUES(@mahd, @ma, @sl, @gia)";
                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn);
                    cmdCT.Parameters.AddWithValue("@mahd", mahd);
                    cmdCT.Parameters.AddWithValue("@ma", ct.MaThuoc);
                    cmdCT.Parameters.AddWithValue("@sl", ct.SoLuong);
                    cmdCT.Parameters.AddWithValue("@gia", ct.DonGia);
                    cmdCT.ExecuteNonQuery();

                    // cập nhật tồn kho
                    string sqlUpdate = "UPDATE thuoc SET soluong = soluong - @sl WHERE mathuoc=@ma";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@sl", ct.SoLuong);
                    cmdUpdate.Parameters.AddWithValue("@ma", ct.MaThuoc);
                    cmdUpdate.ExecuteNonQuery();
                }

                return mahd;
            }
        }
    }
}
