# Kỹ năng & Hướng dẫn Kỹ thuật (WinRap Skills)

Tài liệu này lưu trữ các logic phức tạp và giải pháp kỹ thuật của dự án.

---

## 1. Xử lý lỗi Cross-thread trong Task.Run

Khi sử dụng `Task.Run`, luồng phụ không thể truy cập trực tiếp các Control UI.
**Cách làm đúng:**
```csharp
// 1. Lấy dữ liệu ở luồng chính (UI Thread)
string data = txtInput.Text;
int id = (int)cboData.SelectedValue;

// 2. Xử lý ở luồng phụ
await Task.Run(() => {
    using (var db = new DataContext()) {
        var item = db.Table.Find(id);
        item.Name = data;
        db.SaveChanges();
    }
});
```

## 2. Quản lý dự án .NET Framework (.csproj)

Đối với các dự án .NET Framework, tệp `.csproj` quản lý danh sách file biên dịch. Nếu thêm file thủ công:
- **Tệp .cs:** `<Compile Include="Path\To\File.cs"><SubType>Form</SubType></Compile>`
- **Phụ thuộc:** Tệp `.Designer.cs` phải nằm trong thẻ `<DependentUpon>File.cs</DependentUpon>`.

## 3. Bảo mật mật khẩu

- Sử dụng hàm băm **MD5** để lưu trữ mật khẩu trong bảng `tblNguoiDung`.
- Luôn sử dụng `StringBuilder` để tối ưu hóa hiệu năng khi tạo chuỗi hex từ mảng byte của hash.

## 4. Kỹ thuật Vẽ sơ đồ ghế (frmSeatLayout)

- Dựa vào `SoHang` và `SoCot` của phòng chiếu.
- Sử dụng vòng lặp lồng nhau để tạo các `Guna2Button` động.
- Lưu trạng thái ghế vào thuộc tính `Tag` để xử lý sự kiện Click và tính tiền Real-time.

## 5. Xử lý Suất chiếu xuyên đêm & SqlDbType.Time overflow

Trong SQL Server, kiểu `time` không chấp nhận giá trị >= 24h.
**Giải pháp cho Suất chiếu xuyên đêm:**
- **Lưu trữ:** Nếu `TimeSpan` kết thúc sau 12h đêm (Days > 0), phải chuẩn hóa nó về dưới 24h bằng cách tạo `new TimeSpan(Hours, Minutes, Seconds)`.
- **Kiểm tra trùng lịch:** Chuyển đổi toàn bộ sang `DateTime` để so sánh chính xác: `(StartA < EndB && StartB < EndA)`.

## 6. Quản lý trạng thái Giao diện (State Management)

Để cải thiện trải nghiệm người dùng khi nhập liệu:
- **Nguyên lý:** Sử dụng một biến cờ `isAdding` và hàm `SwitchMode(bool isEditMode)`.
- **Hoạt động:** Khi bấm "Thêm/Sửa", ẩn các nút chính và hiện nút "Lưu/Hủy". Vô hiệu hóa Grid (`Enabled = false`) để bảo vệ dữ liệu đang nhập.

## 7. Cập nhật Real-time & Tối ưu hiệu năng UI

Khi hiển thị sơ đồ ghế động (120-180 ghế), việc nạp lại dữ liệu liên tục có thể gây nháy màn hình.
**Giải pháp:**
- **Timer + Dictionary:** Sử dụng `System.Windows.Forms.Timer` để quét CSDL theo chu kỳ. Lưu danh sách Button vào `Dictionary<string, Guna2Button>` để cập nhật trạng thái trực tiếp mà không cần xóa đi vẽ lại (`Controls.Clear`).
- **DoubleBuffered:** Kích hoạt `this.DoubleBuffered = true` cho Form để giảm thiểu hiện tượng giật lag khi render hàng loạt control.

## 8. Quy tắc cho Visual Studio Designer (InitializeComponent)

Trình phân tích mã (Parser) của Visual Studio Designer rất nhạy cảm với cú pháp.
**Quy tắc bắt buộc:**
- **Khai báo biến:** Mọi Control UI (Label, Panel, Button...) phải được khai báo làm biến thành viên (Class member), không khai báo cục bộ bên trong hàm.
- **Khởi tạo:** Luôn dùng `this.control = new ...()` và thiết lập thuộc tính từng dòng riêng biệt. Tránh sử dụng cú pháp Object Initializer `{ Property = Value }` vì nó dễ gây lỗi `Failed to parse method 'InitializeComponent'`.

---
*Ghi chú: Luôn cập nhật file này khi phát triển xong một logic phức tạp mới.*
