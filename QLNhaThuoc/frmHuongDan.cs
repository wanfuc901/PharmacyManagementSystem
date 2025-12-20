using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLNhaThuoc
{
    public partial class frmHuongDan : Form
    {
        private readonly Dictionary<string, string> _sections = new();
        private readonly List<int> _matchPositions = new();
        private int _matchIndex = -1;
        private string _lastSearch = "";

        public frmHuongDan()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            richTextBox1.ReadOnly = true;
            richTextBox1.BackColor = Color.White;
        }

        private void frmHuongDan_Load(object sender, EventArgs e)
        {
            BuildSections();
            BuildTree();

            tvMucLuc.ExpandAll();
            if (tvMucLuc.Nodes.Count > 0)
            {
                tvMucLuc.SelectedNode = tvMucLuc.Nodes[0].FirstNode ?? tvMucLuc.Nodes[0];
            }

            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = false;

            splitContainer1.Panel1MinSize = 200;
            splitContainer1.Panel2MinSize = 400;

            // Đảm bảo chạy sau khi layout xong (Width đã đúng)
            BeginInvoke(new Action(() =>
            {
                splitContainer1.SplitterDistance = (int)(splitContainer1.Width * 0.3); // 3/7
            }));
        }

        private void BuildSections()
        {
            _sections.Clear();

            _sections["intro"] =
@"I. GIỚI THIỆU CHUNG
-------------------------------------------------------------------------------
Phần mềm dùng để:
• Quản lý danh sách thuốc trong nhà thuốc
• Quản lý khách hàng
• Bán hàng và lập hóa đơn
• Xem báo cáo doanh thu, tồn kho, thuốc bán chạy, khách hàng mua nhiều,...

Giao diện được chia thành các màn hình chính:
1. Màn hình đăng nhập
2. Màn hình chính (menu chức năng)
3. Màn hình quản lý thuốc
4. Màn hình quản lý khách hàng
5. Màn hình bán hàng / hóa đơn
6. Màn hình tìm kiếm hóa đơn
7. Màn hình báo cáo tổng hợp
";

            _sections["login"] =
@"II. MÀN HÌNH ĐĂNG NHẬP
-------------------------------------------------------------------------------
Thành phần giao diện:
• Ô 'Tên đăng nhập'
• Ô 'Mật khẩu'
• Nút 'Đăng nhập'
• Nút 'Thoát' (nếu có)

Cách sử dụng:
1. Nhập đúng tên đăng nhập và mật khẩu được cấp.
2. Nhấn 'Đăng nhập':
   - Nếu đúng: chuyển sang màn hình chính.
   - Nếu sai: hiển thị thông báo lỗi, nhập lại.
3. Nhấn 'Thoát' để đóng chương trình (nếu không muốn sử dụng).
";

            _sections["mainmenu"] =
@"III. MÀN HÌNH CHÍNH (MENU CHỨC NĂNG)
-------------------------------------------------------------------------------
• Nhấn vào từng menu để mở màn hình tương ứng.
• 'Đăng xuất' dùng để quay lại màn hình đăng nhập.
";

            _sections["thuoc"] =
@"IV. MÀN HÌNH QUẢN LÝ THUỐC
-------------------------------------------------------------------------------
Thành phần:
• Bảng danh sách thuốc: Mã thuốc, Tên thuốc, Đơn vị tính, Giá bán, Số lượng tồn,...
• Ô tìm kiếm để lọc theo tên thuốc.
• Nút: Thêm / Sửa / Xóa / Lưu / Hủy / Đóng.

Quy trình:
- Thêm: Thêm → nhập → Lưu
- Sửa: chọn dòng → Sửa → chỉnh → Lưu
- Xóa: chọn dòng → Xóa → xác nhận
- Tìm kiếm: gõ tên thuốc để lọc
";

            _sections["khachhang"] =
@"V. MÀN HÌNH QUẢN LÝ KHÁCH HÀNG
-------------------------------------------------------------------------------
• Bảng danh sách khách hàng: Mã KH, Họ tên, Giới tính, SĐT, Địa chỉ,...
• Ô tìm kiếm theo tên hoặc SĐT.
• Nút: Thêm / Sửa / Xóa / Lưu / Hủy / Đóng.
";

            _sections["banhang"] =
@"VI. MÀN HÌNH BÁN HÀNG / HÓA ĐƠN
-------------------------------------------------------------------------------
Quy trình bán hàng:
1) Chọn/nhập khách hàng
2) Chọn thuốc + nhập số lượng + thêm vào hóa đơn
3) Kiểm tra chi tiết hóa đơn
4) Thanh toán (lưu hóa đơn, trừ tồn kho)
";

            _sections["timkiemhd"] =
@"VII. MÀN HÌNH TÌM KIẾM HÓA ĐƠN
-------------------------------------------------------------------------------
1) Chọn khoảng thời gian cần tra cứu
2) Chọn điều kiện lọc thêm (nếu có)
3) Nhấn 'Tìm kiếm'
4) Xem danh sách hóa đơn, xem chi tiết/in (nếu có)
";

            _sections["baocao"] =
@"VIII. MÀN HÌNH BÁO CÁO TỔNG HỢP
-------------------------------------------------------------------------------
• Doanh thu
• Tồn kho
• Thuốc bán chạy
• Nhập hàng
• Khách hàng mua nhiều

Chọn loại báo cáo + điều kiện lọc để xem bảng/biểu đồ.
";

            _sections["antoan"] =
@"IX. GỢI Ý SỬ DỤNG AN TOÀN
-------------------------------------------------------------------------------
• Phân quyền tài khoản rõ ràng (quản trị/nhân viên)
• Hạn chế xóa dữ liệu quan trọng
• Sao lưu dữ liệu định kỳ (backup)
";
        }

        private void BuildTree()
        {
            tvMucLuc.BeginUpdate();
            tvMucLuc.Nodes.Clear();

            var root = new TreeNode("HƯỚNG DẪN SỬ DỤNG");

            var n1 = new TreeNode("I. Giới thiệu chung") { Tag = "intro" };
            var n2 = new TreeNode("II. Đăng nhập") { Tag = "login" };
            var n3 = new TreeNode("III. Menu chính") { Tag = "mainmenu" };

            var nhomQuanLy = new TreeNode("IV–V. Quản lý");
            nhomQuanLy.Nodes.Add(new TreeNode("IV. Quản lý thuốc") { Tag = "thuoc" });
            nhomQuanLy.Nodes.Add(new TreeNode("V. Quản lý khách hàng") { Tag = "khachhang" });

            var nhomNghiepVu = new TreeNode("VI–VII. Nghiệp vụ");
            nhomNghiepVu.Nodes.Add(new TreeNode("VI. Bán hàng / Hóa đơn") { Tag = "banhang" });
            nhomNghiepVu.Nodes.Add(new TreeNode("VII. Tìm kiếm hóa đơn") { Tag = "timkiemhd" });

            var nhomBaoCao = new TreeNode("VIII–IX. Báo cáo & An toàn");
            nhomBaoCao.Nodes.Add(new TreeNode("VIII. Báo cáo tổng hợp") { Tag = "baocao" });
            nhomBaoCao.Nodes.Add(new TreeNode("IX. Gợi ý sử dụng an toàn") { Tag = "antoan" });

            root.Nodes.AddRange(new[] { n1, n2, n3, nhomQuanLy, nhomNghiepVu, nhomBaoCao });

            tvMucLuc.Nodes.Add(root);
            tvMucLuc.EndUpdate();
        }

        private void tvMucLuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is not string key) return;
            if (!_sections.TryGetValue(key, out var content)) return;

            richTextBox1.Text = content;
            ResetSearchState();
        }

        // ===== SEARCH =====

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // tìm lại khi thay đổi từ khóa
            DoSearch(resetIndex: true);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GoNext();
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                e.SuppressKeyPress = true;
                txtSearch.Focus();
                txtSearch.SelectAll();
            }
        }

        private void btnNext_Click(object sender, EventArgs e) => GoNext();
        private void btnPrev_Click(object sender, EventArgs e) => GoPrev();

        private void ResetSearchState()
        {
            _matchPositions.Clear();
            _matchIndex = -1;
            _lastSearch = "";
            lblResult.Text = "";
            ClearHighlight();
        }

        private void DoSearch(bool resetIndex)
        {
            var term = (txtSearch.Text ?? "").Trim();
            if (term.Length == 0)
            {
                ResetSearchState();
                return;
            }

            if (!string.Equals(term, _lastSearch, StringComparison.CurrentCultureIgnoreCase))
            {
                _lastSearch = term;
                RebuildMatches(term);
                _matchIndex = resetIndex ? -1 : _matchIndex;
            }
            else if (resetIndex)
            {
                _matchIndex = -1;
            }

            UpdateResultLabel();
            // highlight match hiện tại (nếu có) để nhìn rõ
            if (_matchPositions.Count > 0 && _matchIndex >= 0)
                SelectMatch(_matchIndex);
        }

        private void RebuildMatches(string term)
        {
            _matchPositions.Clear();
            ClearHighlight();

            var text = richTextBox1.Text ?? "";
            int start = 0;

            while (true)
            {
                int idx = text.IndexOf(term, start, StringComparison.CurrentCultureIgnoreCase);
                if (idx < 0) break;

                _matchPositions.Add(idx);
                start = idx + term.Length;
            }

            // highlight tất cả match (nhẹ, vì text không quá dài)
            HighlightAll(term);
        }

        private void HighlightAll(string term)
        {
            if (_matchPositions.Count == 0) return;

            int oldStart = richTextBox1.SelectionStart;
            int oldLen = richTextBox1.SelectionLength;

            for (int i = 0; i < _matchPositions.Count; i++)
            {
                richTextBox1.Select(_matchPositions[i], term.Length);
                richTextBox1.SelectionBackColor = Color.Khaki;
            }

            richTextBox1.Select(oldStart, oldLen);
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
        }

        private void ClearHighlight()
        {
            int oldStart = richTextBox1.SelectionStart;
            int oldLen = richTextBox1.SelectionLength;

            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;

            richTextBox1.Select(oldStart, oldLen);
        }

        private void GoNext()
        {
            DoSearch(resetIndex: false);
            if (_matchPositions.Count == 0) return;

            _matchIndex++;
            if (_matchIndex >= _matchPositions.Count) _matchIndex = 0;

            SelectMatch(_matchIndex);
            UpdateResultLabel();
        }

        private void GoPrev()
        {
            DoSearch(resetIndex: false);
            if (_matchPositions.Count == 0) return;

            _matchIndex--;
            if (_matchIndex < 0) _matchIndex = _matchPositions.Count - 1;

            SelectMatch(_matchIndex);
            UpdateResultLabel();
        }

        private void SelectMatch(int index)
        {
            var term = _lastSearch;
            if (term.Length == 0) return;
            if (index < 0 || index >= _matchPositions.Count) return;

            int pos = _matchPositions[index];
            richTextBox1.Focus();
            richTextBox1.Select(pos, term.Length);
            richTextBox1.ScrollToCaret();
        }

        private void UpdateResultLabel()
        {
            if (_lastSearch.Length == 0)
            {
                lblResult.Text = "";
                return;
            }

            if (_matchPositions.Count == 0)
            {
                lblResult.Text = "0/0";
                return;
            }

            // hiển thị theo kiểu 1/5, 2/5...
            int current = (_matchIndex >= 0 ? _matchIndex + 1 : 0);
            lblResult.Text = $"{current}/{_matchPositions.Count}";
        }
    }
}
