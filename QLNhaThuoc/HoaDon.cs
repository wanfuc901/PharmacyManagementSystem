using System;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QL_NhaThuoc
{
    public partial class HoaDon : Form
    {

        public HoaDon()
        {
            InitializeComponent();
            txtMaHD.ReadOnly = true; // Không cho sửa Mã hóa đơn
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”
            LoadHoaDon();
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            CultureInfo ci = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO
            {
                NgayLap = dtpNgayLap.Value,
                MaKH = int.Parse(txtMaKH.Text),
                TongTien = decimal.Parse(txtTongTien.Text)
            };

            if (HoaDonBUS.Insert(hd))
                MessageBox.Show("Thêm hóa đơn thành công!");
            else
                MessageBox.Show("Thêm hóa đơn thất bại!");

            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            dataGridView1.DataSource = HoaDonBUS.GetAll();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.QuyenNguoiDung != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được xóa hóa đơn!");
                return;
            }
            if (int.TryParse(txtMaHD.Text, out int maHD))
            {
                if (HoaDonBUS.Delete(maHD))
                    MessageBox.Show("Xóa hóa đơn thành công!");
                else
                    MessageBox.Show("Không tìm thấy Mã HĐ để xóa!");
            }
            LoadHoaDon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.QuyenNguoiDung != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được sửa hóa đơn!");
                return;
            }
            if (int.TryParse(txtMaHD.Text, out int maHD))
            {
                HoaDonDTO hd = new HoaDonDTO
                {
                    MaHD = maHD,
                    NgayLap = dtpNgayLap.Value,
                    MaKH = int.Parse(txtMaKH.Text),
                    TongTien = decimal.Parse(txtTongTien.Text)
                };

                if (HoaDonBUS.Update(hd))
                    MessageBox.Show("Cập nhật hóa đơn thành công!");
                else
                    MessageBox.Show("Không tìm thấy Mã HĐ để sửa!");
            }
            LoadHoaDon();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            HoaDonDTO hd = new HoaDonDTO
            {
                MaHD = int.TryParse(txtMaHD.Text, out int mahd) ? mahd : 0,
                MaKH = int.TryParse(txtMaKH.Text, out int makh) ? makh : 0,
                TongTien = decimal.TryParse(txtTongTien.Text, out decimal tien) ? tien : 0
            };

            dataGridView1.DataSource = HoaDonBUS.Search(hd);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            txtMaHD.Clear();
            dtpNgayLap.Value = DateTime.Now;
            txtMaKH.Clear();
            txtTongTien.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước!");
                return;
            }

            int mahd = int.Parse(txtMaHD.Text);
            ChiTietHoaDon frm = new ChiTietHoaDon(mahd);
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
