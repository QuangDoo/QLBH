GO
 CREATE PROC [dbo].[PSP_SanPham_LaySanPham] 
AS
    SELECT ROW_NUMBER() over (order by (select 1)) as STT, a.MaSanPham ,
            TenSanPham ,
            GiaBinhQuan ,
            GiaBanHienHanh,
            NgayApDung
    FROM    dbo.SanPham a JOIN GiaBan b ON a.MaSanPham=b.MaSanPham
    WHERE b.IsDelete=0