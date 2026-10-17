-- Database/QuanLyBenhVien.sql
-- Bài 5: Quản lý hồ sơ bệnh án của bệnh nhân (SQL Server)
IF DB_ID(N'QuanLyBenhVien') IS NULL CREATE DATABASE QuanLyBenhVien;
GO
USE QuanLyBenhVien;
GO

-- Xóa bảng theo thứ tự ngược của khóa ngoại để chạy lại được nhiều lần
IF OBJECT_ID('ThanhToanVienPhi','U') IS NOT NULL DROP TABLE ThanhToanVienPhi;
IF OBJECT_ID('ChiTietToaThuoc','U') IS NOT NULL DROP TABLE ChiTietToaThuoc;
IF OBJECT_ID('ToaThuoc','U') IS NOT NULL DROP TABLE ToaThuoc;
IF OBJECT_ID('XetNghiem','U') IS NOT NULL DROP TABLE XetNghiem;
IF OBJECT_ID('PhieuKham','U') IS NOT NULL DROP TABLE PhieuKham;
IF OBJECT_ID('LichHen','U') IS NOT NULL DROP TABLE LichHen;
IF OBJECT_ID('LePhi','U') IS NOT NULL DROP TABLE LePhi;
IF OBJECT_ID('HoSoBenhAn','U') IS NOT NULL DROP TABLE HoSoBenhAn;
IF OBJECT_ID('PhieuDangKy','U') IS NOT NULL DROP TABLE PhieuDangKy;
IF OBJECT_ID('Thuoc','U') IS NOT NULL DROP TABLE Thuoc;
IF OBJECT_ID('LoaiXetNghiem','U') IS NOT NULL DROP TABLE LoaiXetNghiem;
IF OBJECT_ID('BacSi','U') IS NOT NULL DROP TABLE BacSi;
IF OBJECT_ID('Khoa','U') IS NOT NULL DROP TABLE Khoa;
IF OBJECT_ID('BenhNhan','U') IS NOT NULL DROP TABLE BenhNhan;
IF OBJECT_ID('NhanVien','U') IS NOT NULL DROP TABLE NhanVien;
GO

-- ===================== DANH MỤC =====================
CREATE TABLE NhanVien(
 MaNV varchar(20) NOT NULL PRIMARY KEY,
 HoTen nvarchar(120) NOT NULL,
 BoPhan nvarchar(50) NOT NULL
);

CREATE TABLE Khoa(
 MaKhoa varchar(20) NOT NULL PRIMARY KEY,
 TenKhoa nvarchar(100) NOT NULL UNIQUE
);

CREATE TABLE BacSi(
 MaBS varchar(20) NOT NULL PRIMARY KEY,
 MaKhoa varchar(20) NOT NULL,
 HoTen nvarchar(120) NOT NULL,
 ChuyenMon nvarchar(100) NULL,
 CONSTRAINT FK_BacSi_Khoa FOREIGN KEY(MaKhoa) REFERENCES Khoa(MaKhoa)
);

CREATE TABLE LoaiXetNghiem(
 MaLoaiXN varchar(20) NOT NULL PRIMARY KEY,
 TenXN nvarchar(120) NOT NULL UNIQUE,
 MoTa nvarchar(250) NULL
);

CREATE TABLE Thuoc(
 MaThuoc varchar(20) NOT NULL PRIMARY KEY,
 TenThuoc nvarchar(120) NOT NULL,
 DonViTinh nvarchar(40) NOT NULL,
 TacDungPhu nvarchar(250) NULL
);

-- ===================== ĐĂNG KÝ - HỒ SƠ - LỆ PHÍ =====================
CREATE TABLE BenhNhan(
 MaBN varchar(20) NOT NULL PRIMARY KEY,
 HoTen nvarchar(120) NOT NULL,
 DiaChi nvarchar(250) NOT NULL,
 NgaySinh date NOT NULL,
 DienThoai varchar(20) NOT NULL,
 Anh3x4 varbinary(max) NULL,
 CONSTRAINT CK_BenhNhan_NgaySinh CHECK(NgaySinh < CAST(GETDATE() AS date))
);

CREATE TABLE PhieuDangKy(
 SoPhieuDK varchar(30) NOT NULL PRIMARY KEY,
 MaBN varchar(20) NOT NULL,
 MaNV varchar(20) NOT NULL,
 NgayDangKy date NOT NULL DEFAULT (CAST(GETDATE() AS date)),
 CONSTRAINT FK_PhieuDK_BenhNhan FOREIGN KEY(MaBN) REFERENCES BenhNhan(MaBN),
 CONSTRAINT FK_PhieuDK_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE HoSoBenhAn(
 MaHoSo varchar(30) NOT NULL PRIMARY KEY,
 MaBN varchar(20) NOT NULL,
 NgayCap date NOT NULL DEFAULT (CAST(GETDATE() AS date)),
 TrangThai nvarchar(30) NOT NULL DEFAULT N'Còn hiệu lực',
 CONSTRAINT UQ_HoSo_BenhNhan UNIQUE(MaBN),
 CONSTRAINT CK_HoSo_TrangThai CHECK(TrangThai IN (N'Còn hiệu lực',N'Hết hạn',N'Đã đóng')),
 CONSTRAINT FK_HoSo_BenhNhan FOREIGN KEY(MaBN) REFERENCES BenhNhan(MaBN)
);

CREATE TABLE LePhi(
 MaLePhi varchar(30) NOT NULL PRIMARY KEY,
 MaHoSo varchar(30) NOT NULL,
 NamApDung int NOT NULL CHECK(NamApDung >= 2000),
 SoTien decimal(18,2) NOT NULL CHECK(SoTien > 0),
 NgayDong date NOT NULL DEFAULT (CAST(GETDATE() AS date)),
 CONSTRAINT UQ_LePhi_HoSo_Nam UNIQUE(MaHoSo,NamApDung),
 CONSTRAINT FK_LePhi_HoSo FOREIGN KEY(MaHoSo) REFERENCES HoSoBenhAn(MaHoSo)
);

CREATE TABLE LichHen(
 MaLichHen varchar(30) NOT NULL PRIMARY KEY,
 MaHoSo varchar(30) NOT NULL,
 NgayGioHen datetime NOT NULL,
 Quy int NOT NULL,
 TrangThai nvarchar(30) NOT NULL DEFAULT N'Đã hẹn',
 CONSTRAINT CK_LichHen_Quy CHECK(Quy BETWEEN 1 AND 4),
 CONSTRAINT CK_LichHen_TrangThai CHECK(TrangThai IN (N'Đã hẹn',N'Đã khám',N'Đã hủy')),
 CONSTRAINT FK_LichHen_HoSo FOREIGN KEY(MaHoSo) REFERENCES HoSoBenhAn(MaHoSo)
);

-- ===================== KHÁM BỆNH =====================
CREATE TABLE PhieuKham(
 SoPhieuKham varchar(30) NOT NULL PRIMARY KEY,
 MaHoSo varchar(30) NOT NULL,
 MaBS varchar(20) NOT NULL,
 MaKhoa varchar(20) NOT NULL,
 MaNV varchar(20) NOT NULL,
 MaLichHen varchar(30) NULL,
 NgayGioKham datetime NOT NULL,
 LoaiKham nvarchar(30) NOT NULL DEFAULT N'Khám bệnh',
 TrieuChung nvarchar(500) NULL,
 ThanNhiet decimal(4,1) NULL,
 HuyetAp varchar(20) NULL,
 KetLuan nvarchar(500) NULL,
 CONSTRAINT CK_PhieuKham_Loai CHECK(LoaiKham IN (N'Khám bệnh',N'Khám định kỳ')),
 CONSTRAINT CK_PhieuKham_ThanNhiet CHECK(ThanNhiet IS NULL OR ThanNhiet BETWEEN 30 AND 45),
 CONSTRAINT FK_PhieuKham_HoSo FOREIGN KEY(MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
 CONSTRAINT FK_PhieuKham_BacSi FOREIGN KEY(MaBS) REFERENCES BacSi(MaBS),
 CONSTRAINT FK_PhieuKham_Khoa FOREIGN KEY(MaKhoa) REFERENCES Khoa(MaKhoa),
 CONSTRAINT FK_PhieuKham_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_PhieuKham_LichHen FOREIGN KEY(MaLichHen) REFERENCES LichHen(MaLichHen)
);

CREATE TABLE XetNghiem(
 MaXN varchar(30) NOT NULL PRIMARY KEY,
 SoPhieuKham varchar(30) NOT NULL,
 MaLoaiXN varchar(20) NOT NULL,
 NgayChiDinh datetime NOT NULL,
 KetQua nvarchar(500) NULL,
 NgayCoKetQua datetime NULL,
 CONSTRAINT CK_XetNghiem_Ngay CHECK(NgayCoKetQua IS NULL OR NgayCoKetQua >= NgayChiDinh),
 CONSTRAINT FK_XetNghiem_Phieu FOREIGN KEY(SoPhieuKham) REFERENCES PhieuKham(SoPhieuKham),
 CONSTRAINT FK_XetNghiem_Loai FOREIGN KEY(MaLoaiXN) REFERENCES LoaiXetNghiem(MaLoaiXN)
);

CREATE TABLE ToaThuoc(
 MaToa varchar(30) NOT NULL PRIMARY KEY,
 SoPhieuKham varchar(30) NOT NULL,
 NgayKeToa date NOT NULL,
 LoiDan nvarchar(500) NULL,
 CONSTRAINT UQ_ToaThuoc_Phieu UNIQUE(SoPhieuKham),
 CONSTRAINT FK_ToaThuoc_Phieu FOREIGN KEY(SoPhieuKham) REFERENCES PhieuKham(SoPhieuKham)
);

CREATE TABLE ChiTietToaThuoc(
 MaToa varchar(30) NOT NULL,
 MaThuoc varchar(20) NOT NULL,
 SoLuong int NOT NULL CHECK(SoLuong > 0),
 LieuDung nvarchar(100) NOT NULL,
 CachDung nvarchar(200) NULL,
 PRIMARY KEY(MaToa,MaThuoc),
 CONSTRAINT FK_CTToa_Toa FOREIGN KEY(MaToa) REFERENCES ToaThuoc(MaToa),
 CONSTRAINT FK_CTToa_Thuoc FOREIGN KEY(MaThuoc) REFERENCES Thuoc(MaThuoc)
);

CREATE TABLE ThanhToanVienPhi(
 SoBienLai varchar(30) NOT NULL PRIMARY KEY,
 SoPhieuKham varchar(30) NOT NULL,
 NgayThanhToan datetime NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien > 0),
 HinhThuc nvarchar(30) NOT NULL,
 CONSTRAINT UQ_ThanhToan_Phieu UNIQUE(SoPhieuKham),
 CONSTRAINT CK_ThanhToan_HinhThuc CHECK(HinhThuc IN (N'Tiền mặt',N'Chuyển khoản',N'Thẻ',N'Ví điện tử')),
 CONSTRAINT FK_ThanhToan_Phieu FOREIGN KEY(SoPhieuKham) REFERENCES PhieuKham(SoPhieuKham)
);
GO

-- ===================== INDEX =====================
-- Mỗi lịch hẹn chỉ tạo tối đa một phiếu khám (MaLichHen có thể NULL)
CREATE UNIQUE INDEX UQ_PhieuKham_LichHen ON PhieuKham(MaLichHen) WHERE MaLichHen IS NOT NULL;
-- Tra cứu hồ sơ theo họ tên / ngày sinh / điện thoại
CREATE INDEX IX_BenhNhan_HoTen_NgaySinh ON BenhNhan(HoTen,NgaySinh);
CREATE INDEX IX_BenhNhan_DienThoai ON BenhNhan(DienThoai);
-- Lịch sử khám theo hồ sơ và theo bác sĩ
CREATE INDEX IX_PhieuKham_HoSo ON PhieuKham(MaHoSo,NgayGioKham);
CREATE INDEX IX_PhieuKham_BacSi ON PhieuKham(MaBS,NgayGioKham);
CREATE INDEX IX_XetNghiem_Phieu ON XetNghiem(SoPhieuKham);
CREATE INDEX IX_LichHen_HoSo ON LichHen(MaHoSo,NgayGioHen);
GO

-- ===================== TRIGGER =====================
-- Không xóa phiếu khám đã ghi nhận (truy vết trách nhiệm bác sĩ)
CREATE TRIGGER TR_PhieuKham_ChanXoa ON PhieuKham
INSTEAD OF DELETE
AS
BEGIN
 RAISERROR(N'Không được xóa phiếu khám đã ghi nhận.',16,1);
END;
GO

-- ===================== DỮ LIỆU MẪU (DANH MỤC) =====================
INSERT INTO NhanVien(MaNV,HoTen,BoPhan) VALUES
('NV01',N'Nguyễn Thu Hà',N'Chăm sóc khách hàng'),
('NV02',N'Trần Minh An',N'Xét nghiệm'),
('NV03',N'Lê Hoàng Nam',N'Thanh toán');

INSERT INTO Khoa(MaKhoa,TenKhoa) VALUES
('NOI',N'Khoa Nội'),('NGOAI',N'Khoa Ngoại'),('NHI',N'Khoa Nhi');

INSERT INTO BacSi(MaBS,MaKhoa,HoTen,ChuyenMon) VALUES
('BS01','NOI',N'Phạm Quốc Bảo',N'Nội tổng quát'),
('BS02','NGOAI',N'Võ Thanh Tùng',N'Ngoại tổng quát'),
('BS03','NHI',N'Đặng Mai Lan',N'Nhi khoa');

INSERT INTO LoaiXetNghiem(MaLoaiXN,TenXN,MoTa) VALUES
('HH',N'Huyết học',N'Công thức máu'),
('SH',N'Sinh hóa máu',N'Đường huyết, mỡ máu, chức năng gan thận'),
('XQ',N'X-quang',N'Chụp X-quang');

INSERT INTO Thuoc(MaThuoc,TenThuoc,DonViTinh,TacDungPhu) VALUES
('T01',N'Paracetamol 500mg',N'Viên',N'Hiếm gặp: dị ứng ngoài da'),
('T02',N'Amoxicillin 500mg',N'Viên',N'Rối loạn tiêu hóa, dị ứng'),
('T03',N'Vitamin C 500mg',N'Viên',NULL);
GO
