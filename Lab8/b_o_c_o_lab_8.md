# LAB8 – QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT

| | |
|---|---|
| **Họ và tên** | [Điền họ tên của bạn] |
| **MSSV** | [Điền MSSV của bạn] |
| **Lớp** | [Điền Lớp của bạn] |
| **Môn** | Thực hành Phân tích thiết kế hướng đối tượng |
| **Tên bài Lab** | Quản lý cửa hàng nước (Bài 8) |

---

## 1. Môi trường / phiên bản

| Thành phần | Phiên bản |
|---|---|
| Hệ điều hành | Windows 11 |
| IDE | Visual Studio 2022 |
| Nền tảng | .NET Framework 4.7.2, C# (Windows Forms), ADO.NET |
| CSDL | Microsoft SQL Server 2016 trở lên (Express hoặc LocalDB) |
| Công cụ quản trị CSDL | SQL Server Management Studio (SSMS) |

Kiến trúc 3 lớp tách biệt: **Forms (giao diện) → Services (nghiệp vụ) → Data (truy cập dữ liệu)**. Form không viết SQL trực tiếp; các nghiệp vụ nhiều bảng dùng transaction trong Service.

---

## 2. Nội dung đã thực hiện

### 2.1. Phân tích thiết kế hệ thống
- Phân tích yêu cầu bài toán, xác định các hoạt động nghiệp vụ: Quản lý danh mục, Đặt hàng, Nhận hàng, Bán hàng, Giao hàng, Ghi nợ và Thống kê.
- Xây dựng sơ đồ UML: Use Case (tổng quát, phân rã), Class Diagram, Statechart Diagram, Sequence Diagram cho các chức năng nghiệp vụ, Activity Diagram.
- Thiết kế sơ đồ ERD cho cơ sở dữ liệu.
- Thiết kế giao diện cho các Form theo kiến trúc hệ thống.

### 2.2. Cơ sở dữ liệu
- Thiết kế và tạo 14 bảng trong CSDL: `LoaiNGK`, `NhaCungCap`, `NuocGiaiKhat`, `DonDatHang`, `ChiTietDonDatHang`, `PhieuGiaoHang`, `ChiTietPhieuGiao`, `KhachHang`, `NhanVien`, `HoaDon`, `ChiTietHoaDon`, `PhieuHen`, `ChiTietPhieuHen`, `PhieuGhiNo`.
- Cài đặt các ràng buộc (Constraints) đảm bảo toàn vẹn dữ liệu:
  - Khóa chính, khóa ngoại đầy đủ.
  - Số lượng đặt, giao, mua phải > 0.
  - Mỗi đơn đặt hàng được giao tối đa 3 đợt.
  - Ngày nhận dự kiến >= Ngày đặt hàng.
  - Các ràng buộc về logic nghiệp vụ: chỉ lập phiếu hẹn khi tồn kho không đủ, phiếu ghi nợ chỉ dành cho khách quen.
- Khóa ngoại dùng `ON DELETE NO ACTION` để chặn xóa dữ liệu đã phát sinh nghiệp vụ.

### 2.3. Chương trình (thư mục `QuanLyCuaHangNuoc`)

| Màn hình | Chức năng |
|---|---|
| **Trang chủ** | Điều hướng đến các chức năng chính |
| **Danh mục** | Thêm, sửa, xóa, tra cứu thông tin Loại NGK, NGK, Nhà cung ứng, Nhân viên, Khách hàng |
| **Nhập hàng** | Lập đơn đặt hàng, gửi nhà cung ứng, theo dõi và lập phiếu giao hàng theo đợt |
| **Bán hàng** | Kiểm tra tồn kho, lập hóa đơn, lập phiếu hẹn cho khách quen nếu thiếu hàng |
| **Giao hàng** | Cập nhật số lượng giao theo phiếu hẹn cho khách quen |
| **Công nợ** | Lập phiếu ghi nợ cho khách quen trả chậm |
| **Thống kê** | Tra cứu, tổng hợp dữ liệu |

### 2.4. Yêu cầu chức năng chung đã đáp ứng
Kiểm tra dữ liệu đầu vào · Sử dụng transaction cho các nghiệp vụ phức tạp (lập đơn hàng, lập phiếu giao, hóa đơn, phiếu hẹn, phiếu ghi nợ) · Thông báo lỗi rõ ràng và quản lý trạng thái các đối tượng · Sử dụng DataGridView và ComboBox hỗ trợ thao tác · Liên kết dữ liệu nhất quán.

---

## 3. Kết quả

Các kịch bản nghiệp vụ chính và kết quả mong đợi:

| # | Thao tác | Kết quả mong đợi |
|---|---|---|
| 1 | Thêm mặt hàng NGK mới (đủ thông tin hợp lệ) | Thành công; mặt hàng được liên kết đúng nhãn hiệu và nhà cung ứng |
| 2 | Lập đơn đặt hàng hợp lệ (ngày nhận >= ngày đặt, số lượng > 0) | Thành công; tạo đơn và lưu chi tiết |
| 3 | Lập đơn đặt hàng không hợp lệ (số lượng = 0 hoặc ngày nhận < ngày đặt) | Từ chối lập đơn |
| 4 | Ghi nhận đợt giao thứ nhất cho đơn đặt hàng | Lưu phiếu giao, số lượng và số tiền |
| 5 | Ghi nhận đợt giao thứ tư cho một đơn đặt hàng | Từ chối (tối đa 3 đợt giao) |
| 6 | Lập hóa đơn và giao hàng khi tồn kho đủ | Tạo hóa đơn, ghi chi tiết và xác nhận giao hàng |
| 7 | Lập hóa đơn và phiếu hẹn khi tồn kho thiếu (khách quen) | Lưu hóa đơn và phiếu hẹn phần còn thiếu |
| 8 | Lập phiếu ghi nợ cho khách quen (đủ thông tin) | Lưu phiếu ghi nợ |
| 9 | Lập phiếu ghi nợ cho khách vãng lai | Từ chối (chỉ áp dụng cho khách quen) |
| 10 | Xóa mặt hàng hoặc nhà cung ứng đã có dữ liệu liên quan | Từ chối xóa |

---

## 4. Lỗi thường gặp và cách khắc phục

| Lỗi | Nguyên nhân | Cách khắc phục |
|---|---|---|
| Mở form báo **"Không thực hiện được thao tác … cannot open database / server was not found"** | Chưa chạy script SQL, hoặc chuỗi kết nối trong `App.config` mặc định `.\SQLEXPRESS` không khớp máy | Chạy script SQL; sửa `Data Source` trong `App.config` |
| Lập phiếu hẹn báo **"Khách vãng lai không được hẹn giao"** | Cố gắng lập phiếu hẹn khi khách mua là khách vãng lai | Chọn đúng khách hàng là khách quen hoặc từ chối đơn hàng |
| Lập phiếu ghi nợ báo **"Chỉ áp dụng cho khách quen"** | Chọn khách hàng vãng lai để ghi nợ | Chọn khách hàng là khách quen |
| Nhận đợt giao hàng báo **"Vượt quá số đợt giao (tối đa 3)"** | Đơn đặt hàng đã hoàn tất 3 đợt giao trước đó | Chọn đơn đặt hàng khác hoặc kiểm tra lại thông tin đợt giao |
| Báo **"Dữ liệu bị trùng"** | Mã số (mặt hàng, nhà cung cấp, số đơn...) đã tồn tại | Nhập mã khác |

---

## 5. Hướng dẫn chạy

### Restore file backup đã gửi

File backup: **`QuanLyCuaHangNuocBak.bak`** (kèm trong bài nộp).

**Bằng giao diện SSMS**
1. Kết nối SQL Server → chuột phải **Databases** → **Restore Database…**
2. Chọn **Device** → `…` → **Add** → chọn file `QuanLyCuaHangNuocBak.bak` → OK.

**Chạy chương trình**
1. Mở file `.sln` bằng Visual Studio 2022.
2. Kiểm tra `Data Source` trong `App.config` (mặc định `.\SQLEXPRESS`; LocalDB: `(localdb)\MSSQLLocalDB`). Xác thực Windows (`Integrated Security=True`).
3. Nhấn **F5** (Start). Từ Trang chủ, chọn các chức năng để kiểm tra các luồng nghiệp vụ.

---

## 6. Cấu trúc thư mục

```text
QuanLyCuaHangNuoc/
├─ QuanLyCuaHangNuoc.sln
└─ QuanLyCuaHangNuoc/
   ├─ Forms/      (giao diện)
   ├─ Services/   (nghiệp vụ)
   ├─ Data/       (truy cập SQL Server)
   ├─ Properties/
   └─ App.config  (chuỗi kết nối)
```