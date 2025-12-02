using BUS;
using DTO;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VietQRHelper;
namespace QLNhaThuoc
{
    public partial class Trade : Form
    {
        private BindingList<TradeDTO> gioHang = new BindingList<TradeDTO>();

        public Trade()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hoặc tên để tìm!");
                return;
            }

            DataTable dt = KhachHangBUS.SearchByKeyword(keyword);

            if (dt.Rows.Count > 0)
            {
                // Nếu tìm thấy khách hàng
                DataRow row = dt.Rows[0];
                txtHoTen.Text = row["TenKH"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
                txtSDT.Text = row["SDT"].ToString();
                txtEmail.Text = row["Email"].ToString();

                // Khóa các ô nhập
                txtHoTen.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtEmail.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Khách hàng mới, vui lòng nhập thông tin!");

                // Cho phép nhập mới
                txtHoTen.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtEmail.ReadOnly = false;

                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtEmail.Clear();
                txtSDT.Clear();

                // Nếu nhập số điện thoại thì đưa vào ô SDT, nếu nhập tên thì đưa vào ô tên
                if (System.Text.RegularExpressions.Regex.IsMatch(keyword, @"^\d+$"))
                {
                    txtSDT.Text = keyword;
                }
                else
                {
                    txtHoTen.Text = keyword;
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("SĐT không được để trống!");
                return;
            }

            // Kiểm tra trùng SĐT
            if (KhachHangBUS.ExistsBySDT(txtSDT.Text.Trim()))
            {
                MessageBox.Show("SĐT đã tồn tại, vui lòng nhập số khác!");
                return;
            }

            KhachHangDTO kh = new KhachHangDTO
            {
                TenKH = txtHoTen.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            if (KhachHangBUS.Insert(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                // Sau khi thêm, khóa lại để chỉ hiển thị
                txtHoTen.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtEmail.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!");
            }
        }

        private void txtSearchMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchMed_Click(object sender, EventArgs e)
        {
            LoadThuoc(txtSearchMed.Text.Trim());
        }

        private void btnChooseMed_Click(object sender, EventArgs e)
        {
            if (dgvThuoc.CurrentRow == null) return;

            int maThuoc = Convert.ToInt32(dgvThuoc.CurrentRow.Cells["mathuoc"].Value);
            string tenThuoc = dgvThuoc.CurrentRow.Cells["tenthuoc"].Value.ToString();
            decimal gia = Convert.ToDecimal(dgvThuoc.CurrentRow.Cells["gia"].Value);
            int soLuongTon = Convert.ToInt32(dgvThuoc.CurrentRow.Cells["soluong"].Value);

            int soLuongMua = (int)nudSoLuong.Value;
            if (soLuongMua <= 0 || soLuongMua > soLuongTon)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            var existing = gioHang.FirstOrDefault(t => t.MaThuoc == maThuoc);
            if (existing != null)
                existing.SoLuong += soLuongMua;
            else
                gioHang.Add(new TradeDTO
                {
                    MaThuoc = maThuoc,
                    TenThuoc = tenThuoc,
                    DonGia = gia,
                    SoLuong = soLuongMua
                });

            UpdateTongTien();
            dgvGioHang.Refresh();
        }
        private void UpdateTongTien()
        {
            decimal tong = gioHang.Sum(t => t.ThanhTien);
            lblTongTien.Text = "Tổng cộng: " + tong.ToString("N0") + " đ";
        }


        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];

            if (row.Cells["ghichu"].Value != DBNull.Value)
                txtGhiChu.Text = row.Cells["ghichu"].Value.ToString();
            else
                txtGhiChu.Clear();
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                gioHang.RemoveAt(dgvGioHang.CurrentRow.Index);
                UpdateTongTien();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng!");
                return;
            }

            decimal tong = gioHang.Sum(t => t.ThanhTien);

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                FileName = $"HoaDon_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
            };
            if (save.ShowDialog() != DialogResult.OK) return;

            using (PdfDocument pdf = new PdfDocument())
            {
                pdf.Info.Title = "Hóa đơn bán thuốc";
                PdfPage page = pdf.AddPage();
                page.Width = XUnit.FromMillimeter(100);
                page.Height = XUnit.FromMillimeter(230);
                XGraphics g = XGraphics.FromPdfPage(page);

                XFont f8 = new XFont("Arial", 8);
                XFont f9 = new XFont("Arial", 9);
                XFont f9b = new XFont("Arial", 9, XFontStyle.Bold);
                XFont f10b = new XFont("Arial", 10, XFontStyle.Bold);

                double y = 20;

                // ===== HEADER =====
                g.DrawString("NHÀ THUỐC VINMEC", f10b, XBrushes.Black,
                    new XRect(0, y, page.Width, 10), XStringFormats.TopCenter);
                y += 15;
                g.DrawString("89 Lê Hồng Phong, Cần Thơ", f8, XBrushes.Black,
                    new XRect(0, y, page.Width, 10), XStringFormats.TopCenter);
                y += 10;
                g.DrawString("ĐT: 0944 649 923", f8, XBrushes.Black,
                    new XRect(0, y, page.Width, 10), XStringFormats.TopCenter);
                y += 20;

                g.DrawString($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}", f9, XBrushes.Black, 15, y);
                y += 12;
                g.DrawString($"Khách hàng: {txtHoTen.Text}", f9, XBrushes.Black, 15, y);
                y += 12;
                g.DrawString($"SĐT: {txtSDT.Text}", f9, XBrushes.Black, 15, y);
                y += 15;

                
                y += 8;

                // ===== BẢNG SẢN PHẨM =====
                g.DrawString("Tên thuốc", f9b, XBrushes.Black, 15, y);
                g.DrawString("SL", f9b, XBrushes.Black, 95, y);
                g.DrawString("Đ.Giá", f9b, XBrushes.Black, 125, y);
                g.DrawString("T.Tiền", f9b, XBrushes.Black, 175, y);
                y += 12;
                g.DrawLine(XPens.Black, 10, y, page.Width - 10, y);
                y += 10;

                foreach (var t in gioHang)
                {
                    g.DrawString(t.TenThuoc, f9, XBrushes.Black, 15, y);
                    g.DrawString(t.SoLuong.ToString(), f9, XBrushes.Black, 95, y);
                    g.DrawString(t.DonGia.ToString("N0"), f9, XBrushes.Black, 125, y);
                    g.DrawString(t.ThanhTien.ToString("N0"), f9, XBrushes.Black, 175, y);
                    y += 14;
                }

                y += 5;
                g.DrawLine(XPens.Black, 10, y, page.Width - 10, y);
                y += 12;

                // ===== TỔNG CỘNG =====
                g.DrawString($"TỔNG CỘNG: {tong:N0} đ", f9b, XBrushes.Black,
                    new XRect(0, y, page.Width - 15, 10), XStringFormats.TopRight);
                y += 20;

                // ===== QR VIETQR =====
                Bitmap qrBmp = GenerateVietQR(tong);
                using (MemoryStream ms = new MemoryStream())
                {
                    qrBmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                    XImage qrImg = XImage.FromStream(() => new MemoryStream(ms.ToArray()));
                    g.DrawImage(qrImg, (page.Width - 130) / 2, y, 130, 130);
                }

                y += 140;
                g.DrawString("Quét mã VietQR để thanh toán", f9, XBrushes.Black,
                    new XRect(0, y, page.Width, 10), XStringFormats.TopCenter);
                y += 25;
                g.DrawString("Cảm ơn quý khách! Hẹn gặp lại!", f9, XBrushes.Black,
                    new XRect(0, y, page.Width, 10), XStringFormats.TopCenter);
                y += 10;
                g.DrawString("Liên hệ tư vấn: 1900 1234", f9, XBrushes.Black,
                    new XRect(0, y, page.Width, 10), XStringFormats.TopCenter);

                pdf.Save(save.FileName);
            }

            System.Diagnostics.Process.Start("explorer.exe", save.FileName);
        }

        private Bitmap GenerateVietQR(decimal amount)
        {
            try
            {
                string accountNumber = "0944649923";
                string accountName = "PHAM HOANG PHUC";
                string bankBin = "970422"; // MBBank BIN

                var qr = QRPay.InitVietQR(bankBin, accountNumber, amount.ToString("0"), "Thanh toán hóa đơn - " + accountName);
                string payload = qr.Build();

                QRCodeGenerator qrGen = new QRCodeGenerator();
                QRCodeData qrData = qrGen.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrData);
                return qrCode.GetGraphic(20);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo VietQR: " + ex.Message);
                return new Bitmap(150, 150);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gioHang.Clear();
            UpdateTongTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                TradeDTO hd = new TradeDTO { MaKH = null }; // chưa chọn khách hàng
                int mahd = TradeBUS.ThanhToan(hd, gioHang.ToList());
                MessageBox.Show("Thanh toán thành công. Mã HĐ: " + mahd);

                gioHang.Clear();
                UpdateTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Trade_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”
            if (dgvGioHang.Columns["MaHD"] != null)
                dgvGioHang.Columns["MaHD"].Visible = false;
            if (dgvGioHang.Columns["MaKH"] != null)
                dgvGioHang.Columns["MaKH"].Visible = false;

            // Giỏ hàng
            dgvGioHang.AutoGenerateColumns = true;
            dgvGioHang.DataSource = gioHang;

            // Thuốc
            dgvThuoc.AutoGenerateColumns = true;
            LoadThuoc();

            // Số lượng mặc định
            try
            {
                nudSoLuong.Minimum = 1;
                if (nudSoLuong.Value < 1) nudSoLuong.Value = 1;
            }
            catch { /* nếu designer đặt khác, bỏ qua */ }


            UpdateTongTien();
        }

        private void LoadThuoc(string keyword = "")
        {
            DataTable dt = string.IsNullOrWhiteSpace(keyword)
                ? ThuocBUS.GetAll()
                : ThuocBUS.Search(keyword);

            dgvThuoc.DataSource = dt;

            // Ẩn cột không cần nếu muốn
            if (dgvThuoc.Columns.Contains("ghichu")) dgvThuoc.Columns["ghichu"].Visible = false;
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
