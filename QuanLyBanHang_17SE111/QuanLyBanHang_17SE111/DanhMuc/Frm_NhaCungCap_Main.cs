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
    public partial class Frm_NhaCungCap_Main : Form
    {
        public Frm_NhaCungCap_Main()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        string err = string.Empty;
        DataTable dtNhaCungCap;
        public DTO_NhaCungCap nhaCungCap;

        private void HienThiDanhSachNhaCungCap()
        {
            dtNhaCungCap = new DataTable();
            dtNhaCungCap = bd.LayDanhSachNhaCungCap(ref err);
            dgvNhaCungCap.DataSource = dtNhaCungCap;
        }

        private void Frm_NhaCungCap_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            HienThiDanhSachNhaCungCap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvNhaCungCap.EndEdit();
            for(int i = dgvNhaCungCap.RowCount-1; i>=0 ; i--)
            {
                if(dgvNhaCungCap.Rows[i].Cells["colChonXoa"].Value.ToString().Equals("1"))
                {
                    bd.DeleteNhaCungCap(ref err, dgvNhaCungCap.Rows[i].Cells["colMaNhaCungCap"].Value.ToString());
                }
            }
            HienThiDanhSachNhaCungCap();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Nơi chứa file Exprot Excel";
            save.DefaultExt = "xls";
            save.AddExtension = true;
            save.Filter = "File Excel (*.xls)|*.xls";
            save.RestoreDirectory = true;
            save.FileName = string.Format("ExportExcel_NhaCungCap_{0}{1:00}{2:00}{3:00}{4:00}{5:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (save.ShowDialog() == DialogResult.OK)
            {

                Cls_Main.ExportExcelByMicrosoft(dgvNhaCungCap, "Danh sách nhà cung cấp", save.FileName, 65, "A2");
                MessageBox.Show("Export Thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNhaCungCap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCap_Modifies frm_nhacungcap_modifies = new Frm_NhaCungCap_Modifies();
            frm_nhacungcap_modifies.Them = false;
            frm_nhacungcap_modifies.nhaCungCap = nhaCungCap;
            frm_nhacungcap_modifies.ShowDialog();
            HienThiDanhSachNhaCungCap();
        }

        private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.Rows.Count > 0)
            {
                nhaCungCap = new DTO_NhaCungCap();
                nhaCungCap.MaNhaCungCap = dgvNhaCungCap.CurrentRow.Cells["colMaNhaCungCap"].Value.ToString();
                nhaCungCap.TenNhaCungCap = dgvNhaCungCap.CurrentRow.Cells["colTenNhaCungCap"].Value.ToString();
                nhaCungCap.MoTa = dgvNhaCungCap.CurrentRow.Cells["colMoTa"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCap_Modifies frm_nhacungcap_modifies = new Frm_NhaCungCap_Modifies();
            frm_nhacungcap_modifies.Them = true;
            frm_nhacungcap_modifies.ShowDialog();
            HienThiDanhSachNhaCungCap();
        }
        
        

       

        

      
    }
}
