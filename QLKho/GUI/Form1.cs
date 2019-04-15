using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.GUI;

namespace QLKho
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnnhacungcap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap f = new FrmNhaCungCap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            FrmSanPham f = new FrmSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnnhapsanpham_Click(object sender, EventArgs e)
        {
            FrmPhieuNhap f = new FrmPhieuNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnxuatsanpham_Click(object sender, EventArgs e)
        {
            FrmXuatSanPham f = new FrmXuatSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
