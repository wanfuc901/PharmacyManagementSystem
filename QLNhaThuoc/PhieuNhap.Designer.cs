namespace QL_NhaThuoc
{
    partial class PhieuNhap
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
            label1 = new Label();
            txtTimKiem = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTongTien = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            txtMaNCC = new TextBox();
            groupBox2 = new GroupBox();
            lblTong = new Label();
            button5 = new Button();
            button4 = new Button();
            dgvPhieuNhap = new DataGridView();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm Nhà Cung Cấp:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(174, 40);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(114, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiemNCC_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhà Cung Cấp:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 143);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Tổng Tiền:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 203);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Ngày Nhập:";
            label4.Click += label4_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(174, 143);
            txtTongTien.Margin = new Padding(3, 4, 3, 4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(213, 27);
            txtTongTien.TabIndex = 6;
            txtTongTien.TextChanged += textBox2_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 203);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(302, 40);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 8;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(27, 266);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 10;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 266);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 11;
            button3.Text = "Làm Mới";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(14, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(418, 323);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(160, 93);
            txtMaNCC.Margin = new Padding(3, 4, 3, 4);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(213, 27);
            txtMaNCC.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTong);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(dgvPhieuNhap);
            groupBox2.Location = new Point(14, 332);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(418, 316);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(345, 269);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(43, 20);
            lblTong.TabIndex = 15;
            lblTong.Text = "Tổng";
            // 
            // button5
            // 
            button5.Location = new Point(235, 264);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 14;
            button5.Text = "In Phiếu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(93, 264);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 14;
            button4.Text = "Xuất Excel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Location = new Point(7, 29);
            dgvPhieuNhap.Margin = new Padding(3, 4, 3, 4);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.Size = new Size(405, 200);
            dgvPhieuNhap.TabIndex = 14;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(9, 11);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button6
            // 
            button6.Location = new Point(288, 266);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 15;
            button6.Text = "Chi Tiết";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 664);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTongTien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhieuNhap";
            Text = "DANH SÁCH PHIẾU NHẬP   ";
            Load += PhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTimKiem;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTongTien;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private DataGridView dgvPhieuNhap;
        private Button button5;
        private Label lblTong;
        private TextBox txtMaNCC;
        private DataGridView dataGridView1;
        private Button button6;
    }
}