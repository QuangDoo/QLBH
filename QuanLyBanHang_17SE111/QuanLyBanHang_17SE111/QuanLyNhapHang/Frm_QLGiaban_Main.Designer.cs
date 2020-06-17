namespace QuanLyBanHang_17SE111.QuanLyNhapHang
{
    partial class Frm_QLGiaban_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayApDung = new System.Windows.Forms.DateTimePicker();
            this.lblTennhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.dgvGiaban = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayApDung);
            this.panel1.Controls.Add(this.lblTennhanVien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 61);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgayApDung
            // 
            this.dtpNgayApDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayApDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayApDung.Location = new System.Drawing.Point(581, 17);
            this.dtpNgayApDung.Name = "dtpNgayApDung";
            this.dtpNgayApDung.Size = new System.Drawing.Size(187, 27);
            this.dtpNgayApDung.TabIndex = 4;
            // 
            // lblTennhanVien
            // 
            this.lblTennhanVien.AutoSize = true;
            this.lblTennhanVien.Location = new System.Drawing.Point(344, 17);
            this.lblTennhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTennhanVien.Name = "lblTennhanVien";
            this.lblTennhanVien.Size = new System.Drawing.Size(101, 22);
            this.lblTennhanVien.TabIndex = 3;
            this.lblTennhanVien.Text = "Nhân viên: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày áp dụng";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCapnhat);
            this.panel2.Controls.Add(this.txtGiaban);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(510, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 381);
            this.panel2.TabIndex = 1;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(3, 36);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(259, 32);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(0, 0);
            this.txtGiaban.Multiline = true;
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(262, 30);
            this.txtGiaban.TabIndex = 0;
            this.txtGiaban.Text = "0";
            this.txtGiaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvGiaban
            // 
            this.dgvGiaban.AllowUserToAddRows = false;
            this.dgvGiaban.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiaban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaban.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaSanPham,
            this.colTenSanPham,
            this.colGiaNhap,
            this.colGiaBan,
            this.colDVT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaban.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiaban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaban.Location = new System.Drawing.Point(0, 61);
            this.dgvGiaban.Margin = new System.Windows.Forms.Padding(5);
            this.dgvGiaban.Name = "dgvGiaban";
            this.dgvGiaban.ReadOnly = true;
            this.dgvGiaban.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiaban.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGiaban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaban.Size = new System.Drawing.Size(510, 381);
            this.dgvGiaban.TabIndex = 2;
            this.dgvGiaban.Click += new System.EventHandler(this.dgvGiaban_Click);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            this.colMaSanPham.Visible = false;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            this.colTenSanPham.Width = 200;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaNhap.DataPropertyName = "DonGiaBinhQuan";
            this.colGiaNhap.HeaderText = "Giá Nhập";
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaBan.DataPropertyName = "GiaBanHienHanh";
            this.colGiaBan.HeaderText = "Giá Bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colDVT
            // 
            this.colDVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDVT.DataPropertyName = "TenDonViTinh";
            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            // 
            // Frm_QLGiaban_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 442);
            this.Controls.Add(this.dgvGiaban);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_QLGiaban_Main";
            this.Text = "Frm_QLGiaban_Main";
            this.Load += new System.EventHandler(this.Frm_QLGiaban_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvGiaban;
        private System.Windows.Forms.Label lblTennhanVien;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.DateTimePicker dtpNgayApDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
    }
}