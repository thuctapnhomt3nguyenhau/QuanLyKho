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
    public partial class FrmXuatReport : Form
    {
        public FrmXuatReport()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        private void FrmXuatReport_Load(object sender, EventArgs e)
        {
            this.rE_XuatTableAdapter.Fill(this.dataSet_XuatSanPham.RE_Xuat, id);

            this.reportViewer1.RefreshReport();
        }
    }
}
