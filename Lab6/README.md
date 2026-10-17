# LAB6 – QUẢN LÝ HỒ SƠ BỆNH ÁN CỦA BỆNH NHÂN

| | |
|---|---|
| **Họ và tên** | Trương Kiến Phi |
| **MSSV** | 1250080141 |
| **Lớp** | 12_ĐH_CNPM2 |
| **Môn** | Thực hành Phân tích thiết kế hướng đối tượng |
| **Tên bài Lab** | Quản Lý Hồ Sơ Bệnh Án Của Bệnh Nhân (Bài 5 – bệnh viện đa khoa quốc tế) |

---

## 1. Môi trường / phiên bản

| Thành phần | Phiên bản |
|---|---|
| Hệ điều hành | Windows 10/11 |
| IDE | Visual Studio 2022 |
| Nền tảng | .NET Framework 4.7.2, C# (Windows Forms), ADO.NET |
| CSDL | Microsoft SQL Server 2016 trở lên (Express hoặc LocalDB) |
| Công cụ quản trị CSDL | SQL Server Management Studio (SSMS) |

Kiến trúc 3 lớp tách biệt: **Forms (giao diện) → Services (nghiệp vụ) → Data (truy cập dữ liệu)**. Form không viết SQL trực tiếp; các nghiệp vụ nhiều bảng dùng transaction trong Service.

---

## 2. Nội dung đã thực hiện

### 2.1. Cơ sở dữ liệu (file `Database/QuanLyBenhVien.sql`)
- 15 bảng: NhanVien, Khoa, BacSi, LoaiXetNghiem, Thuoc, BenhNhan, PhieuDangKy, HoSoBenhAn, LePhi, LichHen, PhieuKham, XetNghiem, ToaThuoc, ChiTietToaThuoc, ThanhToanVienPhi.
- Ràng buộc PK / FK / CHECK / UNIQUE theo quy tắc nghiệp vụ, ví dụ:
  - `UNIQUE(MaBN)` trên HoSoBenhAn: mỗi bệnh nhân một hồ sơ; trạng thái hồ sơ chỉ gồm *Còn hiệu lực, Hết hạn, Đã đóng*.
  - `LePhi.SoTien > 0` và `UNIQUE(MaHoSo, NamApDung)`: mỗi hồ sơ chỉ đóng một lần lệ phí cho mỗi năm.
  - `LichHen.Quy` từ 1 đến 4; mỗi lịch hẹn chỉ tạo tối đa một phiếu khám (unique index có điều kiện).
  - `PhieuKham`: bắt buộc ghi bác sĩ, khoa; *Khám bệnh* bắt buộc có triệu chứng, *Khám định kỳ* được để trống; thân nhiệt 30–45 °C.
  - `XetNghiem`: ngày có kết quả ≥ ngày chỉ định; `ToaThuoc` có tối đa một toa cho mỗi phiếu khám; `ChiTietToaThuoc` có PK (MaToa, MaThuoc), số lượng > 0.
  - `ThanhToanVienPhi`: `UNIQUE(SoPhieuKham)`, số tiền > 0, hình thức chỉ gồm *Tiền mặt, Chuyển khoản, Thẻ, Ví điện tử*.
- Khóa ngoại dùng `ON DELETE NO ACTION` để chặn xóa dữ liệu đã phát sinh nghiệp vụ.
- Có sẵn dữ liệu mẫu (nhân viên theo 4 vai trò, khoa, bác sĩ, loại xét nghiệm, thuốc) và một hồ sơ mẫu `HS001` đã đóng lệ phí năm hiện tại để thử nhanh.

### 2.2. Chương trình (thư mục `QuanLyBenhVien`)

| Màn hình | Chức năng |
|---|---|
| **Danh mục** | Khoa, bác sĩ, nhân viên (4 vai trò), loại xét nghiệm, thuốc (kèm phản ứng phụ) |
| **Đăng ký hồ sơ** | Lập phiếu đăng ký (họ tên, địa chỉ, ngày sinh, điện thoại, ảnh 3x4), thu lệ phí năm đầu và cấp hồ sơ có mã hồ sơ **trong một transaction**; thu lệ phí hằng năm cho hồ sơ đã có; danh sách hồ sơ, lọc theo trạng thái |
| **Khám bệnh** | Tra cứu hồ sơ (kiểm tra còn hiệu lực và đã có lệ phí năm khám), xem lịch sử khám, lập phiếu khám kèm triệu chứng, toa thuốc, chỉ định xét nghiệm trong **một transaction**; ghi kết quả xét nghiệm |
| **Khám định kỳ** | Kiểm tra hồ sơ, hẹn lịch khám theo quý (miễn phí), hủy lịch, ghi đợt khám như một lần điều trị (không bệnh hoặc phát hiện sớm mầm bệnh) |
| **Thanh toán** | Thanh toán viện phí (mỗi phiếu một biên lai), làm thủ tục xuất viện, sau đó phòng chăm sóc khách hàng ghi nhận thông tin khám vào hồ sơ; xem toa thuốc và xét nghiệm của phiếu |
| **Tra cứu** | Tìm hồ sơ theo mã hồ sơ, họ tên, ngày sinh hoặc điện thoại; hiển thị lịch sử khám, toa thuốc, xét nghiệm |
| **Thống kê** | Theo khoảng thời gian và theo bác sĩ: hồ sơ mới, phiếu khám, khám định kỳ, lệ phí, viện phí; thống kê trách nhiệm bác sĩ, thuốc và phản ứng phụ, diễn biến theo hồ sơ |

### 2.3. Yêu cầu chức năng chung đã đáp ứng
Kiểm tra dữ liệu đầu vào · chỉ cấp hồ sơ khi đã đóng lệ phí · transaction cho nghiệp vụ nhiều bảng · thông báo thành công hoặc lý do từ chối · ComboBox cho khóa ngoại (nhân viên lọc theo vai trò) + DataGridView cho danh sách · FK chặn xóa dữ liệu đã phát sinh · không xóa phiếu khám đã ghi nhận, luôn lưu bác sĩ và thời điểm khám để truy vết · thống kê báo cáo.

> Chưa thực hiện: phân quyền đăng nhập theo vai trò (yêu cầu phi chức năng "Bảo mật"), vì bảng nhân viên không có tài khoản/mật khẩu. Hiện chỉ lọc danh sách nhân viên theo vai trò ở từng màn hình.

---

## 3. Kết quả

Các kịch bản nghiệp vụ chính và kết quả mong đợi (xem thêm file `Bai5_TestCase.docx`):

| # | Thao tác | Kết quả mong đợi |
|---|---|---|
| 1 | Đăng ký hồ sơ: nhập đủ thông tin, có ảnh 3x4, lệ phí > 0 | Thành công; lưu bệnh nhân, phiếu đăng ký, lệ phí và hồ sơ *Còn hiệu lực* |
| 2 | Lệ phí = 0 hoặc chưa chọn ảnh 3x4 | Từ chối, không tạo hồ sơ |
| 3 | Thu lệ phí lần 2 cho cùng hồ sơ trong cùng năm | Từ chối: mỗi năm chỉ đóng một lần |
| 4 | Khám bệnh: hồ sơ hợp lệ, có triệu chứng, bác sĩ, khoa, toa thuốc, xét nghiệm | Lưu phiếu khám, toa thuốc, chi tiết toa, xét nghiệm trong một transaction |
| 5 | Hồ sơ hết hạn hoặc chưa có lệ phí năm khám | Từ chối, nêu rõ cần đóng lệ phí |
| 6 | *Khám bệnh* nhưng để trống triệu chứng | Từ chối (khám định kỳ thì được để trống) |
| 7 | Tra cứu theo mã hồ sơ / họ tên / ngày sinh (dd/MM/yyyy) / điện thoại | Hiển thị hồ sơ và lịch sử khám, toa thuốc, xét nghiệm |
| 8 | Hẹn khám định kỳ; hẹn lần 2 cùng hồ sơ cùng quý | Lần 1 thành công (miễn phí); lần 2 bị từ chối |
| 9 | Ghi đợt khám định kỳ cho lịch *Đã hẹn* | Lập phiếu khám định kỳ; lịch hẹn chuyển *Đã khám* |
| 10 | Xuất viện / ghi nhận vào hồ sơ khi chưa thanh toán viện phí | Từ chối |
| 11 | Đã thanh toán và xuất viện → ghi nhận vào hồ sơ | Thành công; ghi nhận lần 2 bị từ chối |
| 12 | Thống kê theo khoảng ngày (có thể lọc bác sĩ) | Hiển thị số liệu tổng hợp và các bảng thống kê |

---

## 4. Lỗi thường gặp và cách khắc phục

| Lỗi | Nguyên nhân | Cách khắc phục |
|---|---|---|
| Mở form báo **"Không thực hiện được thao tác … cannot open database / server was not found"** | Chưa chạy script SQL, hoặc chuỗi kết nối trong `App.config` mặc định `.\SQLEXPRESS` không khớp máy (LocalDB, `MSSQLSERVER`…) | Chạy `Database/QuanLyBenhVien.sql` trong SSMS; sửa `Data Source` trong `QuanLyBenhVien/App.config`, ví dụ `(localdb)\MSSQLLocalDB` hoặc `.` |
| Khám bệnh báo **"chưa đóng lệ phí năm …" / "đã hết hạn"** | Hồ sơ không có lệ phí của năm khám nên bị chuyển *Hết hạn* | Vào Đăng ký hồ sơ → thu lệ phí năm hiện tại cho hồ sơ đó |
| Đặt lịch báo **"Ngày giờ hẹn phải sau thời điểm hiện tại"** hoặc **"không thuộc quý / năm đã chọn"** | Chọn ngày hẹn trong quá khứ hoặc lệch quý | Chọn ngày giờ hẹn sau hiện tại và nằm trong quý/năm đã chọn |
| **"Hồ sơ đã có lịch khám định kỳ cho quý …"** | Mỗi hồ sơ chỉ hẹn một lịch mỗi quý | Hủy lịch cũ (nếu còn *Đã hẹn*) hoặc chọn quý khác |
| Xuất viện / ghi nhận báo **"chưa thanh toán viện phí"** hoặc **"chưa xuất viện"** | Sai thứ tự quy trình: thanh toán → xuất viện → ghi nhận | Thanh toán viện phí, rồi xuất viện, rồi mới ghi nhận vào hồ sơ |
| Báo **"Dữ liệu bị trùng (mã … đã tồn tại)"** | Trùng mã hồ sơ, bệnh nhân, phiếu khám, toa thuốc, biên lai… | Nhập mã khác |
| Tìm theo ngày sinh báo sai định dạng | Ngày sinh phải nhập dạng `dd/MM/yyyy` | Nhập lại, ví dụ `12/05/1990` |

---

## 5. Hướng dẫn chạy

1. Mở SSMS, kết nối SQL Server, mở file `Database/QuanLyBenhVien.sql` và nhấn **Execute** (script tự tạo CSDL `QuanLyBenhVien`, bảng, ràng buộc và dữ liệu mẫu; chạy lại được nhiều lần, mỗi lần sẽ xóa và tạo lại dữ liệu).
2. Mở `QuanLyBenhVien.sln` bằng Visual Studio 2022.
3. Kiểm tra `Data Source` trong `QuanLyBenhVien/App.config` (mặc định `.\SQLEXPRESS`; LocalDB: `(localdb)\MSSQLLocalDB`). Xác thực Windows (`Integrated Security=True`).
4. Nhấn **F5** (Start). Màn hình chính có các nút: Danh mục, Đăng ký hồ sơ, Khám bệnh, Thanh toán, Tra cứu, Khám định kỳ, Thống kê. Thử nhanh với hồ sơ mẫu `HS001`, theo bảng kịch bản ở mục 3.

---

## 6. Cấu trúc thư mục

```
QuanLyBenhVien/
├─ QuanLyBenhVien.sln
└─ QuanLyBenhVien/
   ├─ Database/   (QuanLyBenhVien.sql – tạo CSDL + dữ liệu mẫu)
   ├─ Forms/      (giao diện + UiHelper)
   ├─ Services/   (nghiệp vụ)
   ├─ Data/       (Db.cs – truy cập SQL Server)
   ├─ Properties/
   └─ App.config  (chuỗi kết nối)
```
