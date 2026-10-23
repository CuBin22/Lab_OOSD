
IF DB_ID(N'QuanLyNhanSu') IS NULL CREATE DATABASE QuanLyNhanSu;
GO
USE QuanLyNhanSu;
GO

IF OBJECT_ID('vw_HopDongDaiHanThieuBaoHiem','V') IS NOT NULL DROP VIEW vw_HopDongDaiHanThieuBaoHiem;
IF OBJECT_ID('PhieuThuNopPhat','U') IS NOT NULL DROP TABLE PhieuThuNopPhat;
IF OBJECT_ID('PhieuChiKhenThuong','U') IS NOT NULL DROP TABLE PhieuChiKhenThuong;
IF OBJECT_ID('QuyetDinhKyLuat','U') IS NOT NULL DROP TABLE QuyetDinhKyLuat;
IF OBJECT_ID('QuyetDinhKhenThuong','U') IS NOT NULL DROP TABLE QuyetDinhKhenThuong;
IF OBJECT_ID('BangLuong','U') IS NOT NULL DROP TABLE BangLuong;
IF OBJECT_ID('ChiTietPhieuPhuTroi','U') IS NOT NULL DROP TABLE ChiTietPhieuPhuTroi;
IF OBJECT_ID('PhieuPhuTroi','U') IS NOT NULL DROP TABLE PhieuPhuTroi;
IF OBJECT_ID('PhieuChamCong','U') IS NOT NULL DROP TABLE PhieuChamCong;
IF OBJECT_ID('ChiTietPhanCong','U') IS NOT NULL DROP TABLE ChiTietPhanCong;
IF OBJECT_ID('KeHoachPhanCong','U') IS NOT NULL DROP TABLE KeHoachPhanCong;
IF OBJECT_ID('QuyetDinhLuong','U') IS NOT NULL DROP TABLE QuyetDinhLuong;
IF OBJECT_ID('QuyetDinhChucVu','U') IS NOT NULL DROP TABLE QuyetDinhChucVu;
IF OBJECT_ID('HoSoBaoHiem','U') IS NOT NULL DROP TABLE HoSoBaoHiem;
IF OBJECT_ID('HopDong','U') IS NOT NULL DROP TABLE HopDong;
IF OBJECT_ID('QuyetDinhTuyenDung','U') IS NOT NULL DROP TABLE QuyetDinhTuyenDung;
IF OBJECT_ID('NhanVien','U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('PhongBan','U') IS NOT NULL DROP TABLE PhongBan;
GO

CREATE TABLE PhongBan(
    MaPhongBan  varchar(20)   NOT NULL PRIMARY KEY,
    TenPhongBan nvarchar(100) NOT NULL UNIQUE,
    MoTa        nvarchar(250) NULL
);

CREATE TABLE NhanVien(
    MaNV        varchar(20)   NOT NULL PRIMARY KEY,
    HoTen       nvarchar(120) NOT NULL,
    CCCD        varchar(20)   NOT NULL UNIQUE,
    NgaySinh    date          NULL,
    GioiTinh    nvarchar(10)  NULL,
    DiaChi      nvarchar(250) NULL,
    SoDienThoai varchar(20)   NULL,
    MaPhongBan  varchar(20)   NULL,          
    VaiTro      nvarchar(50)  NULL,          
    TrangThai   nvarchar(30)  NOT NULL DEFAULT N'Thử việc',
    CONSTRAINT CK_NhanVien_GioiTinh  CHECK(GioiTinh IS NULL OR GioiTinh IN (N'Nam',N'Nữ',N'Khác')),
    CONSTRAINT CK_NhanVien_TrangThai CHECK(TrangThai IN (N'Thử việc',N'Chính thức',N'Đã nghỉ')),
    CONSTRAINT FK_NhanVien_PhongBan  FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

CREATE TABLE QuyetDinhTuyenDung(
    SoQDTD             varchar(30)   NOT NULL PRIMARY KEY,
    MaNV               varchar(20)   NOT NULL UNIQUE,   
    MaPhongBan         varchar(20)   NOT NULL,          
    NgayKy             date          NOT NULL,
    NgayBatDauThuViec  date          NOT NULL,
    NgayKetThucThuViec date          NOT NULL,
    LuongThuViec       decimal(18,2) NOT NULL,
    DieuKhoan          nvarchar(max) NULL,              
    MaNguoiKy          varchar(20)   NOT NULL,
    CONSTRAINT CK_QDTD_ThoiGian CHECK(NgayKetThucThuViec > NgayBatDauThuViec),
    CONSTRAINT CK_QDTD_Luong    CHECK(LuongThuViec > 0),
    CONSTRAINT FK_QDTD_NV       FOREIGN KEY(MaNV)       REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_QDTD_PB       FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan),
    CONSTRAINT FK_QDTD_NguoiKy  FOREIGN KEY(MaNguoiKy)  REFERENCES NhanVien(MaNV)
);

CREATE TABLE HopDong(
    SoHopDong   varchar(30)  NOT NULL PRIMARY KEY,
    MaNV        varchar(20)  NOT NULL,
    SoQDTD      varchar(30)  NOT NULL,
    LoaiHopDong nvarchar(20) NOT NULL,
    NgayKy      date         NOT NULL,
    NgayBatDau  date         NOT NULL,
    NgayKetThuc date         NULL,                      
    TrangThai   nvarchar(30) NOT NULL DEFAULT N'Hiệu lực',
    CONSTRAINT CK_HopDong_Loai      CHECK(LoaiHopDong IN (N'Dài hạn',N'Ngắn hạn')),
    CONSTRAINT CK_HopDong_Ngay      CHECK(NgayBatDau >= NgayKy AND (NgayKetThuc IS NULL OR NgayKetThuc >= NgayBatDau)),
    CONSTRAINT CK_HopDong_NganHan   CHECK(LoaiHopDong = N'Dài hạn' OR NgayKetThuc IS NOT NULL),
    CONSTRAINT CK_HopDong_TrangThai CHECK(TrangThai IN (N'Hiệu lực',N'Hết hạn',N'Chấm dứt')),
    CONSTRAINT FK_HopDong_NV        FOREIGN KEY(MaNV)   REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_HopDong_QDTD      FOREIGN KEY(SoQDTD) REFERENCES QuyetDinhTuyenDung(SoQDTD)
);

CREATE TABLE HoSoBaoHiem(
    MaHoSoBH    int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MaNV        varchar(20)  NOT NULL,
    SoHopDong   varchar(30)  NOT NULL,                  
    LoaiBaoHiem nvarchar(10) NOT NULL,
    SoSoBH      varchar(30)  NULL,
    NgayLap     date         NOT NULL,
    MucDong     decimal(5,2) NOT NULL,                 
    CONSTRAINT CK_HSBH_Loai   CHECK(LoaiBaoHiem IN (N'BHYT',N'BHXH')),
    CONSTRAINT CK_HSBH_Muc    CHECK(MucDong >= 0 AND MucDong <= 100),
    CONSTRAINT UQ_HSBH_NV_Loai UNIQUE(MaNV,LoaiBaoHiem),
    CONSTRAINT FK_HSBH_NV     FOREIGN KEY(MaNV)      REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_HSBH_HD     FOREIGN KEY(SoHopDong) REFERENCES HopDong(SoHopDong)
);


CREATE TABLE QuyetDinhChucVu(
    SoQDCV         varchar(30)   NOT NULL PRIMARY KEY,
    MaNV           varchar(20)   NOT NULL,
    ChucVu         nvarchar(80)  NOT NULL,
    PhuCapChucVu   decimal(18,2) NOT NULL DEFAULT 0,
    NgayHieuLuc    date          NOT NULL,
    MaNguoiKy      varchar(20)   NOT NULL,
    CONSTRAINT CK_QDCV_PhuCap  CHECK(PhuCapChucVu >= 0),
    CONSTRAINT UQ_QDCV_NV_Ngay UNIQUE(MaNV,NgayHieuLuc),
    CONSTRAINT FK_QDCV_NV      FOREIGN KEY(MaNV)      REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_QDCV_NguoiKy FOREIGN KEY(MaNguoiKy) REFERENCES NhanVien(MaNV)
);

CREATE TABLE QuyetDinhLuong(
    SoQDL         varchar(30)   NOT NULL PRIMARY KEY,
    MaNV          varchar(20)   NOT NULL,
    LuongCoBan    decimal(18,2) NOT NULL,
    PhuCapLuong   decimal(18,2) NOT NULL DEFAULT 0,
    PhuCapDocHai  decimal(18,2) NOT NULL DEFAULT 0,
    NgayHieuLuc   date          NOT NULL,
    MaNguoiKy     varchar(20)   NOT NULL,
    CONSTRAINT CK_QDL_Luong    CHECK(LuongCoBan > 0),
    CONSTRAINT CK_QDL_PhuCap   CHECK(PhuCapLuong >= 0 AND PhuCapDocHai >= 0),
    CONSTRAINT UQ_QDL_NV_Ngay  UNIQUE(MaNV,NgayHieuLuc),
    CONSTRAINT FK_QDL_NV       FOREIGN KEY(MaNV)      REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_QDL_NguoiKy  FOREIGN KEY(MaNguoiKy) REFERENCES NhanVien(MaNV)
);


CREATE TABLE KeHoachPhanCong(
    SoKeHoach    varchar(30) NOT NULL PRIMARY KEY,
    MaNguoiLap   varchar(20) NOT NULL,                  
    MaPhongBan   varchar(20) NOT NULL,
    TuNgay       date        NOT NULL,
    DenNgay      date        NOT NULL,                  
    CONSTRAINT CK_KHPC_Ngay CHECK(DenNgay >= TuNgay AND DATEDIFF(DAY,TuNgay,DenNgay) <= 6),
    CONSTRAINT FK_KHPC_NV   FOREIGN KEY(MaNguoiLap) REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_KHPC_PB   FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

CREATE TABLE ChiTietPhanCong(
    SoKeHoach    varchar(30)  NOT NULL,
    MaNV         varchar(20)  NOT NULL,
    NgayLamViec  date         NOT NULL,
    Ca           nvarchar(20) NOT NULL,
    CoPhuTroi    bit          NOT NULL DEFAULT 0,       
    PRIMARY KEY(SoKeHoach,MaNV,NgayLamViec,Ca),
    CONSTRAINT UQ_CTPC_NV_Ngay_Ca UNIQUE(MaNV,NgayLamViec,Ca),
    CONSTRAINT CK_CTPC_Ca  CHECK(Ca IN (N'Sáng',N'Chiều',N'Tối')),
    CONSTRAINT FK_CTPC_KH  FOREIGN KEY(SoKeHoach) REFERENCES KeHoachPhanCong(SoKeHoach),
    CONSTRAINT FK_CTPC_NV  FOREIGN KEY(MaNV)      REFERENCES NhanVien(MaNV)
);

CREATE TABLE PhieuChamCong(
    SoPhieuCC   varchar(30)  NOT NULL PRIMARY KEY,
    MaNV        varchar(20)  NOT NULL,              
    MaNVLap     varchar(20)  NOT NULL,                 
    NgayCong    date         NOT NULL,
    Ca          nvarchar(20) NOT NULL,
    SoGioLam    decimal(4,2) NOT NULL,
    GhiChu      nvarchar(200) NULL,
    CONSTRAINT CK_PCC_Ca      CHECK(Ca IN (N'Sáng',N'Chiều',N'Tối')),
    CONSTRAINT CK_PCC_SoGio   CHECK(SoGioLam >= 0 AND SoGioLam <= 24),
    CONSTRAINT UQ_PCC_NV_Ngay_Ca UNIQUE(MaNV,NgayCong,Ca),
    CONSTRAINT FK_PCC_NV      FOREIGN KEY(MaNV)    REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_PCC_NVLap   FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);

CREATE TABLE PhieuPhuTroi(
    SoPhieuPT     varchar(30)  NOT NULL PRIMARY KEY,
    NgayPhuTroi   date         NOT NULL,
    SoGioPhuTroi  decimal(4,2) NOT NULL,
    HinhThuc      nvarchar(20) NOT NULL,
    HeSoPhuTroi   decimal(3,1) NOT NULL DEFAULT 1.5,    
    MaNVLap       varchar(20)  NOT NULL,                
    CONSTRAINT CK_PPT_SoGio   CHECK(SoGioPhuTroi > 0 AND SoGioPhuTroi <= 24),
    CONSTRAINT CK_PPT_HinhThuc CHECK(HinhThuc IN (N'Tăng ca',N'Ngày lễ',N'Ngày nghỉ')),
    CONSTRAINT CK_PPT_HeSo    CHECK(HeSoPhuTroi = 1.5),
    CONSTRAINT FK_PPT_NVLap   FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);

CREATE TABLE ChiTietPhieuPhuTroi(
    SoPhieuPT  varchar(30) NOT NULL,
    MaNV       varchar(20) NOT NULL,
    GhiChu     nvarchar(200) NULL,
    PRIMARY KEY(SoPhieuPT,MaNV),                        
    CONSTRAINT FK_CTPPT_Phieu FOREIGN KEY(SoPhieuPT) REFERENCES PhieuPhuTroi(SoPhieuPT),
    CONSTRAINT FK_CTPPT_NV    FOREIGN KEY(MaNV)      REFERENCES NhanVien(MaNV)
);

CREATE TABLE QuyetDinhKhenThuong(
    SoQDKT         varchar(30)   NOT NULL PRIMARY KEY,
    NgayKy         date          NOT NULL,
    LoaiKhenThuong nvarchar(30)  NOT NULL,
    MaNV           varchar(20)   NULL,                 
    MaPhongBan     varchar(20)   NULL,                
    SoTien         decimal(18,2) NOT NULL,
    NoiDung        nvarchar(250) NULL,
    MaNguoiKy      varchar(20)   NOT NULL,            
    CONSTRAINT CK_QDKT_Loai CHECK(LoaiKhenThuong IN (N'Thành tích',N'Ngày lễ',N'Thưởng cuối năm',N'Lương tháng 13')),
    CONSTRAINT CK_QDKT_Tien CHECK(SoTien > 0),
    CONSTRAINT CK_QDKT_DoiTuong CHECK((MaNV IS NOT NULL AND MaPhongBan IS NULL) OR (MaNV IS NULL AND MaPhongBan IS NOT NULL)),
    CONSTRAINT FK_QDKT_NV      FOREIGN KEY(MaNV)       REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_QDKT_PB      FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan),
    CONSTRAINT FK_QDKT_NguoiKy FOREIGN KEY(MaNguoiKy)  REFERENCES NhanVien(MaNV)
);

CREATE TABLE QuyetDinhKyLuat(
    SoQDKL        varchar(30)   NOT NULL PRIMARY KEY,
    NgayKy        date          NOT NULL,
    HinhThucXuLy  nvarchar(50)  NOT NULL,
    MaNV          varchar(20)   NULL,                  
    MaPhongBan    varchar(20)   NULL,                 
    SoTienPhat    decimal(18,2) NOT NULL DEFAULT 0,
    LyDo          nvarchar(250) NULL,
    MaNguoiKy     varchar(20)   NOT NULL,
    CONSTRAINT CK_QDKL_Tien CHECK(SoTienPhat >= 0),
    CONSTRAINT CK_QDKL_DoiTuong CHECK((MaNV IS NOT NULL AND MaPhongBan IS NULL) OR (MaNV IS NULL AND MaPhongBan IS NOT NULL)),
    CONSTRAINT FK_QDKL_NV      FOREIGN KEY(MaNV)       REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_QDKL_PB      FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan),
    CONSTRAINT FK_QDKL_NguoiKy FOREIGN KEY(MaNguoiKy)  REFERENCES NhanVien(MaNV)
);

CREATE TABLE PhieuChiKhenThuong(
    SoPhieuChi  varchar(30)   NOT NULL PRIMARY KEY,
    SoQDKT      varchar(30)   NOT NULL UNIQUE,          
    NgayChi     date          NOT NULL,
    SoTien      decimal(18,2) NOT NULL,
    MaNVLap     varchar(20)   NOT NULL,
    CONSTRAINT CK_PCKT_Tien CHECK(SoTien > 0),
    CONSTRAINT FK_PCKT_QD   FOREIGN KEY(SoQDKT)  REFERENCES QuyetDinhKhenThuong(SoQDKT),
    CONSTRAINT FK_PCKT_NV   FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);

CREATE TABLE PhieuThuNopPhat(
    SoPhieuThu   varchar(30)   NOT NULL PRIMARY KEY,
    SoQDKL       varchar(30)   NOT NULL UNIQUE,        
    NgayThu      date          NOT NULL,
    HinhThucThu  nvarchar(30)  NOT NULL,
    SoTien       decimal(18,2) NOT NULL,
    MaNVLap      varchar(20)   NOT NULL,
    CONSTRAINT CK_PTNP_Hinh CHECK(HinhThucThu IN (N'Nộp trực tiếp',N'Trừ lương')),
    CONSTRAINT CK_PTNP_Tien CHECK(SoTien > 0),
    CONSTRAINT FK_PTNP_QD   FOREIGN KEY(SoQDKL)  REFERENCES QuyetDinhKyLuat(SoQDKL),
    CONSTRAINT FK_PTNP_NV   FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);

CREATE TABLE BangLuong(
    SoBangLuong      varchar(30)   NOT NULL PRIMARY KEY,
    MaNV             varchar(20)   NOT NULL,
    Thang            int           NOT NULL,
    Nam              int           NOT NULL,
    LuongCoBan       decimal(18,2) NOT NULL DEFAULT 0, 
    PhuCap           decimal(18,2) NOT NULL DEFAULT 0,  
    TienPhuTroi      decimal(18,2) NOT NULL DEFAULT 0,  
    TienThuong       decimal(18,2) NOT NULL DEFAULT 0,  
    KhoanTruBaoHiem  decimal(18,2) NOT NULL DEFAULT 0,  
    TienPhat         decimal(18,2) NOT NULL DEFAULT 0, 
    ThucLanh AS (CONVERT(decimal(18,2),
                 LuongCoBan + PhuCap + TienPhuTroi + TienThuong - KhoanTruBaoHiem - TienPhat)) PERSISTED,
    CONSTRAINT CK_BL_Thang CHECK(Thang BETWEEN 1 AND 12),
    CONSTRAINT CK_BL_Nam   CHECK(Nam > 0),
    CONSTRAINT CK_BL_Tien  CHECK(LuongCoBan >= 0 AND PhuCap >= 0 AND TienPhuTroi >= 0
                                 AND TienThuong >= 0 AND KhoanTruBaoHiem >= 0 AND TienPhat >= 0),
    CONSTRAINT UQ_BL_NV_Thang_Nam UNIQUE(MaNV,Thang,Nam),
    CONSTRAINT FK_BL_NV    FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE INDEX IX_HopDong_NV      ON HopDong(MaNV,TrangThai,NgayBatDau,NgayKetThuc);
CREATE INDEX IX_PCC_NgayCong    ON PhieuChamCong(NgayCong,MaNV);
CREATE INDEX IX_PPT_Ngay        ON PhieuPhuTroi(NgayPhuTroi);
CREATE INDEX IX_BL_ThangNam     ON BangLuong(Nam,Thang);
GO


CREATE TRIGGER trg_HopDong_KiemTra ON HopDong
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1
              FROM inserted i
              JOIN QuyetDinhTuyenDung q ON q.SoQDTD = i.SoQDTD
              WHERE i.MaNV <> q.MaNV OR i.NgayKy < q.NgayKetThucThuViec)
    BEGIN
        RAISERROR(N'Hợp đồng phải thuộc đúng nhân viên của quyết định tuyển dụng và chỉ được ký sau khi hết thời gian thử việc.',16,1);
        ROLLBACK TRANSACTION; RETURN;
    END

    IF EXISTS(SELECT 1
              FROM inserted i
              JOIN HopDong h ON h.MaNV = i.MaNV AND h.SoHopDong <> i.SoHopDong
              WHERE i.TrangThai = N'Hiệu lực' AND h.TrangThai = N'Hiệu lực'
                AND i.NgayBatDau <= ISNULL(h.NgayKetThuc,'9999-12-31')
                AND h.NgayBatDau <= ISNULL(i.NgayKetThuc,'9999-12-31'))
    BEGIN
        RAISERROR(N'Nhân viên đã có hợp đồng đang hiệu lực trong khoảng thời gian này.',16,1);
        ROLLBACK TRANSACTION; RETURN;
    END
END;
GO

CREATE TRIGGER trg_HoSoBaoHiem_KiemTra ON HoSoBaoHiem
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT 1
              FROM inserted i
              JOIN HopDong h ON h.SoHopDong = i.SoHopDong
              WHERE h.LoaiHopDong <> N'Dài hạn' OR h.MaNV <> i.MaNV)
    BEGIN
        RAISERROR(N'Chỉ làm hồ sơ BHYT/BHXH cho nhân viên có hợp đồng dài hạn.',16,1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER trg_PhieuChiKT_KiemTra ON PhieuChiKhenThuong
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT 1
              FROM inserted i
              JOIN QuyetDinhKhenThuong q ON q.SoQDKT = i.SoQDKT
              WHERE i.SoTien <> q.SoTien)
    BEGIN
        RAISERROR(N'Số tiền phiếu chi phải bằng số tiền trong quyết định khen thưởng.',16,1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER trg_PhieuThuNP_KiemTra ON PhieuThuNopPhat
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT 1
              FROM inserted i
              JOIN QuyetDinhKyLuat q ON q.SoQDKL = i.SoQDKL
              WHERE i.SoTien <> q.SoTienPhat)
    BEGIN
        RAISERROR(N'Số tiền phiếu thu phải bằng số tiền phạt trong quyết định kỷ luật.',16,1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE VIEW vw_HopDongDaiHanThieuBaoHiem AS
SELECT h.SoHopDong, h.MaNV, nv.HoTen,
       COUNT(DISTINCT b.LoaiBaoHiem) AS SoLoaiDaCo
FROM HopDong h
JOIN NhanVien nv ON nv.MaNV = h.MaNV
LEFT JOIN HoSoBaoHiem b ON b.MaNV = h.MaNV
WHERE h.LoaiHopDong = N'Dài hạn' AND h.TrangThai = N'Hiệu lực'
GROUP BY h.SoHopDong, h.MaNV, nv.HoTen
HAVING COUNT(DISTINCT b.LoaiBaoHiem) < 2;
GO

INSERT INTO PhongBan(MaPhongBan,TenPhongBan) VALUES
('TCKT',N'Phòng tài chính kế toán'),('KT',N'Phòng kỹ thuật'),('SX',N'Phòng sản xuất');

INSERT INTO NhanVien(MaNV,HoTen,CCCD,MaPhongBan,VaiTro,TrangThai) VALUES
('NV001',N'Nguyễn Văn Giám',  '079000000001','TCKT',N'Giám đốc',     N'Chính thức'),
('NV002',N'Trần Thị Trưởng',  '079000000002','SX',  N'Trưởng phòng', N'Chính thức'),
('NV003',N'Lê Thu Chấm',      '079000000003','TCKT',N'Ban chấm công',N'Chính thức'),
('NV004',N'Phạm Minh Tuấn',   '079000000004','SX',  N'Nhân viên',    N'Chính thức');

INSERT INTO QuyetDinhTuyenDung(SoQDTD,MaNV,MaPhongBan,NgayKy,NgayBatDauThuViec,NgayKetThucThuViec,LuongThuViec,DieuKhoan,MaNguoiKy) VALUES
('TD001','NV004','SX','2026-01-02','2026-01-02','2026-03-02',6000000,N'Thử việc 2 tháng tại phòng sản xuất','NV001');

INSERT INTO HopDong(SoHopDong,MaNV,SoQDTD,LoaiHopDong,NgayKy,NgayBatDau,NgayKetThuc,TrangThai) VALUES
('HD001','NV004','TD001',N'Dài hạn','2026-03-03','2026-03-03',NULL,N'Hiệu lực');

INSERT INTO HoSoBaoHiem(MaNV,SoHopDong,LoaiBaoHiem,SoSoBH,NgayLap,MucDong) VALUES
('NV004','HD001',N'BHYT','YT0001','2026-03-03',1.5),
('NV004','HD001',N'BHXH','XH0001','2026-03-03',8);

INSERT INTO QuyetDinhChucVu(SoQDCV,MaNV,ChucVu,PhuCapChucVu,NgayHieuLuc,MaNguoiKy) VALUES
('CV001','NV004',N'Công nhân sản xuất',0,'2026-03-03','NV001');

INSERT INTO QuyetDinhLuong(SoQDL,MaNV,LuongCoBan,PhuCapLuong,PhuCapDocHai,NgayHieuLuc,MaNguoiKy) VALUES
('L001','NV004',8000000,500000,300000,'2026-03-03','NV001');

INSERT INTO KeHoachPhanCong(SoKeHoach,MaNguoiLap,MaPhongBan,TuNgay,DenNgay) VALUES
('KH001','NV002','SX','2026-03-09','2026-03-15');
INSERT INTO ChiTietPhanCong(SoKeHoach,MaNV,NgayLamViec,Ca,CoPhuTroi) VALUES
('KH001','NV004','2026-03-09',N'Sáng',0),('KH001','NV004','2026-03-10',N'Sáng',1);

INSERT INTO PhieuChamCong(SoPhieuCC,MaNV,MaNVLap,NgayCong,Ca,SoGioLam) VALUES
('CC001','NV004','NV003','2026-03-09',N'Sáng',8);

INSERT INTO PhieuPhuTroi(SoPhieuPT,NgayPhuTroi,SoGioPhuTroi,HinhThuc,MaNVLap) VALUES
('PT001','2026-03-10',3,N'Tăng ca','NV003');
INSERT INTO ChiTietPhieuPhuTroi(SoPhieuPT,MaNV) VALUES ('PT001','NV004');

INSERT INTO QuyetDinhKhenThuong(SoQDKT,NgayKy,LoaiKhenThuong,MaNV,SoTien,NoiDung,MaNguoiKy) VALUES
('KT001','2026-04-30',N'Ngày lễ','NV004',500000,N'Thưởng lễ 30/4','NV001');
INSERT INTO PhieuChiKhenThuong(SoPhieuChi,SoQDKT,NgayChi,SoTien,MaNVLap) VALUES
('PC001','KT001','2026-04-30',500000,'NV003');

INSERT INTO QuyetDinhKyLuat(SoQDKL,NgayKy,HinhThucXuLy,MaNV,SoTienPhat,LyDo,MaNguoiKy) VALUES
('KL001','2026-03-20',N'Phạt tiền đi trễ','NV004',100000,N'Đi trễ nhiều lần','NV001');
INSERT INTO PhieuThuNopPhat(SoPhieuThu,SoQDKL,NgayThu,HinhThucThu,SoTien,MaNVLap) VALUES
('PTH001','KL001','2026-03-31',N'Trừ lương',100000,'NV003');

INSERT INTO BangLuong(SoBangLuong,MaNV,Thang,Nam,LuongCoBan,PhuCap,TienPhuTroi,TienThuong,KhoanTruBaoHiem,TienPhat) VALUES
('BL202603-NV004','NV004',3,2026,8000000,800000,185000,0,760000,100000);
GO
