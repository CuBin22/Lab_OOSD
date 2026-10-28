# LAB8 – QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT

| | |
|---|---|
| **Họ và tên** | Trương Kiến Phi |
| **MSSV** | 1250080141 |
| **Lớp** | 12_ĐH_CNPM2 |
| **Môn** | Thực hành Phân tích thiết kế hướng đối tượng |
| **Tên bài Lab** | Quản lý cửa hàng nước giải khát (Bài 2) |

---

## 1. Mục tiêu hệ thống

Hệ thống quản lý cửa hàng nước giải khát hỗ trợ theo dõi danh mục mặt hàng, nhãn hiệu, nhà cung ứng, khách hàng và nhân viên; quản lý đặt hàng, nhận hàng, bán hàng, giao hàng hẹn và công nợ. Dữ liệu được lưu trữ để phục vụ tra cứu và thống kê hoạt động cửa hàng.

## 2. Nội dung báo cáo

### 2.1. Hoạt động nghiệp vụ

- Quản lý nước giải khát theo mã, tên, đơn vị tính và nhãn hiệu.
- Lưu thông tin nhà cung ứng gồm tên, địa chỉ, số điện thoại; mỗi loại nước giải khát lấy từ một nhà cung ứng.
- Nhân viên lập đơn đặt hàng, ghi ngày đặt, ngày nhận dự kiến và số lượng từng mặt hàng.
- Theo dõi tối đa 3 đợt giao trên mỗi đơn đặt hàng. Mỗi đợt có phiếu giao ghi ngày, số lượng chi tiết và số tiền phải trả.
- Khi bán hàng, cửa hàng kiểm tra tồn kho; nếu đủ thì giao hàng và lập hóa đơn.
- Nếu thiếu hàng, khách quen có thể nhận hàng thành nhiều đợt theo phiếu hẹn gắn với hóa đơn.
- Khách vãng lai thanh toán tại cửa hàng; khách quen được trả chậm bằng phiếu ghi nợ có ngày lập, số tiền nợ, ngày dự kiến trả, lý do và nhân viên lập.

### 2.2. Yêu cầu hệ thống

Báo cáo phân tích đầu vào, xử lý và kết quả cho từng nhóm nghiệp vụ; phân loại công việc theo bộ phận/actor; xác định quy tắc nghiệp vụ, yêu cầu chức năng và phi chức năng. Phần chức năng bao gồm quản lý danh mục, đặt và nhận hàng, kiểm tra tồn kho, bán hàng, lập hóa đơn, theo dõi giao hẹn, thanh toán, ghi nợ, tra cứu và thống kê.

### 2.3. Phân tích và thiết kế

Báo cáo có các mục mô hình Use Case tổng quát và phân rã, sơ đồ lớp, lớp phân tích và lớp chi tiết, sơ đồ trạng thái, sơ đồ tuần tự, thiết kế từng chức năng, sơ đồ hoạt động, thiết kế dữ liệu và ERD.

### 2.4. Thiết kế dữ liệu

Danh sách bảng trong báo cáo gồm 14 bảng:

`LoaiNGK`, `NhaCungCap`, `NuocGiaiKhat`, `DonDatHang`, `ChiTietDonDatHang`, `PhieuGiaoHang`, `ChiTietPhieuGiao`, `KhachHang`, `NhanVien`, `HoaDon`, `ChiTietHoaDon`, `PhieuHen`, `ChiTietPhieuHen`, `PhieuGhiNo`.

Các ràng buộc chính gồm khóa chính và khóa ngoại; thông tin bắt buộc; số lượng đặt, giao, bán phải dương; mỗi đơn đặt tối đa 3 đợt giao; phiếu hẹn chỉ áp dụng cho khách quen khi còn hàng chưa giao; phiếu ghi nợ chỉ áp dụng cho khách quen và phải liên kết với hóa đơn. Chứng từ, mặt hàng và khách hàng đã được nghiệp vụ sử dụng không được xóa tùy tiện.

### 2.5. Kiểm thử tổng thể

Báo cáo xác định 24 ca kiểm thử theo cấu trúc **TC – Điều kiện – Thao tác – Kết quả mong đợi**. Các ca bao quát nhập danh mục, đặt hàng, giới hạn số đợt giao, lập phiếu giao, kiểm tra tồn kho, hóa đơn, giao hẹn, thanh toán, ghi nợ, tra cứu, xóa dữ liệu đang được tham chiếu và thống kê.

## 3. Tệp báo cáo

- `Lab8.docx` – báo cáo phân tích thiết kế hướng đối tượng cho hệ thống quản lý cửa hàng nước giải khát.
- `Bai_2_Cua_hang_nuoc_giai_khat.docx` – đề bài tham khảo.

> Các mục mô hình và thiết kế trong báo cáo là nội dung bài tập; README này không khẳng định chương trình đã được triển khai hay các ca kiểm thử đã chạy trên phần mềm.
