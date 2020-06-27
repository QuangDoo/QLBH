using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    public class BLL_BanHang
    {
        readonly Database data;
        public BLL_BanHang()
        {
            data = new Database();
        }
        public DataTable LayDanhSachHoaDon(ref string err)
        {
            return data.GetDataTable(ref err, "PSH_NhaCungCap_Select", CommandType.StoredProcedure, null);
        }
    }
}
