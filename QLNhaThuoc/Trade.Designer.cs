namespace QLNhaThuoc
{
    partial class Trade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnSearch = new Button();
            txtSDT = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnChooseMed = new Button();
            dgvThuoc = new DataGridView();
            btnSearchMed = new Button();
            txtSearchMed = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            btnHuy = new Button();
            btnIn = new Button();
            btnXoaThuoc = new Button();
            nudSoLuong = new NumericUpDown();
            dgvGioHang = new DataGridView();
            txtGhiChu = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // button2
            // 
            button2.Location = new Point(21, 178);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Thêm KH";
            button2.UseVisualStyleBackColor = true;            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(304, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm KH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(82, 148);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(297, 23);
            txtSDT.TabIndex = 9;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 151);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "SDT";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(82, 119);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(297, 23);
            txtDiaChi.TabIndex = 7;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 122);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Địa Chỉ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 23);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 93);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(82, 61);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(297, 23);
            txtHoTen.TabIndex = 3;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(82, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(211, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "SDT,TÊN:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(btnChooseMed);
            groupBox2.Controls.Add(dgvThuoc);
            groupBox2.Controls.Add(btnSearchMed);
            groupBox2.Controls.Add(txtSearchMed);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 213);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Thuốc";
            // 
            // btnChooseMed
            // 
            btnChooseMed.Location = new Point(385, 22);
            btnChooseMed.Name = "btnChooseMed";
            btnChooseMed.Size = new Size(75, 23);
            btnChooseMed.TabIndex = 16;
            btnChooseMed.Text = "Chọn";
            btnChooseMed.UseVisualStyleBackColor = true;
            btnChooseMed.Click += btnChooseMed_Click;
            // 
            // dgvThuoc
            // 
            dgvThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuoc.Location = new Point(0, 51);
            dgvThuoc.Name = "dgvThuoc";
            dgvThuoc.Size = new Size(388, 156);
            dgvThuoc.TabIndex = 15;
            dgvThuoc.CellContentClick += dgvThuoc_CellContentClick;
            // 
            // btnSearchMed
            // 
            btnSearchMed.Location = new Point(304, 22);
            btnSearchMed.Name = "btnSearchMed";
            btnSearchMed.Size = new Size(75, 23);
            btnSearchMed.TabIndex = 14;
            btnSearchMed.Text = "Tìm";
            btnSearchMed.UseVisualStyleBackColor = true;
            btnSearchMed.Click += btnSearchMed_Click;
            // 
            // txtSearchMed
            // 
            txtSearchMed.Location = new Point(82, 22);
            txtSearchMed.Name = "txtSearchMed";
            txtSearchMed.Size = new Size(211, 23);
            txtSearchMed.TabIndex = 13;
            txtSearchMed.TextChanged += txtSearchMed_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 25);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 12;
            label6.Text = "Tìm Thuốc";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTongTien);
            groupBox3.Controls.Add(btnThanhToan);
            groupBox3.Controls.Add(btnHuy);
            groupBox3.Controls.Add(btnIn);
            groupBox3.Controls.Add(btnXoaThuoc);
            groupBox3.Controls.Add(nudSoLuong);
            groupBox3.Controls.Add(dgvGioHang);
            groupBox3.Location = new Point(498, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giỏ Hàng";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(21, 272);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(70, 15);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng Cộng:";
            lblTongTien.Click += lblTongTien_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(64, 382);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(155, 23);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(196, 342);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(85, 23);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(105, 342);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(85, 23);
            btnIn.TabIndex = 3;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnXoaThuoc
            // 
            btnXoaThuoc.Location = new Point(24, 342);
            btnXoaThuoc.Name = "btnXoaThuoc";
            btnXoaThuoc.Size = new Size(75, 23);
            btnXoaThuoc.TabIndex = 2;
            btnXoaThuoc.Text = "Xóa Thuốc";
            btnXoaThuoc.UseVisualStyleBackColor = true;
            btnXoaThuoc.Click += btnXoaThuoc_Click;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(174, 268);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(120, 23);
            nudSoLuong.TabIndex = 1;
            nudSoLuong.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dgvGioHang
            // 
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Location = new Point(11, 19);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.Size = new Size(279, 239);
            dgvGioHang.TabIndex = 0;
            dgvGioHang.CellContentClick += dgvGioHang_CellContentClick;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(394, 51);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(80, 156);
            txtGhiChu.TabIndex = 7;
            txtGhiChu.TextChanged += txtGhiChu_TextChanged;
            // 
            // Trade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Trade";
            Text = "Trade";
            Load += Trade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnSearch;
        private TextBox txtSDT;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtHoTen;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private Button button2;
        private Button btnSearchMed;
        private TextBox txtSearchMed;
        private Label label6;
        private Button btnChooseMed;
        private DataGridView dgvThuoc;
        private NumericUpDown nudSoLuong;
        private Label lblTongTien;
        private Button btnThanhToan;
        private Button btnHuy;
        private Button btnIn;
        private Button btnXoaThuoc;
        private TextBox txtGhiChu;
        private DataGridView dgvGioHang;
    }
}