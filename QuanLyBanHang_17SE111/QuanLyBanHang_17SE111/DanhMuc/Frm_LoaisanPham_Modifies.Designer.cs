namespace QuanLyBanHang_17SE111.DanhMuc
{
    partial class Frm_LoaisanPham_Modifies
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
            this.lblTenLoaiSanPham = new System.Windows.Forms.Label();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.txtMasanpham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenLoaiSanPham
            // 
            this.lblTenLoaiSanPham.AutoSize = true;
            this.lblTenLoaiSanPham.Location = new System.Drawing.Point(14, 50);
            this.lblTenLoaiSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenLoaiSanPham.Name = "lblTenLoaiSanPham";
            this.lblTenLoaiSanPham.Size = new System.Drawing.Size(163, 22);
            this.lblTenLoaiSanPham.TabIndex = 0;
            this.lblTenLoaiSanPham.Text = "Tên loại sản phẩm:";
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(185, 47);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(282, 27);
            this.txtTensanpham.TabIndex = 1;
            // 
            // txtMasanpham
            // 
            this.txtMasanpham.Enabled = false;
            this.txtMasanpham.Location = new System.Drawing.Point(185, 14);
            this.txtMasanpham.Name = "txtMasanpham";
            this.txtMasanpham.Size = new System.Drawing.Size(282, 27);
            this.txtMasanpham.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại sản phẩm:";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(185, 80);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(282, 65);
            this.txtmota.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(329, 150);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 37);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(185, 151);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(138, 36);
            this.btnCapnhat.TabIndex = 5;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // Frm_LoaisanPham_Modifies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 196);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasanpham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTensanpham);
            this.Controls.Add(this.lblTenLoaiSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_LoaisanPham_Modifies";
            this.Text = "Frm_LoaisanPham_Modifies";
            this.Load += new System.EventHandler(this.Frm_LoaisanPham_Modifies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenLoaiSanPham;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.TextBox txtMasanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapnhat;
    }
}