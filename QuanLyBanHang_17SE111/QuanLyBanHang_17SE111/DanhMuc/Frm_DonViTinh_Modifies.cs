using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111.DanhMuc
{
    public partial class Frm_DonViTinh_Modifies : Form
    {
        public Frm_DonViTinh_Modifies()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        public bool Them = false;
        string err = string.Empty;
        public DTO_DonViTinh donViTinh;
        int count = 0;
        private void Frm_DonViTinh_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            if (Them)
            {
                txtMadonvitinh.Text = "";
                txtTenDonViTinh.Focus();
            }
            else //sửa
            {
                //view thông tin cần sửa
                LayDuLieuVaoControl(donViTinh);
            }
        }

        private void LayDuLieuVaoControl(DTO_DonViTinh donViTinh)
        {
            txtMadonvitinh.Text = donViTinh.MaDonViTinh;
            txtTenDonViTinh.Text = donViTinh.TenDonViTinh;
            txtmota.Text = donViTinh.MoTa;
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenDonViTinh.Text))
            {
                LayThongTinDonViTinhTuControl();
                if (bd.CapNhatDonViTinh(ref err, ref count, donViTinh))
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
                txtTenDonViTinh.Focus();
            }
        }

        private void LayThongTinDonViTinhTuControl()
        {
            donViTinh = new DTO_DonViTinh();
            donViTinh.MaDonViTinh = txtMadonvitinh.Text;
            donViTinh.TenDonViTinh = txtTenDonViTinh.Text;
            donViTinh.MoTa = txtmota.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    
    }
}
