namespace QLNhaThuoc
{
    partial class AdminMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip2 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox2 = new ToolStripTextBox();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            càiDDToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            phiếuTrảToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            tồnKhoToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            nhậpHàngToolStripMenuItem = new ToolStripMenuItem();
            bánChạyToolStripMenuItem = new ToolStripMenuItem();
            càiĐặToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, -68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1267, 1044);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, càiDDToolStripMenuItem, báoCáoToolStripMenuItem, càiĐặToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(8, 3, 0, 3);
            menuStrip2.Size = new Size(900, 30);
            menuStrip2.TabIndex = 12;
            menuStrip2.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, toolStripTextBox1, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(174, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Text = "Đổi Mật Khẩu";
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(174, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kháchHàngToolStripMenuItem, nhàCungCấpToolStripMenuItem, toolStripTextBox2, tàiKhoảnToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(187, 26);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click_1;
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(187, 26);
            nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            nhàCungCấpToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click_1;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            toolStripTextBox2.Text = "Hóa Đơn";
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(187, 26);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click_1;
            // 
            // càiDDToolStripMenuItem
            // 
            càiDDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phiếuNhậpToolStripMenuItem, phiếuTrảToolStripMenuItem });
            càiDDToolStripMenuItem.Name = "càiDDToolStripMenuItem";
            càiDDToolStripMenuItem.Size = new Size(93, 24);
            càiDDToolStripMenuItem.Text = "Nghiệp Vụ";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            phiếuNhậpToolStripMenuItem.Size = new Size(168, 26);
            phiếuNhậpToolStripMenuItem.Text = "Phiếu Nhập";
            phiếuNhậpToolStripMenuItem.Click += phiếuNhậpToolStripMenuItem_Click;
            // 
            // phiếuTrảToolStripMenuItem
            // 
            phiếuTrảToolStripMenuItem.Name = "phiếuTrảToolStripMenuItem";
            phiếuTrảToolStripMenuItem.Size = new Size(168, 26);
            phiếuTrảToolStripMenuItem.Text = "Phiếu Trả";
            phiếuTrảToolStripMenuItem.Click += phiếuTrảToolStripMenuItem_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tồnKhoToolStripMenuItem, doanhThuToolStripMenuItem, nhậpHàngToolStripMenuItem, bánChạyToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(79, 24);
            báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // tồnKhoToolStripMenuItem
            // 
            tồnKhoToolStripMenuItem.Name = "tồnKhoToolStripMenuItem";
            tồnKhoToolStripMenuItem.Size = new Size(168, 26);
            tồnKhoToolStripMenuItem.Text = "Tồn Kho";
            tồnKhoToolStripMenuItem.Click += tồnKhoToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(168, 26);
            doanhThuToolStripMenuItem.Text = "Doanh Thu";
            doanhThuToolStripMenuItem.Click += doanhThuToolStripMenuItem_Click;
            // 
            // nhậpHàngToolStripMenuItem
            // 
            nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            nhậpHàngToolStripMenuItem.Size = new Size(168, 26);
            nhậpHàngToolStripMenuItem.Text = "Nhập Hàng";
            nhậpHàngToolStripMenuItem.Click += nhậpHàngToolStripMenuItem_Click;
            // 
            // bánChạyToolStripMenuItem
            // 
            bánChạyToolStripMenuItem.Name = "bánChạyToolStripMenuItem";
            bánChạyToolStripMenuItem.Size = new Size(168, 26);
            bánChạyToolStripMenuItem.Text = "Bán Chạy";
            bánChạyToolStripMenuItem.Click += bánChạyToolStripMenuItem_Click;
            // 
            // càiĐặToolStripMenuItem
            // 
            càiĐặToolStripMenuItem.Name = "càiĐặToolStripMenuItem";
            càiĐặToolStripMenuItem.Size = new Size(72, 24);
            càiĐặToolStripMenuItem.Text = "Cài Đặt";
            càiĐặToolStripMenuItem.Click += càiĐặToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(18, 106, 235);
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(595, 300);
            label2.Name = "label2";
            label2.Size = new Size(115, 26);
            label2.TabIndex = 2;
            label2.Text = "Bán Hàng";
            label2.Click += label2_Click;
            // 
            // AdminMenu
            // 
            ClientSize = new Size(1070, 620);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "AdminMenu";
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip2;
        private Label label2;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem càiDDToolStripMenuItem;
        private ToolStripMenuItem càiĐặToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripMenuItem phiếuTrảToolStripMenuItem;
        private ToolStripMenuItem tồnKhoToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private ToolStripMenuItem bánChạyToolStripMenuItem;
    }
}
