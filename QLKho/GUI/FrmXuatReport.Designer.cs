namespace QLKho.GUI
{
    partial class FrmXuatReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rEXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_XuatSanPham = new QLKho.DataSet_XuatSanPham();
            this.rE_XuatTableAdapter = new QLKho.DataSet_XuatSanPhamTableAdapters.RE_XuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rEXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_XuatSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Xuat";
            reportDataSource1.Value = this.rEXuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKho.Report_Xuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1316, 707);
            this.reportViewer1.TabIndex = 0;
            // 
            // rEXuatBindingSource
            // 
            this.rEXuatBindingSource.DataMember = "RE_Xuat";
            this.rEXuatBindingSource.DataSource = this.dataSet_XuatSanPham;
            // 
            // dataSet_XuatSanPham
            // 
            this.dataSet_XuatSanPham.DataSetName = "DataSet_XuatSanPham";
            this.dataSet_XuatSanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rE_XuatTableAdapter
            // 
            this.rE_XuatTableAdapter.ClearBeforeFill = true;
            // 
            // FrmXuatReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 731);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmXuatReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXuatReport";
            this.Load += new System.EventHandler(this.FrmXuatReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_XuatSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rEXuatBindingSource;
        private DataSet_XuatSanPham dataSet_XuatSanPham;
        private DataSet_XuatSanPhamTableAdapters.RE_XuatTableAdapter rE_XuatTableAdapter;
    }
}