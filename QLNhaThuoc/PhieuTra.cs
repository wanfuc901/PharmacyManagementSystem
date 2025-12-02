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

namespace QLNhaThuoc
{
    public partial class PhieuTra : Form
    {

        public PhieuTra()
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

        private void LoadData()
        {

            dgvPhieuTra.DataSource = PhieuTraBUS.LayDanhSach();
            lblTong.Text = "Tổng: " + dgvPhieuTra.Rows.Count.ToString() + " phiếu";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PhieuTra_Load(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportHelper.ExportToExcel(dgvPhieuTra, "PhieuTra");
        }

        private void btnThem_Click(object sender, EventArgs e)
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

                if (PhieuTraBUS.ThemPhieuTra(mancc, tong))
                {
                    MessageBox.Show("Thêm phiếu trả thành công!");
                    LoadData();
                    txtMaNCC.Clear();
                    txtTongTien.Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm phiếu trả!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (keyword == "")
            {
                LoadData();
                return;
            }

            DataTable dt = PhieuTraBUS.TimTheoNCC(keyword);
            dgvPhieuTra.DataSource = dt;
            lblTong.Text = "Kết quả: " + dt.Rows.Count + " phiếu";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtMaNCC.Clear();
            txtTongTien.Clear();
            LoadData();
        }

        private void dgvPhieuTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPhieuTra.Rows[e.RowIndex];
            txtMaNCC.Text = row.Cells["tenncc"].Value?.ToString() ?? "";
            txtTongTien.Text = row.Cells["tongtien"].Value?.ToString() ?? "";
            dateNgayTra.Value = Convert.ToDateTime(row.Cells["ngaytra"].Value);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (keyword == "")
            {
                LoadData();
                return;
            }

            DataTable dt = PhieuTraBUS.TimTheoNCC(keyword);
            dgvPhieuTra.DataSource = dt;
            lblTong.Text = "Kết quả: " + dt.Rows.Count + " phiếu";
        }
    }
}
