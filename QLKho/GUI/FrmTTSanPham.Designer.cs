namespace QLKho.GUI
{
    partial class FrmTTSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTTSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGetMa = new System.Windows.Forms.Label();
            this.cboMancc = new System.Windows.Forms.ComboBox();
            this.lblmaNCC = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtThongsokt = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.lbltsKT = new System.Windows.Forms.Label();
            this.lbltenSP = new System.Windows.Forms.Label();
            this.lblmaSP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvttsanpham = new System.Windows.Forms.DataGridView();
            this.MA_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONGSO_KT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblGetMa);
            this.panel1.Controls.Add(this.cboMancc);
            this.panel1.Controls.Add(this.lblmaNCC);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtThongsokt);
            this.panel1.Controls.Add(this.txtTensp);
            this.panel1.Controls.Add(this.lbltsKT);
            this.panel1.Controls.Add(this.lbltenSP);
            this.panel1.Controls.Add(this.lblmaSP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 436);
            this.panel1.TabIndex = 81;
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
            this.cboMancc.Location = new System.Drawing.Point(863, 274);
            this.cboMancc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMancc.Name = "cboMancc";
            this.cboMancc.Size = new System.Drawing.Size(308, 24);
            this.cboMancc.TabIndex = 5;
            // 
            // lblmaNCC
            // 
            this.lblmaNCC.AutoSize = true;
            this.lblmaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaNCC.Location = new System.Drawing.Point(647, 274);
            this.lblmaNCC.Name = "lblmaNCC";
            this.lblmaNCC.Size = new System.Drawing.Size(210, 25);
            this.lblmaNCC.TabIndex = 19;
            this.lblmaNCC.Text = "Mã Nhà Cung Cấp : ";
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuy.Location = new System.Drawing.Point(1176, 330);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 99);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(1039, 330);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 99);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Location = new System.Drawing.Point(901, 330);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 99);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.BackgroundImage")));
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefesh.Location = new System.Drawing.Point(756, 330);
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
            this.btnSearch.Location = new System.Drawing.Point(379, 343);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 48);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(49, 343);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 48);
            this.txtSearch.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblSanPham);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 100);
            this.panel2.TabIndex = 0;
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.Location = new System.Drawing.Point(109, 27);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(272, 44);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "Thông tin giày";
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
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(1191, 0);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(116, 100);
            this.btnback.TabIndex = 20;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvttsanpham);
            this.panel3.Location = new System.Drawing.Point(12, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 289);
            this.panel3.TabIndex = 82;
            // 
            // dgvttsanpham
            // 
            this.dgvttsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvttsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_SP,
            this.TEN_SP,
            this.TEN_NCC,
            this.MA_NCC,
            this.GIA,
            this.THONGSO_KT});
            this.dgvttsanpham.Location = new System.Drawing.Point(3, 3);
            this.dgvttsanpham.Name = "dgvttsanpham";
            this.dgvttsanpham.RowHeadersVisible = false;
            this.dgvttsanpham.RowTemplate.Height = 24;
            this.dgvttsanpham.Size = new System.Drawing.Size(1307, 283);
            this.dgvttsanpham.TabIndex = 0;
            // 
            // MA_SP
            // 
            this.MA_SP.DataPropertyName = "maSP";
            this.MA_SP.FillWeight = 50F;
            this.MA_SP.HeaderText = "Mã Sản Phẩm";
            this.MA_SP.Name = "MA_SP";
            // 
            // TEN_SP
            // 
            this.TEN_SP.DataPropertyName = "tenSP";
            this.TEN_SP.FillWeight = 200F;
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
            this.MA_NCC.FillWeight = 50F;
            this.MA_NCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MA_NCC.Name = "MA_NCC";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "gia";
            this.GIA.HeaderText = "Đơn Giá";
            this.GIA.Name = "GIA";
            // 
            // THONGSO_KT
            // 
            this.THONGSO_KT.DataPropertyName = "tsKT";
            this.THONGSO_KT.FillWeight = 150F;
            this.THONGSO_KT.HeaderText = "Thông Số Kỹ Thuật";
            this.THONGSO_KT.Name = "THONGSO_KT";
            // 
            // FrmTTSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 796);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTTSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvttsanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGetMa;
        private System.Windows.Forms.ComboBox cboMancc;
        private System.Windows.Forms.Label lblmaNCC;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtThongsokt;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label lbltsKT;
        private System.Windows.Forms.Label lbltenSP;
        private System.Windows.Forms.Label lblmaSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvttsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONGSO_KT;
    }
}