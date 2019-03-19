namespace QLKho.GUI
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.txtGiasp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
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
            this.MA_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONGSO_KT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThongsokt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGetMa = new System.Windows.Forms.Label();
            this.cboMancc = new System.Windows.Forms.ComboBox();
            this.lblmaNCC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGiasp
            // 
            this.txtGiasp.Location = new System.Drawing.Point(148, 197);
            this.txtGiasp.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiasp.Multiline = true;
            this.txtGiasp.Name = "txtGiasp";
            this.txtGiasp.Size = new System.Drawing.Size(296, 40);
            this.txtGiasp.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuy.Location = new System.Drawing.Point(904, 303);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(70, 66);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(825, 303);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 66);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(744, 303);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 66);
            this.btnSua.TabIndex = 14;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Location = new System.Drawing.Point(662, 303);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 66);
            this.btnThem.TabIndex = 13;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.BackgroundImage")));
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefesh.Location = new System.Drawing.Point(577, 303);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(70, 66);
            this.btnRefesh.TabIndex = 12;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(281, 330);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 39);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.Location = new System.Drawing.Point(82, 22);
            this.lblSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(160, 36);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "Sản Phẩm";
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgia.Location = new System.Drawing.Point(87, 197);
            this.lblgia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(52, 20);
            this.lblgia.TabIndex = 17;
            this.lblgia.Text = "Giá : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 330);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 40);
            this.txtSearch.TabIndex = 6;
            // 
            // txtSoluongsp
            // 
            this.txtSoluongsp.Location = new System.Drawing.Point(148, 243);
            this.txtSoluongsp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoluongsp.Multiline = true;
            this.txtSoluongsp.Name = "txtSoluongsp";
            this.txtSoluongsp.Size = new System.Drawing.Size(296, 38);
            this.txtSoluongsp.TabIndex = 3;
            this.txtSoluongsp.TextChanged += new System.EventHandler(this.txtSoluongsp_TextChanged);
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensp.Location = new System.Drawing.Point(148, 138);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTensp.Multiline = true;
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(296, 38);
            this.txtTensp.TabIndex = 1;
            // 
            // lbltsKT
            // 
            this.lbltsKT.AutoSize = true;
            this.lbltsKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltsKT.Location = new System.Drawing.Point(530, 107);
            this.lbltsKT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltsKT.Name = "lbltsKT";
            this.lbltsKT.Size = new System.Drawing.Size(119, 20);
            this.lbltsKT.TabIndex = 4;
            this.lbltsKT.Text = "Thông số KT: ";
            // 
            // lblsoLuong
            // 
            this.lblsoLuong.AutoSize = true;
            this.lblsoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoLuong.Location = new System.Drawing.Point(42, 250);
            this.lblsoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsoLuong.Name = "lblsoLuong";
            this.lblsoLuong.Size = new System.Drawing.Size(101, 20);
            this.lblsoLuong.TabIndex = 3;
            this.lblsoLuong.Text = "Số Lượng : ";
            // 
            // lbltenSP
            // 
            this.lbltenSP.AutoSize = true;
            this.lbltenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenSP.Location = new System.Drawing.Point(8, 151);
            this.lbltenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltenSP.Name = "lbltenSP";
            this.lbltenSP.Size = new System.Drawing.Size(141, 20);
            this.lbltenSP.TabIndex = 2;
            this.lbltenSP.Text = "Tên Sản Phẩm : ";
            // 
            // lblmaSP
            // 
            this.lblmaSP.AutoSize = true;
            this.lblmaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaSP.Location = new System.Drawing.Point(14, 107);
            this.lblmaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmaSP.Name = "lblmaSP";
            this.lblmaSP.Size = new System.Drawing.Size(135, 20);
            this.lblmaSP.TabIndex = 1;
            this.lblmaSP.Text = "Mã Sản Phẩm : ";
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(891, -2);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(91, 84);
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
            this.MA_NCC,
            this.THONGSO_KT,
            this.GIA,
            this.SOLUONG});
            this.dgvSanpham.Location = new System.Drawing.Point(2, 2);
            this.dgvSanpham.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersVisible = false;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(977, 337);
            this.dgvSanpham.TabIndex = 0;
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
            // MA_NCC
            // 
            this.MA_NCC.DataPropertyName = "maNCC";
            this.MA_NCC.HeaderText = "Mã Nhà Cung Cấp";
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
            // txtThongsokt
            // 
            this.txtThongsokt.Location = new System.Drawing.Point(647, 97);
            this.txtThongsokt.Margin = new System.Windows.Forms.Padding(2);
            this.txtThongsokt.Multiline = true;
            this.txtThongsokt.Name = "txtThongsokt";
            this.txtThongsokt.Size = new System.Drawing.Size(307, 102);
            this.txtThongsokt.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblSanPham);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 81);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSanpham);
            this.panel3.Location = new System.Drawing.Point(9, 397);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 247);
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
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
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
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 383);
            this.panel1.TabIndex = 80;
            // 
            // lblGetMa
            // 
            this.lblGetMa.AutoSize = true;
            this.lblGetMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetMa.Location = new System.Drawing.Point(165, 107);
            this.lblGetMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGetMa.Name = "lblGetMa";
            this.lblGetMa.Size = new System.Drawing.Size(19, 20);
            this.lblGetMa.TabIndex = 20;
            this.lblGetMa.Text = "1";
            // 
            // cboMancc
            // 
            this.cboMancc.FormattingEnabled = true;
            this.cboMancc.Location = new System.Drawing.Point(647, 250);
            this.cboMancc.Margin = new System.Windows.Forms.Padding(2);
            this.cboMancc.Name = "cboMancc";
            this.cboMancc.Size = new System.Drawing.Size(232, 21);
            this.cboMancc.TabIndex = 5;
            this.cboMancc.SelectedIndexChanged += new System.EventHandler(this.cboMancc_SelectedIndexChanged);
            // 
            // lblmaNCC
            // 
            this.lblmaNCC.AutoSize = true;
            this.lblmaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaNCC.Location = new System.Drawing.Point(485, 250);
            this.lblmaNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmaNCC.Name = "lblmaNCC";
            this.lblmaNCC.Size = new System.Drawing.Size(169, 20);
            this.lblmaNCC.TabIndex = 19;
            this.lblmaNCC.Text = "Mã Nhà Cung Cấp : ";
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
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
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONGSO_KT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.Label lblGetMa;
    }
}