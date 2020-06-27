use DatabaseBanHang_17SE111

GO
create PROC PSH_DonViTinh_Select
as
	select ROW_NUMBER() OVER (ORDER BY(SELECT 1) ) AS STT, MaDonViTinh, TenDonViTinh, MoTa, IsDelete 
	from DonViTinh 
	where IsDelete = 0;
	
alter proc PSH_DonViTinh_Select
as
	select ROW_NUMBER() OVER (ORDER BY(SELECT 1) ) AS STT, MaDonViTinh, TenDonViTinh, MoTa, IsDelete , 0 AS ChonXoa
	from DonViTinh 
	where IsDelete = 0;
	
Go
create Proc PSH_DonViTinh_Delete @MaDonViTinh int 
	as 
	Update DonViTinh 
	set IsDelete = 1
	where MaDonViTinh = @MaDonViTinh

GO
if object_id('PSH_DonViTinh_InsertUpdate') is not null
begin
drop proc dbol.PSH_DonViTinh_InsertUpdate
end

GO
create Proc PSH_DonViTinh_InsertUpdate
	@MaDonViTinh int,
	@TenDonViTinh nvarchar(50),
	@MoTa nvarchar(200)
as
if exists ( select 1 from dbo.DonViTinh where MaDonViTinh = @MaDonViTinh)
begin
	update dbo.DonViTinh
	set TenDonViTinh = @TenDonViTinh, MoTa = @MoTa
	where MaDonViTinh=@MaDonViTinh
end
else
begin
	insert into DonViTinh(TenDonViTinh, MoTa)
	values (@TenDonViTinh,@MoTa)
end