 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.DanhMuc
{
     public class DTO_NhaCungCap
    {
        string maNhaCungCap, tenNhaCungCap, moTa;
        bool isDelete;

        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }

        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
    }
}
