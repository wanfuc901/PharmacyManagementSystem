using Microsoft.VisualBasic.Logging;
using QL_NhaThuoc;
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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();

            // ===== HEADER GIỐNG ADMIN =====
            Panel header = new Panel();
            header.Height = 70;
            header.Dock = DockStyle.Top;
            header.BackColor = Color.White;

            Label title = new Label();
            title.Text = "PHẦN MỀM QUẢN LÝ NHÀ THUỐC";
            title.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(18, 106, 235);
            title.AutoSize = true;
            title.Location = new Point(20, 20);

            // MENU CHO USER
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.BackColor = Color.White;
            menuStrip2.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            menuStrip2.Location = new Point(480, 23);

            header.Controls.Add(title);
            header.Controls.Add(menuStrip2);

            this.Controls.Add(header);
            header.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TonKho frm = new TonKho();
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Search_Report f = new Search_Report();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Trade f = new Trade();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Quay về màn hình đăng nhập
            LuaChon loginForm = new LuaChon();
            loginForm.Show();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”
            pictureBox1.SendToBack();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmBaoCaoTongHop f = new frmBaoCaoTongHop();
            f.ShowDialog();
        }

        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongHop f = new frmBaoCaoTongHop();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.ShowDialog();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            NCC F = new NCC();
            F.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TonKho f = new TonKho();
            f.ShowDialog();
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Search_Report f = new Search_Report();
        }
    }
}
