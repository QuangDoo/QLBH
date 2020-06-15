using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang_17SE111.DanhMuc;

namespace QuanLyBanHang_17SE111.DanhMuc
{
    public partial class Frm_LoaisanPham_Modifies : Form
    {
        public Frm_LoaisanPham_Modifies()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        public bool Them = false;
        string err = string.Empty;
        public DTO_LoaiSanPham loaiSanPham;
        int count = 0;
        private void Frm_LoaisanPham_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            if (Them)
            {
                txtMasanpham.Text = "";
                txtTensanpham.Focus();
            }
            else //sửa
            {
                //view thông tin cần sửa
                LayDuLieuVaoControl(loaiSanPham);
                txtTensanpham.Focus();
            }
        }

        private void LayDuLieuVaoControl(DTO_LoaiSanPham loaiSanPham)
        {
            txtMasanpham.Text = loaiSanPham.MaLoaiSanPham;
            txtTensanpham.Text = loaiSanPham.TenLoaiSanPham;
            txtmota.Text = loaiSanPham.MoTa;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTensanpham.Text))
            {
                LayThongTinLoaiSanPhamControl();
                if (bd.CapNhatLoaiSanPham(ref err, ref count, loaiSanPham))
                {

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa thêm thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thành công");
                txtTensanpham.Focus();
            }
        }

        private void LayThongTinLoaiSanPhamControl()
        {
            loaiSanPham = new DTO_LoaiSanPham();
            loaiSanPham.MaLoaiSanPham = txtMasanpham.Text;
            loaiSanPham.TenLoaiSanPham = txtTensanpham.Text;
            loaiSanPham.MoTa = txtmota.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
