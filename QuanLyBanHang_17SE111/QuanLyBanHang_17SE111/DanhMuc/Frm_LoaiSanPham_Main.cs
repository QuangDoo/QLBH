using MyLibrary;
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
    public partial class Frm_LoaiSanPham_Main : Form
    {
        public Frm_LoaiSanPham_Main()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        string err = string.Empty;
        DataTable dtLoaiSanPham;
       public DTO_LoaiSanPham loaiSanPham;
        private void Frm_LoaiSanPham_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            HienThiDanhSachLoaiSanPham();
        }

        private void HienThiDanhSachLoaiSanPham()
        {
            dtLoaiSanPham = new DataTable();
            dtLoaiSanPham = bd.LayDanhSachLoaiSanPham(ref err);
            dgvLoaiSanPham.DataSource = dtLoaiSanPham;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvLoaiSanPham.EndEdit();
            for (int i = dgvLoaiSanPham.RowCount - 1; i >= 0; i--)
            {
                if (dgvLoaiSanPham.Rows[i].Cells["colChonXoa"].Value.ToString().Equals("1"))
                {
                    bd.DeleteLoaiSanPham(ref err, dgvLoaiSanPham.Rows[i].Cells["colMaLoaiSanPham"].Value.ToString());
                }
            }
            HienThiDanhSachLoaiSanPham();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Nơi chứa file Exprot Excel";
            save.DefaultExt = "xls";
            save.AddExtension = true;
            save.Filter = "File Excel (*.xls)|*.xls";
            save.RestoreDirectory = true;
            save.FileName = string.Format("ExportExcel_LoaiSanPham_{0}{1:00}{2:00}{3:00}{4:00}{5:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (save.ShowDialog() == DialogResult.OK)
            {

                Cls_Main.ExportExcelByMicrosoft(dgvLoaiSanPham, "Danh sách loại sản phẩm", save.FileName, 65, "A2");
                MessageBox.Show("Export Thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSanPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Frm_LoaisanPham_Modifies frm_loaiSanPham_Modifies = new Frm_LoaisanPham_Modifies();
            frm_loaiSanPham_Modifies.Them = false;
            frm_loaiSanPham_Modifies.loaiSanPham = loaiSanPham;
            frm_loaiSanPham_Modifies.ShowDialog();
            HienThiDanhSachLoaiSanPham();
        }

        private void dgvLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.Rows.Count > 0)
            {
                loaiSanPham = new DTO_LoaiSanPham();
                loaiSanPham.MaLoaiSanPham = dgvLoaiSanPham.CurrentRow.Cells["colMaLoaiSanPham"].Value.ToString();
                loaiSanPham.TenLoaiSanPham = dgvLoaiSanPham.CurrentRow.Cells["colTenLoaiSanPham"].Value.ToString();
                loaiSanPham.MoTa = dgvLoaiSanPham.CurrentRow.Cells["colMoTa"].Value.ToString();


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_LoaisanPham_Modifies frm_loaiSanPham_modifies = new Frm_LoaisanPham_Modifies();
            frm_loaiSanPham_modifies.Them = true;
            frm_loaiSanPham_modifies.ShowDialog();
            HienThiDanhSachLoaiSanPham();

        }
    }
}
