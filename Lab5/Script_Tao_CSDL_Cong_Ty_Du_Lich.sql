/* =====================================================================
   CSDL: QUẢN LÝ CÔNG TY DU LỊCH
   Hệ quản trị: Microsoft SQL Server 2016 trở lên (T-SQL)
   Nội dung   : tạo CSDL, 18 bảng, khóa, ràng buộc CHECK/UNIQUE,
                trigger cho ràng buộc liên bảng, stored procedure
                lập phiếu đăng ký đoàn (1 transaction)
   ===================================================================== */

IF DB_ID(N'QuanLyCongTyDuLich') IS NULL
    CREATE DATABASE QuanLyCongTyDuLich COLLATE Vietnamese_CI_AS;
GO
USE QuanLyCongTyDuLich;
GO
SET NOCOUNT ON;
GO

/* ---------------------------------------------------------------------
   0. XÓA ĐỐI TƯỢNG CŨ (để chạy lại nhiều lần)
   --------------------------------------------------------------------- */
DROP PROCEDURE IF EXISTS dbo.sp_LapPhieuDoan;
DROP TYPE IF EXISTS dbo.DSThanhVienDoan;
DROP TABLE IF EXISTS dbo.PhieuKhaoSat;
DROP TABLE IF EXISTS dbo.PhanCong;
DROP TABLE IF EXISTS dbo.ThanhToan;
DROP TABLE IF EXISTS dbo.ThanhVienDoan;
DROP TABLE IF EXISTS dbo.PhieuDangKyChuyen;
DROP TABLE IF EXISTS dbo.PhieuDangKyDoan;
DROP TABLE IF EXISTS dbo.PhieuDangKy;
DROP TABLE IF EXISTS dbo.KhachHang;
DROP TABLE IF EXISTS dbo.ChuyenTour;
DROP TABLE IF EXISTS dbo.ChiTietTourDiemTQ;
DROP TABLE IF EXISTS dbo.DiemThamQuan;
DROP TABLE IF EXISTS dbo.DungChan;
DROP TABLE IF EXISTS dbo.PhuongTien;
DROP TABLE IF EXISTS dbo.DiaDiem;
DROP TABLE IF EXISTS dbo.Tour;
DROP TABLE IF EXISTS dbo.NhanVien;
DROP TABLE IF EXISTS dbo.DiemDon;
DROP TABLE IF EXISTS dbo.DiemBanVe;
DROP SEQUENCE IF EXISTS dbo.seq_SoPhieu;
DROP SEQUENCE IF EXISTS dbo.seq_MaTV;
DROP SEQUENCE IF EXISTS dbo.seq_MaThanhToan;
GO

/* ---------------------------------------------------------------------
   1. SEQUENCE sinh mã tự động
   --------------------------------------------------------------------- */
CREATE SEQUENCE dbo.seq_SoPhieu     AS int START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE dbo.seq_MaTV        AS int START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE dbo.seq_MaThanhToan AS int START WITH 1 INCREMENT BY 1;
GO

/* ---------------------------------------------------------------------
   2. CÁC BẢNG DANH MỤC
   --------------------------------------------------------------------- */
CREATE TABLE dbo.Tour (
    MaTour   varchar(20)    NOT NULL,
    TenTour  nvarchar(100)  NOT NULL,
    SoNgay   int            NOT NULL,
    SoDem    int            NOT NULL,
    DonGia   decimal(18,2)  NOT NULL,
    CONSTRAINT PK_Tour        PRIMARY KEY (MaTour),
    CONSTRAINT CK_Tour_SoNgay CHECK (SoNgay > 0),
    CONSTRAINT CK_Tour_SoDem  CHECK (SoDem >= 0),
    CONSTRAINT CK_Tour_DonGia CHECK (DonGia >= 0)
);

CREATE TABLE dbo.DiaDiem (
    MaDiaDiem   varchar(20)    NOT NULL,
    TenDiaDiem  nvarchar(100)  NOT NULL,
    CONSTRAINT PK_DiaDiem PRIMARY KEY (MaDiaDiem)
);

CREATE TABLE dbo.PhuongTien (
    MaPT   varchar(20)   NOT NULL,
    TenPT  nvarchar(50)  NOT NULL,
    CONSTRAINT PK_PhuongTien PRIMARY KEY (MaPT)
);

CREATE TABLE dbo.DiemThamQuan (
    MaDiemTQ   varchar(20)    NOT NULL,
    TenDiemTQ  nvarchar(100)  NOT NULL,
    DiaDiem    nvarchar(100)  NULL,
    NoiDung    nvarchar(500)  NULL,
    YNghia     nvarchar(500)  NULL,
    CONSTRAINT PK_DiemThamQuan PRIMARY KEY (MaDiemTQ)
);

CREATE TABLE dbo.DiemBanVe (
    MaDiemBan   varchar(20)    NOT NULL,
    TenDiemBan  nvarchar(100)  NOT NULL,
    DiaChi      nvarchar(200)  NULL,
    DienThoai   varchar(15)    NULL,
    CONSTRAINT PK_DiemBanVe PRIMARY KEY (MaDiemBan)
);

CREATE TABLE dbo.DiemDon (
    MaDiemDon   varchar(20)    NOT NULL,
    TenDiemDon  nvarchar(100)  NOT NULL,
    DiaChi      nvarchar(200)  NULL,
    CONSTRAINT PK_DiemDon PRIMARY KEY (MaDiemDon)
);

CREATE TABLE dbo.NhanVien (
    MaNV         varchar(20)    NOT NULL,
    HoTen        nvarchar(100)  NOT NULL,
    DiaChi       nvarchar(200)  NULL,
    DienThoai    varchar(15)    NULL,
    LuongCanBan  decimal(18,2)  NOT NULL CONSTRAINT DF_NhanVien_Luong DEFAULT 0,
    CONSTRAINT PK_NhanVien      PRIMARY KEY (MaNV),
    CONSTRAINT CK_NhanVien_Luong CHECK (LuongCanBan >= 0)
);
GO

/* ---------------------------------------------------------------------
   3. LỘ TRÌNH TOUR
   --------------------------------------------------------------------- */
CREATE TABLE dbo.DungChan (
    MaDungChan     varchar(20)  NOT NULL,
    MaTour         varchar(20)  NOT NULL,
    MaDiaDiem      varchar(20)  NOT NULL,
    MaPT           varchar(20)  NOT NULL,      -- phương tiện đi tới nơi dừng chân này
    ThuTu          int          NOT NULL,
    DoiPhuongTien  bit          NOT NULL CONSTRAINT DF_DungChan_DoiPT  DEFAULT 0,
    CoNoiAn        bit          NOT NULL CONSTRAINT DF_DungChan_NoiAn  DEFAULT 0,
    CoKhachSan     bit          NOT NULL CONSTRAINT DF_DungChan_KS     DEFAULT 0,
    LoaiKhachSan   int          NULL,          -- số sao 1..5
    CONSTRAINT PK_DungChan          PRIMARY KEY (MaDungChan),
    CONSTRAINT FK_DungChan_Tour     FOREIGN KEY (MaTour)    REFERENCES dbo.Tour(MaTour) ON DELETE CASCADE,
    CONSTRAINT FK_DungChan_DiaDiem  FOREIGN KEY (MaDiaDiem) REFERENCES dbo.DiaDiem(MaDiaDiem),
    CONSTRAINT FK_DungChan_PT       FOREIGN KEY (MaPT)      REFERENCES dbo.PhuongTien(MaPT),
    CONSTRAINT UQ_DungChan_ThuTu    UNIQUE (MaTour, ThuTu),
    CONSTRAINT CK_DungChan_ThuTu    CHECK (ThuTu > 0),
    CONSTRAINT CK_DungChan_KhachSan CHECK (
        (CoKhachSan = 1 AND LoaiKhachSan BETWEEN 1 AND 5)
     OR (CoKhachSan = 0 AND LoaiKhachSan IS NULL))
);

CREATE TABLE dbo.ChiTietTourDiemTQ (
    MaTour     varchar(20)  NOT NULL,
    MaDiemTQ   varchar(20)  NOT NULL,
    CONSTRAINT PK_ChiTietTourDiemTQ PRIMARY KEY (MaTour, MaDiemTQ),
    CONSTRAINT FK_CTTDTQ_Tour       FOREIGN KEY (MaTour)   REFERENCES dbo.Tour(MaTour) ON DELETE CASCADE,
    CONSTRAINT FK_CTTDTQ_DiemTQ     FOREIGN KEY (MaDiemTQ) REFERENCES dbo.DiemThamQuan(MaDiemTQ)
);

CREATE TABLE dbo.ChuyenTour (
    MaChuyen    varchar(20)  NOT NULL,
    MaTour      varchar(20)  NOT NULL,
    NgayDi      date         NOT NULL,
    NgayVe      date         NOT NULL,
    SoChoToiDa  int          NOT NULL,
    CONSTRAINT PK_ChuyenTour      PRIMARY KEY (MaChuyen),
    CONSTRAINT FK_ChuyenTour_Tour FOREIGN KEY (MaTour) REFERENCES dbo.Tour(MaTour),
    CONSTRAINT CK_ChuyenTour_Ngay CHECK (NgayVe >= NgayDi),
    CONSTRAINT CK_ChuyenTour_Cho  CHECK (SoChoToiDa > 0)
);
GO

/* ---------------------------------------------------------------------
   4. KHÁCH HÀNG VÀ PHIẾU ĐĂNG KÝ
   --------------------------------------------------------------------- */
CREATE TABLE dbo.KhachHang (
    MaKH          varchar(20)    NOT NULL,
    TenKH         nvarchar(100)  NOT NULL,
    DiaChi        nvarchar(200)  NULL,
    DienThoai     varchar(15)    NULL,
    LoaiKhach     nvarchar(10)   NOT NULL,
    NguoiDaiDien  nvarchar(100)  NULL,   -- chỉ dùng cho khách đoàn
    SoCMND        varchar(20)    NULL,   -- chỉ dùng cho khách lẻ
    CONSTRAINT PK_KhachHang      PRIMARY KEY (MaKH),
    CONSTRAINT CK_KhachHang_Loai CHECK (LoaiKhach IN (N'Đoàn', N'Lẻ')),
    CONSTRAINT CK_KhachHang_TT   CHECK (
        (LoaiKhach = N'Đoàn' AND NguoiDaiDien IS NOT NULL)
     OR (LoaiKhach = N'Lẻ'   AND SoCMND       IS NOT NULL))
);

CREATE TABLE dbo.PhieuDangKy (
    SoPhieu    varchar(30)    NOT NULL,
    MaKH       varchar(20)    NOT NULL,
    LoaiPhieu  nvarchar(10)   NOT NULL,
    NgayLap    datetime       NOT NULL CONSTRAINT DF_PDK_NgayLap  DEFAULT GETDATE(),
    TongTien   decimal(18,2)  NOT NULL CONSTRAINT DF_PDK_TongTien DEFAULT 0,
    TrangThai  nvarchar(30)   NOT NULL CONSTRAINT DF_PDK_TrangThai DEFAULT N'Mới lập',
    CONSTRAINT PK_PhieuDangKy    PRIMARY KEY (SoPhieu),
    CONSTRAINT FK_PDK_KhachHang  FOREIGN KEY (MaKH) REFERENCES dbo.KhachHang(MaKH),
    CONSTRAINT CK_PDK_Loai       CHECK (LoaiPhieu IN (N'Đoàn', N'Chuyến')),
    CONSTRAINT CK_PDK_TongTien   CHECK (TongTien >= 0),
    CONSTRAINT CK_PDK_TrangThai  CHECK (TrangThai IN (N'Mới lập', N'Đã đặt cọc', N'Đã thanh toán', N'Hoàn tất', N'Đã hủy'))
);

CREATE TABLE dbo.PhieuDangKyDoan (
    SoPhieu     varchar(30)    NOT NULL,
    MaTour      varchar(20)    NOT NULL,
    NgayDi      date           NOT NULL,
    SoNguoi     int            NOT NULL,
    DiaChiDon   nvarchar(200)  NOT NULL,
    CoBaoHiem   bit            NOT NULL CONSTRAINT DF_PDKD_BaoHiem DEFAULT 0,
    TienDatCoc  decimal(18,2)  NOT NULL,
    CONSTRAINT PK_PhieuDangKyDoan     PRIMARY KEY (SoPhieu),
    CONSTRAINT FK_PDKD_PhieuDangKy    FOREIGN KEY (SoPhieu) REFERENCES dbo.PhieuDangKy(SoPhieu) ON DELETE CASCADE,
    CONSTRAINT FK_PDKD_Tour           FOREIGN KEY (MaTour)  REFERENCES dbo.Tour(MaTour),
    CONSTRAINT CK_PDKD_SoNguoi        CHECK (SoNguoi > 12),     -- ngưỡng khách đoàn (cần xác nhận khi đúng 12)
    CONSTRAINT CK_PDKD_TienCoc        CHECK (TienDatCoc > 0)
);

CREATE TABLE dbo.PhieuDangKyChuyen (
    SoPhieu    varchar(30)  NOT NULL,
    MaChuyen   varchar(20)  NOT NULL,
    MaDiemBan  varchar(20)  NOT NULL,
    MaDiemDon  varchar(20)  NOT NULL,
    SoVe       int          NOT NULL,
    CONSTRAINT PK_PhieuDangKyChuyen   PRIMARY KEY (SoPhieu),
    CONSTRAINT FK_PDKC_PhieuDangKy    FOREIGN KEY (SoPhieu)   REFERENCES dbo.PhieuDangKy(SoPhieu) ON DELETE CASCADE,
    CONSTRAINT FK_PDKC_ChuyenTour     FOREIGN KEY (MaChuyen)  REFERENCES dbo.ChuyenTour(MaChuyen),
    CONSTRAINT FK_PDKC_DiemBanVe      FOREIGN KEY (MaDiemBan) REFERENCES dbo.DiemBanVe(MaDiemBan),
    CONSTRAINT FK_PDKC_DiemDon        FOREIGN KEY (MaDiemDon) REFERENCES dbo.DiemDon(MaDiemDon),
    CONSTRAINT CK_PDKC_SoVe           CHECK (SoVe > 0)
);

CREATE TABLE dbo.ThanhVienDoan (
    MaTV      varchar(20)    NOT NULL,
    SoPhieu   varchar(30)    NOT NULL,
    HoTen     nvarchar(100)  NOT NULL,
    NgaySinh  date           NULL,
    SoCMND    varchar(20)    NULL,
    CONSTRAINT PK_ThanhVienDoan  PRIMARY KEY (MaTV),
    CONSTRAINT FK_TVD_PhieuDoan  FOREIGN KEY (SoPhieu) REFERENCES dbo.PhieuDangKyDoan(SoPhieu) ON DELETE CASCADE
);

CREATE TABLE dbo.ThanhToan (
    MaThanhToan     varchar(30)    NOT NULL,
    SoPhieu         varchar(30)    NOT NULL,
    NgayThanhToan   datetime       NOT NULL CONSTRAINT DF_TT_Ngay DEFAULT GETDATE(),
    LoaiThanhToan   nvarchar(30)   NOT NULL,
    HinhThuc        nvarchar(30)   NOT NULL,
    SoTien          decimal(18,2)  NOT NULL,
    CONSTRAINT PK_ThanhToan      PRIMARY KEY (MaThanhToan),
    CONSTRAINT FK_TT_PhieuDK     FOREIGN KEY (SoPhieu) REFERENCES dbo.PhieuDangKy(SoPhieu),
    CONSTRAINT CK_TT_SoTien      CHECK (SoTien > 0),
    CONSTRAINT CK_TT_Loai        CHECK (LoaiThanhToan IN (N'Đặt cọc', N'Tiền vé', N'Kinh phí đoàn')),
    CONSTRAINT CK_TT_HinhThuc    CHECK (HinhThuc IN (N'Tiền mặt', N'Chuyển khoản', N'Thẻ', N'Ví điện tử'))
);

CREATE TABLE dbo.PhieuKhaoSat (
    MaKS         varchar(20)    NOT NULL,
    SoPhieu      varchar(30)    NOT NULL,
    NgayGui      date           NOT NULL,
    NgayTraLoi   date           NULL,
    DiemDanhGia  int            NULL,
    GopY         nvarchar(500)  NULL,
    CONSTRAINT PK_PhieuKhaoSat    PRIMARY KEY (MaKS),
    CONSTRAINT FK_PKS_PhieuDK     FOREIGN KEY (SoPhieu) REFERENCES dbo.PhieuDangKy(SoPhieu),
    CONSTRAINT UQ_PKS_SoPhieu     UNIQUE (SoPhieu),                       -- mỗi phiếu tối đa 1 khảo sát
    CONSTRAINT CK_PKS_Diem        CHECK (DiemDanhGia BETWEEN 1 AND 5),
    CONSTRAINT CK_PKS_Ngay        CHECK (NgayTraLoi IS NULL OR NgayTraLoi >= NgayGui)
);
GO

/* ---------------------------------------------------------------------
   5. PHÂN CÔNG HƯỚNG DẪN VIÊN
   --------------------------------------------------------------------- */
CREATE TABLE dbo.PhanCong (
    MaPC          varchar(20)    NOT NULL,
    MaNV          varchar(20)    NOT NULL,
    MaChuyen      varchar(20)    NULL,    -- phân công cho chuyến (khách lẻ)
    SoPhieu       varchar(30)    NULL,    -- hoặc cho phiếu đoàn
    NgayBatDau    date           NOT NULL,
    NgayKetThuc   date           NOT NULL,
    TienCongTour  decimal(18,2)  NOT NULL CONSTRAINT DF_PC_TienCong DEFAULT 0,
    CONSTRAINT PK_PhanCong         PRIMARY KEY (MaPC),
    CONSTRAINT FK_PC_NhanVien      FOREIGN KEY (MaNV)     REFERENCES dbo.NhanVien(MaNV),
    CONSTRAINT FK_PC_ChuyenTour    FOREIGN KEY (MaChuyen) REFERENCES dbo.ChuyenTour(MaChuyen),
    CONSTRAINT FK_PC_PhieuDoan     FOREIGN KEY (SoPhieu)  REFERENCES dbo.PhieuDangKyDoan(SoPhieu),
    CONSTRAINT CK_PC_Xor           CHECK ((MaChuyen IS NOT NULL AND SoPhieu IS NULL)
                                       OR (MaChuyen IS NULL AND SoPhieu IS NOT NULL)),   -- {xor}
    CONSTRAINT CK_PC_Ngay          CHECK (NgayKetThuc >= NgayBatDau),
    CONSTRAINT CK_PC_TienCong      CHECK (TienCongTour >= 0)
);
-- Mỗi chuyến lẻ chỉ có một nhân viên (đoàn có thể nhiều nhân viên)
CREATE UNIQUE INDEX UQ_PhanCong_MaChuyen ON dbo.PhanCong(MaChuyen) WHERE MaChuyen IS NOT NULL;
GO

/* ---------------------------------------------------------------------
   6. INDEX hỗ trợ truy vấn
   --------------------------------------------------------------------- */
CREATE INDEX IX_ChuyenTour_MaTour    ON dbo.ChuyenTour(MaTour, NgayDi);
CREATE INDEX IX_PDK_MaKH             ON dbo.PhieuDangKy(MaKH);
CREATE INDEX IX_PDKD_Tour_NgayDi     ON dbo.PhieuDangKyDoan(MaTour, NgayDi);
CREATE INDEX IX_PDKC_MaChuyen        ON dbo.PhieuDangKyChuyen(MaChuyen);
CREATE INDEX IX_TVD_SoPhieu          ON dbo.ThanhVienDoan(SoPhieu);
CREATE INDEX IX_TT_SoPhieu           ON dbo.ThanhToan(SoPhieu);
CREATE INDEX IX_PC_MaNV              ON dbo.PhanCong(MaNV, NgayBatDau, NgayKetThuc);
GO

/* =====================================================================
   7. TRIGGER – RÀNG BUỘC LIÊN BẢNG
   ===================================================================== */

-- 7.1 Phiếu đoàn: ngày đi >= ngày lập; tiền cọc <= tổng tiền; không trùng phiếu
CREATE TRIGGER dbo.trg_PhieuDangKyDoan_KiemTra
ON dbo.PhieuDangKyDoan
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM inserted i JOIN dbo.PhieuDangKy p ON p.SoPhieu = i.SoPhieu
               WHERE i.NgayDi < CAST(p.NgayLap AS date))
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50001, N'Ngày đi phải lớn hơn hoặc bằng ngày lập phiếu.', 1;
    END;

    IF EXISTS (SELECT 1 FROM inserted i JOIN dbo.PhieuDangKy p ON p.SoPhieu = i.SoPhieu
               WHERE i.TienDatCoc > p.TongTien)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50002, N'Tiền đặt cọc không được vượt quá tổng tiền của phiếu.', 1;
    END;

    -- Trùng phiếu: cùng khách, cùng tour, cùng ngày đi (bỏ qua phiếu đã hủy)
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN dbo.PhieuDangKy    p  ON p.SoPhieu = i.SoPhieu AND p.TrangThai <> N'Đã hủy'
        JOIN dbo.PhieuDangKyDoan d2 ON d2.MaTour = i.MaTour AND d2.NgayDi = i.NgayDi AND d2.SoPhieu <> i.SoPhieu
        JOIN dbo.PhieuDangKy    p2 ON p2.SoPhieu = d2.SoPhieu AND p2.MaKH = p.MaKH AND p2.TrangThai <> N'Đã hủy')
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50003, N'Phiếu đăng ký đoàn bị trùng (cùng khách, tour và ngày đi).', 1;
    END;
END;
GO

-- 7.2 Phiếu khách lẻ: tổng số vé của chuyến không vượt SoChoToiDa
CREATE TRIGGER dbo.trg_PhieuDangKyChuyen_ChoTrong
ON dbo.PhieuDangKyChuyen
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1
        FROM dbo.ChuyenTour c
        WHERE c.MaChuyen IN (SELECT MaChuyen FROM inserted)
          AND (SELECT ISNULL(SUM(k.SoVe), 0)
               FROM dbo.PhieuDangKyChuyen k
               JOIN dbo.PhieuDangKy p ON p.SoPhieu = k.SoPhieu AND p.TrangThai <> N'Đã hủy'
               WHERE k.MaChuyen = c.MaChuyen) > c.SoChoToiDa)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50004, N'Chuyến tour đã hết chỗ, không thể đăng ký thêm.', 1;
    END;
END;
GO

-- 7.3 Thành viên đoàn chỉ được lưu khi phiếu có mua bảo hiểm
CREATE TRIGGER dbo.trg_ThanhVienDoan_BaoHiem
ON dbo.ThanhVienDoan
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM inserted i JOIN dbo.PhieuDangKyDoan d ON d.SoPhieu = i.SoPhieu
               WHERE d.CoBaoHiem = 0)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50005, N'Phiếu không mua bảo hiểm nên không lưu danh sách thành viên.', 1;
    END;
END;
GO

-- 7.4 Tổng tiền thanh toán của một phiếu không vượt tổng tiền phiếu
CREATE TRIGGER dbo.trg_ThanhToan_TongTien
ON dbo.ThanhToan
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1
        FROM dbo.PhieuDangKy p
        WHERE p.SoPhieu IN (SELECT SoPhieu FROM inserted)
          AND (SELECT SUM(t.SoTien) FROM dbo.ThanhToan t WHERE t.SoPhieu = p.SoPhieu) > p.TongTien)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50006, N'Tổng số tiền thanh toán vượt quá tổng tiền của phiếu.', 1;
    END;
END;
GO

-- 7.5 Một nhân viên không được phân công hai khoảng thời gian chồng nhau
CREATE TRIGGER dbo.trg_PhanCong_TrungLich
ON dbo.PhanCong
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN dbo.PhanCong p ON p.MaNV = i.MaNV
                           AND p.MaPC <> i.MaPC
                           AND p.NgayBatDau  <= i.NgayKetThuc
                           AND p.NgayKetThuc >= i.NgayBatDau)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50007, N'Nhân viên đã được phân công trong khoảng thời gian trùng lịch.', 1;
    END;
END;
GO

/* =====================================================================
   8. STORED PROCEDURE – LẬP PHIẾU ĐĂNG KÝ ĐOÀN (1 TRANSACTION)
   ===================================================================== */
CREATE TYPE dbo.DSThanhVienDoan AS TABLE (
    HoTen     nvarchar(100) NOT NULL,
    NgaySinh  date          NULL,
    SoCMND    varchar(20)   NULL
);
GO

CREATE PROCEDURE dbo.sp_LapPhieuDoan
    @MaKH         varchar(20),
    @MaTour       varchar(20),
    @NgayDi       date,
    @SoNguoi      int,
    @DiaChiDon    nvarchar(200),
    @CoBaoHiem    bit,
    @TienDatCoc   decimal(18,2),
    @HinhThuc     nvarchar(30) = N'Tiền mặt',
    @DSThanhVien  dbo.DSThanhVienDoan READONLY,
    @SoPhieu      varchar(30) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @DonGia decimal(18,2), @TongTien decimal(18,2), @SoTV int;

    -- Kiểm tra dữ liệu đầu vào
    IF NOT EXISTS (SELECT 1 FROM dbo.KhachHang WHERE MaKH = @MaKH AND LoaiKhach = N'Đoàn')
        THROW 50101, N'Khách hàng không tồn tại hoặc không phải khách đoàn.', 1;

    SELECT @DonGia = DonGia FROM dbo.Tour WHERE MaTour = @MaTour;
    IF @DonGia IS NULL
        THROW 50102, N'Tour không tồn tại.', 1;

    IF @SoNguoi <= 12
        THROW 50103, N'Số người phải lớn hơn 12 để đăng ký theo đoàn.', 1;
    IF @NgayDi < CAST(GETDATE() AS date)
        THROW 50104, N'Ngày đi không được nằm trong quá khứ.', 1;
    IF @TienDatCoc IS NULL OR @TienDatCoc <= 0
        THROW 50105, N'Tiền đặt cọc phải lớn hơn 0.', 1;

    SELECT @SoTV = COUNT(*) FROM @DSThanhVien;
    IF @CoBaoHiem = 1 AND @SoTV <> @SoNguoi
        THROW 50106, N'Danh sách người đi phải có đúng bằng số người đăng ký khi mua bảo hiểm.', 1;
    IF @CoBaoHiem = 0 AND @SoTV > 0
        THROW 50107, N'Đoàn không mua bảo hiểm thì không nhập danh sách người đi.', 1;

    SET @TongTien = @DonGia * @SoNguoi;
    IF @TienDatCoc > @TongTien
        THROW 50108, N'Tiền đặt cọc không được vượt quá tổng tiền.', 1;

    SET @SoPhieu = 'PD' + RIGHT('000000' + CAST(NEXT VALUE FOR dbo.seq_SoPhieu AS varchar(10)), 6);

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT dbo.PhieuDangKy (SoPhieu, MaKH, LoaiPhieu, NgayLap, TongTien, TrangThai)
        VALUES (@SoPhieu, @MaKH, N'Đoàn', GETDATE(), @TongTien, N'Đã đặt cọc');

        INSERT dbo.PhieuDangKyDoan (SoPhieu, MaTour, NgayDi, SoNguoi, DiaChiDon, CoBaoHiem, TienDatCoc)
        VALUES (@SoPhieu, @MaTour, @NgayDi, @SoNguoi, @DiaChiDon, @CoBaoHiem, @TienDatCoc);

        IF @CoBaoHiem = 1
            INSERT dbo.ThanhVienDoan (MaTV, SoPhieu, HoTen, NgaySinh, SoCMND)
            SELECT 'TV' + RIGHT('000000' + CAST(NEXT VALUE FOR dbo.seq_MaTV AS varchar(10)), 6),
                   @SoPhieu, HoTen, NgaySinh, SoCMND
            FROM @DSThanhVien;

        INSERT dbo.ThanhToan (MaThanhToan, SoPhieu, NgayThanhToan, LoaiThanhToan, HinhThuc, SoTien)
        VALUES ('TT' + RIGHT('000000' + CAST(NEXT VALUE FOR dbo.seq_MaThanhToan AS varchar(10)), 6),
                @SoPhieu, GETDATE(), N'Đặt cọc', @HinhThuc, @TienDatCoc);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

/* =====================================================================
   9. VÍ DỤ KIỂM THỬ (bỏ comment để chạy thử)
   =====================================================================
INSERT dbo.Tour (MaTour, TenTour, SoNgay, SoDem, DonGia) VALUES ('T01', N'Đà Lạt 3N2Đ', 3, 2, 3500000);
INSERT dbo.KhachHang (MaKH, TenKH, DiaChi, DienThoai, LoaiKhach, NguoiDaiDien)
VALUES ('KH01', N'Công ty ABC', N'TP.HCM', '0901234567', N'Đoàn', N'Nguyễn Văn A');

DECLARE @ds dbo.DSThanhVienDoan, @so varchar(30);
-- (không mua bảo hiểm nên để trống danh sách)
EXEC dbo.sp_LapPhieuDoan @MaKH='KH01', @MaTour='T01', @NgayDi='2026-12-20', @SoNguoi=20,
     @DiaChiDon=N'12 Nguyễn Huệ, Q1', @CoBaoHiem=0, @TienDatCoc=10000000,
     @DSThanhVien=@ds, @SoPhieu=@so OUTPUT;
SELECT @so AS SoPhieuVuaLap;
   ===================================================================== */
