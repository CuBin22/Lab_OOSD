# BÁO CÁO BÀI LAB 4: HỆ THỐNG ESHOPPING

---

## 1. Thông Tin Sinh Viên
* **Họ và tên:** Trương Kiến Phi
* **Mã số sinh viên (MSSV):** 1250080141
* **Tên bài Lab:** Hệ thống eShopping (C# WinForms / .NET Framework)

---

## 2. Môi Trường và Phiên Bản (Environment & Version)
* **Ngôn ngữ lập trình:** C#
* **Framework:** .NET Framework 4.7.2
* **Môi trường phát triển (IDE):** Visual Studio (hoặc Visual Studio Code)
* **Hệ quản trị cơ sở dữ liệu:** MS SQL Server (kết nối thông qua ADO.NET và cấu hình chuỗi kết nối trong `App.config` / `Db.cs`)
---

## 3. Nội Dung Đã Thực Hiện
* **Xây dựng cấu trúc ứng dụng WinForms:** Tổ chức các tầng kiến trúc rõ ràng gồm `Forms` (Giao diện người dùng như đăng nhập, đăng ký, giỏ hàng, đặt hàng, chi tiết sản phẩm, thanh toán), `Models` (Các lớp dữ liệu), và `Services` (Xử lý nghiệp vụ logic).
* **Phát triển các màn hình chức năng chính:**
  * `FrmDangNhap` / `FrmDangKy`: Quản lý tài khoản người dùng, xác thực thông tin.
  * `FrmSanPham` / `FrmChiTietSanPham`: Hiển thị danh sách sản phẩm và xem chi tiết thông tin sản phẩm.
  * `FrmGioHang`: Quản lý giỏ hàng của người dùng.
  * `FrmDatHang` / `FrmThanhToan` / `FrmXacNhanDonHang`: Xử lý quy trình đặt hàng, thanh toán và xác nhận đơn hàng cuối cùng.
* **Cấu hình kết nối cơ sở dữ liệu:** Viết các lớp truy xuất dữ liệu trong thư mục `Data/Db.cs` và các service tương ứng để thao tác với SQL Server.
* **Thực hiện Restore dữ liệu:** Khôi phục cơ sở dữ liệu từ file backup chuẩn bị sẵn để phục vụ cho việc kiểm thử hệ thống.

---

## 4. Kết Quả Đạt Được
* Hoàn thiện mã nguồn ứng dụng quản lý bán hàng `eShopping` trên nền tảng C# WinForms.
* Các form giao diện tương tác mượt mà, phân chia các module dịch vụ (`Services`) mạch lạc giúp dễ dàng bảo trì và mở rộng.
* Hệ thống có khả năng kết nối cơ sở dữ liệu thành công, thực hiện được các luồng nghiệp vụ cơ bản từ đăng nhập, xem sản phẩm, thêm vào giỏ hàng đến thanh toán đơn hàng.

---

## 5. Lỗi Gặp Phải và Cách Khắc Phục
* **Lỗi kết nối cơ sở dữ liệu (Connection String):** 
  * *Nguyên nhân:* Chuỗi kết nối mặc định trỏ đến instance SQL Server của máy tính phát triển cũ hoặc tên Server không trùng khớp.
  * *Cách khắc phục:* Cập nhật lại chuỗi kết nối (`ConnectionString`) trong file `App.config` hoặc lớp `Data/Db.cs` theo đúng tên Server (`Data Source`) và tên cơ sở dữ liệu thực tế tại máy chấm bài.
* **Lỗi xung đột phiên bản .NET Framework:**
  * *Nguyên nhân:* Máy chấm không khớp phiên bản .NET Framework 4.7.2.
  * *Cách khắc phục:* Đảm bảo máy trạm đã cài đặt gói `.NET Framework 4.7.2 Developer Pack / Target Pack` trong Visual Studio.

---

## 6. Hướng Dẫn Giảng Viên Kiểm Tra và Chạy Lại

### Bước 1: Chuẩn bị Cơ Sở Dữ Liệu (Restore Database)
1. Mở **SQL Server Management Studio (SSMS)**.
2. Thực hiện **Restore** cơ sở dữ liệu từ file backup (`.bak`) của hệ thống eShopping cung cấp.
3. Kiểm tra lại tên Database cho khớp với cấu hình trong mã nguồn.

### Bước 2: Mở và Cấu Hình Dự Án
1. Giải nén thư mục mã nguồn `eShopping`.
2. Mở file giải pháp `eShopping.sln` bằng **Visual Studio**.
3. Kiểm tra file `App.config` để chắc chắn chuỗi kết nối (`ConnectionString`) trỏ đúng đến SQL Server trên máy của bạn (ví dụ: sử dụng `Server=.;Database=eShoppingDB;Integrated Security=true;`).

### Bước 3: Biên Dịch và Chạy Ứng Dụng (Run)
1. Trên thanh công cụ Visual Studio, chọn cấu hình **Debug** hoặc **Release**.
2. Nhấn nút **Start** (hoặc phím tắt `F5`) để biên dịch và khởi chạy ứng dụng.
3. Thử nghiệm các chức năng: Đăng nhập/Đăng ký tài khoản, xem danh sách sản phẩm, thêm sản phẩm vào giỏ hàng và tiến hành thanh toán để kiểm tra kết quả toàn bộ bài Lab.
