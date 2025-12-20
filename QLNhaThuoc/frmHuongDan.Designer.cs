namespace QLNhaThuoc
{
    partial class frmHuongDan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvMucLuc;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblResult;

        private System.Windows.Forms.RichTextBox richTextBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tvMucLuc = new System.Windows.Forms.TreeView();

            pnlTop = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            btnPrev = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();

            richTextBox1 = new System.Windows.Forms.RichTextBox();

            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();

            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.TabIndex = 0;

            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvMucLuc);

            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBox1);
            splitContainer1.Panel2.Controls.Add(pnlTop);

            // 
            // tvMucLuc
            // 
            tvMucLuc.Dock = System.Windows.Forms.DockStyle.Fill;
            tvMucLuc.HideSelection = false;
            tvMucLuc.Location = new System.Drawing.Point(0, 0);
            tvMucLuc.Name = "tvMucLuc";
            tvMucLuc.Size = new System.Drawing.Size(260, 650);
            tvMucLuc.TabIndex = 0;
            tvMucLuc.AfterSelect += tvMucLuc_AfterSelect;

            // 
            // pnlTop
            // 
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Height = 44;
            pnlTop.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            pnlTop.Name = "pnlTop";

            // 
            // txtSearch
            // 
            txtSearch.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            txtSearch.Location = new System.Drawing.Point(10, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(420, 27);
            txtSearch.TabIndex = 0;
            txtSearch.PlaceholderText = "Tìm trong mục đang mở...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;

            // 
            // btnPrev
            // 
            btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPrev.Location = new System.Drawing.Point(440, 8);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new System.Drawing.Size(54, 30);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "◀";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;

            // 
            // btnNext
            // 
            btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnNext.Location = new System.Drawing.Point(498, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(54, 30);
            btnNext.TabIndex = 2;
            btnNext.Text = "▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;

            // 
            // lblResult
            // 
            lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(560, 13);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(0, 20);
            lblResult.TabIndex = 3;

            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(btnPrev);
            pnlTop.Controls.Add(btnNext);
            pnlTop.Controls.Add(lblResult);

            // 
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            richTextBox1.Location = new System.Drawing.Point(0, 44);
            richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new System.Drawing.Size(640, 606);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";

            // 
            // frmHuongDan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 650);
            Controls.Add(splitContainer1);
            Name = "frmHuongDan";
            Text = "Hướng dẫn sử dụng hệ thống";
            Load += frmHuongDan_Load;

            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
    }
}
