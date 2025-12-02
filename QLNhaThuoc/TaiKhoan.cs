using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaThuoc
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            // Khóa chỉnh kích thước
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Gán dữ liệu combobox vai trò
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("NhanVien");
            comboBox1.SelectedIndex = 1; // mặc định nhân viên

            LoadData();
        }
        private void LoadData()
        {

            dataGridView1.DataSource = TKBUS.GetAll();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Columns.Contains("id"))
                dataGridView1.Columns["id"].HeaderText = "Mã TK";
            if (dataGridView1.Columns.Contains("tendn"))
                dataGridView1.Columns["tendn"].HeaderText = "Tên đăng nhập";
            if (dataGridView1.Columns.Contains("matkhau"))
                dataGridView1.Columns["matkhau"].HeaderText = "Mật khẩu";
            if (dataGridView1.Columns.Contains("vaitro"))
                dataGridView1.Columns["vaitro"].HeaderText = "Vai trò";
        }

        private void ClearInput()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            TKDTO tk = new TKDTO
            {
                TenDN = textBox1.Text.Trim(),
                MatKhau = textBox2.Text.Trim(),
                VaiTro = comboBox1.Text
            };

            if (TKBUS.Insert(tk))
                MessageBox.Show("Thêm tài khoản thành công!");
            else
                MessageBox.Show("Tên đăng nhập đã tồn tại!");

            LoadData();
            ClearInput();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kw = textBox3.Text.Trim();
            dataGridView1.DataSource = TKBUS.Search(kw);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["tendn"].Value.ToString();
                textBox2.Text = row.Cells["matkhau"].Value.ToString();
                comboBox1.Text = row.Cells["vaitro"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Chọn tài khoản cần xóa!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TKBUS.Delete(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                    MessageBox.Show("Lỗi khi xóa!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!");
                return;
            }

            TKDTO tk = new TKDTO
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value),
                TenDN = textBox1.Text.Trim(),
                MatKhau = textBox2.Text.Trim(),
                VaiTro = comboBox1.Text
            };

            if (TKBUS.Update(tk))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LamMoi()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = 0;
        }
    }
}
