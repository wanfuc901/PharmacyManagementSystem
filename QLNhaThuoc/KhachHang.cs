using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QL_NhaThuoc
{
    public partial class KhachHang : Form
    {


        public KhachHang()
        {
            InitializeComponent();
            txtMaKH.ReadOnly = true;
        }

        private void KhachHang_Load(object sender, EventArgs e)
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
            LoadKhachHang();
        }



        private void LoadKhachHang()
        {

            dataGridView1.DataSource = KhachHangBUS.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KhachHangDTO kh = new KhachHangDTO
            {
                TenKH = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text
            };

            if (KhachHangBUS.Insert(kh))
                MessageBox.Show("Thêm khách hàng thành công!");
            else
                MessageBox.Show("Thêm khách hàng thất bại!");

            LoadKhachHang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.QuyenNguoiDung != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được xóa khách hàng!");
                return;
            }
            if (int.TryParse(txtMaKH.Text, out int maKH))
            {
                if (KhachHangBUS.Delete(maKH))
                    MessageBox.Show("Xóa khách hàng thành công!");
                else
                    MessageBox.Show("Không tìm thấy Mã KH để xóa!");
            }
            LoadKhachHang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.QuyenNguoiDung != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được sửa khách hàng!");
                return;
            }
            if (int.TryParse(txtMaKH.Text, out int maKH))
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    MaKH = maKH,
                    TenKH = txtTenKH.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text
                };

                if (KhachHangBUS.Update(kh))
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                else
                    MessageBox.Show("Không tìm thấy Mã KH để sửa!");
            }
            LoadKhachHang();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO
            {
                MaKH = int.TryParse(txtMaKH.Text, out int maKH) ? maKH : 0,
                TenKH = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text
            };

            dataGridView1.DataSource = KhachHangBUS.Search(kh);
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
