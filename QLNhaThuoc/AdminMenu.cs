using OpenTK;
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
using ScottPlot;
using ScottPlot.WinForms;

namespace QLNhaThuoc
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // cố định khung
            this.MaximizeBox = false;                            // tắt nút phóng to
            this.MinimizeBox = false;                            // tắt nút thu nhỏ
            this.ControlBox = true;                              // vẫn cho nút X
            this.ShowIcon = false;                               // ẩn icon góc trái
            this.ShowInTaskbar = false;                          // không hiển thị taskbar
            this.StartPosition = FormStartPosition.CenterParent; // mở giữa cha
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;      // chặn kéo giãn
            this.SizeGripStyle = SizeGripStyle.Hide;             // ẩn góc resize

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Trade F = new Trade();
            F.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LuaChon f = new LuaChon();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NCC f = new NCC();
            f.ShowDialog();
        }

        private void càiĐặToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan f = new TaiKhoan();
            f.ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            ChangePass frm = new ChangePass(Program.TenDangNhap);
            frm.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhieuNhap().ShowDialog();

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.ShowDialog();
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuTra f = new PhieuTra();
            f.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TaiKhoan f = new TaiKhoan();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NCC F = new NCC();
            F.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongHop F = new frmBaoCaoTongHop();
            F.ShowDialog();
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
