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
        readonly Database data;
       public BLL_DanhMuc()
       {
           data = new Database();
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
