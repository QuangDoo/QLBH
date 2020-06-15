using MyLibrary;
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

namespace QuanLyBanHang_17SE111.DonViTinh
{
    public partial class Frm_donViTinh_Main : Form
    {
        public Frm_donViTinh_Main()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        string err = string.Empty;
        DataTable dtDonViTinh;
        DTO_DonViTinh donViTinh;
        int count = 0;
        private void Frm_donViTinh_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            HienThiDanhSachDonViTinh();
        }

        private void HienThiDanhSachDonViTinh()
        {
            dtDonViTinh = new DataTable();
            dtDonViTinh = bd.LayDanhSachDonViTinh(ref err);
            dgvDonViTinh.DataSource = dtDonViTinh;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvDonViTinh.EndEdit();
            for(int i = dgvDonViTinh.RowCount-1; i>=0 ; i--)
            {
                if(dgvDonViTinh.Rows[i].Cells["colChon"].Value.ToString().Equals("1"))
                {
                    bd.DeleteDonViTinh(ref err, dgvDonViTinh.Rows[i].Cells["colMaDonViTinh"].Value.ToString());
                }
               
            }
            
            HienThiDanhSachDonViTinh();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachDonViTinh();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Nơi chứa file Exprot Excel";
            save.DefaultExt = "xls";
            save.AddExtension = true;
            save.Filter = "File Excel (*.xls)|*.xls";
            save.RestoreDirectory = true;
            save.FileName = string.Format("ExportExcel_DonViTinh_{0}{1:00}{2:00}{3:00}{4:00}{5:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (save.ShowDialog() == DialogResult.OK)
            {
                Cls_Main.ExportExcelByMicrosoft(dgvDonViTinh, "Danh sách đơn vị tính", save.FileName, 65, "A2");
                
                 MessageBox.Show("Export Thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_DonViTinh_Modifies frm_donvitinh_modifies = new Frm_DonViTinh_Modifies();
            frm_donvitinh_modifies.Them = true;
            frm_donvitinh_modifies.ShowDialog();
            HienThiDanhSachDonViTinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Frm_DonViTinh_Modifies Frm_donvitinh_modifies = new Frm_DonViTinh_Modifies();
            Frm_donvitinh_modifies.Them = false;
            Frm_donvitinh_modifies.donViTinh = donViTinh;
            Frm_donvitinh_modifies.ShowDialog();
            HienThiDanhSachDonViTinh();
        }

        private void dgvDonViTinh_Click(object sender, EventArgs e)
        {
            if (dgvDonViTinh.Rows.Count > 0)
            {
                donViTinh = new DTO_DonViTinh();
                donViTinh.MaDonViTinh = dgvDonViTinh.CurrentRow.Cells["colMaDonViTinh"].Value.ToString();
                donViTinh.TenDonViTinh = dgvDonViTinh.CurrentRow.Cells["colTenDonViTinh"].Value.ToString();
                donViTinh.MoTa = dgvDonViTinh.CurrentRow.Cells["colMoTa"].Value.ToString();


            }
        }

        
    }
}
