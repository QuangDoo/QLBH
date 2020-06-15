using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111.QuanLyNhapHang
{
    public partial class Frm_QLGiaban_Main : Form
    {
        public Frm_QLGiaban_Main()
        {
            InitializeComponent();
        }
        BLL_NhapHang bd;
        string err = string.Empty;
        DataTable dtGiaBan;
        public string tenSanPham = string.Empty;
        private void Frm_QLGiaban_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapHang();
            HienThiDanhSachGiaBan();
            lblTennhanVien.Text = string.Format("Nhân viên: {0}", Cls_Main.tenNhanVien);
            if (!string.IsNullOrEmpty(tenSanPham))
            {
                txtSearch.Text = tenSanPham ;
            }
        }

        private void HienThiDanhSachGiaBan()
        {
            dtGiaBan = new DataTable();
            dtGiaBan = bd.LayDanhSachSanPham(ref err);
            dgvGiaban.DataSource = dtGiaBan.DefaultView;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtGiaBan.DefaultView;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dv.RowFilter = string.Format("TenSanPham like '{0}%'",txtSearch.Text);
            }
            else
            {
                dv.RowFilter = "";
            }
            dgvGiaban.DataSource = dv;
        }
        string maSanPham;
        int donGiaBanHienHanh;
        int Index = 0;
        private void dgvGiaban_Click(object sender, EventArgs e)
        {
            if (dgvGiaban.Rows.Count > 0)
            {
                Index = dgvGiaban.CurrentRow.Index;
                maSanPham = dgvGiaban.CurrentRow.Cells["colMaSanPham"].Value.ToString();
                txtGiaban.Text = dgvGiaban.CurrentRow.Cells["colGiaBan"].Value.ToString();
                txtGiaban.Focus();
                txtGiaban.SelectAll();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string .IsNullOrEmpty(maSanPham))
            {
                if (!string.IsNullOrEmpty(txtGiaban.Text))
                {
                    donGiaBanHienHanh = Convert.ToInt32(txtGiaban.Text);
                    if (bd.ThayDoiGia(ref err, maSanPham, donGiaBanHienHanh, dtpNgayApDung.Value))
                    {
                        HienThiDanhSachGiaBan();
                        maSanPham = string.Empty;
                        donGiaBanHienHanh = 0;
                        txtGiaban.Text = "0";
                        dgvGiaban.Rows[0].Selected = false;
                        dgvGiaban.Rows[Index].Selected = true;
                    }
                        
                    else
                    {
                        MessageBox.Show(string.Format("Cập nhật không thành công {0}", err), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập giá");
                    txtGiaban.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm");
            }
        }
    }
}
