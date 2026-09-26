# BÁO CÁO LAB 1 - XÁC ĐỊNH YÊU CẦU HỆ THỐNG THƯ VIỆN

## Thông tin sinh viên
* **Họ và tên:** Trương Kiến Phi
* **MSSV:** 1250080141
* **Lớp:** 12_ĐH_CNPM2

---

## Tên bài Lab
* **Tên đề tài:** Xây dựng mô hình yêu cầu chức năng và đặc tả Use Case cho Hệ thống Quản lý Thư viện (QLThuVien).

---

## Môi trường / Phiên bản
* **Công cụ mô hình hóa:**  Draw.io (để vẽ biểu đồ Use Case).
* **Ngôn ngữ mô hình hóa:** UML.
* **Tài liệu đặc tả:** Microsoft Word.

---

## Nội dung đã thực hiện
1. **Xác định yêu cầu chức năng:**
   * Liệt kê các chức năng cốt lõi dành cho **Độc giả** (tìm kiếm tài liệu, đọc trực tuyến, tải tài liệu, đăng ký mượn sách, đăng ký tài khoản, đăng nhập, đặt mua tài liệu).
   * Liệt kê các chức năng quản trị dành cho **Thủ thư** (quản lý mượn trả sách, xem tình trạng mượn, cập nhật danh mục sách, duyệt yêu cầu đặt mua).
   * Xây dựng chức năng tự động của **Hệ thống** (gửi email nhắc nhở trước hạn trả sách 3 ngày).
2. **Xây dựng bảng thuật ngữ:** Định nghĩa rõ các khái niệm: Độc giả, Thủ thư, Thẻ thư viện, Tài liệu (in/điện tử), Mượn sách, Đặt mua tài liệu,...
3. **Mô hình hóa Use Case:**
   * Xác định các Actor: *Độc giả*, *Thủ thư*, và *Hệ thống*.
   * Liệt kê 13 Use Case từ `UC01` đến `UC13`.
   * Thiết lập quan hệ `<<include>>` (ví dụ: Tải tài liệu, Đăng ký mượn, Đặt mua bao gồm các bước xác thực/đăng nhập) và `<<extend>>` (Đọc trực tuyến, Tải tài liệu mở rộng từ Tìm kiếm).
4. **Đặc tả chi tiết Use Case:** Viết chi tiết cho từng Use Case bao gồm: Tên, ID, Actor, Mô tả, Tiền/Hậu điều kiện, Luồng sự kiện chính và Luồng sự kiện thay thế.

---

## Kết quả đạt được
* Hoàn thiện sơ đồ Use Case tổng quát cho hệ thống quản lý thư viện.
* Hoàn thành bảng đặc tả chi tiết cho 13 Use Case (`UC01` - `UC13`), làm tiền đề cho giai đoạn thiết kế cơ sở dữ liệu và hiện thực hóa hệ thống ở các lab tiếp theo.

---

## Lỗi gặp phải & Cách khắc phục
* **Lỗi 1:** Nhầm lẫn giữa quan hệ `<<include>>` và `<<extend>>` khi phân tích các chức năng phụ thuộc (ví dụ: việc nhập mã thẻ thư viện khi tải sách hoặc mượn sách).
  * **Cách khắc phục:** Xem xét kỹ tính bắt buộc của luồng. Nếu luồng con luôn luôn phải thực hiện mỗi khi luồng chính chạy thì dùng `<<include>>`; nếu chỉ xảy ra trong điều kiện/nhánh phụ thì dùng `<<extend>>`.
* **Lỗi 2:** Thiếu sót Actor phụ trợ cho các tác vụ tự động (như gửi email nhắc nhở).
  * **Cách khắc phục:** Bổ sung Actor `Hệ thống` (Timer) để kích hoạt tự động Use Case `UC12` theo định kỳ.
