# LAB 2: HỆ THỐNG QUẢN LÝ THƯ VIỆN

**Thông tin sinh viên:**
- **Họ và tên:** Trương Kiến Phi
- **MSSV:** 1250080141
- **Ngôn ngữ / Công nghệ:** C# WinForms, .NET


---

## 1. Môi trường và Công cụ sử dụng
- **IDE:** Microsoft Visual Studio 2022
- **Framework:** .NET Framework 4.7.2
- **Hệ quản trị CSDL:** SQL Server (LocalDB / Express)

---

## 2. Nội dung đã thực hiện
- Khảo sát, phân tích yêu cầu nghiệp vụ và thiết kế các sơ đồ UML (Use Case, Activity, Sequence, Class Diagram).
- Xây dựng sơ đồ cơ sở dữ liệu (ERD) và script khởi tạo CSDL với 9 bảng (NhanVien, TheLoai, NhaXuatBan, DauSach, DocGia, TheDocGia, PhieuMuon, ChiTietPhieuMuon, PhieuPhat).
- Xây dựng lớp `Db` dùng chung để thao tác với SQL Server thông qua .NET.
- Hoàn thiện giao diện (UI) và logic (Services) cho 6 Form chức năng chính:
  1. **FrmMain:** Giao diện điều hướng chính.
  2. **FrmDanhMuc:** CRUD thông tin Nhân viên, Thể loại, Nhà xuất bản.
  3. **FrmSach:** Quản lý, tìm kiếm đầu sách và quản lý số lượng tồn kho.
  4. **FrmDocGia:** Quản lý thông tin độc giả, xử lý cấp thẻ và gia hạn thẻ thư viện.
  5. **FrmMuonTra:** Thực hiện nghiệp vụ lập phiếu mượn, nhận trả sách, tính phí phạt (có áp dụng `SqlTransaction` để đảm bảo tính toàn vẹn dữ liệu).
  6. **FrmThongKe:** Tổng hợp số liệu mượn, trả, trễ hạn, mất, hư hỏng và tính tổng tiền phạt theo tháng/khoảng ngày.

---

## 3. Kết quả đạt được
- Chương trình Build thành công, không có lỗi (0 errors).
- Các chức năng CRUD hoạt động ổn định, luồng dữ liệu được luân chuyển chính xác.
- Áp dụng chặt chẽ các ràng buộc nghiệp vụ (Business Rules) tại tầng Service (ví dụ: cấm mượn quá 3 cuốn, thẻ hết hạn không được mượn, sách quá hạn phải nộp phạt,...).
- Giao diện thân thiện, bẫy lỗi đầy đủ, sử dụng MessageBox báo lỗi thay vì văng Exception.

---

## 4. Lỗi gặp phải và Cách khắc phục
Trong quá trình thực hiện bài Lab, em có gặp một số vấn đề và đã khắc phục như sau:

- **Lỗi tải lại dữ liệu từ file backup (Restore DB/Chạy Script SQL):** 
  - *Tình trạng:* Khi cố gắng chạy file script `.sql` hoặc restore từ file backup `.bak` để nạp lại dữ liệu, hệ thống báo lỗi CSDL đang được sử dụng (in use) hoặc không kết nối được.
  - *Khắc phục:* Em đã ngắt kết nối các session đang treo trong Visual Studio. Thay vì chạy script trực tiếp trên Visual Studio, em sử dụng SQL Server Management Studio (SSMS) để chạy file script tạo bảng. Sau đó, em kiểm tra lại chuỗi kết nối (`ConnectionString`) trong file `App.config` để đảm bảo `Data Source` trỏ đúng vào instance hiện tại (VD: `(LocalDB)\MSSQLLocalDB` hoặc `.\SQLEXPRESS`).
- **Lỗi vi phạm ràng buộc khóa ngoại (Foreign Key) khi xóa:**
  - *Tình trạng:* Khi xóa một "Thể loại" hoặc "Nhà xuất bản" đã có sách tham chiếu tới, SQL Server văng lỗi Exception làm đứng chương trình.
  - *Khắc phục:* Bắt mã lỗi của SqlException (ex.Number == 547) ở tầng Service và trả về `KetQuaXuLy.Loi()` với thông báo tiếng Việt thân thiện cho người dùng trên Form.

---

## 5. Hướng dẫn cài đặt và Chạy thử (Dành cho Giảng viên)

**Bước 1: Khởi tạo Cơ sở dữ liệu (Database)**
- Mở SQL Server Management Studio (SSMS) hoặc SQL Server Object Explorer trong Visual Studio.
- Restore database từ file backup

**Bước 2: Cấu hình chuỗi kết nối (Connection String)**
- Mở file `App.config` nằm ở thư mục gốc của project.
- Tìm đến thẻ `<connectionStrings>` và cập nhật lại phần `Data Source` sao cho khớp với tên Server SQL trên máy của thầy/cô. 

**Bước 3: Build và chạy chương trình (Run)**
- Mở file solution `QuanLyThuVien.sln` bằng Visual Studio 2022.
- Trên thanh menu, chọn **Build > Rebuild Solution** để Visual Studio nạp lại các thư viện và kiểm tra lỗi.
- Nhấn phím **F5** (hoặc click nút **Start**) để khởi chạy phần mềm.
