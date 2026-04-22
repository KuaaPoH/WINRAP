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
- **Nguyên lý:** Sử dụng một biến cờ `AddNew` (để phân biệt đang Thêm hay Sửa) và hàm `setControl(bool isEdit)`.
- **Hoạt động:** Khi bấm "Thêm" hoặc "Sửa", ẩn các nút chính (Thêm, Sửa, Xóa) và hiện nút "Lưu" và "Hủy/Không Lưu". Khóa hoặc mở TextBox tương ứng (`Enabled = isEdit`). Vô hiệu hóa Grid (`Enabled = !isEdit`) để bảo vệ dữ liệu đang nhập và tránh việc người dùng click nhầm dòng khác.

## 7. Tiêu chuẩn Thiết kế Form CRUD (Theo hướng dẫn PDF)

Tất cả các form thao tác dữ liệu cơ bản (Thể loại, Lịch chiếu...) cần tuân thủ cấu trúc sau:

**1. Thiết lập DataGridView (DGV):**
- Trong sự kiện `Form_Load`, luôn gọi `dgv.AutoGenerateColumns = false;` và `dgv.AllowUserToAddRows = false;`.
- Gán dữ liệu nguyên bản từ Entity Framework: `dgv.DataSource = db.Table.ToList();`.

**2. Hiển thị dữ liệu lên TextBox (In-place Edit):**
- Sử dụng sự kiện **`CellEnter`** của DGV.
- Logic: `if (e.RowIndex >= 0) { txtTen.Text = dgv.Rows[e.RowIndex].Cells["TenCot"].Value?.ToString(); }`
- Nhờ sự kiện này, khi người dùng click vào dòng nào, dữ liệu sẽ ngay lập tức được đổ lên các ô nhập liệu bên cạnh/bên dưới.

**3. Lọc và Tìm kiếm (Filter):**
- Không gọi lại DB khi tìm kiếm. Lưu kết quả từ `db.Table.ToList()` vào một `List<object> originalList` toàn cục.
- Trong sự kiện `txtSearch_TextChanged`, thực hiện filter trực tiếp trên `originalList` (ví dụ dùng `Where` và reflection hoặc ép kiểu) sau đó gán lại `DataSource` cho DGV.

**4. Dialog Edit (Dành cho form phức tạp như Khách hàng, Nhân viên):**
- Đối với dữ liệu lớn, thay vì dùng `CellEnter`, ta mở form con dạng Dialog (Pop-up).
- Form con nhận ID thông qua Hàm khởi tạo (Constructor): `public frmEdit(int id) { _id = id; }`.
- Form con tự dùng LINQ `SingleOrDefault` để lấy dữ liệu chi tiết và lưu trực tiếp `SaveChanges()`.

## 8. Cập nhật Real-time & Tối ưu hiệu năng UI

Khi hiển thị sơ đồ ghế động (120-180 ghế), việc nạp lại dữ liệu liên tục có thể gây nháy màn hình.
**Giải pháp:**
- **Timer + Dictionary:** Sử dụng `System.Windows.Forms.Timer` để quét CSDL theo chu kỳ. Lưu danh sách Button vào `Dictionary<string, Guna2Button>` để cập nhật trạng thái trực tiếp mà không cần xóa đi vẽ lại (`Controls.Clear`).
- **DoubleBuffered:** Kích hoạt `this.DoubleBuffered = true` cho Form để giảm thiểu hiện tượng giật lag khi render hàng loạt control.

## 9. Quy tắc cho Visual Studio Designer (InitializeComponent)

Trình phân tích mã (Parser) của Visual Studio Designer rất nhạy cảm với cú pháp.
**Quy tắc bắt buộc:**
- **Khai báo biến:** Mọi Control UI (Label, Panel, Button...) phải được khai báo làm biến thành viên (Class member), không khai báo cục bộ bên trong hàm.
- **Khởi tạo:** Luôn dùng `this.control = new ...()` và thiết lập thuộc tính từng dòng riêng biệt. Tránh sử dụng cú pháp Object Initializer `{ Property = Value }` vì nó dễ gây lỗi `Failed to parse method 'InitializeComponent'`.

---
*Ghi chú: Luôn cập nhật file này khi phát triển xong một logic phức tạp mới.*
