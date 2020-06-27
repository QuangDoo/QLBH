using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    public class BLL_KhachHang
    {
        Database data;
        public BLL_KhachHang()
        {
            data = new Database();
        }
        public System.Data.DataTable LayChiTietKH(ref string err)
        {
            return data.GetDataTable(ref err, "PSH_KhachHang_SelectAll", CommandType.StoredProcedure, null);
        }
        public bool XoaKhachHang(ref string err,ref int count, string maKH)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSH_KhachHang_Delete", CommandType.StoredProcedure, 
                new SqlParameter("@MaKH",maKH));
        }
        public bool CapNhatKhachHang(ref string err, ref int count, DTO_KhachHang khachHang)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSH_KhachHang_InsertUpdate", CommandType.StoredProcedure, 
                new SqlParameter("@MaKH",khachHang.MaKH),
                new SqlParameter("@TenKH", khachHang.TenKH),
                new SqlParameter("@DiaChi", khachHang.DiaChi),
                new SqlParameter("@SDT", khachHang.DienThoai));
        }
    }
}
