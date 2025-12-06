using BUS;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            // Gọi BUS để tạo tài khoản (mặc định Nhân Viên)
            bool result = TaiKhoanBUS.DangKy(user, pass);

            if (result)
            {
                MessageBox.Show("Tạo tài khoản thành công (mặc định Nhân Viên)");
                this.Hide();
                Login f = new Login(textBox1.Text.Trim(), textBox2.Text.Trim());
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại (tên đăng nhập có thể đã tồn tại)");

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox2.UseSystemPasswordChar = true; // mặc định ẩn mật khẩu
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
