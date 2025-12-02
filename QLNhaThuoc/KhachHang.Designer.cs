namespace QL_NhaThuoc
{
    partial class KhachHang
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaKH = new TextBox();
            button5 = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            dataGridView1.Location = new Point(3, 58);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(517, 214);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(4, 13);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(188, 12);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(84, 32);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(96, 12);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(84, 32);
            button3.TabIndex = 3;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(280, 11);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(111, 32);
            button4.TabIndex = 4;
            button4.Text = "Tìm Kiếm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(7, 90);
            txtTenKH.Margin = new Padding(4, 3, 4, 3);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(194, 23);
            txtTenKH.TabIndex = 5;
            txtTenKH.TextChanged += txtTenKH_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(234, 90);
            txtDiaChi.Margin = new Padding(4, 3, 4, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(282, 23);
            txtDiaChi.TabIndex = 6;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(7, 134);
            txtSDT.Margin = new Padding(4, 3, 4, 3);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 23);
            txtSDT.TabIndex = 7;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 42);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 9;
            label1.Text = "Tên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 10;
            label2.Text = "Địa Chỉ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 11;
            label3.Text = "SDT";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 14;
            label5.Text = "Mã KH";
            label5.Click += label5_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(7, 42);
            txtMaKH.Margin = new Padding(4, 3, 4, 3);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(194, 23);
            txtMaKH.TabIndex = 13;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(399, 11);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(111, 32);
            button5.TabIndex = 15;
            button5.Text = "Làm Mới";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(73, 15);
            label6.Name = "label6";
            label6.Size = new Size(378, 40);
            label6.TabIndex = 16;
            label6.Text = "Danh Sách Khách Hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Location = new Point(3, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 175);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(5, 465);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 57);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(-1, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(527, 278);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách";
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 534);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KhachHang";
            Text = "KhachHang";
            Load += KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button button5;
        private Label label6;
        private GroupBox groupBox1;
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox2;
    }
}