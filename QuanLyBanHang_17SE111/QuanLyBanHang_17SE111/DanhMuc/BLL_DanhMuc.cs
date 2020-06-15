using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.DanhMuc
{
   public class BLL_DanhMuc
    {
       Database data;
       public BLL_DanhMuc()
       {
           data = new Database();
       }
       public DataTable LayDanhSachDonViTinh(ref string err)
       {
           return data.GetDataTable(ref err, "PSH_DonViTinh_Select", CommandType.StoredProcedure, null);
       }
       public bool DeleteDonViTinh(ref string err, string maDonViTinh)
       {
           return data.MyExcuteNonQuery(ref err, "PSH_DonViTinh_Delete", CommandType.StoredProcedure, new SqlParameter("@MaDonViTinh", maDonViTinh));
       }
       public bool CapNhatDonViTinh(ref string err, ref int count, DTO_DonViTinh donViTinh)
       {
           return data.MyExcuteNonQuery(ref err, ref count, "PSH_DonViTinh_InsertUpdate", CommandType.StoredProcedure,
               new SqlParameter("@MaDonViTinh", donViTinh.MaDonViTinh),
                new SqlParameter("@TenDonViTinh", donViTinh.TenDonViTinh),
                new SqlParameter("@Mota", donViTinh.MoTa));
       }
       public bool XoaDonViTinhByDeleteByUpdateIsDelete(ref string err, ref int count, DTO_DonViTinh donViTinh)
       {
           return data.MyExcuteNonQuery(ref err, ref count, "PSH_DonViTinh_DeleteByUpdateIsDelete", CommandType.StoredProcedure,
               new SqlParameter("@MaDonViTinh", donViTinh.MaDonViTinh));
       }
       public DataTable LayDanhSachLoaiSanPham(ref string err)
       {
           return data.GetDataTable(ref err, "PSH_LoaiSanPham_Select", CommandType.StoredProcedure, null);
       }
       public bool DeleteLoaiSanPham(ref string err, string maLoaiSanPham)
       {
           return data.MyExcuteNonQuery(ref err, "PSH_LoaisanPham_Delete", CommandType.StoredProcedure, new SqlParameter("@MaLoaiSanPham", maLoaiSanPham));
       }
       public bool CapNhatLoaiSanPham(ref string err, ref int count, DTO_LoaiSanPham loaiSanPham)
       {
           return data.MyExcuteNonQuery(ref err, ref count, "PSH_LoaiSanPham_InsertUpdate", CommandType.StoredProcedure,
               new SqlParameter("@MaLoaiSanPham", loaiSanPham.MaLoaiSanPham),
               new SqlParameter("@TenLoaiSanPham", loaiSanPham.TenLoaiSanPham),
               new SqlParameter("@MoTa", loaiSanPham.MoTa));
       }
       public bool XoaLoaiSanPhamByDeleteByUpdateIsDelete(ref string err, ref int count, string maLoaiSanPham)
       {
           return data.MyExcuteNonQuery(ref err, ref count, "PSH_LoaiSanPham_DeleteByUpdateIsDelete", CommandType.StoredProcedure,
               new SqlParameter("@MaLoaiSanPham", maLoaiSanPham));
       }

       public DataTable LayDanhSachNhaCungCap(ref string err)
       {
           return data.GetDataTable(ref err, "PSH_NhaCungCap_Select", CommandType.StoredProcedure, null);
       }
       public bool DeleteNhaCungCap(ref string err, string maNhaCungCap)
       {
           return data.MyExcuteNonQuery(ref err, "PSH_NhaCungCap_Delete", CommandType.StoredProcedure, new SqlParameter("@MaNhaCungCap", maNhaCungCap));
       }
       public bool CapNhatNhaCungCap(ref string err, ref int count, DTO_NhaCungCap nhaCungCap)
       {
           return data.MyExcuteNonQuery(ref err, ref count, "PSH_NhaCungCap_InsertUpdate", CommandType.StoredProcedure,
               new SqlParameter("@MaNhaCungCap", nhaCungCap.MaNhaCungCap),
               new SqlParameter("@TenNhaCungCap", nhaCungCap.TenNhaCungCap),
               new SqlParameter("@MoTa", nhaCungCap.MoTa));
       }
       public bool XoaNhaCungCapByDeleteByUpdateIsDelete(ref string err, ref int count, string maNhaCungCap)
       {
           return data.MyExcuteNonQuery(ref err, ref count, "PSH_NhaCungCap_DeleteByUpdateIsDelete", CommandType.StoredProcedure,
               new SqlParameter("@MaNhaCungCap", maNhaCungCap));
       }
       
       
       
    }
}
