using DAO;
using DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static string? DangNhap(string user, string pass)
        {
            return TaiKhoanDAO.KiemTraDangNhap(user, pass);
        }

        public static bool DangKy(string user, string pass)
        {
            if (TaiKhoanDAO.Exists(user))
            {
                return false; // tài khoản đã tồn tại
            }

            TaiKhoanDTO tk = new TaiKhoanDTO
            {
                TenDN = user,
                MatKhau = pass,
                VaiTro = "NhanVien"
            };

            return TaiKhoanDAO.Insert(tk);
        }


    }
}
