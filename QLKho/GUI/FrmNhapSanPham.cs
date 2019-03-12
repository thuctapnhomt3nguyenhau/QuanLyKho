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
    public partial class FrmNhapSanPham : Form
    {
        public FrmNhapSanPham()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapSanPham_CT f = new FrmNhapSanPham_CT();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmNhapSanPham_CT f = new FrmNhapSanPham_CT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
