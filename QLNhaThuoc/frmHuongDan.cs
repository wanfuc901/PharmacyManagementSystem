using System;
using System.Windows.Forms;

namespace QLNhaThuoc
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();

            // Khóa không cho thay đổi kích thước form
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;               // Ẩn nút phóng to
            this.MinimizeBox = true;                // Cho phép thu nhỏ (nếu không cần thì = false)
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmHuongDan_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox1.BackColor = System.Drawing.Color.White;

            richTextBox1.Text =
@"
================= HƯỚNG DẪN SỬ DỤNG HỆ THỐNG QUẢN LÝ NHÀ THUỐC =================

I. GIỚI THIỆU CHUNG
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


II. MÀN HÌNH ĐĂNG NHẬP
-------------------------------------------------------------------------------
Thành phần giao diện:
• Ô 'Tên đăng nhập'
• Ô 'Mật khẩu'
• Nút 'Đăng nhập'
• Nút 'Thoát' (nếu có)

Cách sử dụng:
1. Nhập đúng tên đăng nhập và mật khẩu được cấp.
2. Nhấn nút 'Đăng nhập':
   - Nếu đúng: chuyển sang màn hình chính.
   - Nếu sai: hệ thống hiển thị thông báo lỗi, nhập lại.
3. Nhấn 'Thoát' để đóng chương trình (nếu không muốn sử dụng).


III. MÀN HÌNH CHÍNH (MENU CHỨC NĂNG)
-------------------------------------------------------------------------------
Thành phần giao diện (tuỳ bố cục của bạn nhưng thường gồm):
• Thanh menu / các nút chức năng:
  - 'Quản lý thuốc'
  - 'Quản lý khách hàng'
  - 'Bán hàng' hoặc 'Hóa đơn'
  - 'Tìm kiếm hóa đơn'
  - 'Báo cáo tổng hợp'
  - 'Đăng xuất' hoặc 'Thoát'

Cách sử dụng:
• Nhấn vào từng nút để mở màn hình tương ứng.
• Nút 'Đăng xuất' dùng để quay lại màn hình đăng nhập.
• Nút 'Thoát' dùng để đóng toàn bộ chương trình.


IV. MÀN HÌNH QUẢN LÝ THUỐC
-------------------------------------------------------------------------------
Thành phần giao diện:
• Bảng danh sách thuốc: hiển thị các cột như:
  - Mã thuốc, Tên thuốc, Đơn vị tính, Giá bán, Số lượng tồn,...
• Ô tìm kiếm (thường ở phía trên) để lọc theo tên thuốc.
• Các nút chức năng thường gặp:
  - Nút 'Thêm'
  - Nút 'Sửa'
  - Nút 'Xóa'
  - Nút 'Lưu'
  - Nút 'Hủy'
  - Nút 'Đóng' / 'Thoát'

Cách sử dụng các nút:
1. Nút 'Thêm':
   - Nhấn 'Thêm' → các ô nhập thông tin bên dưới/d bên cạnh sẽ trống.
   - Nhập: tên thuốc, đơn vị, giá bán, số lượng ban đầu, nhà cung cấp,...
   - Nhấn 'Lưu' để lưu thuốc mới vào danh sách.

2. Nút 'Sửa':
   - Chọn 1 dòng thuốc trong bảng.
   - Nhấn 'Sửa' → thông tin thuốc được đưa vào vùng nhập.
   - Chỉnh sửa nội dung cần thay đổi.
   - Nhấn 'Lưu' để cập nhật.

3. Nút 'Xóa':
   - Chọn 1 dòng thuốc trong bảng.
   - Nhấn 'Xóa' → xác nhận xóa.
   - Thuốc sẽ bị xóa khỏi danh sách (nên cẩn thận khi xóa thuốc đã có hóa đơn).

4. Nút 'Hủy':
   - Dùng để hủy thao tác thêm / sửa đang thực hiện.
   - Dữ liệu sẽ trở về trạng thái ban đầu.

5. Nút 'Đóng' / 'Thoát':
   - Đóng màn hình quản lý thuốc và quay lại màn hình chính.

6. Ô tìm kiếm:
   - Gõ tên (hoặc 1 phần tên) thuốc → danh sách lọc theo nội dung đã gõ.


V. MÀN HÌNH QUẢN LÝ KHÁCH HÀNG
-------------------------------------------------------------------------------
Thành phần giao diện:
• Bảng danh sách khách hàng:
  - Mã KH, Họ tên, Giới tính, Số điện thoại, Địa chỉ,...
• Ô tìm kiếm theo tên hoặc số điện thoại.
• Các nút: 'Thêm', 'Sửa', 'Xóa', 'Lưu', 'Hủy', 'Đóng'.

Cách sử dụng:
1. Thêm khách hàng:
   - Nhấn 'Thêm' → nhập họ tên, số điện thoại, địa chỉ,...
   - Nhấn 'Lưu' để tạo khách hàng mới.

2. Sửa thông tin:
   - Chọn khách hàng trong bảng.
   - Nhấn 'Sửa' → điều chỉnh thông tin.
   - Nhấn 'Lưu' để cập nhật.

3. Xóa khách hàng:
   - Chọn khách hàng.
   - Nhấn 'Xóa' → xác nhận xóa.

4. Tìm kiếm:
   - Nhập tên hoặc số điện thoại vào ô tìm kiếm.
   - Danh sách sẽ tự lọc theo nội dung nhập.

5. Đóng màn hình:
   - Nhấn 'Đóng' để quay về màn hình chính.


VI. MÀN HÌNH BÁN HÀNG / HÓA ĐƠN
-------------------------------------------------------------------------------
Thành phần giao diện thường có:
• Khu vực thông tin khách hàng:
  - Ô nhập số điện thoại hoặc chọn khách hàng
  - Nút 'Thêm khách hàng' (nếu khách mới)
• Khu vực chọn thuốc:
  - Ô chọn thuốc / tìm thuốc
  - Ô nhập số lượng
  - Nút 'Thêm vào hóa đơn'
• Bảng chi tiết hóa đơn:
  - Danh sách các thuốc đã chọn, số lượng, đơn giá, thành tiền
• Khu vực tổng tiền:
  - Tổng tiền hàng
  - Có thể có giảm giá / thuế (tùy bạn thiết kế)
• Nút chức năng:
  - 'Thanh toán'
  - 'Xóa dòng' (xóa 1 thuốc khỏi hóa đơn)
  - 'Làm mới' / 'Hủy hóa đơn'
  - 'Đóng' / 'Thoát'

Quy trình bán hàng:
1. Chọn hoặc nhập khách hàng:
   - Nếu là khách cũ: chọn từ danh sách hoặc tìm theo số điện thoại.
   - Nếu là khách mới: nhấn nút thêm khách hàng (nếu có) và tạo mới.

2. Chọn thuốc:
   - Chọn 1 thuốc từ danh sách hoặc từ ô chọn thuốc.
   - Nhập số lượng cần bán.
   - Nhấn 'Thêm vào hóa đơn' → thuốc xuất hiện trong bảng chi tiết.

3. Kiểm tra danh sách:
   - Có thể chọn 1 dòng và nhấn 'Xóa dòng' nếu thêm nhầm.

4. Thanh toán:
   - Kiểm tra tổng tiền.
   - Nhấn 'Thanh toán':
     • Hóa đơn được lưu.
     • Số lượng tồn kho của các thuốc trong hóa đơn sẽ giảm.
   - In hóa đơn (nếu phần mềm hỗ trợ in).

5. Hủy / làm mới hóa đơn:
   - Nếu nhập sai quá nhiều, nhấn 'Hủy' hoặc 'Làm mới' để xóa hết dữ liệu trên màn hình.


VII. MÀN HÌNH TÌM KIẾM HÓA ĐƠN
-------------------------------------------------------------------------------
Thành phần:
• Ô chọn ngày bắt đầu – ngày kết thúc.
• Có thể có ô chọn nhân viên, chọn khách hàng.
• Nút 'Tìm kiếm'.
• Bảng danh sách hóa đơn thỏa điều kiện.
• Nút xem chi tiết / in hóa đơn (nếu có).

Cách sử dụng:
1. Chọn khoảng thời gian cần tra cứu (ví dụ: từ ngày 01 đến ngày 31).
2. Nếu cần lọc thêm:
   - Chọn nhân viên lập hóa đơn.
   - Chọn khách hàng.
3. Nhấn 'Tìm kiếm'.
4. Danh sách hóa đơn hiện ra:
   - Chọn 1 dòng → nhấn nút xem chi tiết (nếu có).
   - Có thể in hoặc xuất (nếu phần mềm hỗ trợ).


VIII. MÀN HÌNH BÁO CÁO TỔNG HỢP
-------------------------------------------------------------------------------
Thành phần thường gồm nhiều tab hoặc nhiều lựa chọn:
1. Báo cáo doanh thu:
   - Chọn năm / tháng.
   - Bảng liệt kê doanh thu theo thời gian.
   - Có tổng doanh thu phía dưới.
   - Có biểu đồ minh họa.

2. Báo cáo tồn kho:
   - Danh sách thuốc còn tồn, số lượng hiện tại.
   - Có thể có cột cảnh báo tồn thấp.

3. Thuốc bán chạy:
   - Danh sách các thuốc bán nhiều nhất trong khoảng thời gian.

4. Nhập hàng:
   - Thống kê tổng giá trị nhập theo tháng, năm.

5. Khách hàng mua nhiều:
   - Danh sách khách hàng xếp theo tổng số tiền đã mua.

Cách sử dụng:
• Chọn loại báo cáo (doanh thu, tồn kho, thuốc bán chạy,...).
• Chọn điều kiện lọc (năm, tháng, khoảng thời gian).
• Xem bảng kết quả và biểu đồ.


IX. GỢI Ý SỬ DỤNG AN TOÀN
-------------------------------------------------------------------------------
• Nên phân quyền tài khoản rõ ràng: quản trị / nhân viên.
• Hạn chế xóa dữ liệu quan trọng (thuốc, khách hàng, hóa đơn).
• Thường xuyên sao lưu (backup) cơ sở dữ liệu để tránh mất dữ liệu.


===================== KẾT THÚC HƯỚNG DẪN CHO NGƯỜI DÙNG =====================
";
        }
    }
}
