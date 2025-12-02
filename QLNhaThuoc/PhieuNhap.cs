using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
            KhoaLayout();
            LoadData();

        }

        private void KhoaLayout()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.SizeGripStyle = SizeGripStyle.Hide;
        }

        // ====================== LOAD DỮ LIỆU ======================
        private void LoadData()
        {
            dgvPhieuNhap.DataSource = PhieuNhapBUS.LayDanhSach();
            lblTong.Text = "Tổng: " + dgvPhieuNhap.Rows.Count.ToString() + " phiếu";
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtTongTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                int mancc = Convert.ToInt32(txtMaNCC.Text);
                decimal tong = Convert.ToDecimal(txtTongTien.Text);

                if (PhieuNhapBUS.ThemPhieuNhap(mancc, tong))
                {
                    MessageBox.Show("Thêm phiếu nhập thành công!");
                    LoadData();
                    txtMaNCC.Clear();
                    txtTongTien.Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm phiếu nhập!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (keyword == "")
            {
                LoadData();
                return;
            }

            DataTable dt = PhieuNhapBUS.TimTheoNCC(keyword);
            dgvPhieuNhap.DataSource = dt;
            lblTong.Text = "Kết quả: " + dt.Rows.Count + " phiếu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (keyword == "")
            {
                LoadData();
                return;
            }

            DataTable dt = PhieuNhapBUS.TimTheoNCC(keyword);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu nào phù hợp!");
                return;
            }

            dgvPhieuNhap.DataSource = dt;
            lblTong.Text = "Kết quả: " + dt.Rows.Count + " phiếu";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtMaNCC.Clear();
            txtTongTien.Clear();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportHelper.ExportToExcel(dgvPhieuNhap, "PhieuNhap");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng in phiếu sẽ được tích hợp với RDLC / PDF sau.");
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // bỏ header

            DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];

            txtMaNCC.Text = row.Cells["tenncc"].Value?.ToString() ?? "";
            txtTongTien.Text = row.Cells["tongtien"].Value?.ToString() ?? "";
            dateTimePicker1.Text = Convert.ToDateTime(row.Cells["ngaynhap"].Value).ToString("yyyy-MM-dd");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
