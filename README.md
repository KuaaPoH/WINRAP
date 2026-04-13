# WinRap - Cinema Management System

Ứng dụng quản lý rạp chiếu phim hiện đại được xây dựng bằng công nghệ **C# Windows Forms (.NET Framework 4.7.2)**, sử dụng thư viện **Guna UI2** cho giao diện và **Entity Framework 6** để quản lý cơ sở dữ liệu.

---

### 🚀 Hướng dẫn đóng góp dự án (Dành cho thành viên)

Để bắt đầu làm việc cùng dự án, các bạn vui lòng thực hiện theo các bước sau:

#### 1. Fork & Clone dự án
- Nhấn nút **Fork** ở góc trên bên phải GitHub để tạo bản sao về tài khoản cá nhân.
- Clone bản sao đó về máy cục bộ:
  ```bash
  git clone https://github.com/TÊN_GITHUB_CỦA_BẠN/WINRAP.git
  ```

#### 2. Thiết lập Cơ sở dữ liệu (SQL Server)
Trong thư mục `csdl/`, dự án cung cấp các file cần thiết:
- **Cách 1 (Khuyên dùng):** Sử dụng file `WINRAP.bak`.
    1. Mở **SQL Server Management Studio (SSMS)**.
    2. Chuột phải vào **Databases** -> chọn **Restore Database...**.
    3. Chọn **Device** -> nhấn nút `...` -> chọn đường dẫn tới file `csdl/WINRAP.bak`.
    4. Nhấn **OK** để khôi phục toàn bộ cấu trúc và dữ liệu mẫu.
- **Cách 2:** Chạy script `WinRap.sql` để tạo mới cấu trúc bảng nếu không dùng được file backup.

#### 3. Cấu hình kết nối (ConnectionString)
- Mở file `WinRap/App.config` trong Visual Studio.
- Tìm thẻ `<connectionStrings>` và cập nhật `Data Source` thành tên Server SQL của bạn (ví dụ: `.\SQLEXPRESS` hoặc `TÊN_MÁY_TÍNH`).
  ```xml
  connectionString="data source=TÊN_SERVER_CỦA_BẠN;initial catalog=WINRAP;integrated security=True;..."
  ```

#### 4. Cài đặt thư viện (NuGet)
- Mở tệp `WinRap.sln`.
- Chuột phải vào **Solution 'WinRap'** -> Chọn **Restore NuGet Packages**.
- Các thư viện **Guna.UI2** và **EntityFramework** sẽ tự động được tải về.

#### 5. Quy trình làm việc (Workflow)
- **Tạo nhánh mới:** 
  ```bash
  git checkout -b feature/ten-tinh-nang
  ```
- **Lưu thay đổi:** 
  ```bash
  git add .
  git commit -m "Thêm tính năng X hoặc Sửa lỗi Y"
  ```
- **Push & Pull Request:** Đẩy code lên bản Fork và tạo Pull Request trên GitHub chính để Leader duyệt code.

#### 6. Tài liệu quan trọng
- `RULE.md`: Các quy tắc bắt buộc về đặt tên, màu sắc UI và coding.
- `PROGRESS.md`: Theo dõi tiến độ các tính năng.
- `SKILL.md`: Hướng dẫn các kỹ thuật xử lý lỗi Cross-thread, bảo mật MD5 và sơ đồ ghế.

---
*Dự án được duy trì bởi Leader KuaaPoH và cộng sự.*
