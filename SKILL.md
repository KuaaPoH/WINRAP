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

---
*Ghi chú: Luôn cập nhật file này khi phát triển xong một logic phức tạp mới.*
