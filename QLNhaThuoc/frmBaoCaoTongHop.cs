using BUS;
using DAO;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.rtf.table;
using PdfSharpCore.Drawing;
using System;
using System.Data;
using System.Linq;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.IO;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;


namespace QLNhaThuoc
{

    public partial class frmBaoCaoTongHop : Form
    {
        private ComboBox cbCa;
        private ComboBox cbNV;
        private ComboBox cbPayment;

        private ComboBox cbNCC;
        private TextBox txtTenThuoc;

        private ComboBox cbNhomThuoc;

        private NumericUpDown numTop;
        private NumericUpDown numTopKH;


        private bool isSwitchingType = false;
        public frmBaoCaoTongHop()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void AttachAutoReload(Control ctrl)
        {
            if (ctrl is ComboBox cb)
                cb.SelectedIndexChanged += (s, e) =>
                {
                    if (!isSwitchingType)
                        LoadBaoCao();
                };

            else if (ctrl is TextBox tb)
                tb.TextChanged += (s, e) =>
                {
                    if (!isSwitchingType)
                        LoadBaoCao();
                };

            else if (ctrl is NumericUpDown num)
                num.ValueChanged += (s, e) =>
                {
                    if (!isSwitchingType)
                        LoadBaoCao();
                };
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BuildDynamicFilter()
        {
            // reset toàn bộ biến filter trước khi tạo mới
            cbCa = null;
            cbNV = null;
            cbPayment = null;
            cbNCC = null;
            txtTenThuoc = null;
            cbNhomThuoc = null;
            numTop = null;
            numTopKH = null;

            panelFilter.Controls.Clear();

            switch (cbLoaiBaoCao.Text)
            {
                case "Doanh thu": AddFilter_DonThu(); break;
                case "Nhập hàng": AddFilter_NhapHang(); break;
                case "Tồn kho": AddFilter_TonKho(); break;
                case "Thuốc bán chạy": AddFilter_ThuocBanChay(); break;
                case "Khách hàng mua nhiều": AddFilter_KhachHangMuaNhieu(); break;
            }
        }


        private void frmBaoCaoTongHop_Load(object sender, EventArgs e)
        {
            cbLoaiBaoCao.Items.AddRange(new string[]
    {
        "Doanh thu",
        "Nhập hàng",
        "Tồn kho",
        "Thuốc bán chạy",
        "Khách hàng mua nhiều"
    });

            cbLoaiBaoCao.SelectedIndexChanged += (s, ev) =>
            {
                isSwitchingType = true;    // khóa auto reload khi tạo filter mới
                BuildDynamicFilter();
                isSwitchingType = false;   // mở khóa lại

                LoadBaoCao();
            };


            cbLoaiBaoCao.SelectedIndex = 0; // tự động gọi 1 lần

            // === THỜI GIAN MẶC ĐỊNH ===
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;

            // === TẢI DỮ LIỆU BAN ĐẦU ===
            LoadBaoCao();
        }

        private void AddFilter_DonThu()
        {
            

            Label l1 = new Label { Text = "Ca:", Left = 10, Top = 10 };
            cbCa = new ComboBox { Left = 80, Top = 8, Width = 120 };
            cbCa.Items.AddRange(new string[] { "Tất cả", "Ca sáng", "Ca chiều", "Ca tối" });
            cbCa.SelectedIndex = 0;
            AttachAutoReload(cbCa);

            Label l2 = new Label { Text = "Nhân viên:", Left = 230, Top = 10 };
            cbNV = new ComboBox { Left = 310, Top = 8, Width = 150 };
            cbNV.Items.Add("Tất cả");
            cbNV.Items.AddRange(BaoCaoDAO.LayDanhSachNhanVien().ToArray());
            cbNV.SelectedIndex = 0;
            AttachAutoReload(cbNV);

            Label l3 = new Label { Text = "Thanh toán:", Left = 480, Top = 10 };
            cbPayment = new ComboBox { Left = 560, Top = 8, Width = 150 };
            cbPayment.Items.AddRange(new string[] { "Tất cả", "Tiền mặt", "Chuyển khoản", "VNPay", "Momo" });
            cbPayment.SelectedIndex = 0;
            AttachAutoReload(cbPayment);

            panelFilter.Controls.AddRange(new Control[] { l1, cbCa, l2, cbNV, l3, cbPayment });
        }



        private void AddFilter_NhapHang()
        {

            cbNCC = new ComboBox { Left = 10, Top = 8, Width = 200 };
            cbNCC.Items.Add("Tất cả nhà cung cấp");
            cbNCC.Items.AddRange(NCCDAO.LayDanhSach().ToArray());
            cbNCC.SelectedIndex = 0;
            AttachAutoReload(cbNCC);

            txtTenThuoc = new TextBox
            {
                Left = 230,
                Top = 8,
                Width = 200,
                PlaceholderText = "Tên thuốc..."
            };
            AttachAutoReload(txtTenThuoc);

            panelFilter.Controls.Add(cbNCC);
            panelFilter.Controls.Add(txtTenThuoc);
        }




        private void AddFilter_TonKho()
        {
            cbNhomThuoc = new ComboBox { Left = 10, Top = 8, Width = 200 };
            cbNhomThuoc.Items.Add("Tất cả nhóm thuốc");
            cbNhomThuoc.Items.AddRange(ThuocDAO.LayDanhSachNhom().ToArray());
            cbNhomThuoc.SelectedIndex = 0;
            AttachAutoReload(cbNhomThuoc);

            panelFilter.Controls.Add(cbNhomThuoc);
        }




        private void AddFilter_ThuocBanChay()
        {

            Label lb = new Label { Text = "Top:", Left = 10, Top = 12 };

            numTop = new NumericUpDown
            {
                Left = 60,
                Top = 8,
                Width = 70,
                Minimum = 3,
                Maximum = 50,
                Value = 10
            };
            AttachAutoReload(numTop);

            panelFilter.Controls.Add(lb);
            panelFilter.Controls.Add(numTop);
        }


        private void AddFilter_KhachHangMuaNhieu()
        {


            Label lb = new Label { Text = "Top:", Left = 10, Top = 12 };

            numTopKH = new NumericUpDown
            {
                Left = 60,
                Top = 8,
                Width = 70,
                Minimum = 3,
                Maximum = 50,
                Value = 10
            };
            AttachAutoReload(numTopKH);

            panelFilter.Controls.Add(lb);
            panelFilter.Controls.Add(numTopKH);
        }


        private void lblTongCong_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void LoadBaoCao()
        {
            string loai = cbLoaiBaoCao.Text;
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;

            DataTable dt = loai switch
            {
                "Doanh thu" => LocDoanhThu(BaoCaoDAO.LayDoanhThuTheoKhoang(from, to)),
                "Nhập hàng" => LocNhapHang(BaoCaoDAO.LayNhapHangTheoKhoang(from, to)),
                "Tồn kho" => LocTonKho(BaoCaoBUS.TonKho()),
                "Thuốc bán chạy" => LocThuocBanChay(BaoCaoBUS.ThuocBanChay()),
                "Khách hàng mua nhiều" => LocKhachHangMuaNhieu(BaoCaoBUS.KhachHangMuaNhieu()),
                _ => null
            };

            dataGridView1.DataSource = dt;
        }

        private DataTable LocDoanhThu(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return dt;

            DataView dv = dt.DefaultView;
            var dk = new List<string>();

            if (dt.Columns.Contains("Ca") && cbCa.Text != "Tất cả")
                dk.Add($"Ca = '{cbCa.Text}'");

            if (dt.Columns.Contains("NhanVien") && cbNV.Text != "Tất cả")
                dk.Add($"NhanVien = '{cbNV.Text}'");

            if (dt.Columns.Contains("ThanhToan") && cbPayment.Text != "Tất cả")
                dk.Add($"ThanhToan = '{cbPayment.Text}'");

            dv.RowFilter = string.Join(" AND ", dk);
            return dv.ToTable();
        }


        private DataTable LocNhapHang(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return dt;

            DataView dv = dt.DefaultView;
            var dk = new List<string>();

            if (dt.Columns.Contains("NCC") && cbNCC.Text != "Tất cả nhà cung cấp")
                dk.Add($"NCC = '{cbNCC.Text}'");

            if (dt.Columns.Contains("TenThuoc") && txtTenThuoc.Text.Trim() != "")
                dk.Add($"TenThuoc LIKE '%{txtTenThuoc.Text.Trim()}%'");

            dv.RowFilter = string.Join(" AND ", dk);
            return dv.ToTable();
        }




        private DataTable LocTonKho(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return dt;

            if (dt.Columns.Contains("Nhom") && cbNhomThuoc.Text != "Tất cả nhóm thuốc")
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Nhom = '{cbNhomThuoc.Text}'";
                return dv.ToTable();
            }

            return dt;
        }


        private DataTable LocThuocBanChay(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return dt;

            int top = (int)numTop.Value;

            return dt.AsEnumerable()
                     .OrderByDescending(r => r.Field<int>("SoLuongBan"))
                     .Take(top)
                     .CopyToDataTable();
        }


        private DataTable LocKhachHangMuaNhieu(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return dt;

            int top = (int)numTopKH.Value;

            return dt.AsEnumerable()
                     .OrderByDescending(r => r.Field<decimal>("TongChiTieu"))
                     .Take(top)
                     .CopyToDataTable();
        }





        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in");
                return;
            }

            string loai = cbLoaiBaoCao.Text;
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "PDF files|*.pdf",
                FileName = $"BaoCao_{loai.Replace(" ", "_")}_{DateTime.Now:ddMMyyyy}.pdf"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                // === TẠO PDF ===
                PdfDocument doc = new PdfDocument();
                var page = doc.AddPage();
                XGraphics g = XGraphics.FromPdfPage(page);

                XFont fontTitle = new XFont("Arial", 14, XFontStyle.Bold);
                XFont fontText = new XFont("Arial", 10);
                double y = 40;

                g.DrawString("BÁO CÁO TỔNG HỢP - " + loai.ToUpper(), fontTitle, XBrushes.Black,
                    new XRect(0, y, page.Width, 20), XStringFormats.TopCenter);
                y += 30;
                g.DrawString($"Từ ngày {from:dd/MM/yyyy} đến {to:dd/MM/yyyy}", fontText, XBrushes.Black, 40, y);
                y += 30;

                // === VẼ BẢNG DỮ LIỆU ===
                double x1 = 40;
                double colWidth = (page.Width - 80) / dt.Columns.Count;
                g.DrawLine(XPens.Black, x1, y, x1 + colWidth * dt.Columns.Count, y);
                y += 15;

                // Header
                for (int i = 0; i < dt.Columns.Count; i++)
                    g.DrawString(dt.Columns[i].ColumnName, fontText, XBrushes.Black, x1 + i * colWidth, y);
                y += 15;

                // Dòng dữ liệu
                foreach (DataRow r in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                        g.DrawString(Convert.ToString(r[i]), fontText, XBrushes.Black, x1 + i * colWidth, y);
                    y += 15;
                    if (y > page.Height - 60)
                    {
                        page = doc.AddPage();
                        g = XGraphics.FromPdfPage(page);
                        y = 40;
                    }
                }

                y += 20;
                double tong = dt.AsEnumerable()
                    .SelectMany(r => r.ItemArray)
                    .Where(v => double.TryParse(Convert.ToString(v), out _))
                    .Sum(v => Convert.ToDouble(v));

                g.DrawString($"Tổng cộng: {tong:N0} đ", fontTitle, XBrushes.Black, 40, y);



                doc.Save(sfd.FileName);
                MessageBox.Show("Đã tạo file PDF: " + sfd.FileName);
                System.Diagnostics.Process.Start("explorer.exe", sfd.FileName);
            }
        }
    }
}
