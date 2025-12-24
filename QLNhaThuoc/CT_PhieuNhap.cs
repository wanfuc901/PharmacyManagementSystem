using BUS;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    public partial class CT_PhieuNhap : Form
    {
        private int _maPN;

        public CT_PhieuNhap(int maPN)
        {
            InitializeComponent();
            _maPN = maPN;
            KhoaLayout();
        }

        private void KhoaLayout()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CT_PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = CT_PhieuNhapBUS.LayChiTiet(_maPN);
            dgvCTPN.DataSource = dt;

            lblTitle.Text = $"CHI TIẾT PHIẾU NHẬP #{_maPN}";
            lblTongSoDong.Text = $"Số mặt hàng: {dt.Rows.Count}";

            decimal tongTien = dt.AsEnumerable()
                .Sum(r => r.Field<decimal>("thanhtien"));

            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportHelper.ExportToExcel(dgvCTPN, $"CT_PhieuNhap_{_maPN}");
        }
    }
}
