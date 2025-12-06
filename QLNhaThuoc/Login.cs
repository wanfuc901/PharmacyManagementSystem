using BUS;
using QL_NhaThuoc;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNhaThuoc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string selectedRole = cboRole.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!");
                return;
            }

            string? dbRole = TaiKhoanBUS.DangNhap(username, password);

            if (dbRole != null)
            {
                // Kiểm tra vai trò đúng với lựa chọn
                if (!dbRole.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Tài khoản không có quyền truy cập vào vai trò này!");
                    return;
                }

                // Lưu thông tin người dùng
                Program.TenDangNhap = username;
                Program.QuyenNguoiDung = dbRole;

                MessageBox.Show("Đăng nhập thành công! Vai trò: " + dbRole);
                this.Hide();

                if (dbRole == "Admin")
                    new AdminMenu().ShowDialog();
                else
                    new UserMenu().ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”
            textBox2.UseSystemPasswordChar = true;

            cboRole.Items.Clear();
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("NhanVien");
            cboRole.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // chặn tiếng “ding”
                textBox2.Focus();          // chuyển con trỏ xuống ô mật khẩu
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // Gọi trực tiếp sự kiện đăng nhập
                label1_Click(sender, e);

            }
        }

        public Login(string user, string pass)
        {
            InitializeComponent();

            textBox1.Text = user;   // tự điền username
            textBox2.Text = pass;   // tự điền password
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
