# BÁO CÁO LAB 3 - HỆ THỐNG QUẢN LÝ KHÁCH SẠN (.NET WINFORMS)

## 1. Thông tin sinh viên
* **Họ và tên:** Trương Kiến Phi
* **Mã số sinh viên (MSSV):** 1250080141
* **Tên bài Lab:** Xây dựng ứng dụng Quản lý Khách sạn (Lab 3)

---

## 2. Môi trường & Công nghệ sử dụng
* **Ngôn ngữ lập trình:** C#
* **Framework:** .NET Framework / .NET WinForms
* **Hệ quản trị cơ sở dữ liệu (DBMS):** Microsoft SQL Server
* **Công cụ phát triển:** Visual Studio 2022

---

## 3. Nội dung đã thực hiện
* Thiết kế cấu trúc cơ sở dữ liệu (SQL Server) gồm các bảng quản lý khách hàng, phòng, dịch vụ, phiếu đặt phòng và phân quyền nhân viên.
* Xây dựng kiến trúc phân tầng (chia tách các lớp `Service`, `Data` helper kết nối CSDL và giao diện `Forms`).
* Lập trình các chức năng chính cho các form:
  * **Form Main (`FrmMain`):** Điều hướng hệ thống.
  * **Form Danh mục (`FrmDanhMuc`):** Quản lý thông tin danh mục cơ bản.
  * **Form Phòng - Tiện nghi (`FrmPhongTienNghi`):** Quản lý danh sách phòng và tiện nghi đi kèm.
  * Các form nghiệp vụ mở rộng: Đặt phòng (`FrmDatPhong`), Ghi nhận dịch vụ (`FrmDichVu`), Trả phòng (`FrmTraPhong`),...

---

## 4. Kết quả đạt được
* **Phần chạy tốt:** 
  * Chương trình biên dịch thành công, khởi chạy mượt mà.
  * Các form như **Form Main**, **Form Danh mục**, và **Form Phòng - Tiện nghi** hoạt động ổn định, kết nối trực tiếp với CSDL để hiển thị dữ liệu lên giao diện (`DataGridView`) chính xác và hỗ trợ thêm mới dữ liệu vào CSDL thành công.
* **Phần còn hạn chế:** 
  * Các form còn lại (như đặt phòng, dịch vụ,...) vẫn bật lên được giao diện nhưng hiện tại chưa hiển thị được dữ liệu từ CSDL lên các điều khiển (như ComboBox, GridView) và chưa thực hiện được thao tác thêm/ghi nhận dữ liệu.

---

## 5. Lỗi gặp phải & Cách khắc phục
* **Lỗi gặp phải:** 
  1. Lỗi xung đột bộ nhớ đệm giao diện (`Designer`) khi chỉnh sửa thủ công các file `.Designer.cs`.
  2. Các ComboBox hoặc GridView ở các form nghiệp vụ phụ bị trống, không load được dữ liệu hoặc phát sinh ngoại lệ khi thực thi thao tác thêm dữ liệu.
* **Nguyên nhân (dự kiến):** Có thể do trạng thái dữ liệu trong CSDL chưa đồng bộ với điều kiện lọc của câu lệnh SQL (ví dụ: các hàm service yêu cầu dữ liệu ở trạng thái cụ thể như `N'Đang ở'`, nhưng dữ liệu test chưa có), hoặc các tên điều khiển (`(Name)` trên giao diện) chưa khớp hoàn toàn với mã nguồn logic.
* **Cách khắc phục đã áp dụng:** Chuẩn hóa lại tên các control, thực hiện `Clean Solution` và `Rebuild Solution` trong Visual Studio để đồng bộ lại mã nguồn và giao diện.

---

## 6. Hướng dẫn Giảng viên kiểm tra và chạy lại chương trình

1. **Chuẩn bị Cơ sở dữ liệu:**
   * Mở Microsoft SQL Server Management Studio (SSMS).
   * Tạo cơ sở dữ liệu cho project và chạy các script tạo bảng, chèn dữ liệu mẫu (đảm bảo bảng có các bản ghi trạng thái phù hợp như `"Đang ở"` hoặc danh mục nhân viên, dịch vụ).
2. **Cấu hình chuỗi kết nối (Connection String):**
   * Mở file `App.config` trong project Visual Studio.
   * Kiểm tra và chỉnh sửa lại thông tin server name trong chuỗi kết nối (`connectionString`) cho khớp với máy của bạn.
3. **Mở và Chạy Project:**
   * Khởi động phần mềm **Visual Studio 2022**.
   * Mở file solution (`.sln`) của project Quản lý Khách sạn.
   * Trên thanh thực đơn, chọn **Build** -> **Clean Solution**, sau đó chọn **Build** -> **Rebuild Solution**.
   * Nhấn nút **Start** (hoặc phím tắt `F5`) trên thanh công cụ để chạy ứng dụng và kiểm tra kết quả trên `FrmMain`.
