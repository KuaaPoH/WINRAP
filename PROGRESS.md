# Nhật ký Dự án: Quản lý Rạp Chiếu Phim (WinRap)

Dự án xây dựng ứng dụng quản lý rạp chiếu phim bằng **C# Windows Forms (.NET Framework 4.7.2)**, thư viện **Guna UI2** và **SQL Server**.

## 1. Cấu trúc Cơ sở dữ liệu (Database)
- [x] Thiết kế bảng: Phim, Thể loại, Suất chiếu, Phòng, Ghế, Khách hàng, Nhân viên, Vé.
- [x] Tạo script khởi tạo Database (`WinRap.sql`).
- [x] **Cập nhật:** Tạo script dữ liệu mẫu chuẩn (`SampleData.sql`) với hơn 30 bản ghi, hỗ trợ tự động reset ID và làm sạch dữ liệu.

## 2. Tiến độ triển khai

### Giai đoạn 1: Giao diện (UI) - Hoàn thành 100%
- [x] **frmMain:** Menu điều hướng mượt mà (Singleton).
- [x] **frmMovie:** Giao diện quản lý phim tối giản, tích hợp thanh lọc/tìm kiếm.
- [x] **frmCustomer:** Giao diện quản lý khách hàng đồng bộ, tích hợp lọc theo điểm.
- [x] **frmStaff:** Giao diện quản lý nhân viên đồng bộ, tích hợp lọc theo chức vụ.
- [x] **Bộ 3 Form Overlay cho Phim:** `frmMovieNew`, `frmMovieEdit`, `frmMovieDetail`.
- [x] **Bộ đôi Form cho Khách hàng & Nhân viên:** Tách thành `New` và `Edit` riêng biệt, chuẩn hóa layout.
- [x] **frmTheLoai:** Quản lý thể loại phim với cơ chế async/await.
- [x] **frmRoom:** Thiết kế hệ thống Tab giả (Panel switching) hiện đại, tích hợp nút điều hướng cạnh thanh tìm kiếm.
- [x] **frmShowtime:** Lập lịch chiếu phim với cơ chế State Management (Hoàn thành).
### Giai đoạn 2: Kết nối dữ liệu & LINQ - Đang triển khai
- [x] Cấu hình Entity Framework 6 và DataContext.
- [x] Hoàn thiện CRUD cho Khách hàng, Nhân viên, Thể loại và Phim.
    - [x] Sửa lỗi hiển thị dữ liệu `frmStaff`, `frmCustomer` (AutoGenerateColumns, sự kiện Load).
    - [x] Cải tiến `frmTheLoai` theo chuẩn "In-place Edit" với thanh tìm kiếm và hiển thị tổng số.
- [x] **frmShowtime:** Cập nhật ComboBox chỉ hiển thị Phim "Đang chiếu" và Phòng "Sẵn sàng". Hoàn thiện kiểm tra trùng lịch (Overlap) cho suất chiếu.
- [x] **Quản lý Phòng (Hoàn thành):**
    - [x] **frmRoom:** Màn hình Giám sát rạp chuyên nghiệp, hiển thị trạng thái suất chiếu và tỷ lệ lấp đầy ghế real-time.
    - [x] **frmRoomConfig (Mới):** Tách biệt chức năng cấu hình thông tin phòng (Tên, Loại, Trạng thái, Ghi chú) với giao diện nhập liệu thông minh.
    - [x] **frmRoomEdit:** Sơ đồ ghế hoạt động ổn định, tích hợp cập nhật trạng thái đã bán real-time qua Timer và cơ chế click đổi loại ghế (Thường/VIP) đồng bộ trực tiếp với CSDL.
- [ ] **frmTicket:** Lập trình logic Bán vé và Sơ đồ ghế động.
- [ ] **Thống kê:** Lập trình báo cáo doanh thu.

---
*Cập nhật ngày: 16/04/2026*
- [ ] Lập trình in hóa đơn vé.
- [ ] **frmLogin:** Hoàn thiện bảo mật hệ thống.

---
*Cập nhật ngày: 14/04/2026*
