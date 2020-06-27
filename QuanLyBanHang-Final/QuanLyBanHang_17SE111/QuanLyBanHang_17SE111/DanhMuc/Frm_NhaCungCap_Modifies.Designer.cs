namespace QuanLyBanHang_17SE111.DanhMuc
{
    partial class Frm_NhaCungCap_Modifies
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
            this.txtMota = new System.Windows.Forms.TextBox();
            this.lblMota = new System.Windows.Forms.Label();
            this.txtTennhaCungcap = new System.Windows.Forms.TextBox();
            this.lblManhacungcap = new System.Windows.Forms.Label();
            this.txtManhacungcap = new System.Windows.Forms.TextBox();
            this.lblTenLoaiSanPham = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(182, 88);
            this.txtMota.Margin = new System.Windows.Forms.Padding(5);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(282, 66);
            this.txtMota.TabIndex = 3;
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Location = new System.Drawing.Point(110, 91);
            this.lblMota.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(59, 22);
            this.lblMota.TabIndex = 10;
            this.lblMota.Text = "Mô tả:";
            // 
            // txtTennhaCungcap
            // 
            this.txtTennhaCungcap.Location = new System.Drawing.Point(182, 51);
            this.txtTennhaCungcap.Margin = new System.Windows.Forms.Padding(5);
            this.txtTennhaCungcap.Name = "txtTennhaCungcap";
            this.txtTennhaCungcap.Size = new System.Drawing.Size(282, 27);
            this.txtTennhaCungcap.TabIndex = 2;
            // 
            // lblManhacungcap
            // 
            this.lblManhacungcap.AutoSize = true;
            this.lblManhacungcap.Location = new System.Drawing.Point(17, 17);
            this.lblManhacungcap.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblManhacungcap.Name = "lblManhacungcap";
            this.lblManhacungcap.Size = new System.Drawing.Size(152, 22);
            this.lblManhacungcap.TabIndex = 8;
            this.lblManhacungcap.Text = "Mã nhà cung cấp:";
            // 
            // txtManhacungcap
            // 
            this.txtManhacungcap.Enabled = false;
            this.txtManhacungcap.Location = new System.Drawing.Point(182, 14);
            this.txtManhacungcap.Margin = new System.Windows.Forms.Padding(5);
            this.txtManhacungcap.Name = "txtManhacungcap";
            this.txtManhacungcap.Size = new System.Drawing.Size(282, 27);
            this.txtManhacungcap.TabIndex = 7;
            // 
            // lblTenLoaiSanPham
            // 
            this.lblTenLoaiSanPham.AutoSize = true;
            this.lblTenLoaiSanPham.Location = new System.Drawing.Point(9, 54);
            this.lblTenLoaiSanPham.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTenLoaiSanPham.Name = "lblTenLoaiSanPham";
            this.lblTenLoaiSanPham.Size = new System.Drawing.Size(160, 22);
            this.lblTenLoaiSanPham.TabIndex = 6;
            this.lblTenLoaiSanPham.Text = "Tên nhà cung cấp:";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(182, 167);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(138, 36);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(326, 166);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_NhaCungCap_Modifies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 219);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.txtTennhaCungcap);
            this.Controls.Add(this.lblManhacungcap);
            this.Controls.Add(this.txtManhacungcap);
            this.Controls.Add(this.lblTenLoaiSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_NhaCungCap_Modifies";
            this.Text = "Frm_NhaCungCap_Modifies";
            this.Load += new System.EventHandler(this.Frm_NhaCungCap_Modifies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.TextBox txtTennhaCungcap;
        private System.Windows.Forms.Label lblManhacungcap;
        private System.Windows.Forms.TextBox txtManhacungcap;
        private System.Windows.Forms.Label lblTenLoaiSanPham;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThoat;
    }
}