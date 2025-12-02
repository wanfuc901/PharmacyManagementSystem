namespace QLNhaThuoc
{
    partial class ChangePass
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
            txtTenDN = new TextBox();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtNhapLai = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(115, 22);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(100, 23);
            txtTenDN.TabIndex = 0;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(115, 51);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(100, 23);
            txtMatKhauCu.TabIndex = 1;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(115, 80);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(100, 23);
            txtMatKhauMoi.TabIndex = 2;
            // 
            // txtNhapLai
            // 
            txtNhapLai.Location = new Point(115, 109);
            txtNhapLai.Name = "txtNhapLai";
            txtNhapLai.Size = new Size(100, 23);
            txtNhapLai.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 54);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Mật Khẩu Cũ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 83);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 112);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 7;
            label4.Text = "Mật Khẩu Mới";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenDN);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMatKhauCu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatKhauMoi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNhapLai);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 198);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // button1
            // 
            button1.Location = new Point(34, 154);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 154);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Xác Nhận";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 214);
            Controls.Add(groupBox1);
            Name = "ChangePass";
            Text = "ChangePass";
            Load += ChangePass_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTenDN;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtNhapLai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
    }
}