namespace QL_NhaThuoc
{
    partial class CT_PhieuNhap
    {
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblTongSoDong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnDong;

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            dgvCTPN = new DataGridView();
            panelFooter = new Panel();
            lblTongSoDong = new Label();
            lblTongTien = new Label();
            btnXuatExcel = new Button();
            btnDong = new Button();

            // ===== HEADER =====
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 60;
            panelHeader.BackColor = Color.FromArgb(18, 106, 235);

            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 18);

            panelHeader.Controls.Add(lblTitle);

            // ===== DATAGRID =====
            dgvCTPN.Dock = DockStyle.Fill;
            dgvCTPN.ReadOnly = true;
            dgvCTPN.AllowUserToAddRows = false;
            dgvCTPN.AllowUserToDeleteRows = false;
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTPN.BackgroundColor = Color.White;
            dgvCTPN.BorderStyle = BorderStyle.None;
            dgvCTPN.RowHeadersVisible = false;

            // ===== FOOTER =====
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Height = 55;
            panelFooter.BackColor = Color.WhiteSmoke;

            lblTongSoDong.Location = new Point(15, 18);
            lblTongSoDong.AutoSize = true;

            lblTongTien.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTongTien.Location = new Point(200, 18);
            lblTongTien.AutoSize = true;

            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.Size = new Size(100, 32);
            btnXuatExcel.Location = new Point(520, 12);
            btnXuatExcel.Click += btnXuatExcel_Click;

            btnDong.Text = "Đóng";
            btnDong.Size = new Size(80, 32);
            btnDong.Location = new Point(630, 12);
            btnDong.Click += btnDong_Click;

            panelFooter.Controls.Add(lblTongSoDong);
            panelFooter.Controls.Add(lblTongTien);
            panelFooter.Controls.Add(btnXuatExcel);
            panelFooter.Controls.Add(btnDong);

            // ===== FORM =====
            this.Text = "Chi tiết phiếu nhập";
            this.ClientSize = new Size(740, 450);
            this.Controls.Add(dgvCTPN);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);
            this.Load += CT_PhieuNhap_Load;
        }
    }
}