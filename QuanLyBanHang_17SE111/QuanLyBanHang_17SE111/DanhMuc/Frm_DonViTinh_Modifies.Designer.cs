namespace QuanLyBanHang_17SE111.DanhMuc
{
    partial class Frm_DonViTinh_Modifies
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
            this.lblMadonvitinh = new System.Windows.Forms.Label();
            this.lblMota = new System.Windows.Forms.Label();
            this.txtMadonvitinh = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenDonViTinh = new System.Windows.Forms.TextBox();
            this.lblTenDonViTinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMadonvitinh
            // 
            this.lblMadonvitinh.AutoSize = true;
            this.lblMadonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadonvitinh.Location = new System.Drawing.Point(17, 9);
            this.lblMadonvitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMadonvitinh.Name = "lblMadonvitinh";
            this.lblMadonvitinh.Size = new System.Drawing.Size(131, 22);
            this.lblMadonvitinh.TabIndex = 0;
            this.lblMadonvitinh.Text = "Mã đơn vị tính: ";
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMota.Location = new System.Drawing.Point(85, 68);
            this.lblMota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(59, 22);
            this.lblMota.TabIndex = 3;
            this.lblMota.Text = "Mô tả:";
            // 
            // txtMadonvitinh
            // 
            this.txtMadonvitinh.Enabled = false;
            this.txtMadonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadonvitinh.Location = new System.Drawing.Point(155, 10);
            this.txtMadonvitinh.Name = "txtMadonvitinh";
            this.txtMadonvitinh.Size = new System.Drawing.Size(229, 23);
            this.txtMadonvitinh.TabIndex = 4;
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.Location = new System.Drawing.Point(154, 68);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(229, 56);
            this.txtmota.TabIndex = 3;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(154, 130);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(109, 31);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(269, 130);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 31);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenDonViTinh
            // 
            this.txtTenDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDonViTinh.Location = new System.Drawing.Point(154, 39);
            this.txtTenDonViTinh.Name = "txtTenDonViTinh";
            this.txtTenDonViTinh.Size = new System.Drawing.Size(229, 23);
            this.txtTenDonViTinh.TabIndex = 2;
            // 
            // lblTenDonViTinh
            // 
            this.lblTenDonViTinh.AutoSize = true;
            this.lblTenDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDonViTinh.Location = new System.Drawing.Point(13, 39);
            this.lblTenDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDonViTinh.Name = "lblTenDonViTinh";
            this.lblTenDonViTinh.Size = new System.Drawing.Size(134, 22);
            this.lblTenDonViTinh.TabIndex = 9;
            this.lblTenDonViTinh.Text = "Tên đơn vị tính:";
            // 
            // Frm_DonViTinh_Modifies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 183);
            this.Controls.Add(this.txtTenDonViTinh);
            this.Controls.Add(this.lblTenDonViTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtMadonvitinh);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.lblMadonvitinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_DonViTinh_Modifies";
            this.Text = "Frm_DonViTinh_Modifies";
            this.Load += new System.EventHandler(this.Frm_DonViTinh_Modifies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMadonvitinh;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.TextBox txtMadonvitinh;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenDonViTinh;
        private System.Windows.Forms.Label lblTenDonViTinh;
    }
}