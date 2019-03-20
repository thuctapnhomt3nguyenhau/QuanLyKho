namespace QLKho
{
    partial class frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnhacungcap = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnxuatsanpham = new System.Windows.Forms.Button();
            this.btnnhapsanpham = new System.Windows.Forms.Button();
            this.btnsanpham = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.BackColor = System.Drawing.SystemColors.Window;
            this.btnnhanvien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.BackgroundImage")));
            this.btnnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhanvien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnnhanvien.Location = new System.Drawing.Point(261, 87);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(208, 172);
            this.btnnhanvien.TabIndex = 0;
            this.btnnhanvien.Text = "Nhân Viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnnhanvien.UseVisualStyleBackColor = false;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnnhacungcap);
            this.panel1.Controls.Add(this.btnthongke);
            this.panel1.Controls.Add(this.btnxuatsanpham);
            this.panel1.Controls.Add(this.btnnhapsanpham);
            this.panel1.Controls.Add(this.btnsanpham);
            this.panel1.Controls.Add(this.btnnhanvien);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 688);
            this.panel1.TabIndex = 0;
            // 
            // btnnhacungcap
            // 
            this.btnnhacungcap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnhacungcap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhacungcap.BackgroundImage")));
            this.btnnhacungcap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhacungcap.Location = new System.Drawing.Point(513, 87);
            this.btnnhacungcap.Name = "btnnhacungcap";
            this.btnnhacungcap.Size = new System.Drawing.Size(208, 172);
            this.btnnhacungcap.TabIndex = 1;
            this.btnnhacungcap.Text = "Nhà Cung Cấp";
            this.btnnhacungcap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnnhacungcap.UseVisualStyleBackColor = false;
            this.btnnhacungcap.Click += new System.EventHandler(this.btnnhacungcap_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthongke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthongke.BackgroundImage")));
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Location = new System.Drawing.Point(771, 87);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(202, 171);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Hướng Dẫn Sử Dụng";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnthongke.UseVisualStyleBackColor = false;
            // 
            // btnxuatsanpham
            // 
            this.btnxuatsanpham.BackColor = System.Drawing.Color.White;
            this.btnxuatsanpham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxuatsanpham.BackgroundImage")));
            this.btnxuatsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxuatsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatsanpham.Location = new System.Drawing.Point(771, 299);
            this.btnxuatsanpham.Name = "btnxuatsanpham";
            this.btnxuatsanpham.Size = new System.Drawing.Size(202, 172);
            this.btnxuatsanpham.TabIndex = 5;
            this.btnxuatsanpham.Text = "Xuất Sản Phẩm";
            this.btnxuatsanpham.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnxuatsanpham.UseVisualStyleBackColor = false;
            this.btnxuatsanpham.Click += new System.EventHandler(this.btnxuatsanpham_Click);
            // 
            // btnnhapsanpham
            // 
            this.btnnhapsanpham.BackColor = System.Drawing.Color.White;
            this.btnnhapsanpham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhapsanpham.BackgroundImage")));
            this.btnnhapsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnhapsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhapsanpham.Location = new System.Drawing.Point(513, 299);
            this.btnnhapsanpham.Name = "btnnhapsanpham";
            this.btnnhapsanpham.Size = new System.Drawing.Size(208, 172);
            this.btnnhapsanpham.TabIndex = 4;
            this.btnnhapsanpham.Text = "Nhập Sản Phẩm";
            this.btnnhapsanpham.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnnhapsanpham.UseVisualStyleBackColor = false;
            this.btnnhapsanpham.Click += new System.EventHandler(this.btnnhapsanpham_Click);
            // 
            // btnsanpham
            // 
            this.btnsanpham.BackColor = System.Drawing.Color.White;
            this.btnsanpham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsanpham.BackgroundImage")));
            this.btnsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsanpham.Location = new System.Drawing.Point(261, 299);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Size = new System.Drawing.Size(208, 172);
            this.btnsanpham.TabIndex = 3;
            this.btnsanpham.Text = "Kho Sản Phẩm";
            this.btnsanpham.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnsanpham.UseVisualStyleBackColor = false;
            this.btnsanpham.Click += new System.EventHandler(this.btnsanpham_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 712);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsanpham;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnxuatsanpham;
        private System.Windows.Forms.Button btnnhapsanpham;
        private System.Windows.Forms.Button btnnhacungcap;
    }
}

