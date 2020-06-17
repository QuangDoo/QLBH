using MyLibrary;
namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    partial class Frm_QuanLyBanHang_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgaylapHD = new System.Windows.Forms.DateTimePicker();
            this.txtMaSanPham = new MyLibrary.TextBoxComau();
            this.pnThongtin = new System.Windows.Forms.Panel();
            this.txtKhachDua = new MyLibrary.TextBoxComau();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbltienbangchu = new System.Windows.Forms.Label();
            this.lblTraLai = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPhaiTra = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(775, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel1.Text = "HD00001";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpNgaylapHD);
            this.panel1.Controls.Add(this.txtMaSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 46);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày lập HĐ:";
            // 
            // dtpNgaylapHD
            // 
            this.dtpNgaylapHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaylapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylapHD.Location = new System.Drawing.Point(563, 8);
            this.dtpNgaylapHD.Name = "dtpNgaylapHD";
            this.dtpNgaylapHD.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaylapHD.TabIndex = 2;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Location = new System.Drawing.Point(130, 3);
            this.txtMaSanPham.Multiline = true;
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(192, 37);
            this.txtMaSanPham.TabIndex = 0;
            // 
            // pnThongtin
            // 
            this.pnThongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnThongtin.Controls.Add(this.txtKhachDua);
            this.pnThongtin.Controls.Add(this.btnNhaplai);
            this.pnThongtin.Controls.Add(this.btnInHoaDon);
            this.pnThongtin.Controls.Add(this.btnThanhToan);
            this.pnThongtin.Controls.Add(this.lbltienbangchu);
            this.pnThongtin.Controls.Add(this.lblTraLai);
            this.pnThongtin.Controls.Add(this.label13);
            this.pnThongtin.Controls.Add(this.label14);
            this.pnThongtin.Controls.Add(this.label10);
            this.pnThongtin.Controls.Add(this.label11);
            this.pnThongtin.Controls.Add(this.lblPhaiTra);
            this.pnThongtin.Controls.Add(this.label7);
            this.pnThongtin.Controls.Add(this.label8);
            this.pnThongtin.Controls.Add(this.lblTien);
            this.pnThongtin.Controls.Add(this.label1);
            this.pnThongtin.Controls.Add(this.lblThanhtien);
            this.pnThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongtin.Location = new System.Drawing.Point(0, 46);
            this.pnThongtin.Name = "pnThongtin";
            this.pnThongtin.Size = new System.Drawing.Size(775, 447);
            this.pnThongtin.TabIndex = 4;
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Location = new System.Drawing.Point(328, 140);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(155, 27);
            this.txtKhachDua.TabIndex = 21;
            this.txtKhachDua.Text = "0";
            this.txtKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(476, 318);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(103, 33);
            this.btnNhaplai.TabIndex = 20;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(363, 318);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(103, 33);
            this.btnInHoaDon.TabIndex = 19;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(229, 318);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 33);
            this.btnThanhToan.TabIndex = 18;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // lbltienbangchu
            // 
            this.lbltienbangchu.AutoSize = true;
            this.lbltienbangchu.Location = new System.Drawing.Point(225, 213);
            this.lbltienbangchu.Name = "lbltienbangchu";
            this.lbltienbangchu.Size = new System.Drawing.Size(86, 22);
            this.lbltienbangchu.TabIndex = 17;
            this.lbltienbangchu.Text = "Bằng chữ";
            // 
            // lblTraLai
            // 
            this.lblTraLai.BackColor = System.Drawing.Color.White;
            this.lblTraLai.Location = new System.Drawing.Point(328, 173);
            this.lblTraLai.Name = "lblTraLai";
            this.lblTraLai.Size = new System.Drawing.Size(155, 29);
            this.lblTraLai.TabIndex = 16;
            this.lblTraLai.Text = "label12";
            this.lblTraLai.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 22);
            this.label13.TabIndex = 15;
            this.label13.Text = "VNĐ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Trả lại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "Khách đưa:";
            // 
            // lblPhaiTra
            // 
            this.lblPhaiTra.BackColor = System.Drawing.Color.White;
            this.lblPhaiTra.Location = new System.Drawing.Point(328, 106);
            this.lblPhaiTra.Name = "lblPhaiTra";
            this.lblPhaiTra.Size = new System.Drawing.Size(155, 28);
            this.lblPhaiTra.TabIndex = 10;
            this.lblPhaiTra.Text = "label6";
            this.lblPhaiTra.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phải trả:";
            // 
            // lblTien
            // 
            this.lblTien.BackColor = System.Drawing.Color.White;
            this.lblTien.Location = new System.Drawing.Point(328, 65);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(155, 28);
            this.lblTien.TabIndex = 6;
            this.lblTien.Text = "label4";
            this.lblTien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "VNĐ";
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.Location = new System.Drawing.Point(221, 65);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.Size = new System.Drawing.Size(101, 22);
            this.lblThanhtien.TabIndex = 0;
            this.lblThanhtien.Text = "Thành tiền:";
            // 
            // Frm_QuanLyBanHang_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 515);
            this.Controls.Add(this.pnThongtin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_QuanLyBanHang_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QuanLyBanHang_Main";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnThongtin.ResumeLayout(false);
            this.pnThongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private TextBoxComau txtMaSanPham;
        private System.Windows.Forms.Panel pnThongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgaylapHD;
        private TextBoxComau txtKhachDua;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbltienbangchu;
        private System.Windows.Forms.Label lblTraLai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPhaiTra;
    }
}