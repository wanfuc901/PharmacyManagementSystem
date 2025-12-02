using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    public partial class TonKho : Form
    {

        public TonKho()
        {
            InitializeComponent();
            txtMaThuoc.ReadOnly = true; // Không cho sửa mã thuốc
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”
            dataGridView1.DataSource = ThuocBUS.GetAll();
        }


        private void txtTenThuoc_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // đảm bảo click không phải tiêu đề
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaThuoc.Text = row.Cells["mathuoc"].Value.ToString();
                txtTenThuoc.Text = row.Cells["tenthuoc"].Value.ToString();
                txtLoaiThuoc.Text = row.Cells["loaithuoc"].Value.ToString();

                // nsx và hansudung là DATE
                if (row.Cells["nsx"].Value != DBNull.Value)
                    dtpNSX.Value = Convert.ToDateTime(row.Cells["nsx"].Value);

                if (row.Cells["hansudung"].Value != DBNull.Value)
                    dtpHSD.Value = Convert.ToDateTime(row.Cells["hansudung"].Value);

                txtGia.Text = row.Cells["gia"].Value.ToString();
                txtSoLuong.Text = row.Cells["soluong"].Value.ToString();
                txtGhiChu.Text = row.Cells["ghichu"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.QuyenNguoiDung != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được thêm hàng!");
                return;
            }
            ThuocDTO thuoc = new ThuocDTO
            {
                TenThuoc = txtTenThuoc.Text,
                LoaiThuoc = txtLoaiThuoc.Text,
                NSX = dtpNSX.Value,
                HanSuDung = dtpHSD.Value,
                Gia = decimal.TryParse(txtGia.Text, out var g) ? g : 0,
                SoLuong = int.TryParse(txtSoLuong.Text, out var sl) ? sl : 0,
                GhiChu = txtGhiChu.Text
            };

            if (ThuocBUS.Insert(thuoc))
                MessageBox.Show("Thêm thuốc thành công!");
            else
                MessageBox.Show("Thêm thất bại!");

            dataGridView1.DataSource = ThuocBUS.GetAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.QuyenNguoiDung != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được xóa hàng!");
                return;
            }
            if (int.TryParse(txtMaThuoc.Text, out int maThuoc))
            {
                if (ThuocBUS.Delete(maThuoc))
                    MessageBox.Show("Xóa thuốc thành công!");
                else
                    MessageBox.Show("Không tìm thấy thuốc!");
            }
            dataGridView1.DataSource = ThuocBUS.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.QuyenNguoiDung != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được sửa hàng!");
                return;
            }
            if (int.TryParse(txtMaThuoc.Text, out int maThuoc))
            {
                ThuocDTO thuoc = new ThuocDTO
                {
                    MaThuoc = maThuoc,
                    TenThuoc = txtTenThuoc.Text,
                    LoaiThuoc = txtLoaiThuoc.Text,
                    NSX = dtpNSX.Value,
                    HanSuDung = dtpHSD.Value,
                    Gia = decimal.TryParse(txtGia.Text, out var g) ? g : 0,
                    SoLuong = int.TryParse(txtSoLuong.Text, out var sl) ? sl : 0,
                    GhiChu = txtGhiChu.Text
                };

                if (ThuocBUS.Update(thuoc))
                    MessageBox.Show("Cập nhật thành công!");
                else
                    MessageBox.Show("Không tìm thấy thuốc!");
            }
            dataGridView1.DataSource = ThuocBUS.GetAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThuocBUS.Search(txtTenThuoc.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

