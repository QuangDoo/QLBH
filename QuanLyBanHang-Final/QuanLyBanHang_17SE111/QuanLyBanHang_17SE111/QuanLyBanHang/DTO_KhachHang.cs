using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    public class DTO_KhachHang
    {
        string maKH, tenKH, diaChi, dienThoai;
        bool isDelete;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
    }
}
