using System;
using System.Data;
using System.Windows.Forms;
using BUS;
namespace QL_NhaThuoc
{
    public partial class ChiTietHoaDon : Form
    {
       
        private int mahd; // giữ mã hóa đơn được truyền vào
        public ChiTietHoaDon()
        {
            InitializeComponent();
            this.mahd = mahd;
        }
        // Constructor nhận tham số
        public ChiTietHoaDon(int mahd)
        {
            InitializeComponent();
            this.mahd = mahd; // gán vào biến để sử dụng
        }
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadChiTiet();
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // hoặc FixedDialog/Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = false;           // tùy chọn
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // chặn “kéo giãn”

        }
        private void LoadChiTiet()
        {
            dataGridView1.DataSource = ChiTietHoaDonBUS.GetByHoaDon(mahd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
