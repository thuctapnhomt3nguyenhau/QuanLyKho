using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho.GUI
{
    public partial class FrmNhapReport : Form
    {
        public FrmNhapReport()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        private void FrmNhapReport_Load(object sender, EventArgs e)
        {
            this.rE_NhapTableAdapter.Fill(this.dataSet_NhapSanPham.RE_Nhap, id);

            this.reportViewer1.RefreshReport();
        }
    }
}
