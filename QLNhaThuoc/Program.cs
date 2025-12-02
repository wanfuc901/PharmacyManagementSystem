using QLNhaThuoc;
using System;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    internal static class Program
    {
        public static string QuyenNguoiDung = "";
        public static string TenDangNhap = "";
        /// <summary>
        /// Điểm bắt đầu của ứng dụng
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // cấu hình mặc định cho WinForms
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBaoCaoTongHop()); // Form khởi động
        }
    }
}
