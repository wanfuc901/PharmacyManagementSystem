namespace QLNhaThuoc
{
    partial class PhieuTra
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
            txtMaNCC = new TextBox();
            txtTongTien = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateNgayTra = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            label4 = new Label();
            txtTimKiem = new TextBox();
            panel1 = new Panel();
            btnXuatExcel = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            lblTong = new Label();
            dgvPhieuTra = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuTra).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 49);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã NCC:";
            label1.Click += label1_Click;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(78, 45);
            txtMaNCC.Margin = new Padding(3, 4, 3, 4);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(114, 27);
            txtMaNCC.TabIndex = 1;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(279, 45);
            txtTongTien.Margin = new Padding(3, 4, 3, 4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(114, 27);
            txtTongTien.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 97);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày Trả:";
            // 
            // dateNgayTra
            // 
            dateNgayTra.Location = new Point(78, 92);
            dateNgayTra.Margin = new Padding(3, 4, 3, 4);
            dateNgayTra.Name = "dateNgayTra";
            dateNgayTra.Size = new Size(315, 27);
            dateNgayTra.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(dateNgayTra);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(408, 151);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(3, 161);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(408, 111);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(307, 49);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 31);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 55);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(78, 49);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(222, 27);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXuatExcel);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(65, 280);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 36);
            panel1.TabIndex = 8;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(185, 4);
            btnXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(86, 31);
            btnXuatExcel.TabIndex = 11;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(93, 4);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 31);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(0, 4);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(lblTong);
            groupBox3.Controls.Add(dgvPhieuTra);
            groupBox3.Location = new Point(3, 324);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(408, 317);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(307, 284);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(46, 20);
            lblTong.TabIndex = 1;
            lblTong.Text = "Tổng:";
            // 
            // dgvPhieuTra
            // 
            dgvPhieuTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuTra.Location = new Point(7, 24);
            dgvPhieuTra.Margin = new Padding(3, 4, 3, 4);
            dgvPhieuTra.Name = "dgvPhieuTra";
            dgvPhieuTra.RowHeadersWidth = 51;
            dgvPhieuTra.Size = new Size(394, 245);
            dgvPhieuTra.TabIndex = 0;
            dgvPhieuTra.CellContentClick += dgvPhieuTra_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(214, 277);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 12;
            button1.Text = "Chi Tiết";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PhieuTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 657);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhieuTra";
            Text = " ";
            Load += PhieuTra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuTra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMaNCC;
        private TextBox txtTongTien;
        private Label label2;
        private Label label3;
        private DateTimePicker dateNgayTra;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private Label label4;
        private TextBox txtTimKiem;
        private Panel panel1;
        private Button btnXuatExcel;
        private Button btnLamMoi;
        private Button btnThem;
        private GroupBox groupBox3;
        private DataGridView dgvPhieuTra;
        private Label lblTong;
        private Button button1;
    }
}