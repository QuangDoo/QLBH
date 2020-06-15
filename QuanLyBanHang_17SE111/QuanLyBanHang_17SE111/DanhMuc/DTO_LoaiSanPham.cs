using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.DanhMuc
{
    public class DTO_LoaiSanPham
    {
        string maLoaiSanPham, tenLoaiSanPham, moTa;
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

        public string TenLoaiSanPham
        {
            get { return tenLoaiSanPham; }
            set { tenLoaiSanPham = value; }
        }

        public string MaLoaiSanPham
        {
            get { return maLoaiSanPham; }
            set { maLoaiSanPham = value; }
        }
    }
}
