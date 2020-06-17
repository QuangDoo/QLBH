create proc PST_TimSanPhamTheoMa
as declare
@MaSanPham int
select * from dbo.SanPham where MaSanPham = @MaSanPham
