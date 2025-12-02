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
            label1.Location = new Point(8, 37);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã NCC:";
            label1.Click += label1_Click;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(68, 34);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(100, 23);
            txtMaNCC.TabIndex = 1;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(244, 34);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(100, 23);
            txtTongTien.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 36);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 73);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Ngày Trả:";
            // 
            // dateNgayTra
            // 
            dateNgayTra.Location = new Point(68, 69);
            dateNgayTra.Name = "dateNgayTra";
            dateNgayTra.Size = new Size(276, 23);
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
            groupBox1.Location = new Point(3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 113);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(3, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 83);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(269, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 41);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(68, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(195, 23);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXuatExcel);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(57, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 27);
            panel1.TabIndex = 8;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(162, 3);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(75, 23);
            btnXuatExcel.TabIndex = 11;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(81, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(0, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTong);
            groupBox3.Controls.Add(dgvPhieuTra);
            groupBox3.Location = new Point(3, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(357, 238);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(269, 213);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(37, 15);
            lblTong.TabIndex = 1;
            lblTong.Text = "Tổng:";
            // 
            // dgvPhieuTra
            // 
            dgvPhieuTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuTra.Location = new Point(6, 18);
            dgvPhieuTra.Name = "dgvPhieuTra";
            dgvPhieuTra.Size = new Size(345, 184);
            dgvPhieuTra.TabIndex = 0;
            dgvPhieuTra.CellContentClick += dgvPhieuTra_CellContentClick;
            // 
            // PhieuTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 493);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
    }
}