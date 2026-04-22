# Quy tắc Dự án (Project Rules) - WinRap

Tài liệu này quy định các tiêu chuẩn bắt buộc khi phát triển dự án WinRap để đảm bảo tính đồng bộ và dễ bảo trì.

## 1. Quy tắc đặt tên (Naming Conventions)

### Giao diện (UI)
- **Tên Form:** Bắt đầu bằng tiền tố `frm` (Ví dụ: `frmMain.cs`, `frmMovie.cs`).
- **Control trong DataGridView:** 
    - Thuộc tính `Name` và `DataPropertyName` của Column **BẮT BUỘC** phải trùng khớp hoàn toàn với tên trường trong SQL Server.
- **Form Hành động:** Phân tách rõ rệt giữa `frm...New` (Thêm mới) và `frm...Edit` (Chỉnh sửa).

### Cơ sở dữ liệu (Database)
- **Tên bảng:** Bắt đầu bằng tiền tố `tbl` (Ví dụ: `tblPhim`).
- **Tên trường:** Sử dụng PascalCase (Ví dụ: `MaPhim`, `NgayPhatHanh`).

## 2. Tiêu chuẩn thiết kế giao diện (UI Standards)

- **Thư viện chính:** Guna.UI2. WinForms.
- **Màu sắc chủ đạo:**
    - **Blue (Thêm mới):** `#5E94FF` (94, 148, 255)
    - **Orange (Chỉnh sửa):** `#FF9F43` (255, 159, 67)
    - **Green (Chi tiết/Thành công):** `#00B898`
    - **Gray (Hủy/Đóng):** `#6C757D` (108, 117, 125)
- **Chuẩn hóa Giao diện Danh sách:**
    - Loại bỏ tiêu đề lớn trên cùng, thay bằng thanh tìm kiếm (`txtSearch`) và nhãn tổng số (`lblTotalCount`).
    - Nút chức năng (Thêm, Sửa, Xóa, Lưu, Hủy) đặt ở Panel dưới cùng căn lề phải.
- **Data Binding (Hiển thị dữ liệu):**
    - **BẮT BUỘC** tắt tự động tạo cột: `dgv.AutoGenerateColumns = false;`.
    - Sử dụng `[NotMapped]` trong Class Model (Entity) để tạo các thuộc tính hiển thị (Ví dụ: `TrangThaiDisplay`) thay vì dùng truy vấn `Select` ẩn danh phức tạp trên UI.

## 3. Quy tắc mã nguồn (Coding Rules)

- **Quản lý Form con:** Luôn sử dụng phương thức `container(object _form)` trong `frmMain.cs` (Singleton).
- **Lập trình Bất đồng bộ (Async):** 
    - Các thao tác CSDL **BẮT BUỘC** sử dụng `async/await` và `Task.Run`.
- **An toàn luồng (Cross-thread):**
    - Luôn lấy dữ liệu từ Control UI gán vào biến cục bộ **TRƯỚC** khi vào khối `Task.Run`.
    - Không truy cập Control trực tiếp từ luồng phụ.
- **Quản lý dự án:** Khi thêm/xóa file thủ công, phải cập nhật tham chiếu trong `WinRap.csproj`.
- **Tiền tệ:** Sử dụng định dạng `string.Format("{0:N0} VND", price)` để hiển thị giá vé.

---
*Vui lòng tuân thủ nghiêm ngặt các quy tắc trên.*
