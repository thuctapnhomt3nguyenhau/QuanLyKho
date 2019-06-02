namespace QLKho.GUI
{
    partial class FrmKhoSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoSanPham));
            this.txtGiasp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblgia = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSoluongsp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.lbltsKT = new System.Windows.Forms.Label();
            this.lblsoLuong = new System.Windows.Forms.Label();
            this.lbltenSP = new System.Windows.Forms.Label();
            this.lblmaSP = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.txtThongsokt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGetMa = new System.Windows.Forms.Label();
            this.cboMancc = new System.Windows.Forms.ComboBox();
            this.lblmaNCC = new System.Windows.Forms.Label();
            this.MA_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONGSO_KT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGiasp
            // 
            this.txtGiasp.Location = new System.Drawing.Point(197, 242);
            this.txtGiasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiasp.Multiline = true;
            this.txtGiasp.Name = "txtGiasp";
            this.txtGiasp.Size = new System.Drawing.Size(393, 48);
            this.txtGiasp.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.BackgroundImage")));
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefesh.Location = new System.Drawing.Point(625, 355);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(117, 99);
            this.btnRefesh.TabIndex = 12;
            this.btnRefesh.Text = "Refresh";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(375, 406);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 48);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.Location = new System.Drawing.Point(109, 27);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(184, 44);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "Kho Giày";
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgia.Location = new System.Drawing.Point(116, 242);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(64, 25);
            this.lblgia.TabIndex = 17;
            this.lblgia.Text = "Giá : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(47, 406);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 48);
            this.txtSearch.TabIndex = 6;
            // 
            // txtSoluongsp
            // 
            this.txtSoluongsp.Location = new System.Drawing.Point(197, 299);
            this.txtSoluongsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluongsp.Multiline = true;
            this.txtSoluongsp.Name = "txtSoluongsp";
            this.txtSoluongsp.Size = new System.Drawing.Size(393, 46);
            this.txtSoluongsp.TabIndex = 3;
            this.txtSoluongsp.TextChanged += new System.EventHandler(this.txtSoluongsp_TextChanged);
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensp.Location = new System.Drawing.Point(197, 170);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTensp.Multiline = true;
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(393, 46);
            this.txtTensp.TabIndex = 1;
            // 
            // lbltsKT
            // 
            this.lbltsKT.AutoSize = true;
            this.lbltsKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltsKT.Location = new System.Drawing.Point(707, 132);
            this.lbltsKT.Name = "lbltsKT";
            this.lbltsKT.Size = new System.Drawing.Size(151, 25);
            this.lbltsKT.TabIndex = 4;
            this.lbltsKT.Text = "Thông số KT: ";
            // 
            // lblsoLuong
            // 
            this.lblsoLuong.AutoSize = true;
            this.lblsoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoLuong.Location = new System.Drawing.Point(56, 308);
            this.lblsoLuong.Name = "lblsoLuong";
            this.lblsoLuong.Size = new System.Drawing.Size(124, 25);
            this.lblsoLuong.TabIndex = 3;
            this.lblsoLuong.Text = "Số Lượng : ";
            // 
            // lbltenSP
            // 
            this.lbltenSP.AutoSize = true;
            this.lbltenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenSP.Location = new System.Drawing.Point(11, 186);
            this.lbltenSP.Name = "lbltenSP";
            this.lbltenSP.Size = new System.Drawing.Size(175, 25);
            this.lbltenSP.TabIndex = 2;
            this.lbltenSP.Text = "Tên Sản Phẩm : ";
            // 
            // lblmaSP
            // 
            this.lblmaSP.AutoSize = true;
            this.lblmaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaSP.Location = new System.Drawing.Point(19, 132);
            this.lblmaSP.Name = "lblmaSP";
            this.lblmaSP.Size = new System.Drawing.Size(167, 25);
            this.lblmaSP.TabIndex = 1;
            this.lblmaSP.Text = "Mã Sản Phẩm : ";
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(1188, -2);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(121, 103);
            this.btnback.TabIndex = 20;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_SP,
            this.TEN_SP,
            this.TEN_NCC,
            this.MA_NCC,
            this.THONGSO_KT,
            this.GIA,
            this.SOLUONG});
            this.dgvSanpham.Location = new System.Drawing.Point(3, 2);
            this.dgvSanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersVisible = false;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(1303, 338);
            this.dgvSanpham.TabIndex = 0;
            // 
            // txtThongsokt
            // 
            this.txtThongsokt.Location = new System.Drawing.Point(863, 119);
            this.txtThongsokt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThongsokt.Multiline = true;
            this.txtThongsokt.Name = "txtThongsokt";
            this.txtThongsokt.Size = new System.Drawing.Size(408, 125);
            this.txtThongsokt.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lblSanPham);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSanpham);
            this.panel3.Location = new System.Drawing.Point(12, 489);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1309, 404);
            this.panel3.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblGetMa);
            this.panel1.Controls.Add(this.cboMancc);
            this.panel1.Controls.Add(this.lblmaNCC);
            this.panel1.Controls.Add(this.txtGiasp);
            this.panel1.Controls.Add(this.lblgia);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtSoluongsp);
            this.panel1.Controls.Add(this.txtThongsokt);
            this.panel1.Controls.Add(this.txtTensp);
            this.panel1.Controls.Add(this.lbltsKT);
            this.panel1.Controls.Add(this.lblsoLuong);
            this.panel1.Controls.Add(this.lbltenSP);
            this.panel1.Controls.Add(this.lblmaSP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 471);
            this.panel1.TabIndex = 80;
            // 
            // lblGetMa
            // 
            this.lblGetMa.AutoSize = true;
            this.lblGetMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetMa.Location = new System.Drawing.Point(220, 132);
            this.lblGetMa.Name = "lblGetMa";
            this.lblGetMa.Size = new System.Drawing.Size(24, 25);
            this.lblGetMa.TabIndex = 20;
            this.lblGetMa.Text = "1";
            // 
            // cboMancc
            // 
            this.cboMancc.FormattingEnabled = true;
            this.cboMancc.Location = new System.Drawing.Point(863, 277);
            this.cboMancc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMancc.Name = "cboMancc";
            this.cboMancc.Size = new System.Drawing.Size(308, 24);
            this.cboMancc.TabIndex = 5;
            this.cboMancc.SelectedIndexChanged += new System.EventHandler(this.cboMancc_SelectedIndexChanged);
            // 
            // lblmaNCC
            // 
            this.lblmaNCC.AutoSize = true;
            this.lblmaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaNCC.Location = new System.Drawing.Point(647, 277);
            this.lblmaNCC.Name = "lblmaNCC";
            this.lblmaNCC.Size = new System.Drawing.Size(210, 25);
            this.lblmaNCC.TabIndex = 19;
            this.lblmaNCC.Text = "Mã Nhà Cung Cấp : ";
            // 
            // MA_SP
            // 
            this.MA_SP.DataPropertyName = "maSP";
            this.MA_SP.HeaderText = "Mã Sản Phẩm";
            this.MA_SP.Name = "MA_SP";
            // 
            // TEN_SP
            // 
            this.TEN_SP.DataPropertyName = "tenSP";
            this.TEN_SP.HeaderText = "Tên Sản Phẩm";
            this.TEN_SP.Name = "TEN_SP";
            // 
            // TEN_NCC
            // 
            this.TEN_NCC.DataPropertyName = "tenNCC";
            this.TEN_NCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TEN_NCC.Name = "TEN_NCC";
            // 
            // MA_NCC
            // 
            this.MA_NCC.DataPropertyName = "maNCC";
            this.MA_NCC.FillWeight = 30F;
            this.MA_NCC.HeaderText = "Mã NCC";
            this.MA_NCC.Name = "MA_NCC";
            // 
            // THONGSO_KT
            // 
            this.THONGSO_KT.DataPropertyName = "tsKT";
            this.THONGSO_KT.HeaderText = "Thông Số Kỹ Thuật";
            this.THONGSO_KT.Name = "THONGSO_KT";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "gia";
            this.GIA.HeaderText = "Đơn Giá";
            this.GIA.Name = "GIA";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "soLuong";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // btnNhap
            // 
            this.btnNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhap.BackgroundImage")));
            this.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhap.Location = new System.Drawing.Point(961, 341);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(140, 113);
            this.btnNhap.TabIndex = 13;
            this.btnNhap.Text = "Nhập sản phẩm";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuat.BackgroundImage")));
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXuat.Location = new System.Drawing.Point(1134, 341);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(137, 113);
            this.btnXuat.TabIndex = 14;
            this.btnXuat.Text = "Xuất sản phẩm";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // FrmKhoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 969);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmKhoSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiasp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSoluongsp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label lbltsKT;
        private System.Windows.Forms.Label lblsoLuong;
        private System.Windows.Forms.Label lbltenSP;
        private System.Windows.Forms.Label lblmaSP;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.TextBox txtThongsokt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMancc;
        private System.Windows.Forms.Label lblmaNCC;
        private System.Windows.Forms.Label lblGetMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONGSO_KT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnNhap;
    }
}