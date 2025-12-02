using ScottPlot;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace QL_NhaThuoc
{
    public partial class Search_Report : Form
    {
        private DataTable dataBaoCao;
        private readonly Random rnd = new Random();

        public Search_Report()
        {
            InitializeComponent();

            cboKieu.Items.AddRange(new string[] { "Cột", "Đường", "Tròn" });
            cboKieu.SelectedIndex = 0;
        }

        private void Search_Report_Load(object sender, EventArgs e)
        {
            isLoaded = true;
            dateTimePicker1.Value = DateTime.Now.AddDays(-7);
            dateTimePicker2.Value = DateTime.Now;
            TaoDuLieuGiaLap();
        }

        // ----- TẠO DỮ LIỆU GIẢ LẬP -----
        private void TaoDuLieuGiaLap()
        {
            dataBaoCao = new DataTable();
            dataBaoCao.Columns.Add("Ngay", typeof(DateTime));
            dataBaoCao.Columns.Add("DoanhThu", typeof(double));

            for (int i = 0; i < 10; i++)
                dataBaoCao.Rows.Add(DateTime.Today.AddDays(-i), rnd.Next(5, 20) * 100000);

            dgvBaoCao.DataSource = dataBaoCao;
            CapNhatGridVaTong();
        }


        // ----- CẬP NHẬT DGV + TỔNG -----
        private void CapNhatGridVaTong()
        {
            double tong = dataBaoCao.AsEnumerable().Sum(r => r.Field<double>("DoanhThu"));
            lblTongTien.Text = $"Tổng cộng: {tong:N0} đ";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void lbIn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var from = dateTimePicker1.Value.Date;
            var to = dateTimePicker2.Value.Date;
            var kieu = cboKieu.SelectedItem?.ToString() ?? "Cột";

            var filtered = dataBaoCao.AsEnumerable()
                .Where(r => r.Field<DateTime>("Ngay") >= from && r.Field<DateTime>("Ngay") <= to)
                .OrderBy(r => r.Field<DateTime>("Ngay"))
                .ToList();

            if (!filtered.Any())
            {
                MessageBox.Show("Không có dữ liệu!");
                return;
            }

            double[] values = filtered.Select(r => r.Field<double>("DoanhThu")).ToArray();
            double[] xs = Enumerable.Range(0, values.Length).Select(i => (double)i).ToArray();
            string[] labels = filtered.Select(r => r.Field<DateTime>("Ngay").ToString("dd/MM")).ToArray();

            var plt = formsPlot1.Plot;
            plt.Clear();

            if (kieu == "Cột")
                plt.PlotBar(xs, values);
            else if (kieu == "Đường")
                plt.PlotScatter(xs, values);
            else if (kieu == "Tròn")
                plt.PlotPie(values, labels);

            plt.Title($"Biểu đồ doanh thu ({from:dd/MM} - {to:dd/MM})");
            plt.XTicks(xs, labels);
            plt.YLabel("Doanh thu (VNĐ)");
            plt.Legend();
            formsPlot1.Refresh();
        }
        private bool isLoaded = false;

        private void btnPDF_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog { Filter = "PDF Files|*.pdf", FileName = "BaoCao.pdf" })
            {
                if (save.ShowDialog() != DialogResult.OK) return;

                string imgPath = Path.Combine(Path.GetTempPath(), "chart.png");
                formsPlot1.Plot.SaveFig(imgPath);

                using (var doc = new PdfDocument())
                {
                    var page = doc.AddPage();
                    var g = XGraphics.FromPdfPage(page);
                    var f1 = new XFont("Arial", 14, XFontStyle.Bold);
                    var f2 = new XFont("Arial", 10);

                    g.DrawString("BÁO CÁO DOANH THU", f1, XBrushes.Black, new XRect(0, 20, page.Width, 20), XStringFormats.TopCenter);
                    g.DrawImage(XImage.FromFile(imgPath), 50, 80, page.Width - 100, 300);
                    g.DrawString(lblTongTien.Text, f2, XBrushes.Black, 50, 400);

                    doc.Save(save.FileName);
                }
                MessageBox.Show("Xuất PDF thành công!");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboKieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;  // NGĂN GỌI KHI CHƯA LOAD
            btnPreview_Click(sender, e); // tự cập nhật lại khi đổi kiểu

        }

        private void btnTaiLaiBieuDo_Click(object sender, EventArgs e)
        {
            TaoDuLieuGiaLap();
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();
        }

        private void lblTieuDeBieuDo_Click(object sender, EventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
