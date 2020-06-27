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

namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        BLL_KhachHang kh;
        DataTable dt;
        string err = string.Empty;
        DTO_KhachHang khachHang;
        int count = 0;
        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            kh = new BLL_KhachHang();
            HienThiKhachHang();
        }

        private void HienThiKhachHang()
        {
            dt = new DataTable();
            dt = kh.LayChiTietKH(ref err);
            dgvKhachHang.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                if (MessageBox.Show(string.Format("Chương trình sẽ thực hiện thao tác xóa khách hàng {0} khỏi hệ thống \nViệc này sẽ làm cho dữ liệu của Khách hàng {1} bị thay đổi và không thể phục hồi \nBạn có chắc chắn muốn xóa dữ liệu này không?\n Nếu đồng ý chọn OK.", khachHang.TenKH, khachHang.TenKH), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    count = 0;
                    if (kh.XoaKhachHang(ref err, ref count, khachHang.MaKH))
                    {
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                            HienThiKhachHang();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công\n" + err);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công\n" + err);
                    }
                }
            }
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 0)
            {
                khachHang = new DTO_KhachHang();
                khachHang.MaKH = dgvKhachHang.CurrentRow.Cells["colMaKH"].Value.ToString();
                khachHang.TenKH = dgvKhachHang.CurrentRow.Cells["colTenKH"].Value.ToString();
                khachHang.DiaChi = dgvKhachHang.CurrentRow.Cells["colDiaChi"].Value.ToString();
                khachHang.DienThoai = dgvKhachHang.CurrentRow.Cells["colSDT"].Value.ToString();
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Nơi chứa file Exprot Excel";
            save.DefaultExt = "xls";
            save.AddExtension = true;
            save.Filter = "File Excel (*.xls)|*.xls";
            save.RestoreDirectory = true;
            save.FileName = string.Format("ExportExcel_{0}{1:00}{2:00}{3:00}{4:00}{5:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (save.ShowDialog() == DialogResult.OK)
            {
                ExportExcel.ExportExcelByMicrosoft(dgvKhachHang, "Danh sách khách hàng", save.FileName, 65, "A2");

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang_Modified kh_modified = new Frm_KhachHang_Modified();
            kh_modified.Them = true;
            kh_modified.ShowDialog();
            HienThiKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Frm_KhachHang_Modified kh_modified = new Frm_KhachHang_Modified();
            kh_modified.Them = true;
            kh_modified.khachHang = khachHang;
            kh_modified.ShowDialog();
            HienThiKhachHang();
        }
    }
}
