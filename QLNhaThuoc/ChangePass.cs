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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNhaThuoc
{
    public partial class ChangePass : Form
    {
        private string tendn;
        public ChangePass(string username)
        {
            InitializeComponent();

            // Khóa form, không cho resize
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // Gán tên đăng nhập hiện tại
            tendn = username;
            txtTenDN.Text = username;
            txtTenDN.ReadOnly = true;   // khóa không cho chỉnh sửa
            txtTenDN.TabStop = false;   // bỏ focus
        }
     
        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mkcu = txtMatKhauCu.Text.Trim();
            string mkmoi = txtMatKhauMoi.Text.Trim();
            string nhaplai = txtNhapLai.Text.Trim();

            if (mkmoi != nhaplai)
            {
                MessageBox.Show("Mật khẩu mới không khớp.");
                return;
            }

            bool doiThanhCong = DoiMatKhauBUS.DoiMatKhau(tendn, mkcu, mkmoi);
            if (doiThanhCong)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
        }
    }
}
