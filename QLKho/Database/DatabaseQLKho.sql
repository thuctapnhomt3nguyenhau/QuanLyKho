-- CREATE DATABASE
CREATE DATABASE TT_QLKHO
GO

-- USE Database
USE TT_QLKHO
GO

------------------------------------------------- CREATE TABLE--------------------------------------------------------
CREATE TABLE NHANVIEN
(
	MA_NV INT IDENTITY(1,1) NOT NULL,
	TEN_NV NVARCHAR(100),
	SDT_NV INT,
	EMAIL_NV CHAR(100),

	CONSTRAINT PK_NHANVIEN PRIMARY KEY (MA_NV)
)
GO

CREATE TABLE NHACUNGCAP
(
	MA_NCC INT IDENTITY(1,1) NOT NULL,
	TEN_NCC NVARCHAR(100),
	DIACHI_NCC NVARCHAR(100),
	SDT_NCC INT,
	WEBSITE_NCC CHAR(50),

	CONSTRAINT PK_NHACUNGCAP PRIMARY KEY (MA_NCC)
)
GO

CREATE TABLE PHIEUXUAT
(
	MA_PX INT IDENTITY(1,1) NOT NULL,
	MA_NV INT , 
	NGAYXUAT DATE DEFAULT GETDATE(),

	CONSTRAINT PK_PHIEUXUAT PRIMARY KEY (MA_PX),
	CONSTRAINT PK_NHANVIEN_FK_PHIEUXUAT FOREIGN KEY (MA_NV) REFERENCES dbo.NHANVIEN(MA_NV)
)
GO

CREATE TABLE PHIEUNHAP
(
	MA_PN INT IDENTITY(1,1) NOT NULL,
	MA_NV INT,
	MA_NCC INT,
	NGAYNHAP DATE DEFAULT GETDATE(),

	CONSTRAINT PK_PHIEUNHAP PRIMARY KEY (MA_PN),
	CONSTRAINT PK_NHANVIEN_FK_PHIEUNHAP FOREIGN KEY (MA_NV) REFERENCES dbo.NHANVIEN(MA_NV),
	CONSTRAINT PK_NHACUNGCAP_FK_PHIEUNHAP FOREIGN KEY (MA_NCC) REFERENCES dbo.NHACUNGCAP(MA_NCC)
)
GO

CREATE TABLE SANPHAM
(
	MA_SP INT IDENTITY(1,1) NOT NULL,
	TEN_SP NVARCHAR(100),
	MA_NCC INT,
	THONGSO_KT NVARCHAR(100),
	GIA FLOAT,
	SOLUONG INT,

	CONSTRAINT PK_SANPHAM PRIMARY KEY (MA_SP),
	CONSTRAINT PK_NHACUNGCAP_FK_SANPHAM FOREIGN KEY (MA_NCC) REFERENCES dbo.NHACUNGCAP(MA_NCC)
)
GO

CREATE TABLE CT_PHIEUNHAP
(
	MA_CTPN INT IDENTITY(1,1) NOT NULL,
	MA_PN INT ,
	MA_SP INT ,
	SOLUONG INT,
	DONGIA FLOAT,

	CONSTRAINT PK_CT_PHIEUNHAP PRIMARY KEY(MA_CTPN),
	CONSTRAINT PK_PHIEUNHAP_FK_CT_PHIEUNHAP FOREIGN KEY (MA_PN) REFERENCES dbo.PHIEUNHAP,
	CONSTRAINT PK_SANPHAM_FK_CT_PHIEUNHAP FOREIGN KEY (MA_SP) REFERENCES dbo.SANPHAM
)

CREATE TABLE CT_PHIEUXUAT
(
	MA_CTPX INT IDENTITY(1,1) NOT NULL,
	MA_PX INT,
	MA_SP INT,
	SOLUONG INT,
	DONGIA FLOAT,

	CONSTRAINT PK_CT_PHIEUXUAT PRIMARY KEY(MA_CTPX),
	CONSTRAINT PK_PHIEUXUAT_FK_CT_PHIEUXUAT FOREIGN KEY (MA_PX) REFERENCES dbo.PHIEUXUAT,
	CONSTRAINT PK_SANPHAM_FK_CT_PHIEUXUAT FOREIGN KEY (MA_SP) REFERENCES dbo.SANPHAM
)
GO

-----------------------------------------------------------BẢNG NHÂN VIÊN--------------------------------------------------------------------------
-------TẠO PROC GETALL
CREATE PROC SP_NHANVIEN_GETALL
AS
BEGIN
	SELECT MA_NV, TEN_NV, SDT_NV, EMAIL_NV
	FROM dbo.NHANVIEN
END
GO

EXEC dbo.SP_NHANVIEN_GETALL
GO

-------TẠO PROC INSERT
CREATE PROC SP_NHANVIEN_INSERT
	@TENNV NVARCHAR(100),
	@SDT INT,
	@EMAIL CHAR(100)
AS
BEGIN
	INSERT INTO dbo.NHANVIEN( TEN_NV, SDT_NV, EMAIL_NV )
	VALUES  ( @TENNV, -- TEN_NV - nvarchar(100)
	          @SDT, -- SDT_NV - int
	          @EMAIL  -- EMAIL_NV - char(100)
	          )
END
GO

------TẠO PROC DELETE
CREATE PROC SP_NHANVIEN_DELETE
	@MANV INT
AS
BEGIN
	DELETE dbo.NHANVIEN WHERE MA_NV = @MANV
END
GO

------TẠO PROC UPDATE
CREATE PROC SP_NHANVIEN_UPDATE
	@MANV INT,
	@TENNV NVARCHAR(100),
	@SDT INT,
	@EMAIL CHAR(100)
AS
BEGIN
	UPDATE dbo.NHANVIEN
	SET TEN_NV = @TENNV, SDT_NV = @SDT, EMAIL_NV = @EMAIL
	WHERE MA_NV = @MANV
END
GO

---TẠO PROC SEARCH
CREATE PROC SP_NHANVIEN_SEARCH
	@SEARCHVALUE NVARCHAR(100)
AS
BEGIN
	SELECT MA_NV, TEN_NV, SDT_NV, EMAIL_NV
	FROM dbo.NHANVIEN
	WHERE (dbo.NHANVIEN.MA_NV LIKE N'%' + @SEARCHVALUE +'%')
		OR (dbo.NHANVIEN.TEN_NV LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.NHANVIEN.SDT_NV LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.NHANVIEN.EMAIL_NV LIKE N'%' + @SEARCHVALUE + '%')
END
GO

---------------------------------------------------Xuất kho-----------------------------------------------------------------------------
CREATE VIEW v_CTPhieuXuat
AS
SELECT MA_CTPX,MA_PX,CT_PHIEUXUAT.MA_SP,CT_PHIEUXUAT.SOLUONG,DONGIA,dbo.SANPHAM.TEN_SP FROM dbo.CT_PHIEUXUAT, dbo.SANPHAM where SANPHAM.MA_SP = CT_PHIEUXUAT.MA_SP
GO
CREATE VIEW v_PhieuXuat
AS
SELECT MA_PX,PHIEUXUAT.MA_NV,TEN_NV,NGAYXUAT FROM dbo.PHIEUXUAT,dbo.NHANVIEN WHERE NHANVIEN.MA_NV=PHIEUXUAT.MA_NV
GO
CREATE VIEW v_XuatKho
AS
SELECT v_CTPhieuXuat.MA_PX,MA_NV,TEN_NV,NGAYXUAT,MA_CTPX,MA_SP,SOLUONG,DONGIA,TEN_SP FROM dbo.v_PhieuXuat LEFT JOIN dbo.v_CTPhieuXuat ON v_CTPhieuXuat.MA_PX = v_PhieuXuat.MA_PX
GO
CREATE PROC USP_GetListXuatKho
AS
SELECT * FROM dbo.v_PhieuXuat LEFT JOIN dbo.v_CTPhieuXuat ON v_CTPhieuXuat.MA_PX = v_PhieuXuat.MA_PX
GO

CREATE PROC USP_ThemPhieuXuat
	@mapx INT,
	@manv INT,
	@ngayxuat DATE,
	@tensp NVARCHAR(100),
	@soluong INT
AS
BEGIN
	DECLARE @id INT,@idsp INT,@gia FLOAT,@soluongton INT
	SELECT @idsp=MA_SP FROM dbo.SANPHAM WHERE TEN_SP=@tensp
	SELECT @gia=GIA FROM dbo.SANPHAM WHERE MA_SP=@idsp
	SELECT @soluongton = SOLUONG FROM dbo.SANPHAM
	IF (@soluongton < @soluong) RETURN 0
	ELSE
	BEGIN
		IF (SELECT COUNT(*) FROM dbo.PHIEUXUAT WHERE MA_PX = @mapx) = 0
		BEGIN
			INSERT dbo.PHIEUXUAT ( MA_NV, NGAYXUAT ) VALUES  ( @manv, @ngayxuat)
			SELECT @id=SCOPE_IDENTITY()
		END
		ELSE SET @id = @mapx
		IF (@soluongton > @soluong)
		BEGIN
			IF (SELECT COUNT(*) FROM dbo.CT_PHIEUXUAT WHERE MA_SP=@idsp AND MA_PX=@mapx) = 0
			BEGIN
				INSERT dbo.CT_PHIEUXUAT ( MA_PX, MA_SP, SOLUONG, DONGIA )VALUES  ( @id, @idsp, @soluong, @gia )
				UPDATE dbo.SANPHAM SET SOLUONG=SOLUONG-@soluong WHERE TEN_SP = @tensp
			END
			ELSE
			BEGIN
				UPDATE dbo.CT_PHIEUXUAT SET SOLUONG=SOLUONG+@soluong WHERE MA_PX=@mapx AND MA_SP=@idsp
			END
		END
	END
END
GO

CREATE PROC USP_UpdatePhieuXuat
	@mapx INT,
	@mact INT,
	@manv INT,
	@ngayxuat DATE,
	@tensp NVARCHAR(100),
	@soluong INT
AS
BEGIN
	DECLARE @masp INT,@soluongxuat INT,@maspct INT, @dongia FLOAT,@soluongton INT
	SELECT @masp=MA_SP,@dongia = GIA,@soluongton=SOLUONG FROM dbo.SANPHAM WHERE TEN_SP=@tensp
	IF (@soluongton + (SELECT SOLUONG FROM dbo.CT_PHIEUXUAT WHERE MA_CTPX=@mact) < @soluong OR @soluong=0) RETURN 0
	ELSE
	BEGIN
		SELECT @maspct=MA_SP,@soluongxuat=SOLUONG FROM dbo.CT_PHIEUXUAT WHERE MA_CTPX=@mact
		UPDATE dbo.PHIEUXUAT SET MA_NV=@manv,NGAYXUAT=@ngayxuat WHERE MA_PX=@mapx
		IF ( @maspct <> @masp)
		BEGIN
			UPDATE dbo.SANPHAM SET SOLUONG=SOLUONG+@soluongxuat WHERE MA_SP=@maspct
			UPDATE dbo.CT_PHIEUXUAT SET MA_SP = @masp , SOLUONG = @soluong WHERE MA_CTPX=@mact
			UPDATE dbo.SANPHAM SET SOLUONG = SOLUONG - @soluong WHERE MA_SP=@masp
		END
		ELSE
		BEGIN
			UPDATE dbo.SANPHAM SET SOLUONG = SOLUONG + @soluongxuat - @soluong WHERE MA_SP=@masp
			UPDATE dbo.CT_PHIEUXUAT SET SOLUONG = @soluong WHERE MA_CTPX=@mact
		END
		UPDATE dbo.CT_PHIEUXUAT SET DONGIA = @dongia WHERE MA_CTPX = @mact
	END
END
GO

CREATE PROC DeleteCTPhieuXuatXuatKho
@mapx INT,
@mact INT
AS
BEGIN
	DECLARE @soluong INT,@idsp INT
	SELECT @idsp=MA_SP,@soluong=SOLUONG FROM dbo.CT_PHIEUXUAT WHERE MA_CTPX=@mact
	DELETE FROM dbo.CT_PHIEUXUAT WHERE MA_CTPX = @mact
	UPDATE dbo.SANPHAM SET SOLUONG=SOLUONG+@soluong WHERE MA_SP=@idsp
	IF (SELECT COUNT(*) FROM dbo.CT_PHIEUXUAT WHERE MA_PX=@mapx)=0
	DELETE FROM dbo.PHIEUXUAT WHERE MA_PX=@mapx
END
GO

CREATE PROC DeletePhieuXuatXuatKho
@maphieuxuat INT
AS
BEGIN
	DECLARE @mactphieuxuat INT
	WHILE (SELECT COUNT(*) FROM dbo.CT_PHIEUXUAT WHERE MA_PX=@maphieuxuat) <> 0
	BEGIN
		SET @mactphieuxuat = (SELECT TOP 1 (MA_CTPX) FROM dbo.CT_PHIEUXUAT WHERE MA_PX=@maphieuxuat)
		EXEC dbo.DeleteCTPhieuXuatXuatKho @mapx = @maphieuxuat,  @mact = @mactphieuxuat
	END
END
GO

CREATE PROC USP_SearchPhieuXuat
@search NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.v_XuatKho 
	WHERE 
	NGAYXUAT LIKE N'%' + @search + '%' OR TEN_NV LIKE N'%' + @search + '%' OR TEN_SP LIKE N'%' + @search + '%'
	OR SOLUONG LIKE N'%' + @search + '%' OR DONGIA LIKE N'%' + @search + '%' OR MA_PX LIKE N'%' + @search + '%' 
	OR MA_CTPX LIKE N'%' + @search + '%' 
END
GO



------------------------BẢNG NHÀ CUNG CẤP--------------------------------
CREATE PROC USP_GetDSNCC AS 
SELECT NHACUNGCAP.MA_NCC,TEN_NCC,DIACHI_NCC,SDT_NCC,WEBSITE_NCC
FROM dbo.NHACUNGCAP JOIN dbo.SANPHAM  ON NHACUNGCAP.MA_NCC=SANPHAM.MA_NCC
GO

------------GET ALL-------------
CREATE PROC USP_GetallNCC
AS
BEGIN
	SELECT MA_NCC, TEN_NCC,DIACHI_NCC, SDT_NCC, WEBSITE_NCC
	FROM dbo.NHACUNGCAP
END
GO

------THEM-----------
CREATE PROC USP_InsertNCC
	@TENNCC NVARCHAR(100),
	@DIACHINCC NVARCHAR(100),
	@SDTNCC INT,
	@WEBSITENCC char(100)
AS
BEGIN
INSERT dbo.NHACUNGCAP ( TEN_NCC,DIACHI_NCC,SDT_NCC,WEBSITE_NCC)
VALUES  (@TENNCC,@DIACHINCC,@SDTNCC,@WEBSITENCC)
END
GO

-------SUA----------
CREATE PROC USP_UpdateNCC
  @MANCC INT,
  @TENNCC NVARCHAR(100),
  @DIACHINCC NVARCHAR(100),
  @SDTNCC INT,
  @WEBSITENCC CHAR(50)

AS
BEGIN
	UPDATE dbo.NHACUNGCAP SET TEN_NCC=@TENNCC,DIACHI_NCC=@DIACHINCC,SDT_NCC=@SDTNCC,WEBSITE_NCC=@WEBSITENCC WHERE MA_NCC=@MANCC
END
GO

-------XOA-------
CREATE PROC USP_DeleteNCC
   @MANCC INT
AS
BEGIN
DELETE dbo.NHACUNGCAP WHERE MA_NCC = @MANCC
END 
GO

----------TIM KIEM-----------
CREATE PROC USP_SearchNCC
  @SEARCHVALUE NVARCHAR(100)
AS 
BEGIN
    SELECT MA_NCC,TEN_NCC,DIACHI_NCC,SDT_NCC,WEBSITE_NCC
	FROM dbo.NHACUNGCAP
	WHERE (dbo.NHACUNGCAP.MA_NCC LIKE N'%' + @SEARCHVALUE + '%')
	    OR (dbo.NHACUNGCAP.TEN_NCC LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.NHACUNGCAP.DIACHI_NCC LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.NHACUNGCAP.SDT_NCC LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.NHACUNGCAP.WEBSITE_NCC LIKE N'%' + @SEARCHVALUE + '%')
END
GO

------------------------------------------------Bảng Sản Phẩm------------------
CREATE PROC SP_SANPHAM_GETALL
AS
BEGIN
	SELECT *
	FROM dbo.SANPHAM
END
GO


--tạo thủ tục thêm:
CREATE PROC SP_SANPHAM_INSERT
	@TENSP NVARCHAR(100),
	@MANCC CHAR(100),
	@THONGSOKT NVARCHAR(100),
	@GIA FLOAT,
	@SOLUONG CHAR(100)
	
AS
BEGIN
	INSERT INTO dbo.SANPHAM( TEN_SP,MA_NCC,THONGSO_KT,GIA,SOLUONG)
	VALUES  ( @TENSP, 
	          @MANCC,
	          @THONGSOKT,
			  @GIA,
			  @SOLUONG  
	          )
END
GO

--tạo thủ tục xóa:
CREATE PROC SP_SANPHAM_DELETE
	@MASP INT
AS
BEGIN
	DELETE dbo.SANPHAM WHERE MA_SP = @MASP
END
GO

--tạo thủ tục update
CREATE PROC SP_SANPHAM_UPDATE
	@MASP INT,
	@TENSP NVARCHAR(100),
	@MANCC INT,
	@THONGSOKT NVARCHAR(100),
	@GIA FLOAT,
	@SOLUONG INT
AS
BEGIN
	UPDATE dbo.SANPHAM
	SET TEN_SP = @TENSP,MA_NCC  = @MANCC ,THONGSO_KT = @THONGSOKT, GIA = @GIA, SOLUONG = @SOLUONG
	WHERE MA_SP = @MASP
END
GO

---TẠO PROC SEARCH
CREATE PROC SP_SANPHAM_SEARCH
	@SEARCHVALUE NVARCHAR(100)
AS
BEGIN
	SELECT MA_SP, TEN_SP, MA_NCC,THONGSO_KT,GIA,SOLUONG
	FROM dbo.SANPHAM
	WHERE (dbo.SANPHAM.MA_SP LIKE N'%' + @SEARCHVALUE +'%')
		OR (dbo.SANPHAM.TEN_SP LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.SANPHAM.MA_NCC LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.SANPHAM.THONGSO_KT LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.SANPHAM.GIA LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.SANPHAM.SOLUONG LIKE N'%' + @SEARCHVALUE + '%')
END
GO


----------------------Phiếu nhập---------------------------------
create procedure SP_PhieuNhap_GetAll
as
begin
	select * from PHIEUNHAP
end
go

create procedure SP_PhieuNhap_Insert
	@maNhanVien int,
	@maNhaCungCap int,
	@ngayNhap date
as
begin
	insert into PHIEUNHAP(MA_NV, MA_NCC, NGAYNHAP)
	values(@maNhanVien, @maNhaCungCap, @ngayNhap)
end	
go

create procedure SP_PhieuNhap_Delete
	@maPhieuNhap int
as
begin
	delete CT_PHIEUNHAP 
	where MA_PN = @maPhieuNhap
	delete PHIEUNHAP 
	where MA_PN = @maPhieuNhap
end
go

create procedure SP_PhieuNhap_Update
	@maPhieuNhap int,
	@maNhanVien int,
	@maNhaCungCap int,
	@ngayNhap date
as
begin
	update PHIEUNHAP 
	set MA_NV = @maNhanVien, MA_NCC = @maNhaCungCap, NGAYNHAP = @ngayNhap
	where MA_PN = @maPhieuNhap
end
go

create procedure SP_PhieuNhap_Search
	@searchValue nvarchar(50)
as
begin
	select * from PHIEUNHAP
	where MA_PN like N'%' + @searchValue +'%'
	or MA_NV like N'%' + @searchValue +'%'
	or MA_NCC like N'%' + @searchValue +'%'
	or NGAYNHAP like N'%' + @searchValue +'%'
end
go

-------------------Chi tiết phiếu nhập-----------------

create procedure SP_CTPhieuNhap_GetAll 
	@maPhieuNhap int
as
begin
	select * from CT_PHIEUNHAP
	where MA_PN = @maPhieuNhap
end
go
SP_CTPhieuNhap_GetAll 1
create procedure SP_CTPhieuNhap_Insert
	@maPhieuNhap int,
	@maSanPham int,
	@soLuong int,
	@donGia float
as
begin
	insert into CT_PHIEUNHAP(MA_PN, MA_SP, SOLUONG, DONGIA)
	values(@maPhieuNhap, @maSanPham, @soLuong, @donGia)
end
go

create procedure SP_CTPhieuNhap_Delete
	@maChiTietPhieuNhap int
as
begin
	delete CT_PHIEUNHAP
	where MA_CTPN = @maChiTietPhieuNhap
end
go

create procedure SP_CTPhieuNhap_Update
	@maChiTietPhieuNhap int,
	@maPhieuNhap int,
	@maSanPham int,
	@soLuong int,
	@donGia float
as
begin
	update CT_PHIEUNHAP
	set MA_SP = @maSanPham, MA_PN = @maPhieuNhap, SOLUONG = @soLuong, DONGIA = @donGia
	where MA_CTPN = @maChiTietPhieuNhap
end
go

create procedure SP_CTPhieuNhap_Search
	@searchValue nvarchar(50),
	@maChiTietPhieuNhap int
as
begin
	select * from CT_PHIEUNHAP
	where MA_CTPN like N'%'+ @searchValue + '%'
	or MA_PN like N'%'+ @searchValue + '%'
	or MA_SP like N'%'+ @searchValue + '%'
	or SOLUONG like N'%'+ @searchValue + '%'
	or DONGIA like N'%'+ @searchValue + '%'
	and MA_CTPN = @maChiTietPhieuNhap
end
go