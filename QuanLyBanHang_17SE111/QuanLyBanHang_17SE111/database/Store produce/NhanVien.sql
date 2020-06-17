--xoa nhan vien
IF OBJECT_ID('dbo.PSP_NhanVien_Delete')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_NhanVien_Delete
END
GO
CREATE PROC dbo.PSP_NhanVien_Delete
@MaNhanVien INT 
AS
DELETE dbo.NhanVien
WHERE MaNhanVien =@MaNhanVien

--xoa nhan vien theo IsDelete = 1
GO
IF OBJECT_ID('dbo.PSP_NhanVien_DeleteByUpdateIsDelete')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_NhanVien_DeleteByUpdateIsDelete
END
GO
CREATE PROC PSP_NhanVien_DeleteByUpdateIsDelete
@MaNhanVien INT
AS
UPDATE dbo.NhanVien
SET IsDelete=1
WHERE MaNhanVien=@MaNhanVien

--Sao luu du lieu
GO
IF OBJECT_ID('dbo.[PSP_SaoLuuDuLieu]')IS NOT NULL
BEGIN
    DROP PROC dbo.[PSP_SaoLuuDuLieu]
END
GO
Create proc [dbo].[PSP_SaoLuuDuLieu]
	@duongdan nvarchar(max)
as
begin
	declare @dbname nvarchar(50)
	set @dbname =  DB_NAME()
	BACKUP DATABASE @dbname
	TO  DISK = @duongdan
	WITH NOFORMAT, NOINIT,  
	SKIP, NOREWIND, NOUNLOAD,  STATS = 10
	select ErrorCode = 1
END

--Lay du lieu combo
GO 
IF OBJECT_ID('dbo.PSP_NhanVien_LayDuLieuCbo')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_NhanVien_LayDuLieuCbo
END
GO
CREATE PROC PSP_NhanVien_LayDuLieuCbo
AS
SELECT MaNhanVien,TenNhanVien
FROM dbo.NhanVien
WHERE IsDelete=0
--reset mk nhan vien
GO 
IF OBJECT_ID('dbo.PSP_NhanVien_ResetMatKhau')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_NhanVien_ResetMatKhau
END
GO
CREATE PROC PSP_NhanVien_ResetMatKhau
@MaNhanVien INT
AS
UPDATE dbo.NhanVien
SET MatKhau=pwdencrypt(TenDangNhap)
WHERE MaNhanVien=@MaNhanVien
--Doi mk nhan vien
GO 
IF OBJECT_ID('dbo.PSP_NhanVien_DoiMatKhau')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_NhanVien_DoiMatKhau
END
GO
CREATE PROC PSP_NhanVien_DoiMatKhau
@MaNhanVien INT,
@MatKhau VARCHAR(30)
AS
UPDATE dbo.NhanVien
SET MatKhau=pwdencrypt(@MatKhau)
WHERE MaNhanVien=@MaNhanVien

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thủ tục kiểm tra đăng nhập
ALTER PROC [dbo].[PSP_NhanVien_KiemTraDangNhap] --'admin','admin'
@TenDangNhap VARCHAR(30),
@MatKhau VARCHAR(30)
AS	
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE TenDangNhap=@TenDangNhap AND pwdcompare(@MatKhau,MatKhau)=1)
BEGIN
    SELECT 1 AS code,TenNhanVien,MaTaiKhoan FROM dbo.NhanVien WHERE TenDangNhap=@TenDangNhap AND pwdcompare(@MatKhau,MatKhau)=1
END
ELSE
BEGIN
    SELECT 0 AS code,'' AS TenNhanVien,0 AS MaTaiKhoan
END

