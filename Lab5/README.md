# LAB5 – QUẢN LÝ CÔNG TY DU LỊCH

| | |
|---|---|
| **Họ và tên** | Trương Kiến Phi |
| **MSSV** | 1250080141 |
| **Lớp** | 12_ĐH_CNPM2 |
| **Môn** | Thực hành Phân tích thiết kế hướng đối tượng|
| **Tên bài Lab** | Quản Lý Công Ty Du Lịch (công ty du lịch Văn Hóa Việt TP.HCM) |

---

## 1. Môi trường / phiên bản

| Thành phần | Phiên bản |
|---|---|
| Hệ điều hành | Windows 10/11 |
| IDE | Visual Studio 2022 |
| Nền tảng | .NET Framework 4.7.2, C# (Windows Forms) |
| CSDL | Microsoft SQL Server 2016 trở lên (Express hoặc LocalDB) |
| Công cụ quản trị CSDL | SQL Server Management Studio (SSMS) |

Kiến trúc 3 lớp tách biệt: **Forms (giao diện) → Services (nghiệp vụ) → Data/Helpers (truy cập dữ liệu)**.

---

## 2. Nội dung đã thực hiện

### 2.1. Cơ sở dữ liệu (thư mục `Database`)
- 18 bảng: Tour, DiaDiem, PhuongTien, DungChan, DiemThamQuan, ChiTietTourDiemTQ, ChuyenTour, KhachHang, PhieuDangKy, PhieuDangKyDoan, PhieuDangKyChuyen, ThanhVienDoan, ThanhToan, DiemBanVe, DiemDon, NhanVien, PhanCong, PhieuKhaoSat.
- Ràng buộc CHECK / UNIQUE / FK theo quy tắc nghiệp vụ (ví dụ: đoàn > 12 người, ngày về ≥ ngày đi, 0 < tiền cọc ≤ tổng tiền, `{xor}` chuyến/đoàn trong PhanCong, mỗi chuyến lẻ chỉ có 1 nhân viên).
- 5 trigger cho ràng buộc liên bảng: trùng phiếu đoàn, hết chỗ chuyến, thành viên đoàn chỉ khi mua bảo hiểm, tổng thanh toán không vượt tổng tiền phiếu, trùng lịch phân công.
- Stored procedure `sp_LapPhieuDoan` (lập phiếu đoàn + thành viên + đặt cọc trong **một transaction**).

### 2.2. Chương trình (thư mục `QuanLyCongTyDuLich`)

| Màn hình | Chức năng |
|---|---|
| **Danh mục** | Địa điểm, phương tiện, điểm tham quan, điểm bán vé, điểm đón: thêm / sửa / xóa |
| **Tour** | Quản lý tour; lộ trình nơi dừng chân (thứ tự, đổi phương tiện, nơi ăn, khách sạn 2–5 sao); điểm tham quan của tour; chuyến tour (ngày đi/về, số chỗ); **Xuất web** (trang HTML giới thiệu tour); **Khách đăng ký** (khách của từng chuyến) |
| **Khách hàng** | Khách đoàn / khách lẻ, tìm kiếm, lọc theo loại |
| **Đăng ký** | Lập phiếu đăng ký **đoàn** (tự phân loại > 12 người, danh sách người đi nếu mua bảo hiểm, đặt cọc, tính tổng tiền/tiền còn lại); đăng ký **chuyến** cho khách lẻ + bán vé; xem người đi của phiếu đoàn |
| **Thanh toán** | Đặt cọc, tiền vé, kinh phí đoàn, xử lý **mất cọc** khi đoàn không đi, biên nhận |
| **Phân công** | Phân công hướng dẫn viên theo chuyến (1 người) hoặc theo đoàn (nhiều người), chặn trùng lịch; quản lý nhân viên; tính lương tháng (lương căn bản + tiền công tour) |
| **Khảo sát** | Gửi phiếu khảo sát sau tour, ghi nhận điểm và góp ý |
| **Thống kê** | Theo khoảng thời gian: đăng ký, doanh thu, phân công, khảo sát, tour, lương nhân viên |

### 2.3. Yêu cầu chức năng chung đã đáp ứng
Kiểm tra dữ liệu đầu vào · phân loại khách tự động · transaction · chặn trùng lịch · thông báo thành công/lý do từ chối · ComboBox cho khóa ngoại + DataGridView cho danh sách · khóa mã khi sửa, FK chặn xóa dữ liệu đã phát sinh · tự tính tiền · thống kê báo cáo.

---

## 3. Kết quả

Các kịch bản nghiệp vụ chính và kết quả mong đợi của chương trình (giảng viên có thể thử lại sau khi restore):

| # | Thao tác | Kết quả mong đợi |
|---|---|---|
| 1 | Đăng ký → tab đoàn, nhập **12 người** rồi bấm *Lập phiếu* | Từ chối: số người phải lớn hơn 12 |
| 2 | Nhập **13+ người**, ngày đi hợp lệ, tiền cọc hợp lệ | Lập phiếu thành công, trạng thái *Đã đặt cọc*, có số phiếu `PDxxxxxx` |
| 3 | Tiền cọc **lớn hơn tổng tiền** | Từ chối, không lưu gì |
| 4 | Tick *Có bảo hiểm* nhưng danh sách người đi chưa đủ | Từ chối: phải kèm danh sách đủ số người |
| 5 | Lập lại phiếu cùng khách + tour + ngày đi | Từ chối: phiếu trùng |
| 6 | Đăng ký chuyến, mua vé nhiều hơn số chỗ còn lại | Từ chối: hết chỗ / không đủ chỗ |
| 7 | Phân công một nhân viên cho 2 chuyến/đoàn trùng thời gian | Từ chối: trùng lịch |
| 8 | Phân công thêm nhân viên thứ 2 cho cùng một **chuyến lẻ** | Từ chối: chuyến đã có hướng dẫn viên |
| 9 | Phân công nhiều nhân viên cho cùng một **đoàn** (lịch không trùng) | Thành công |
| 10 | Thanh toán vượt số tiền còn lại của phiếu | Từ chối |
| 11 | Thanh toán → *Hủy phiếu (mất cọc)* trên phiếu đoàn | Phiếu chuyển *Đã hủy*, tiền cọc được giữ lại |
| 12 | Phân công → tab Lương, chọn tháng/năm | Lương = lương căn bản + tổng tiền công tour kết thúc trong tháng |
| 13 | Tour → *Xuất web* | Sinh file `.html` giới thiệu các tour, mở được bằng trình duyệt |
| 14 | Xóa tour/khách/nhân viên đã phát sinh nghiệp vụ | Báo "đã phát sinh nghiệp vụ nên không thể xóa" |

> *Ảnh chụp màn hình minh họa (nếu cần) đặt trong thư mục `Anh/`.*

---

## 4. Lỗi gặp phải và cách khắc phục

| Lỗi | Nguyên nhân | Cách khắc phục |
|---|---|---|
| Mở chương trình báo **"Không kết nối được cơ sở dữ liệu QuanLyCongTyDuLich"** | Chuỗi kết nối trong `App.config` mặc định là `.\SQLEXPRESS`, máy dùng instance khác (LocalDB, `MSSQLSERVER`…) | Sửa `Data Source` trong `QuanLyCongTyDuLich/App.config` cho đúng, ví dụ `(localdb)\MSSQLLocalDB` hoặc `.` |
| Lập phiếu đoàn báo lỗi **"Ngày đi không được nằm trong quá khứ"** | Dữ liệu mẫu tạo ngày theo `GETDATE()`; chọn ngày đi nhỏ hơn hôm nay | Chọn ngày đi từ hôm nay trở đi |
| Lập phiếu đoàn báo **số người phải > 12** dù nhập đúng 12 | Quy định: *trên* 12 người là khách đoàn; đúng 12 người xếp vào khách lẻ | Nhập ≥ 13 người, hoặc đăng ký theo chuyến (khách lẻ) |
| Lỗi trigger **"đã hết chỗ" / "trùng lịch" / "vượt tổng tiền"** (mã 50004–50007) | Vi phạm quy tắc nghiệp vụ được kiểm tra ở cả tầng Service và trigger | Đây là thông báo từ chối có chủ đích, chương trình hiển thị lý do; điều chỉnh dữ liệu nhập |
| Restore báo **"Exclusive access could not be obtained"** | CSDL đang được mở bởi chương trình/kết nối khác | Đóng chương trình, hoặc restore với `WITH REPLACE` sau khi `SET SINGLE_USER WITH ROLLBACK IMMEDIATE` (xem mục 5) |

---

## 5. Hướng dẫn giảng viên kiểm tra / chạy lại

### Restore file backup đã gửi

File backup: **`DuLichBak.bak`** (kèm trong bài nộp).

**Bằng giao diện SSMS**
1. Kết nối SQL Server → chuột phải **Databases** → **Restore Database…**
2. Chọn **Device** → `…` → **Add** → chọn file `DuLichBak.bak` → OK.

### Chạy chương trình
1. Mở `QuanLyCongTyDuLich.sln` bằng Visual Studio 2022.
2. Kiểm tra `Data Source` trong `QuanLyCongTyDuLich/App.config` (mặc định `.\SQLEXPRESS`; LocalDB: `(localdb)\MSSQLLocalDB`). Xác thực Windows (`Integrated Security=True`).
3. Nhấn **F5** (Start). Màn hình chính có các nút: Danh mục, Tour, Khách hàng, Đăng ký, Thanh toán, Phân công, Khảo sát, Thống kê. Thử theo bảng kịch bản ở mục 3.

---

## 6. Cấu trúc thư mục

```
QuanLyCongTyDuLich/
├─ QuanLyCongTyDuLich.sln
└─ QuanLyCongTyDuLich/
   ├─ Forms/      (giao diện)
   ├─ Services/   (nghiệp vụ)
   ├─ Data/       (Db.cs – truy cập SQL Server)
   ├─ Helpers/    (Hlp.cs, Ui.cs)
   └─ App.config  (chuỗi kết nối)
```
