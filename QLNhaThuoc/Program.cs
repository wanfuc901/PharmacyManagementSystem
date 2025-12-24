using QLNhaThuoc;
using System;
using System.Windows.Forms;

public static class Program   // ❗ KHÔNG namespace
{
    public static string QuyenNguoiDung = "";
    public static string TenDangNhap = "";

    [STAThread]
    public static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new UserMenu()); // form đăng nhập
    }
}
