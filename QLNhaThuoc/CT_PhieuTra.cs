using BUS;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLNhaThuoc
{
    public partial class CT_PhieuTra : Form
    {
        private int _maTra;

        public CT_PhieuTra(int maTra)
        {
            InitializeComponent();
            _maTra = maTra;
            KhoaLayout();
        }

        private void KhoaLayout()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CT_PhieuTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = CT_PhieuTraBUS.LayChiTiet(_maTra);
            dgvCTTra.DataSource = dt;

            lblTitle.Text = $"CHI TIẾT PHIẾU TRẢ #{_maTra}";
            lblSoDong.Text = $"Số mặt hàng: {dt.Rows.Count}";

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
            ExportHelper.ExportToExcel(dgvCTTra, $"CT_PhieuTra_{_maTra}");
        }
    }
}
