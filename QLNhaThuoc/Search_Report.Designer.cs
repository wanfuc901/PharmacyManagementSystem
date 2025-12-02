namespace QL_NhaThuoc
{
    partial class Search_Report
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
            dgvBaoCao = new DataGridView();
            groupBox1 = new GroupBox();
            lblTongTien = new Label();
            groupBox2 = new GroupBox();
            btnPDF = new Button();
            btnPreview = new Button();
            cboKieu = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnTaiLaiBieuDo = new Button();
            formsPlot1 = new ScottPlot.FormsPlot();
            lblTieuDeBieuDo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(11, 22);
            dgvBaoCao.Margin = new Padding(4, 3, 4, 3);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.Size = new Size(663, 203);
            dgvBaoCao.TabIndex = 0;
            dgvBaoCao.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTongTien);
            groupBox1.Controls.Add(dgvBaoCao);
            groupBox1.Location = new Point(12, 412);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(689, 285);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng Dữ Liệu Chi Tiết";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(421, 243);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(157, 26);
            lblTongTien.TabIndex = 5;
            lblTongTien.Text = " Tổng Cộng: đ";
            lblTongTien.Click += lblTongTien_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPDF);
            groupBox2.Controls.Add(btnPreview);
            groupBox2.Controls.Add(cboKieu);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(689, 125);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ Lọc";
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(546, 81);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(75, 23);
            btnPDF.TabIndex = 7;
            btnPDF.Text = "Xuất PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(421, 81);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(75, 23);
            btnPreview.TabIndex = 6;
            btnPreview.Text = "Xem trước";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // cboKieu
            // 
            cboKieu.FormattingEnabled = true;
            cboKieu.Location = new Point(119, 81);
            cboKieu.Name = "cboKieu";
            cboKieu.Size = new Size(121, 23);
            cboKieu.TabIndex = 5;
            cboKieu.SelectedIndexChanged += cboKieu_SelectedIndexChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(421, 33);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 82);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Kiểu biểu đồ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 39);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = " Từ ngày:";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTaiLaiBieuDo);
            panel1.Controls.Add(formsPlot1);
            panel1.Controls.Add(lblTieuDeBieuDo);
            panel1.Location = new Point(12, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 253);
            panel1.TabIndex = 7;
            // 
            // btnTaiLaiBieuDo
            // 
            btnTaiLaiBieuDo.Location = new Point(546, 11);
            btnTaiLaiBieuDo.Name = "btnTaiLaiBieuDo";
            btnTaiLaiBieuDo.Size = new Size(75, 23);
            btnTaiLaiBieuDo.TabIndex = 2;
            btnTaiLaiBieuDo.Text = "Làm Mới";
            btnTaiLaiBieuDo.UseVisualStyleBackColor = true;
            btnTaiLaiBieuDo.Click += btnTaiLaiBieuDo_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(3, 43);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(671, 207);
            formsPlot1.TabIndex = 1;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // lblTieuDeBieuDo
            // 
            lblTieuDeBieuDo.AutoSize = true;
            lblTieuDeBieuDo.Location = new Point(318, 15);
            lblTieuDeBieuDo.Name = "lblTieuDeBieuDo";
            lblTieuDeBieuDo.Size = new Size(38, 15);
            lblTieuDeBieuDo.TabIndex = 0;
            lblTieuDeBieuDo.Text = "label4";
            lblTieuDeBieuDo.Click += lblTieuDeBieuDo_Click;
            // 
            // Search_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 716);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Search_Report";
            Text = "Search_Report";
            Load += Search_Report_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaoCao;
        private GroupBox groupBox1;
        private Label lblTongTien;
        private GroupBox groupBox2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Button btnPDF;
        private Button btnPreview;
        private ComboBox cboKieu;
        private Panel panel1;
        private Label lblTieuDeBieuDo;
        private Button btnTaiLaiBieuDo;
        private ScottPlot.FormsPlot formsPlot1;

    }
}