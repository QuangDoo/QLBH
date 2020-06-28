using QuanLyBanHang_17SE111.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    public partial class Frm_BanHang : Form
    {
        public Frm_BanHang()
        {
            InitializeComponent();
        }

        readonly BLL_BanHang bd;
        readonly string err = string.Empty;
        readonly DataTable dtBanHang;
        //public DTO_NhaCungCap dtBanHang;
        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            btnTinh.Enabled = true;
            
            btnXoa.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaHDBan.ReadOnly = true;
           
            txtTenKhach.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            
            txtTongTien.Text = "0";
            
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHDBan.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            //LoadDataGridView();
        }

        //private void LoadDataGridView()
        //{
        //    dtBanHang = new DataTable();
        //    dtBanHang = bd.LayDanhSachNhaCungCap(ref err);
        //    dgvDanhSachBan.DataSource = dtBanHang;
        //}

        private void LoadInfoHoaDon()
        {
            throw new NotImplementedException();
        }

       
    }
}
