# Nhật ký Dự án: Quản lý Rạp Chiếu Phim (WinRap)

Dự án xây dựng ứng dụng quản lý rạp chiếu phim bằng **C# Windows Forms (.NET Framework 4.7.2)**, thư viện **Guna UI2** và **SQL Server**.

## 1. Cấu trúc Cơ sở dữ liệu (Database)
- [x] Thiết kế bảng: Phim, Thể loại, Suất chiếu, Phòng, Ghế, Khách hàng, Nhân viên, Vé.
- [x] Tạo script khởi tạo Database (`WinRap.sql`).
- [x] **Cập nhật:** Tạo script dữ liệu mẫu chuẩn (`SampleData.sql`) với hơn 30 bản ghi, hỗ trợ tự động reset ID và làm sạch dữ liệu.

## 2. Tiến độ triển khai

### Giai đoạn 1: Giao diện (UI) - Hoàn thành 90%
- [x] **frmMain:** Menu điều hướng mượt mà (Singleton).
- [x] **frmMovie:** Giao diện quản lý phim tối giản, không Header, tích hợp thanh lọc/tìm kiếm.
- [x] **frmCustomer:** Giao diện quản lý khách hàng đồng bộ, tích hợp lọc theo điểm.
- [x] **frmStaff:** Giao diện quản lý nhân viên đồng bộ, tích hợp lọc theo chức vụ.
- [x] **Bộ 3 Form Overlay cho Phim:** 
    - `frmMovieNew`: Thêm phim (Xanh dương).
    - `frmMovieEdit`: Sửa phim (Vàng cam).
    - `frmMovieDetail`: Xem chi tiết (Xanh ngọc).
- [ ] Hoàn thiện giao diện cho Thể loại và Suất chiếu.

### Giai đoạn 2: Kết nối dữ liệu & LINQ - Hoàn thành 70%
- [x] Cấu hình Entity Framework 6 và DataContext.
- [x] Lập trình LINQ cho Tìm kiếm và Lọc dữ liệu Real-time trên Grid.
- [x] Xử lý lưu dữ liệu và hình ảnh Poster cho Phim.
- [ ] Hoàn thiện các chức năng nghiệp vụ nâng cao (Bán vé, In hóa đơn).

### Giai đoạn 3: Nghiệp vụ & Bảo mật
- [ ] Lập trình logic bán vé và in hóa đơn.
- [ ] **frmLogin:** Hoàn thiện bảo mật hệ thống.

---
*Cập nhật lần cuối: 10/04/2026 bởi Gemini CLI*
