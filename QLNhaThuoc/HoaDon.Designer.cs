namespace QL_NhaThuoc
{
    partial class HoaDon
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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            txtMaKH = new TextBox();
            label3 = new Label();
            txtTongTien = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dtpNgayLap = new DateTimePicker();
            label1 = new Label();
            txtMaHD = new TextBox();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 29);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(714, 372);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 45);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 28;
            label5.Text = "Mã KH";
            label5.Click += label5_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(22, 71);
            txtMaKH.Margin = new Padding(5, 4, 5, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(261, 27);
            txtMaKH.TabIndex = 27;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 104);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 25;
            label3.Text = "Ngày Lập";
            label3.Click += label3_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(459, 71);
            txtTongTien.Margin = new Padding(5, 4, 5, 4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(179, 27);
            txtTongTien.TabIndex = 22;
            txtTongTien.TextChanged += txtTongTien_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(320, 55);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(127, 43);
            button4.TabIndex = 18;
            button4.Text = "Tìm Kiếm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(215, 55);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(96, 43);
            button3.TabIndex = 17;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(110, 55);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(96, 43);
            button2.TabIndex = 16;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(5, 55);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 43);
            button1.TabIndex = 15;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(22, 128);
            dtpNgayLap.Margin = new Padding(5, 4, 5, 4);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(617, 27);
            dtpNgayLap.TabIndex = 29;
            dtpNgayLap.ValueChanged += dtpNgayLap_ValueChanged;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Location = new Point(293, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã HD";
            label1.Click += label1_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(297, 71);
            txtMaHD.Margin = new Padding(5, 4, 5, 4);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(148, 27);
            txtMaHD.TabIndex = 30;
            txtMaHD.TextChanged += txtMaHD_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(592, 55);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(127, 43);
            button5.TabIndex = 32;
            button5.Text = "Làm Mới";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(456, 55);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(127, 43);
            button6.TabIndex = 33;
            button6.Text = "Chi Tiết";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Location = new Point(-1, 423);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(747, 166);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(-1, 586);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 174);
            panel1.TabIndex = 35;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(-1, 5);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(747, 409);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách";
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 743);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(5, 4, 5, 4);
            Name = "HoaDon";
            Text = "HoaDon";
            Load += HoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox2;
    }
}