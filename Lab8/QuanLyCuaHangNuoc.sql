/* =====================================================================
   Lab 8: Quan ly cua hang nuoc giai khat - SQL Server
   Noi dung: tao CSDL, tao bang + rang buoc, trigger, du lieu mau
   ===================================================================== */

IF DB_ID(N'QuanLyCuaHangNuoc') IS NULL
    CREATE DATABASE QuanLyCuaHangNuoc;
GO
USE QuanLyCuaHangNuoc;
GO

/* ---------- Xoa bang cu (neu chay lai) - xoa bang con truoc ---------- */
DROP TABLE IF EXISTS PhieuGhiNo;
DROP TABLE IF EXISTS ChiTietPhieuHen;
DROP TABLE IF EXISTS PhieuHen;
DROP TABLE IF EXISTS ChiTietHoaDon;
DROP TABLE IF EXISTS HoaDon;
DROP TABLE IF EXISTS ChiTietPhieuGiao;
DROP TABLE IF EXISTS PhieuGiaoHang;
DROP TABLE IF EXISTS ChiTietDonDatHang;
DROP TABLE IF EXISTS DonDatHang;
DROP TABLE IF EXISTS NuocGiaiKhat;
DROP TABLE IF EXISTS NhanVien;
DROP TABLE IF EXISTS KhachHang;
DROP TABLE IF EXISTS NhaCungCap;
DROP TABLE IF EXISTS LoaiNGK;
GO

/* ============================ TAO BANG ============================== */

CREATE TABLE LoaiNGK (
    MaLoai   VARCHAR(10)   NOT NULL,
    TenLoai  NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_LoaiNGK PRIMARY KEY (MaLoai)
);

CREATE TABLE NhaCungCap (
    MaNCC      VARCHAR(10)   NOT NULL,
    TenNCC     NVARCHAR(100) NOT NULL,
    DiaChi     NVARCHAR(200) NOT NULL,
    DienThoai  VARCHAR(15)   NOT NULL,
    CONSTRAINT PK_NhaCungCap PRIMARY KEY (MaNCC)
);

CREATE TABLE NuocGiaiKhat (
    MaNGK       VARCHAR(10)   NOT NULL,
    TenNGK      NVARCHAR(100) NOT NULL,
    DonViTinh   NVARCHAR(30)  NOT NULL,
    MaLoai      VARCHAR(10)   NOT NULL,
    MaNCC       VARCHAR(10)   NOT NULL,
    DonGia      DECIMAL(18,2) NOT NULL CONSTRAINT DF_NGK_DonGia DEFAULT 0,
    SoLuongTon  INT           NOT NULL CONSTRAINT DF_NGK_Ton DEFAULT 0,
    CONSTRAINT PK_NuocGiaiKhat PRIMARY KEY (MaNGK),
    CONSTRAINT FK_NGK_Loai FOREIGN KEY (MaLoai) REFERENCES LoaiNGK(MaLoai),
    CONSTRAINT FK_NGK_NCC  FOREIGN KEY (MaNCC)  REFERENCES NhaCungCap(MaNCC),
    CONSTRAINT CK_NGK_DonGia CHECK (DonGia >= 0),
    CONSTRAINT CK_NGK_Ton    CHECK (SoLuongTon >= 0)
);

CREATE TABLE NhanVien (
    MaNV       VARCHAR(10)   NOT NULL,
    HoTen      NVARCHAR(100) NOT NULL,
    ChucVu     NVARCHAR(50)  NOT NULL,
    DiaChi     NVARCHAR(200) NOT NULL,
    DienThoai  VARCHAR(15)   NOT NULL,
    CONSTRAINT PK_NhanVien PRIMARY KEY (MaNV)
);

CREATE TABLE KhachHang (
    MaKH       VARCHAR(10)   NOT NULL,
    HoTen      NVARCHAR(100) NOT NULL,
    DiaChi     NVARCHAR(200) NULL,
    DienThoai  VARCHAR(15)   NULL,
    LoaiKhach  NVARCHAR(20)  NOT NULL,
    CONSTRAINT PK_KhachHang PRIMARY KEY (MaKH),
    CONSTRAINT CK_KH_Loai CHECK (LoaiKhach IN (N'Khách quen', N'Khách vãng lai'))
);

CREATE TABLE DonDatHang (
    SoDDH           VARCHAR(10) NOT NULL,
    MaNCC           VARCHAR(10) NOT NULL,
    MaNV            VARCHAR(10) NOT NULL,
    NgayDat         DATE        NOT NULL,
    NgayNhanDuKien  DATE        NOT NULL,
    CONSTRAINT PK_DonDatHang PRIMARY KEY (SoDDH),
    CONSTRAINT FK_DDH_NCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
    CONSTRAINT FK_DDH_NV  FOREIGN KEY (MaNV)  REFERENCES NhanVien(MaNV),
    CONSTRAINT CK_DDH_Ngay CHECK (NgayNhanDuKien >= NgayDat)
);

CREATE TABLE ChiTietDonDatHang (
    SoDDH       VARCHAR(10) NOT NULL,
    MaNGK       VARCHAR(10) NOT NULL,
    SoLuongDat  INT         NOT NULL,
    CONSTRAINT PK_CTDDH PRIMARY KEY (SoDDH, MaNGK),
    CONSTRAINT FK_CTDDH_DDH FOREIGN KEY (SoDDH) REFERENCES DonDatHang(SoDDH),
    CONSTRAINT FK_CTDDH_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK),
    CONSTRAINT CK_CTDDH_SL CHECK (SoLuongDat > 0)
);

/* DotGiao (1..3) + UNIQUE(SoDDH, DotGiao) => moi don toi da 3 phieu giao */
CREATE TABLE PhieuGiaoHang (
    SoPhieuGiao    VARCHAR(10)   NOT NULL,
    SoDDH          VARCHAR(10)   NOT NULL,
    DotGiao        TINYINT       NOT NULL,
    NgayGiao       DATE          NOT NULL,
    SoTienPhaiTra  DECIMAL(18,2) NOT NULL,
    CONSTRAINT PK_PhieuGiaoHang PRIMARY KEY (SoPhieuGiao),
    CONSTRAINT FK_PGH_DDH FOREIGN KEY (SoDDH) REFERENCES DonDatHang(SoDDH),
    CONSTRAINT CK_PGH_Dot  CHECK (DotGiao BETWEEN 1 AND 3),
    CONSTRAINT CK_PGH_Tien CHECK (SoTienPhaiTra >= 0),
    CONSTRAINT UQ_PGH_DDH_Dot UNIQUE (SoDDH, DotGiao)
);

CREATE TABLE ChiTietPhieuGiao (
    SoPhieuGiao  VARCHAR(10) NOT NULL,
    MaNGK        VARCHAR(10) NOT NULL,
    SoLuongGiao  INT         NOT NULL,
    CONSTRAINT PK_CTPG PRIMARY KEY (SoPhieuGiao, MaNGK),
    CONSTRAINT FK_CTPG_PG  FOREIGN KEY (SoPhieuGiao) REFERENCES PhieuGiaoHang(SoPhieuGiao),
    CONSTRAINT FK_CTPG_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK),
    CONSTRAINT CK_CTPG_SL CHECK (SoLuongGiao > 0)
);

CREATE TABLE HoaDon (
    SoHD     VARCHAR(10)   NOT NULL,
    MaKH     VARCHAR(10)   NOT NULL,
    MaNV     VARCHAR(10)   NOT NULL,
    NgayLap  DATETIME      NOT NULL CONSTRAINT DF_HD_Ngay DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) NOT NULL CONSTRAINT DF_HD_Tien DEFAULT 0,
    CONSTRAINT PK_HoaDon PRIMARY KEY (SoHD),
    CONSTRAINT FK_HD_KH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_HD_NV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    CONSTRAINT CK_HD_Tien CHECK (TongTien >= 0)
);

CREATE TABLE ChiTietHoaDon (
    SoHD     VARCHAR(10)   NOT NULL,
    MaNGK    VARCHAR(10)   NOT NULL,
    SoLuong  INT           NOT NULL,
    DonGia   DECIMAL(18,2) NOT NULL,
    CONSTRAINT PK_CTHD PRIMARY KEY (SoHD, MaNGK),
    CONSTRAINT FK_CTHD_HD  FOREIGN KEY (SoHD)  REFERENCES HoaDon(SoHD),
    CONSTRAINT FK_CTHD_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK),
    CONSTRAINT CK_CTHD_SL  CHECK (SoLuong > 0),
    CONSTRAINT CK_CTHD_Gia CHECK (DonGia >= 0)
);

CREATE TABLE PhieuHen (
    SoPhieuHen  VARCHAR(10)  NOT NULL,
    SoHD        VARCHAR(10)  NOT NULL,
    NgayHen     DATE         NOT NULL,
    TrangThai   NVARCHAR(30) NOT NULL CONSTRAINT DF_PH_TT DEFAULT N'Chưa giao',
    CONSTRAINT PK_PhieuHen PRIMARY KEY (SoPhieuHen),
    CONSTRAINT FK_PH_HD FOREIGN KEY (SoHD) REFERENCES HoaDon(SoHD),
    CONSTRAINT CK_PH_TT CHECK (TrangThai IN (N'Chưa giao', N'Đã giao'))
);

CREATE TABLE ChiTietPhieuHen (
    SoPhieuHen  VARCHAR(10) NOT NULL,
    MaNGK       VARCHAR(10) NOT NULL,
    SoLuongHen  INT         NOT NULL,
    CONSTRAINT PK_CTPH PRIMARY KEY (SoPhieuHen, MaNGK),
    CONSTRAINT FK_CTPH_PH  FOREIGN KEY (SoPhieuHen) REFERENCES PhieuHen(SoPhieuHen),
    CONSTRAINT FK_CTPH_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK),
    CONSTRAINT CK_CTPH_SL CHECK (SoLuongHen > 0)
);

CREATE TABLE PhieuGhiNo (
    SoPhieuNo      VARCHAR(10)   NOT NULL,
    SoHD           VARCHAR(10)   NOT NULL,
    MaKH           VARCHAR(10)   NOT NULL,
    MaNV           VARCHAR(10)   NOT NULL,
    NgayLap        DATE          NOT NULL,
    SoTienNo       DECIMAL(18,2) NOT NULL,
    NgayDuKienTra  DATE          NOT NULL,
    LyDo           NVARCHAR(200) NOT NULL,
    CONSTRAINT PK_PhieuGhiNo PRIMARY KEY (SoPhieuNo),
    CONSTRAINT FK_PGN_HD FOREIGN KEY (SoHD) REFERENCES HoaDon(SoHD),
    CONSTRAINT FK_PGN_KH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_PGN_NV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    CONSTRAINT CK_PGN_Tien CHECK (SoTienNo > 0),
    CONSTRAINT CK_PGN_Ngay CHECK (NgayDuKienTra >= NgayLap)
);
GO

/* ============================ TRIGGER ================================ */

/* Chi khach quen moi duoc lap phieu ghi no */
CREATE TRIGGER trg_PhieuGhiNo_KhachQuen ON PhieuGhiNo
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted i
               JOIN KhachHang k ON k.MaKH = i.MaKH
               WHERE k.LoaiKhach <> N'Khách quen')
    BEGIN
        RAISERROR (N'Chỉ khách quen mới được lập phiếu ghi nợ.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

/* Chi lap phieu hen cho hoa don cua khach quen */
CREATE TRIGGER trg_PhieuHen_KhachQuen ON PhieuHen
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted i
               JOIN HoaDon h ON h.SoHD = i.SoHD
               JOIN KhachHang k ON k.MaKH = h.MaKH
               WHERE k.LoaiKhach <> N'Khách quen')
    BEGIN
        RAISERROR (N'Chỉ lập phiếu hẹn giao hàng cho khách quen.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

/* Mat hang tren phieu giao phai thuoc don dat hang tuong ung */
CREATE TRIGGER trg_CTPG_ThuocDon ON ChiTietPhieuGiao
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted i
               JOIN PhieuGiaoHang p ON p.SoPhieuGiao = i.SoPhieuGiao
               WHERE NOT EXISTS (SELECT 1 FROM ChiTietDonDatHang c
                                 WHERE c.SoDDH = p.SoDDH AND c.MaNGK = i.MaNGK))
    BEGIN
        RAISERROR (N'Mặt hàng giao không thuộc đơn đặt hàng tương ứng.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

/* =========================== DU LIEU MAU ============================= */

INSERT INTO LoaiNGK (MaLoai, TenLoai) VALUES
('L01', N'Pepsi'),
('L02', N'Coca Cola'),
('L03', N'Bia Sài Gòn'),
('L04', N'Aquafina');

INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, DienThoai) VALUES
('NCC01', N'Công ty TNHH Phân phối Pepsi Miền Nam', N'12 Nguyễn Văn Linh, Quận 7, TP.HCM', '02838123456'),
('NCC02', N'Công ty TNHH Coca Cola Phú Lâm',        N'88 Kinh Dương Vương, Quận 6, TP.HCM', '02838234567'),
('NCC03', N'Công ty CP Bia Sài Gòn Phân phối',      N'187 Nguyễn Chí Thanh, Quận 5, TP.HCM', '02838345678');

INSERT INTO NuocGiaiKhat (MaNGK, TenNGK, DonViTinh, MaLoai, MaNCC, DonGia, SoLuongTon) VALUES
('N01', N'Pepsi lon 330ml',            N'Lon',   'L01', 'NCC01',   9500, 120),
('N02', N'Pepsi chai 1.5L',            N'Chai',  'L01', 'NCC01',  18000,  80),
('N03', N'Coca Cola lon 330ml',        N'Lon',   'L02', 'NCC02',  10000, 150),
('N04', N'Coca Cola chai 1.5L',        N'Chai',  'L02', 'NCC02',  19000,  60),
('N05', N'Bia Sài Gòn Lager lon 330ml',N'Lon',   'L03', 'NCC03',  13000, 200),
('N06', N'Bia Sài Gòn thùng 24 lon',   N'Thùng', 'L03', 'NCC03', 290000,  15),
('N07', N'Aquafina chai 500ml',        N'Chai',  'L04', 'NCC01',   5000, 300);

INSERT INTO NhanVien (MaNV, HoTen, ChucVu, DiaChi, DienThoai) VALUES
('NV01', N'Nguyễn Văn An',  N'Quản lý',             N'25 Lê Lợi, Quận 1, TP.HCM',          '0901234567'),
('NV02', N'Trần Thị Bình',  N'Nhân viên bán hàng',  N'101 Cách Mạng Tháng 8, Quận 3, TP.HCM','0912345678'),
('NV03', N'Lê Minh Châu',   N'Nhân viên mua hàng',  N'45 Phan Văn Trị, Gò Vấp, TP.HCM',    '0923456789');

INSERT INTO KhachHang (MaKH, HoTen, DiaChi, DienThoai, LoaiKhach) VALUES
('KH01', N'Phạm Quốc Dũng', N'12 Trần Hưng Đạo, Quận 5, TP.HCM',  '0934567890', N'Khách quen'),
('KH02', N'Hoàng Thị Em',   N'7 Võ Văn Tần, Quận 3, TP.HCM',      '0945678901', N'Khách quen'),
('KH03', N'Vũ Văn Phúc',    NULL,                                  NULL,         N'Khách vãng lai'),
('KH04', N'Đặng Thu Giang', NULL,                                  '0956789012', N'Khách vãng lai');

/* ---- Nhap hang ---- */
INSERT INTO DonDatHang (SoDDH, MaNCC, MaNV, NgayDat, NgayNhanDuKien) VALUES
('DDH001', 'NCC01', 'NV03', '20261001', '20261008'),
('DDH002', 'NCC02', 'NV03', '20261003', '20261012'),
('DDH003', 'NCC03', 'NV03', '20261005', '20261015');

INSERT INTO ChiTietDonDatHang (SoDDH, MaNGK, SoLuongDat) VALUES
('DDH001', 'N01', 200),
('DDH001', 'N02', 100),
('DDH001', 'N07', 300),
('DDH002', 'N03', 150),
('DDH002', 'N04',  60),
('DDH003', 'N05', 200),
('DDH003', 'N06',  15);

/* DDH001 giao 2 dot; DDH002, DDH003 giao 1 dot */
INSERT INTO PhieuGiaoHang (SoPhieuGiao, SoDDH, DotGiao, NgayGiao, SoTienPhaiTra) VALUES
('PG001', 'DDH001', 1, '20261008', 1860000),
('PG002', 'DDH001', 2, '20261010', 2440000),
('PG003', 'DDH002', 1, '20261012', 2235000),
('PG004', 'DDH003', 1, '20261015', 5950000);

INSERT INTO ChiTietPhieuGiao (SoPhieuGiao, MaNGK, SoLuongGiao) VALUES
('PG001', 'N01', 120),
('PG001', 'N02',  60),
('PG002', 'N01',  80),
('PG002', 'N02',  40),
('PG002', 'N07', 300),
('PG003', 'N03', 150),
('PG003', 'N04',  60),
('PG004', 'N05', 200),
('PG004', 'N06',  15);

/* ---- Ban hang ---- */
INSERT INTO HoaDon (SoHD, MaKH, MaNV, NgayLap, TongTien) VALUES
('HD001', 'KH03', 'NV02', '20261020 09:30:00',  288000),   -- khach vang lai, du hang, tra ngay
('HD002', 'KH01', 'NV02', '20261021 14:00:00', 8700000),   -- khach quen, thieu hang -> hen giao
('HD003', 'KH02', 'NV01', '20261022 10:15:00', 1020000),   -- khach quen, tra cham
('HD004', 'KH04', 'NV02', '20261025 16:45:00',  108000);   -- khach vang lai

INSERT INTO ChiTietHoaDon (SoHD, MaNGK, SoLuong, DonGia) VALUES
('HD001', 'N01',  24,   9500),
('HD001', 'N07',  12,   5000),
('HD002', 'N06',  30, 290000),
('HD003', 'N03',  50,  10000),
('HD003', 'N05',  40,  13000),
('HD004', 'N02',   6,  18000);

/* HD002: ton kho chi con 15 thung -> giao 15 thung ngay, hen giao 15 thung con thieu */
INSERT INTO PhieuHen (SoPhieuHen, SoHD, NgayHen, TrangThai) VALUES
('PH001', 'HD002', '20261028', N'Chưa giao');

INSERT INTO ChiTietPhieuHen (SoPhieuHen, MaNGK, SoLuongHen) VALUES
('PH001', 'N06', 15);

INSERT INTO PhieuGhiNo (SoPhieuNo, SoHD, MaKH, MaNV, NgayLap, SoTienNo, NgayDuKienTra, LyDo) VALUES
('PGN001', 'HD003', 'KH02', 'NV01', '20261022', 1020000, '20261122', N'Khách quen đề nghị trả chậm đến cuối tháng'),
('PGN002', 'HD002', 'KH01', 'NV01', '20261021', 4350000, '20261115', N'Thanh toán một nửa, phần còn lại trả sau khi nhận đủ hàng');
GO

/* ====================== TRUY VAN KIEM TRA ========================== */
SELECT n.MaNGK, n.TenNGK, l.TenLoai, c.TenNCC, n.DonGia, n.SoLuongTon
FROM NuocGiaiKhat n
JOIN LoaiNGK l ON l.MaLoai = n.MaLoai
JOIN NhaCungCap c ON c.MaNCC = n.MaNCC;

SELECT h.SoHD, k.HoTen, k.LoaiKhach, h.NgayLap, h.TongTien
FROM HoaDon h JOIN KhachHang k ON k.MaKH = h.MaKH;

SELECT d.SoDDH, COUNT(p.SoPhieuGiao) AS SoDotGiao
FROM DonDatHang d LEFT JOIN PhieuGiaoHang p ON p.SoDDH = d.SoDDH
GROUP BY d.SoDDH;
GO
