namespace QLNhaThuoc
{
    partial class frmBaoCaoTongHop
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
            cbLoaiBaoCao = new ComboBox();
            groupBox1 = new GroupBox();
            btnIn = new Button();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            btnXem = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            lblTongCong = new Label();
            panelFilter = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbLoaiBaoCao
            // 
            cbLoaiBaoCao.FormattingEnabled = true;
            cbLoaiBaoCao.Location = new Point(108, 27);
            cbLoaiBaoCao.Margin = new Padding(3, 4, 3, 4);
            cbLoaiBaoCao.Name = "cbLoaiBaoCao";
            cbLoaiBaoCao.Size = new Size(228, 28);
            cbLoaiBaoCao.TabIndex = 0;
            cbLoaiBaoCao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIn);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXem);
            groupBox1.Controls.Add(cbLoaiBaoCao);
            groupBox1.Location = new Point(14, 97);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(654, 132);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công Cụ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(539, 20);
            btnIn.Margin = new Padding(3, 4, 3, 4);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(86, 31);
            btnIn.TabIndex = 8;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(408, 71);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(236, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 77);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Đến Ngày";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 72);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 31);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 3;
            label1.Text = "Loại Báo Cáo";
            // 
            // btnXem
            // 
            btnXem.Location = new Point(432, 20);
            btnXem.Margin = new Padding(3, 4, 3, 4);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(86, 31);
            btnXem.TabIndex = 2;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(14, 237);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(654, 328);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ Liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 29);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(640, 291);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblTongCong
            // 
            lblTongCong.AutoSize = true;
            lblTongCong.Location = new Point(495, 568);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(85, 20);
            lblTongCong.TabIndex = 3;
            lblTongCong.Text = "Tổng Cộng:";
            lblTongCong.Click += lblTongCong_Click;
            // 
            // panelFilter
            // 
            panelFilter.Location = new Point(14, 4);
            panelFilter.Margin = new Padding(3, 4, 3, 4);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(647, 85);
            panelFilter.TabIndex = 4;
            // 
            // frmBaoCaoTongHop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 600);
            Controls.Add(panelFilter);
            Controls.Add(lblTongCong);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBaoCaoTongHop";
            Text = "frmBaoCaoTongHop";
            Load += frmBaoCaoTongHop_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbLoaiBaoCao;
        private GroupBox groupBox1;
        private Button btnXem;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label lblTongCong;
        private Button btnIn;
        private FlowLayoutPanel panelFilter;
    }
}