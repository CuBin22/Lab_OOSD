# LAB7 – QUẢN LÝ NHÂN SỰ CÔNG TY SƠN ĐÔNG Á

| | |
|---|---|
| **Họ và tên** | Trương Kiến Phi |
| **MSSV** | 1250080141 |
| **Lớp** | 12_ĐH_CNPM2 |
| **Môn** | Thực hành Phân tích thiết kế hướng đối tượng |
| **Tên bài Lab** | Quản Lý Nhân Sự (Bài 7 – công ty sơn Đông Á) |

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

### 2.1. Cơ sở dữ liệu (file `Database/QuanLyNhanSu.sql`)
- 20 bảng: PhongBan, ChucVu, NhanVien, QuyetDinhTuyenDung, HopDong, HoSoBaoHiem, QuyetDinhChucVu, QuyetDinhLuong, KeHoachPhanCong, ChiTietPhanCong, PhieuChamCong, ChiTietChamCong, PhieuPhuTroi, ChiTietPhieuPhuTroi, BangLuong, ChiTietBangLuong, QuyetDinhKhenThuong, PhieuChiKhenThuong, QuyetDinhKyLuat, PhieuThuNopPhat.
- Ràng buộc PK / FK / CHECK / UNIQUE theo quy tắc nghiệp vụ, ví dụ:
  - `QuyetDinhTuyenDung`: bắt buộc ghi phòng ban, thời gian thử việc (ngày kết thúc ≥ ngày bắt đầu), lương thử việc > 0 và điều khoản của hai bên.
  - `HopDong`: loại hợp đồng chỉ gồm *Dài hạn, Ngắn hạn*; ngày kết thúc ≥ ngày bắt đầu; chỉ ký sau khi hết thời gian thử việc.
  - `HoSoBaoHiem`: loại bảo hiểm chỉ gồm *BHYT, BHXH*, mức đóng > 0; chỉ lập cho hợp đồng dài hạn.
  - `QuyetDinhLuong`: lương cơ bản > 0, phụ cấp lương và phụ cấp độc hại ≥ 0; `QuyetDinhChucVu`: phụ cấp chức vụ ≥ 0. Mỗi lần tăng lương hoặc bổ nhiệm là một quyết định mới, không ghi đè quyết định cũ.
  - `PhieuPhuTroi`: hình thức chỉ gồm *Tăng ca, Ngày lễ, Ngày nghỉ*; số giờ phụ trội > 0; hệ số phụ trội mặc định 1.5. `ChiTietPhieuPhuTroi` có PK (SoPhieu, MaNV) để ghi rõ từng nhân viên tham gia.
  - `ChiTietChamCong` có PK (SoPhieu, MaNV, NgayCong); `ChiTietPhanCong` ghi ca làm việc và kế hoạch phụ trội cho từng nhân viên.
  - `BangLuong`: `UNIQUE(Thang, Nam)`, mỗi tháng chỉ lập một bảng lương; `ChiTietBangLuong` có PK (SoBangLuong, MaNV).
  - `QuyetDinhKhenThuong` / `QuyetDinhKyLuat`: số tiền > 0; áp dụng cho cá nhân hoặc tập thể phòng ban, `CHECK` chỉ được chọn một trong hai (`MaNV` hoặc `MaPB`).
  - `PhieuChiKhenThuong`: `UNIQUE(SoQD)`, mỗi quyết định khen thưởng một phiếu chi; `PhieuThuNopPhat`: `UNIQUE(SoQD)`, tối đa một phiếu thu cho mỗi quyết định kỷ luật (khoản phạt có thể được trừ thẳng vào lương).
- Khóa ngoại dùng `ON DELETE NO ACTION` để chặn xóa dữ liệu đã phát sinh nghiệp vụ.
- Có sẵn dữ liệu mẫu (phòng ban: tài chính kế toán, kỹ thuật, sản xuất; chức vụ; nhân viên) để thử nhanh.

### 2.2. Chương trình (thư mục `QuanLyNhanSu`)

| Màn hình | Chức năng |
|---|---|
| **Danh mục** | Phòng ban, chức vụ, nhân viên |
| **Tuyển dụng - thử việc** | Lập quyết định tuyển dụng (phòng ban, thời gian thử việc, lương thử việc, điều khoản hai bên); theo dõi thời gian thử việc; danh sách nhân viên thử việc |
| **Hợp đồng - bảo hiểm** | Kiểm tra đã hết thời gian thử việc, ký hợp đồng chính thức (dài hạn hoặc ngắn hạn); với hợp đồng dài hạn lập hồ sơ Bảo hiểm y tế và Bảo hiểm xã hội |
| **Quyết định chức vụ - lương** | Lập quyết định chức vụ (phụ cấp chức vụ), quyết định lương (lương cơ bản, phụ cấp lương, phụ cấp độc hại); ghi nhận quá trình tăng lương, bổ nhiệm |
| **Phân công - chấm công** | Trưởng phòng, ban, phân xưởng lập kế hoạch phân công theo ca và kế hoạch phụ trội hằng tuần; ban chấm công chấm công, lập phiếu ghi nhận giờ phụ trội (1.5 lần giờ lao động bình thường) chi tiết từng nhân viên |
| **Tính lương** | Tính lương hằng tháng từ quyết định lương, quyết định chức vụ, bảng chấm công, phiếu phụ trội; trích trừ bảo hiểm theo mức đóng, trừ tiền phạt nếu có; lập bảng lương |
| **Khen thưởng - kỷ luật** | Lập quyết định khen thưởng (cá nhân hoặc tập thể phòng ban, gồm thưởng ngày lễ, cuối năm, lương tháng 13 do giám đốc ký) và phiếu chi khen thưởng; lập quyết định kỷ luật và phiếu thu nộp phạt hoặc trừ vào lương |
| **Tra cứu** | Tìm nhân viên; xem lịch sử quyết định chức vụ, quyết định lương, hợp đồng, bảo hiểm, bảng lương |

### 2.3. Yêu cầu chức năng chung đã đáp ứng
Kiểm tra dữ liệu đầu vào · tự tính giờ phụ trội (1.5 lần) và lương hằng tháng · transaction cho nghiệp vụ nhiều bảng (quyết định kèm phiếu chi/phiếu thu, lập bảng lương) · thông báo thành công hoặc lý do từ chối · ComboBox cho khóa ngoại (phòng ban, chức vụ, loại hợp đồng, nhân viên) + DataGridView cho danh sách · lưu vết lịch sử quyết định, không ghi đè · FK chặn xóa quyết định, hợp đồng, phiếu đã phát sinh nghiệp vụ.



---

## 3. Kết quả

Các kịch bản nghiệp vụ chính và kết quả mong đợi (xem thêm file `Bai7_TestCase.docx`):

| # | Thao tác | Kết quả mong đợi |
|---|---|---|
| 1 | Lập quyết định tuyển dụng: đủ phòng ban, thời gian thử việc, lương thử việc > 0, điều khoản | Thành công; lưu nhân viên và quyết định tuyển dụng |
| 2 | Lương thử việc = 0 hoặc ngày kết thúc thử việc < ngày bắt đầu | Từ chối, không lưu quyết định |
| 3 | Ký hợp đồng chính thức khi chưa hết thời gian thử việc | Từ chối: chưa hết thời gian thử việc |
| 4 | Ký hợp đồng dài hạn và lập hồ sơ BHYT, BHXH | Thành công; lưu hợp đồng và hồ sơ bảo hiểm |
| 5 | Lập hồ sơ bảo hiểm cho hợp đồng ngắn hạn | Từ chối: chỉ hợp đồng dài hạn mới có bảo hiểm |
| 6 | Lập quyết định lương hoặc chức vụ mới (tăng lương, bổ nhiệm) | Lưu quyết định mới; quyết định cũ vẫn giữ trong lịch sử |
| 7 | Lập phiếu phụ trội: hình thức hợp lệ, số giờ > 0, có chi tiết nhân viên | Thành công; giờ phụ trội tính hệ số 1.5; hình thức khác bị từ chối |
| 8 | Lập kế hoạch phân công, chấm công cho nhân viên theo ca | Lưu kế hoạch, phiếu chấm công và chi tiết từng nhân viên |
| 9 | Tính lương tháng; tính lại lần 2 cùng tháng | Lần 1 thành công (có trừ bảo hiểm, tiền phạt nếu có); lần 2 bị từ chối |
| 10 | Lập quyết định khen thưởng cho cá nhân hoặc phòng ban; chọn cả hai hoặc không chọn | Chọn một đối tượng thì thành công; còn lại bị từ chối |
| 11 | Lập phiếu chi khen thưởng; lập lần 2 cho cùng quyết định | Lần 1 thành công; lần 2 bị từ chối |
| 12 | Lập quyết định kỷ luật, nộp phạt bằng phiếu thu hoặc trừ vào lương | Thành công; khoản phạt thể hiện ở phiếu thu hoặc ở bảng lương |

---

## 4. Lỗi thường gặp và cách khắc phục

| Lỗi | Nguyên nhân | Cách khắc phục |
|---|---|---|
| Mở form báo **"Không thực hiện được thao tác … cannot open database / server was not found"** | Chưa chạy script SQL, hoặc chuỗi kết nối trong `App.config` mặc định `.\SQLEXPRESS` không khớp máy (LocalDB, `MSSQLSERVER`…) | Chạy `Database/QuanLyNhanSu.sql` trong SSMS; sửa `Data Source` trong `QuanLyNhanSu/App.config`, ví dụ `(localdb)\MSSQLLocalDB` hoặc `.` |
| Ký hợp đồng báo **"chưa hết thời gian thử việc"** | Ngày ký hợp đồng nằm trước ngày kết thúc thử việc của quyết định tuyển dụng | Chọn ngày ký sau khi hết thời gian thử việc |
| Lập hồ sơ bảo hiểm báo **"chỉ áp dụng cho hợp đồng dài hạn"** | Hợp đồng được chọn là hợp đồng ngắn hạn | Chọn hợp đồng dài hạn |
| Tính lương báo **"tháng … đã có bảng lương"** | Mỗi tháng chỉ lập một bảng lương | Xem lại bảng lương đã lập, hoặc chọn tháng khác |
| Tính lương thiếu dữ liệu của nhân viên | Chưa có quyết định lương, quyết định chức vụ hoặc phiếu chấm công trong tháng | Lập đủ quyết định và chấm công cho nhân viên trước khi tính lương |
| Lập khen thưởng / kỷ luật báo **"chọn cá nhân hoặc phòng ban"** | Chọn cả nhân viên và phòng ban, hoặc không chọn đối tượng nào | Chỉ chọn một trong hai đối tượng |
| Báo **"Dữ liệu bị trùng (mã … đã tồn tại)"** | Trùng số quyết định, số hợp đồng, số phiếu, mã nhân viên… | Nhập mã khác |
| Báo **"Ngày kết thúc phải sau ngày bắt đầu"** | Ngày kết thúc thử việc hoặc hợp đồng nhỏ hơn ngày bắt đầu | Nhập lại khoảng ngày hợp lệ |

---

## 5. Hướng dẫn chạy

### Restore file backup đã gửi

File backup: **`QuanLyNhanSuBak.bak`** (kèm trong bài nộp).

**Bằng giao diện SSMS**
1. Kết nối SQL Server → chuột phải **Databases** → **Restore Database…**
2. Chọn **Device** → `…` → **Add** → chọn file `QuanLyNhanSuBak.bak` → OK.

**Chạy chương trình**
1. Mở `QuanLyNhanSu.sln` bằng Visual Studio 2022.
2. Kiểm tra `Data Source` trong `QuanLyNhanSu/App.config` (mặc định `.\SQLEXPRESS`; LocalDB: `(localdb)\MSSQLLocalDB`). Xác thực Windows (`Integrated Security=True`).
3. Nhấn **F5** (Start). Màn hình chính có các nút: Danh mục, Tuyển dụng - thử việc, Hợp đồng - bảo hiểm, Quyết định chức vụ - lương, Phân công - chấm công, Tính lương, Khen thưởng - kỷ luật, Tra cứu. Thử nhanh với dữ liệu mẫu, theo bảng kịch bản ở mục 3.

---

## 6. Cấu trúc thư mục

```
QuanLyNhanSu/
├─ QuanLyNhanSu.sln
└─ QuanLyNhanSu/
   ├─ Forms/      (giao diện + UiHelper)
   ├─ Services/   (nghiệp vụ)
   ├─ Data/       (Db.cs – truy cập SQL Server)
   ├─ Properties/
   └─ App.config  (chuỗi kết nối)
```
