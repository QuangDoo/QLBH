-- Lay ten chi tiet nhap hang
IF OBJECT_ID('dbo.PSP_LayTenColumnChiTietNhapHang') IS NOT NULL
    BEGIN
        DROP PROC dbo.PSP_LayTenColumnChiTietNhapHang;
    END;
GO	
CREATE PROC [dbo].[PSP_LayTenColumnChiTietNhapHang]
AS
    SELECT DISTINCT
            a.name
    FROM    sys.all_columns a
            JOIN sys.tables b ON a.object_id = b.object_id
    WHERE   b.name = 'phieuNhap'
            OR b.name = 'ChiTietPhieuNhap'
            OR b.name = 'sanpham';
IF OBJECT_ID('dbo.PSP_NhapHang_XoaPhieuNhapThepMaPhieu') IS NOT NULL
    BEGIN
        DROP PROC dbo.PSP_NhapHang_XoaPhieuNhapThepMaPhieu;
    END;
-- Xoa Phieu nhap hang theo ma phieu
GO	
CREATE PROC PSP_NhapHang_XoaPhieuNhapThepMaPhieu @MaPhieuNhap CHAR(13)
AS
    SET XACT_ABORT ON;
    BEGIN TRAN;
    DECLARE @MaSanPham INT;
    DECLARE _ChiTietPhieuNhap_Cur CURSOR FAST_FORWARD
    FOR
        SELECT  MaSanPham
        FROM    dbo.ChiTietPhieuNhap
        WHERE   MaPhieuNhap = @MaPhieuNhap;
 
    OPEN _ChiTietPhieuNhap_Cur;
    FETCH NEXT FROM _ChiTietPhieuNhap_Cur INTO @MaSanPham; 
    WHILE @@FETCH_STATUS = 0
        BEGIN
            DELETE  dbo.ChiTietPhieuNhap
            WHERE   MaSanPham = @MaSanPham
                    AND MaPhieuNhap = @MaPhieuNhap;
            FETCH NEXT FROM _ChiTietPhieuNhap_Cur INTO @MaSanPham;
        END;
    CLOSE _ChiTietPhieuNhap_Cur;
    DEALLOCATE _ChiTietPhieuNhap_Cur;
    
    DELETE  dbo.PhieuNhap
    WHERE   MaPhieuNhap = @MaPhieuNhap;
    COMMIT;
    -- insert Chi tiet phieu nhap
    SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE PROC [dbo].[PSP_NhapHang_InsertChiTietPhieuNhap]
    @MaPhieuNhap CHAR(13) ,
    @NgayNhap DATETIME ,
    @MaNhanVien INT ,
    @MaSanPham INT ,
    @SoLuongNhap BIGINT ,
    @DonGiaNhap BIGINT ,
    @TenSanPham NVARCHAR(50) ,
    @MoTa NVARCHAR(200) ,
    @MaLoaiSanPham INT ,
    @MaNhaCungCap INT ,
    @DonGiaBan INT
AS --Kiểm tra phiếu nhập tồn tài
	--nếu có
		--kiem tra xem san pham co chua
	--ngược cách khác
		--kiem tra xem san pham co chua
    DECLARE @MaSanPhamNew INT;
    IF EXISTS ( SELECT  1
                FROM    dbo.PhieuNhap
                WHERE   MaPhieuNhap = @MaPhieuNhap )
        BEGIN--có mã phiếu nhập
            IF EXISTS ( SELECT  1
                        FROM    dbo.SanPham
                        WHERE   MaSanPham = @MaSanPham )
                BEGIN--có sản phẩm
                    INSERT  INTO ChiTietPhieuNhap
                            ( MaPhieuNhap ,
                              MaSanPham ,
                              SoLuongNhap ,
                              DonGiaNhap ,
                              SoLuongNhapTon
                            )
                    VALUES  ( @MaPhieuNhap ,
                              @MaSanPham ,
                              @SoLuongNhap ,
                              @DonGiaNhap ,
                              @SoLuongNhap
                            );
                END;	--Có sản phẩm
            ELSE
                BEGIN --Không có sản phẩm
                    INSERT  INTO SanPham
                            ( TenSanPham ,
                              MoTa ,
                              MaDonViTinh ,
                              MaLoaiSanPham ,
                              MaNhaCungCap ,
                              SoLuongTon ,
                              DonGiaBinhQuan ,
                              IsDelete
                            )
                    VALUES  ( @TenSanPham ,
                              @MoTa ,
                              @MaDonViTinh ,
                              @MaLoaiSanPham ,
                              @MaNhaCungCap ,
                              0 ,
                              0 ,
                              0
                            );
				
                    SET @MaSanPhamNew = ( SELECT    MAX(MaSanPham)
                                          FROM      dbo.SanPham
                                          WHERE     IsDelete = 0
                                        );
				
                    INSERT  INTO ChiTietPhieuNhap
                            ( MaPhieuNhap ,
                              MaSanPham ,
                              SoLuongNhap ,
                              DonGiaNhap ,
                              SoLuongNhapTon
                            )
                    VALUES  ( @MaPhieuNhap ,
                              @MaSanPhamNew ,
                              @SoLuongNhap ,
                              @DonGiaNhap ,
                              @SoLuongNhap
                            );	
		
                    INSERT  INTO GiaBan
                            ( MaSanPham, GiaBanHienHanh )
                    VALUES  ( @MaSanPhamNew, @DonGiaBan );	    		
                END; --không có sản phẩm
        END;--có mã phiếu nhập
    ELSE
        BEGIN--không có mã phiếu nhập
            INSERT  INTO dbo.PhieuNhap
                    ( MaPhieuNhap ,
                      NgayNhap ,
                      MaNhanVien
                    )
            VALUES  ( @MaPhieuNhap ,
                      @NgayNhap ,
                      @MaNhanVien
                    );
	    
            IF EXISTS ( SELECT  1
                        FROM    dbo.SanPham
                        WHERE   MaSanPham = @MaSanPham )
                BEGIN--có sản phẩm
                    INSERT  INTO ChiTietPhieuNhap
                            ( MaPhieuNhap ,
                              MaSanPham ,
                              SoLuongNhap ,
                              DonGiaNhap ,
                              SoLuongNhapTon
                            )
                    VALUES  ( @MaPhieuNhap ,
                              @MaSanPham ,
                              @SoLuongNhap ,
                              @DonGiaNhap ,
                              @SoLuongNhap
                            );
                END;	--Có sản phẩm
            ELSE
                BEGIN --Không có sản phẩm
                    INSERT  INTO SanPham
                            ( TenSanPham ,
                              MoTa ,
                              MaDonViTinh ,
                              MaLoaiSanPham ,
                              MaNhaCungCap ,
                              SoLuongTon ,
                              DonGiaBinhQuan ,
                              IsDelete
                            )
                    VALUES  ( @TenSanPham ,
                              @MoTa ,
                              @MaDonViTinh ,
                              @MaLoaiSanPham ,
                              @MaNhaCungCap ,
                              0 ,
                              0 ,
                              0
                            );
				
			
                    SET @MaSanPhamNew = ( SELECT    MAX(MaSanPham)
                                          FROM      dbo.SanPham
                                          WHERE     IsDelete = 0
                                        );
				
                    INSERT  INTO ChiTietPhieuNhap
                            ( MaPhieuNhap ,
                              MaSanPham ,
                              SoLuongNhap ,
                              DonGiaNhap ,
                              SoLuongNhapTon
                            )
                    VALUES  ( @MaPhieuNhap ,
                              @MaSanPhamNew ,
                              @SoLuongNhap ,
                              @DonGiaNhap ,
                              @SoLuongNhap
                            );	
		
                    INSERT  INTO GiaBan
                            ( MaSanPham, GiaBanHienHanh )
                    VALUES  ( @MaSanPhamNew, @DonGiaBan );			
                END; --không có sản phẩm
        END;	--không có mã phiếu nhập
        
--Lay chi tiet nhap hang
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE PROC [dbo].[PSP_NhapHang_LayChiTietNhapHang]
    @MaPhieuNhap CHAR(13) = '0'
AS
    SELECT  ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                         ) ) AS STT ,
            a.MaPhieuNhap ,
            a.NgayNhap ,
            a.MaNhanVien ,
            c.TenNhanVien ,
            b.MaSanPham ,
            d.TenSanPham ,
            b.SoLuongNhap ,
            b.SoLuongNhapTon ,
            b.DonGiaNhap ,
            b.SoLuongNhap * b.DonGiaNhap AS ThanhTienNhap ,
            d.MaLoaiSanPham ,
            e.TenLoaiSanPham ,
            d.MaNhaCungCap ,
            f.TenNhaCungCap ,
            d.MaDonViTinh ,
            g.TenDonViTinh ,
            GiaBanHienHanh
    FROM    dbo.PhieuNhap a
            JOIN dbo.ChiTietPhieuNhap b ON b.MaPhieuNhap = a.MaPhieuNhap
            JOIN dbo.NhanVien c ON c.MaNhanVien = a.MaNhanVien
            JOIN dbo.SanPham d ON d.MaSanPham = b.MaSanPham
            JOIN dbo.LoaiSanPham e ON e.MaLoaiSanPham = d.MaLoaiSanPham
            JOIN dbo.NhaCungCap f ON f.MaNhaCungCap = d.MaNhaCungCap
            JOIN dbo.DonViTinh g ON g.MaDonViTinh = d.MaDonViTinh
            JOIN GiaBan j ON j.MaSanPham = d.MaSanPham
    WHERE   @MaPhieuNhap = CASE @MaPhieuNhap
                             WHEN '0' THEN '0'
                             ELSE a.MaPhieuNhap
                           END
            AND j.IsDelete = 0;
            GO
            CREATE PROC [dbo].[PSP_NhapHang_UpdateChiTietPhieuNhap]
    @MaPhieuNhap CHAR(13), 
@NgayNhap DATETIME, 
@MaNhanVien INT,
@MaSanPham int, 
@SoLuongNhap BIGINT, 
@DonGiaNhap BIGINT,
@TenSanPham nvarchar(50), 
@MoTa NVARCHAR(200), 
@MaDonViTinh INT, 
@MaLoaiSanPham INT, 
@MaNhaCungCap INT ,
@GiaBanHienHanh INT 
AS
SET XACT_ABORT ON
BEGIN TRAN
    UPDATE  dbo.SanPham
    SET     TenSanPham = @TenSanPham ,
            MoTa = @MoTa ,
            MaDonViTinh = @MaDonViTinh ,
            MaLoaiSanPham = @MaLoaiSanPham ,
            MaNhaCungCap = @MaNhaCungCap
    WHERE   MaSanPham = @MaSanPham;      

    UPDATE  dbo.PhieuNhap
    SET     NgayNhap = @NgayNhap
    WHERE   MaPhieuNhap = @MaPhieuNhap;

    UPDATE  dbo.ChiTietPhieuNhap
    SET     SoLuongNhap = @SoLuongNhap ,
            DonGiaNhap = @DonGiaNhap,
            SoLuongNhapTon=@SoLuongNhap
    WHERE   MaPhieuNhap = @MaPhieuNhap
            AND MaSanPham = @MaSanPham; 
            
            
    UPDATE GiaBan
    SET IsDelete=1
    WHERE MaSanPham=@MaSanPham   AND IsDelete=0
    
    INSERT INTO GiaBan(MaSanPham,GiaBanHienHanh)
    VALUES(@MaSanPham,@GiaBanHienHanh)
COMMIT
GO
create PROC [dbo].[PSP_NhapHang_LayThongTinSanPhamTheoHang]
@MaLoaiSanPham INT
AS
SELECT a.MaSanPham, TenSanPham, MoTa, MaDonViTinh, MaLoaiSanPham, MaNhaCungCap, SoLuongTon, DonGiaBinhQuan,GiaBanHienHanh
FROM dbo.SanPham a JOIN giaBan b ON a.MaSanPham=b.MaSanPham
WHERE MaLoaiSanPham=@MaLoaiSanPham AND a.IsDelete=0 AND b.IsDelete=0 