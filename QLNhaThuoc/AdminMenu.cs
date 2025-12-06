using QL_NhaThuoc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLNhaThuoc
{
    public partial class AdminMenu : Form
    {
        // Renderer hiện đại
        public class MyMenuRenderer : ToolStripProfessionalRenderer
        {
            public MyMenuRenderer() : base(new MyMenuColorTable()) { }
        }

        public class MyMenuColorTable : ProfessionalColorTable
        {
            public override Color MenuStripGradientBegin => Color.White;
            public override Color MenuStripGradientEnd => Color.White;

            public override Color MenuItemSelected => Color.FromArgb(18, 106, 235);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(18, 106, 235);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(18, 106, 235);

            public override Color MenuItemPressedGradientBegin => Color.White;
            public override Color MenuItemPressedGradientEnd => Color.White;

            public override Color MenuItemBorder => Color.FromArgb(18, 106, 235);
        }

        public AdminMenu()
        {
            InitializeComponent();

            // giao diện form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // ============ MENU MODERN ============
            menuStrip2.Renderer = new MyMenuRenderer();
            menuStrip2.BackColor = Color.White;
            menuStrip2.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            menuStrip2.Dock = DockStyle.None;  // bắt buộc

            // ============ HEADER PANEL ============
            Panel header = new Panel();
            header.Height = 70;
            header.Dock = DockStyle.Top;
            header.BackColor = Color.White;

            /*PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.logo; // phải có logo trong Resources
            logo.Size = new Size(50, 50);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Location = new Point(15, 10);*/

            Label title = new Label();
            title.Text = "PHẦN MỀM QUẢN LÝ NHÀ THUỐC";
            title.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(18, 106, 235);
            title.AutoSize = true;
            title.Location = new Point(80, 20);

            menuStrip2.Location = new Point(Width - 490, 25);

            //header.Controls.Add(logo);
            header.Controls.Add(title);
            header.Controls.Add(menuStrip2);

            this.Controls.Add(header);
            header.BringToFront();
        }

        // ========================= EVENTS =========================

        private void label2_Click(object sender, EventArgs e)
        {
            new Trade().ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new LuaChon().ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new KhachHang().ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new NCC().ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            new ChangePass(Program.TenDangNhap).ShowDialog();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            new HoaDon().ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhieuNhap().ShowDialog();
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhieuTra().ShowDialog();
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBaoCaoTongHop().ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBaoCaoTongHop().ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBaoCaoTongHop().ShowDialog();
        }

        private void bánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBaoCaoTongHop().ShowDialog();
        }

        private void càiĐặToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void tàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TaiKhoan f = new TaiKhoan();
            f.ShowDialog();
        }
    }
}
