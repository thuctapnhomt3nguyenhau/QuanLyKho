namespace QLKho.GUI
{
    partial class FrmNhapReport
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
            this.rENhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_NhapSanPham = new QLKho.DataSet_NhapSanPham();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rE_NhapTableAdapter = new QLKho.DataSet_NhapSanPhamTableAdapters.RE_NhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rENhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_NhapSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // rENhapBindingSource
            // 
            this.rENhapBindingSource.DataMember = "RE_Nhap";
            this.rENhapBindingSource.DataSource = this.dataSet_NhapSanPham;
            // 
            // dataSet_NhapSanPham
            // 
            this.dataSet_NhapSanPham.DataSetName = "DataSet_NhapSanPham";
            this.dataSet_NhapSanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_NhapSanPham";
            reportDataSource1.Value = this.rENhapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKho.Report_Nhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1318, 798);
            this.reportViewer1.TabIndex = 0;
            // 
            // rE_NhapTableAdapter
            // 
            this.rE_NhapTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNhapReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 822);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmNhapReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNhapReport";
            this.Load += new System.EventHandler(this.FrmNhapReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rENhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_NhapSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rENhapBindingSource;
        private DataSet_NhapSanPham dataSet_NhapSanPham;
        private DataSet_NhapSanPhamTableAdapters.RE_NhapTableAdapter rE_NhapTableAdapter;
    }
}