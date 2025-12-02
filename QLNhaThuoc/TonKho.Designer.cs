namespace QL_NhaThuoc
{
    partial class TonKho
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
            label = new Label();
            txtMaThuoc = new TextBox();
            tt = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTenThuoc = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            txtLoaiThuoc = new TextBox();
            label7 = new Label();
            txtSoLuong = new TextBox();
            dtpNSX = new DateTimePicker();
            dtpHSD = new DateTimePicker();
            txtGhiChu = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtGia = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(5, 23);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(60, 15);
            label.TabIndex = 29;
            label.Text = "Mã Thuốc";
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Location = new Point(8, 42);
            txtMaThuoc.Margin = new Padding(4, 3, 4, 3);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.Size = new Size(76, 23);
            txtMaThuoc.TabIndex = 28;
            // 
            // tt
            // 
            tt.AutoSize = true;
            tt.Location = new Point(8, 76);
            tt.Margin = new Padding(4, 0, 4, 0);
            tt.Name = "tt";
            tt.Size = new Size(61, 15);
            tt.TabIndex = 27;
            tt.Text = "Tên Thuốc";
            tt.Click += txtTenThuoc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 26;
            label3.Text = "NSX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 25;
            label2.Text = "HSD";
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new Point(12, 95);
            txtTenThuoc.Margin = new Padding(4, 3, 4, 3);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(190, 23);
            txtTenThuoc.TabIndex = 23;
            // 
            // button4
            // 
            button4.Location = new Point(286, 38);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(111, 32);
            button4.TabIndex = 19;
            button4.Text = "Tìm Kiếm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(194, 38);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(84, 32);
            button3.TabIndex = 18;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 38);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(84, 32);
            button2.TabIndex = 17;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 38);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 16;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(866, 257);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 33;
            label6.Text = "Loại Thuốc";
            // 
            // txtLoaiThuoc
            // 
            txtLoaiThuoc.Location = new Point(12, 144);
            txtLoaiThuoc.Margin = new Padding(4, 3, 4, 3);
            txtLoaiThuoc.Name = "txtLoaiThuoc";
            txtLoaiThuoc.Size = new Size(190, 23);
            txtLoaiThuoc.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 23);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 31;
            label7.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(92, 42);
            txtSoLuong.Margin = new Padding(4, 3, 4, 3);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(110, 23);
            txtSoLuong.TabIndex = 30;
            // 
            // dtpNSX
            // 
            dtpNSX.Location = new Point(220, 42);
            dtpNSX.Margin = new Padding(4, 3, 4, 3);
            dtpNSX.Name = "dtpNSX";
            dtpNSX.Size = new Size(195, 23);
            dtpNSX.TabIndex = 34;
            // 
            // dtpHSD
            // 
            dtpHSD.Location = new Point(221, 95);
            dtpHSD.Margin = new Padding(4, 3, 4, 3);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(194, 23);
            dtpHSD.TabIndex = 35;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(434, 22);
            txtGhiChu.Margin = new Padding(4, 3, 4, 3);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(420, 145);
            txtGhiChu.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 37;
            label4.Text = "Ghi Chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 126);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 38;
            label5.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(220, 144);
            txtGia.Margin = new Padding(4, 3, 4, 3);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(195, 23);
            txtGia.TabIndex = 39;
            txtGia.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(245, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 94);
            panel1.TabIndex = 40;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtMaThuoc);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTenThuoc);
            groupBox1.Controls.Add(tt);
            groupBox1.Controls.Add(dtpHSD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLoaiThuoc);
            groupBox1.Controls.Add(dtpNSX);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(2, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(866, 260);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thuốc";
            // 
            // TonKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 519);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TonKho";
            Text = "TonKho";
            Load += TonKho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private Panel panel1;
        private GroupBox groupBox1;
    }
}