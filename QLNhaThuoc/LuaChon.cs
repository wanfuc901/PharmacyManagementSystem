using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaThuoc
{
    public partial class LuaChon : Form
    {
        public LuaChon()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignUp f = new SignUp();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();             // Ẩn form hiện tại
            f.ShowDialog();          // Hiển thị form mới (chặn luồng)
            this.Close();            // Đóng form cũ sau khi form mới đóng
        }

        private void LuaChon_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”
        }
    }
}
