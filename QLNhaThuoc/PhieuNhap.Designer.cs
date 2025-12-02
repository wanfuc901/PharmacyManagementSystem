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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm Nhà Cung Cấp:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(152, 30);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(100, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiemNCC_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 71);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhà Cung Cấp:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 107);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Tổng Tiền:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 152);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày Nhập:";
            label4.Click += label4_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(152, 107);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(187, 23);
            txtTongTien.TabIndex = 6;
            txtTongTien.TextChanged += textBox2_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(264, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 200);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(218, 200);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Làm Mới";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 242);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(140, 70);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(187, 23);
            txtMaNCC.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTong);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(dgvPhieuNhap);
            groupBox2.Location = new Point(12, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 237);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(302, 202);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(34, 15);
            lblTong.TabIndex = 15;
            lblTong.Text = "Tổng";
            // 
            // button5
            // 
            button5.Location = new Point(206, 198);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "In Phiếu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(81, 198);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "Xuất Excel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Location = new Point(6, 22);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.Size = new Size(354, 150);
            dgvPhieuNhap.TabIndex = 14;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(8, 8);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 498);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTongTien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
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
    }
}