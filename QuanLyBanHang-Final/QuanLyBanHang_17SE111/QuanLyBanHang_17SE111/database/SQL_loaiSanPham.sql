use DatabaseBanHang
Go
create PROC PSH_LoaiSanPham_Select
as
	select ROW_NUMBER() OVER (ORDER BY(SELECT 1) ) AS STT, MaLoaiSanPham, TenLoaiSanPham, MoTa, IsDelete
	from LoaiSanPham 
	where IsDelete = 0;
	
alter PROC PSH_LoaiSanPham_Select
as
	select ROW_NUMBER() OVER (ORDER BY(SELECT 1) ) AS STT,MaLoaiSanPham, TenLoaiSanPham, MoTa, IsDelete, 0 AS ChonXoa
	from LoaiSanPham 
	where IsDelete = 0;
	
Go
create Proc PSH_LoaiSanPham_Delete @MaLoaiSanPham int 
	as 
	Update LoaiSanPham 
	set IsDelete = 1
	where MaLoaiSanPham = @MaLoaiSanPham

Go
if object_id('PSH_LoaiSanPham_InsertUpdate') is not null
begin
	Drop Proc dbol.PSH_LoaiSanPham_InsertUpdate
end
go
create proc PSH_LoaiSanPham_InsertUpdate
	@MaLoaiSanPham int,
	@TenLoaiSanPham nvarchar(50),
	@MoTa nvarchar(200)
as
if exists ( select 1 from dbo.LoaiSanPham where
	MaLoaiSanPham = @MaLoaiSanPham)
	begin
		Update dbo.LoaiSanPham
		SET TenLoaiSanPham = @TenLoaiSanPham, MoTa = @MoTa
		Where MaLoaiSanPham = @MaLoaiSanPham
	end
else
	 begin
	 insert into LoaiSanPham(TenLoaiSanPham, MoTa)
	 values (@TenLoaiSanPham, @MoTa)
 end 