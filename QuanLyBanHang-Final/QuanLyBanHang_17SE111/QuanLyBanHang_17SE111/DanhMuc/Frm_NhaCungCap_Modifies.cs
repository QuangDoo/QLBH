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
    public partial class Frm_NhaCungCap_Modifies : Form
    {
        public Frm_NhaCungCap_Modifies()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        public bool Them = false;
        string err = string.Empty;
        public DTO_NhaCungCap nhaCungCap;
        int count = 0;
        private void Frm_NhaCungCap_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            if (Them)
            {
                txtManhacungcap.Text = "";
                txtTennhaCungcap.Focus();
            }
            else //sửa
            {
                //view thông tin cần sửa
                LayDuLieuVaoControl(nhaCungCap);
            }
        }

         private void LayDuLieuVaoControl(DTO_NhaCungCap nhaCungCap)
        {
            txtManhacungcap.Text = nhaCungCap.MaNhaCungCap;
            txtTennhaCungcap.Text = nhaCungCap.TenNhaCungCap;
            txtMota.Text = nhaCungCap.MoTa;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTennhaCungcap.Text))
            {
                LayThongTinNhaCungCapControl();
                if (bd.CapNhatNhaCungCap(ref err, ref count, nhaCungCap))
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
                txtTennhaCungcap.Focus();
            }
        }
       
        private void LayThongTinNhaCungCapControl()
        {
            nhaCungCap = new DTO_NhaCungCap();
            nhaCungCap.MaNhaCungCap = txtManhacungcap.Text;
            nhaCungCap.TenNhaCungCap = txtTennhaCungcap.Text;
            nhaCungCap.MoTa = txtMota.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
