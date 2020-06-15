use DatabaseBanHang_17SE111
GO
create PROC PSH_NhaCungCap_Select
as
	select ROW_NUMBER() OVER (ORDER BY(SELECT 1) ) AS STT, MaNhaCungCap, TenNhaCungCap, MoTa, IsDelete
	from NhaCungCap 
	where IsDelete = 0;
	
GO
alter PROC PSH_NhaCungCap_Select
	as
	select ROW_NUMBER() OVER (ORDER BY(SELECT 1) ) AS STT, MaNhaCungCap, TenNhaCungCap, MoTa, IsDelete ,  0 AS ChonXoa
	from NhaCungCap 
	where IsDelete = 0;
	
Go
create Proc PSH_NhaCungCap_Delete @MaNhaCungCap int 
	as 
	Update NhaCungCap 
	set IsDelete = 1
	where MaNhaCungCap = @MaNhaCungCap
	
GO
 if object_id('PSH_NhaCungCap_InsertUpdate') is not null
begin
	drop proc dbol.PSH_NhaCungCap_InsertUpdate
end

GO
create proc PSH_NhaCungCap_InsertUpdate
	@MaNhaCungCap int,
	@TenNhaCungCap nvarchar(50),
	@MoTa nvarchar(200)
	as
	if exists ( select 1 from dbo.NhaCungCap where MaNhaCungCap = @MaNhaCungCap)
		begin
			Update dbo.NhaCungCap
			Set TenNhaCungCap = @TenNhaCungCap, MoTa = @MoTa
			where MaNhaCungCap = @MaNhaCungCap
		end
	else
 begin
	 insert into NhaCungCap(TenNhaCungCap,MoTa)
	 values (@TenNhaCungCap,@MoTa)
 end 
  