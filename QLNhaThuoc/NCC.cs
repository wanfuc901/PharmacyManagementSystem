using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QL_NhaThuoc
{
    public partial class NCC: Form
    {
        public NCC()
        {
            InitializeComponent();
            txtMaNCC.ReadOnly = true; // vì mancc là IDENTITY
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NCCDTO ncc = new NCCDTO
            {
                TenNCC = txtTenNCC.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };

            if (NCCBUS.Insert(ncc))
                MessageBox.Show("Thêm nhà cung cấp thành công!");
            else
                MessageBox.Show("Thêm thất bại!");

            LoadNCC();
        }

        private void LoadNCC()
        {
            dataGridView1.DataSource = NCCBUS.GetAll();
        }

        private void NCC_Load(object sender, EventArgs e)
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
            LoadNCC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaNCC.Text, out int maNCC))
            {
                if (NCCBUS.Delete(maNCC))
                    MessageBox.Show("Xóa nhà cung cấp thành công!");
                else
                    MessageBox.Show("Không tìm thấy nhà cung cấp để xóa!");
            }
            LoadNCC();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaNCC.Text, out int maNCC))
            {
                NCCDTO ncc = new NCCDTO
                {
                    MaNCC = maNCC,
                    TenNCC = txtTenNCC.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text
                };

                if (NCCBUS.Update(ncc))
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                else
                    MessageBox.Show("Không tìm thấy nhà cung cấp để sửa!");
            }
            LoadNCC();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NCCDTO ncc = new NCCDTO
            {
                MaNCC = int.TryParse(txtMaNCC.Text, out int ma) ? ma : 0,
                TenNCC = txtTenNCC.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };

            dataGridView1.DataSource = NCCBUS.Search(ncc);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["mancc"].Value.ToString();
                txtTenNCC.Text = row.Cells["tenncc"].Value.ToString();
                txtSDT.Text = row.Cells["sdt"].Value.ToString();
                txtDiaChi.Text = row.Cells["diachi"].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadNCC();
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
    }
}
