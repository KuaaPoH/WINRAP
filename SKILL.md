# Kỹ năng & Hướng dẫn Kỹ thuật (WinRap Skills)

Tài liệu này lưu trữ các logic phức tạp, giải pháp kỹ thuật và kế hoạch chi tiết cho từng tính năng của WinRap.

---

## 1. Logic Dashboard Phòng chiếu (frmRoom)

### 🎨 Quy trình tạo Card động
Khi đổ dữ liệu từ SQL vào `frmRoom`, sử dụng hàm `AddRoomCard` với các tham số:
- **Tỉ lệ lấp đầy**: `(Vé đã bán * 100) / Tổng số ghế`.
- **Màu sắc ProgressBar**: Nếu `% > 80` -> Màu Đỏ (`#FF5252`), ngược lại -> Màu Xanh dương (`#5E94FF`).

### ⏱️ Tính toán thời gian thực (Real-time)
Sử dụng `System.Windows.Forms.Timer` (Interval: 60000ms) để cập nhật:
- **Còn ... phút**: `GioKetThuc - GioHienTai`. (Màu Đỏ)
- **Bắt đầu sau ... phút**: `GioBatDau - GioHienTai`. (Màu Vàng)
- **Đã hết phim**: Khi `GioHienTai > GioKetThuc`. (Màu Xanh lục)

---

## 2. Kế hoạch thiết kế Lập lịch chiếu (frmShowtime)

### 🧩 Thành phần giao diện (UI)
- **Trái (300px)**: Panel nhập liệu (Chọn Phim, Chọn Phòng, Chọn Giờ, Nhập giá vé).
- **Phải (Fill)**: DataGridView hiển thị danh sách suất chiếu trong ngày.
- **Top**: Bộ lọc nhanh theo Ngày và theo Phòng.

### 🛡️ Ràng buộc nghiệp vụ (Validation) - CỰC KỲ QUAN TRỌNG
Khi thêm suất chiếu mới, phải kiểm tra các điều kiện sau:
1. **Trùng phòng**: Một phòng không thể chiếu 2 phim cùng lúc.
2. **Thời gian nghỉ**: Suất chiếu mới phải bắt đầu sau `Suất trước đó + Thời lượng phim + ThoiGianDonDep`.
3. **Trạng thái phòng**: Chỉ cho phép lập lịch trên các phòng có trạng thái là `N'Sẵn sàng'`.

---

## 3. Kỹ thuật Vẽ sơ đồ ghế (frmSeatLayout)

### 📐 Thuật toán vẽ lưới ghế tự động
Dựa vào `SoHang` và `SoCot` của phòng:
- Sử dụng vòng lặp lồng nhau (Nested Loop) để tạo các `Guna2Button` đại diện cho ghế.
- **Tên ghế**: `(char)(65 + i)` (để ra A, B, C...) + `j` (số thứ tự).
- **Loại ghế**: Kiểm tra bảng `tblGhe` để đổi màu (Ghế VIP: Tím, Ghế thường: Xám, Ghế đã bán: Đỏ).

---

## 4. Truy vấn SQL tổng hợp (Dashboard Query)

Câu lệnh SQL cần dùng để đổ dữ liệu vào Card `frmRoom`:
```sql
SELECT 
    p.MaPhong, p.TenPhong, p.LoaiPhong, p.TongSoGhe, p.TrangThai,
    s.MaSuatChieu, s.GioBatDau, s.GioKetThuc,
    f.TenPhim,
    (SELECT COUNT(*) FROM tblVe v WHERE v.MaSuatChieu = s.MaSuatChieu) as VeDaBan
FROM tblPhongChieu p
LEFT JOIN tblSuatChieu s ON p.MaPhong = s.MaPhong 
    AND CAST(GETDATE() AS DATE) = s.NgayChieu
    AND CAST(GETDATE() AS TIME) BETWEEN s.GioBatDau AND s.GioKetThuc
LEFT JOIN tblPhim f ON s.MaPhim = f.MaPhim
```

## 3. Logic Điều hướng & Bán vé đa bước

### 🔄 Cơ chế Chuyển Form (Singleton Pattern)
- **Vấn đề:** Các Form con (như `frmTicket`) không thể trực tiếp thay đổi nội dung của `pnlMain` trong `frmMain`.
- **Giải pháp:** Sử dụng một Static Instance trong `frmMain`.
- **Cách dùng:**
  ```csharp
  // Từ frmTicket muốn chuyển sang frmSeatLayout
  frmMain.Instance.container(new frmSeatLayout(rows, cols, name));
  ```

### 🎫 Logic Sơ đồ ghế & Tính tiền (frmSeatLayout)
- **Vẽ ghế động:** Sử dụng vòng lặp lồng nhau (Hàng/Cột), tạo `Guna2Button` và tính toán `Location` để căn giữa Panel.
- **Phân loại ghế (Tag):** 
    - Lưu loại ghế vào thuộc tính `Tag` (`VIP`, `NORMAL`, `SOLD`).
    - Thay đổi `FillColor` khi click để biểu diễn trạng thái "Đang chọn".
- **Tính tiền real-time:**
    - Biến `totalPrice` và `selectedCount` cập nhật ngay trong sự kiện `Click` của ghế.
    - Ghế VIP = Giá gốc + 20,000 VND.
    - Ghế thường = Giá gốc.
    - Hiển thị kết quả ra `lblTotalPrice` theo định dạng tiền tệ Việt Nam.

## 4. Entity Framework & LINQ Foundation

### 🔧 Thiết lập ban đầu
- **Mapping:** Sử dụng các thuộc tính `[Table("tblPhim")]` và `[Key]` để ánh xạ chính xác lớp C# với bảng SQL.
- **Navigation Properties:** Sử dụng từ khóa `virtual` cho các tập hợp (ví dụ: `public virtual ICollection<tblSuatChieu> SuatChieus { get; set; }`) để hỗ trợ **Lazy Loading**.
- **DataContext:** Khởi tạo thông qua `DbSet` để quản lý các thực thể.

## 5. Logic Thẻ Phim (Movie Poster Cards - frmTicket)

### 🎨 Quy trình hiển thị
1. **Lọc phim:** Khi thay đổi ngày ở `dtpDate`, thực hiện truy vấn LINQ: `db.tblSuatChieus.Where(sc => sc.NgayChieu == date).Select(sc => sc.tblPhim).Distinct()`.
2. **Tạo Card động:** Duyệt qua danh sách phim, khởi tạo `Guna2GradientPanel` cho mỗi phim.
    - **Shadow:** Bật `ShadowDecoration` (Depth=5) để tạo chiều sâu.
    - **Hover:** Thay đổi `FillColor` khi di chuột để tăng tính tương tác.
3. **Sự kiện Click:** 
    - Lưu `movieId` vào biến `selectedMovieId`.
    - Đổi màu viền (`BorderThickness=2`) cho thẻ được chọn.
    - Tự động load danh sách suất chiếu vào `cboShowtime` dựa trên Phim và Ngày.

## 6. Lập trình Bất đồng bộ (Asynchronous Programming)

### 🚀 Khắc phục treo giao diện (UI Freeze)
- **Truy vấn DB:** Sử dụng `await Task.Run(() => db.Table.ToList())` để đẩy việc xử lý nặng xuống luồng phụ.
- **Xử lý hình ảnh:** Khi hiển thị ảnh trong Grid, sử dụng bản sao `Bitmap` để tránh khóa file:
  ```csharp
  using (var temp = Image.FromFile(path)) {
      pictureBox.Image = new Bitmap(temp);
  }
  ```

## 7. Mô hình Truyền dữ liệu (List -> Dialog)

### 🔄 Quy trình Thêm/Sửa
1. **Khởi tạo:** Form `frm...Action` nhận đối tượng cần sửa (hoặc null nếu thêm mới) qua Constructor hoặc Property.
2. **Xác nhận:** Sử dụng `if (frm.ShowDialog() == DialogResult.OK)` ở Form danh sách để biết khi nào cần `LoadDataAsync()` lại.
3. **Phân tách trách nhiệm:** Form List quản lý Grid và lọc dữ liệu; Form Action quản lý logic Validate và Lưu vào DB.

---
*Ghi chú: Luôn cập nhật file này khi phát triển xong một logic phức tạp mới.*
