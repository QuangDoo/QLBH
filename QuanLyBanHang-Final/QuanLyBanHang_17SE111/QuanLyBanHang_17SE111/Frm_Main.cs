using QuanLyBanHang_17SE111.DanhMuc;
using QuanLyBanHang_17SE111.Help;
using QuanLyBanHang_17SE111.HeThong;
using QuanLyBanHang_17SE111.QuanLyBanHang;
using QuanLyBanHang_17SE111.QuanLyNhapHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111
{
    public partial class Frm_Main: Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        Database data;
        string err = string.Empty;
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
            GioHeThong.Start();
            data = new Database();
            if (data.KiemTraKetNoi(ref err))
            {
                MessageBox.Show("Kết nối thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết nối thất bại.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void mnuDangXuat_Click(object sender, EventArgs e)
        //{
        //    Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
        //    frm_DangNhap.ShowDialog();
        //    lblTenNhanVien.Text = Cls_Main.tenNhanVien;
        //}

        private void mnuSaoLuu_Click(object sender, EventArgs e)
        {
            Frm_SaoLuuPhucHoi frm_SaoLuuPhucHoi = new Frm_SaoLuuPhucHoi();
            frm_SaoLuuPhucHoi.saoLuuStatus = true;
            frm_SaoLuuPhucHoi.ShowDialog();
        }

        private void mnuPhucHoi_Click(object sender, EventArgs e)
        {
            Frm_SaoLuuPhucHoi frm_SaoLuuPhucHoi = new Frm_SaoLuuPhucHoi();
            frm_SaoLuuPhucHoi.saoLuuStatus = false;
            frm_SaoLuuPhucHoi.ShowDialog();
        }


        private void mnuChiTietNhap_Click(object sender, EventArgs e)
        {
            Frm_NhapHang_Main frmNhapHang = new Frm_NhapHang_Main();
            frmNhapHang.ShowDialog();
        }


        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCap_Main frm_nhacungcap = new Frm_NhaCungCap_Main();
            frm_nhacungcap.MdiParent = this;
            frm_nhacungcap.Show();
        }

        private void btnGiaban_Click(object sender, EventArgs e)
        {
            Frm_QLGiaban_Main frm_qlgiaban_main = new Frm_QLGiaban_Main();
            frm_qlgiaban_main.MdiParent = this;
            frm_qlgiaban_main.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBanhang_Click(object sender, EventArgs e)
        {
            Frm_BanHang banhang = new Frm_BanHang();
            banhang.MdiParent = this;
            banhang.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Main frm_NhanVien_Main = new Frm_NhanVien_Main();
            frm_NhanVien_Main.MdiParent = this;
            frm_NhanVien_Main.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
            frm_DoiMatKhau.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GioHeThong_Tick(object sender, EventArgs e)
        {
            lblTimer.Text =  DateTime.Now.ToLongTimeString().ToString();
        }

        private void mnu_about_Click(object sender, EventArgs e)
        {
            Frm_About_Us frm_about = new Frm_About_Us();
            frm_about.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact frm_contact = new Contact();
            frm_contact.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang kh = new Frm_KhachHang();
            kh.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
        }
    }
}
