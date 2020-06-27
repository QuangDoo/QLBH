USE DatabaseBanHang
GO

Go
create proc PSH_KhachHang_SelectAll
as
	Select ROW_NUMBER() over (order by (select 1)) as STT, MaKH, TenKH, DiaChi, DienThoai, IsDelete, 0 as ChonXoa
	from dbo.KhachHang
	where IsDelete = 0
	
Go
create Proc PSH_KhachHang_Delete @MaKH int 
	as 
	Update dbo.KhachHang
	set IsDelete = 1
	where MaKH = @MaKH
	

GO
create  proc PSH_KhachHang_InsertUpdate
	@MaKH int,
	@TenKH nvarchar(50),
	@DiaChi nvarchar(200),
	@SDT varchar(13)
	as
	if exists ( select 1 from dbo.KhachHang where MaKH = @MaKH)
		begin
			Update dbo.KhachHang
			Set TenKH = @TenKH, DiaChi = @DiaChi, DienThoai = @SDT
			where MaKH = @MaKH
		end
	else
	begin
		 insert into dbo.KhachHang(TenKH, DiaChi, DienThoai)
		 values (@TenKH, @DiaChi, @SDT)
	end 
 