namespace QLNhaThuoc
{
    partial class CT_PhieuTra
    {
        private Panel panelHeader;
        private Label lblTitle;
        private DataGridView dgvCTTra;
        private Panel panelFooter;
        private Label lblSoDong;
        private Label lblTongTien;
        private Button btnXuatExcel;
        private Button btnDong;

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            dgvCTTra = new DataGridView();
            panelFooter = new Panel();
            lblSoDong = new Label();
            lblTongTien = new Label();
            btnXuatExcel = new Button();
            btnDong = new Button();

            // HEADER
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 60;
            panelHeader.BackColor = Color.FromArgb(255, 193, 7); // vàng – phiếu trả

            lblTitle.ForeColor = Color.Black;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 18);

            panelHeader.Controls.Add(lblTitle);

            // GRID
            dgvCTTra.Dock = DockStyle.Fill;
            dgvCTTra.ReadOnly = true;
            dgvCTTra.AllowUserToAddRows = false;
            dgvCTTra.AllowUserToDeleteRows = false;
            dgvCTTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTTra.RowHeadersVisible = false;
            dgvCTTra.BackgroundColor = Color.White;
            dgvCTTra.BorderStyle = BorderStyle.None;

            // FOOTER
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Height = 55;
            panelFooter.BackColor = Color.WhiteSmoke;

            lblSoDong.Location = new Point(15, 18);
            lblSoDong.AutoSize = true;

            lblTongTien.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTongTien.Location = new Point(220, 18);
            lblTongTien.AutoSize = true;

            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.Size = new Size(100, 32);
            btnXuatExcel.Location = new Point(520, 12);
            btnXuatExcel.Click += btnXuatExcel_Click;

            btnDong.Text = "Đóng";
            btnDong.Size = new Size(80, 32);
            btnDong.Location = new Point(630, 12);
            btnDong.Click += btnDong_Click;

            panelFooter.Controls.Add(lblSoDong);
            panelFooter.Controls.Add(lblTongTien);
            panelFooter.Controls.Add(btnXuatExcel);
            panelFooter.Controls.Add(btnDong);

            // FORM
            this.Text = "Chi tiết phiếu trả";
            this.ClientSize = new Size(740, 450);
            this.Controls.Add(dgvCTTra);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);
            this.Load += CT_PhieuTra_Load;
        }

    }
}