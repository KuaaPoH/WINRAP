# Quy tắc Dự án (Project Rules) - WinRap

Tài liệu này quy định các tiêu chuẩn bắt buộc khi phát triển dự án WinRap để đảm bảo tính đồng bộ và dễ bảo trì.

## 1. Quy tắc đặt tên (Naming Conventions)

### Giao diện (UI)
- **Tên Form:** Bắt đầu bằng tiền tố `frm` (Ví dụ: `frmMain.cs`, `frmMovie.cs`).
- **Control trong DataGridView:** 
    - Thuộc tính `Name` và `DataPropertyName` của Column **BẮT BUỘC** phải trùng khớp hoàn toàn với tên trường trong SQL Server (Ví dụ: `MaPhim`, `TenPhim`).
- **Dashboard (Card-based):** Sử dụng `FlowLayoutPanel` để tự động sắp xếp các thẻ thông tin.

### Cơ sở dữ liệu (Database)
- **Tên bảng:** Bắt đầu bằng tiền tố `tbl` (Ví dụ: `tblPhim`, `tblPhongChieu`).
- **Tên trường:** Sử dụng PascalCase (Ví dụ: `MaPhim`, `NgayPhatHanh`).
- **Ràng buộc:** Các trường `TrangThai` nên sử dụng `nvarchar(50)` thay vì `bit` để lưu các chuỗi có nghĩa như (Sẵn sàng, Bảo trì, Đang dọn dẹp).

## 2. Tiêu chuẩn thiết kế giao diện (UI Standards)

- **Thư viện chính:** Guna.UI2. WinForms.
- **Phong cách:** Modern Light (Sạch sẽ, phẳng).
- **Màu sắc chủ đạo:**
    - **Blue (Primary):** `#5E94FF` (94, 148, 255) - Sử dụng cho các thao tác chính, Progress Bar mặc định.
    - **Green (Success):** `#00B898` - Trạng thái: Sẵn sàng, Đã hết phim.
    - **Orange (Warning):** `#FF9F43` - Trạng thái: Sắp bắt đầu, Đang chuẩn bị.
    - **Red (Danger):** `#FF5252` - Trạng thái: Bảo trì, Đang trong suất chiếu (Gần hết), Hết vé.
    - **Background:** `#F2F5FA`
- **Kích thước chuẩn:**
    - Form chính: `1200x800`.
    - Sidebar: Rộng `250px`.
    - Form con (MDI Child): `950x718` (Chuẩn khớp với vùng chứa pnlMain).
    - Dashboard Card: `270x230`.

## 3. Quy tắc mã nguồn (Coding Rules)

- **Quản lý Form con:** 
    - Luôn sử dụng phương thức `container(object _form)` trong `frmMain.cs` để load Form.
    - Truy cập qua `frmMain.Instance.container(new frmCon())` từ bất kỳ đâu.
- **Cấu trúc Form con:** Sử dụng layout 3 lớp: `pnlHeader` (Top), `pnlActions` (Bottom), và `pnlContent` (Fill) để đảm bảo không bị tràn giao diện.
- **Cập nhật Real-time:** Sử dụng `System.Windows.Forms.Timer` để cập nhật các thành phần Dashboard mà không cần tải lại toàn bộ Form.
- **Dữ liệu:** 
    - Luôn viết hàm `LoadDummyData()` khi thiết kế UI mới để kiểm tra giao diện trước khi kết nối DB thật.
    - Hình ảnh: Lưu đường dẫn/tên file vào CSDL, không lưu binary trực tiếp.
### Cấu trúc dự án (Architecture)
- **ViewLINQ:** Chứa toàn bộ các Windows Forms. Namespace: `WinRap.ViewLINQ`.
- **Model:** Chứa các lớp thực thể Entity Framework và DataContext. Namespace: `WinRap.Model`.

### Tiêu chuẩn thiết kế Form (UI Pattern)
- **Mô hình List & Action:**
    - **Form Danh sách (List):** Chứa DataGridView chiếm toàn bộ không gian (`Dock=Fill`) và các nút chức năng (Thêm, Sửa, Xóa, Làm mới).
    - **Form Hành động (Action):** Đặt tên dạng `frm...Action`, hiển thị dưới dạng `Dialog` (`CenterParent`) dùng để nhập liệu chi tiết.
- **Lập trình Bất đồng bộ (Async):** 
    - Các thao tác truy vấn CSDL hoặc xử lý file (hình ảnh) **BẮT BUỘC** sử dụng `async/await` và `Task.Run` để tránh treo luồng UI.

### Cơ sở dữ liệu & Entity Framework
- **Tên lớp Model:** Bắt đầu bằng tiền tố `tbl` để khớp với tên bảng (Ví dụ: `tblPhim`, `tblSuatChieu`).
- **DataContext:** Sử dụng chuỗi kết nối `MyConnectionString` trong `App.config`.
- **Truy vấn:** Ưu tiên sử dụng cú pháp LINQ (`db.Table.Where(...).ToList()`) thay cho SQL thuần.
- **Tiền tệ:** Sử dụng định dạng `string.Format("{0:N0} VND", price)` để hiển thị giá vé.
---
*Vui lòng tuân thủ nghiêm ngặt các quy tắc trên.*
