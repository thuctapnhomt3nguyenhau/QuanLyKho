using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.DAO;

namespace QLKho.GUI
{
    public partial class FrmPhieuNhap : Form
    {
        BindingSource phieuNhapList = new BindingSource();
        public FrmPhieuNhap()
        {
            InitializeComponent();
            LoadFirstTime();
        }
        private void LoadFirstTime()
        {
            dgvDanhSachPhieuNhap.DataSource = phieuNhapList;
            LoadListPhieuNhap();
            //EditDataGridView();
            //BindingDataToFrom();
        }
        private void LoadListPhieuNhap()
        {
            try
            {
                //    phie.DataSource = TacGiaDAO.Instance.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Không tìm thấy danh sách tác giả. Vui lòng khởi động lại!");
                Console.WriteLine(err);
            }
        }

        /// //////////////////////////HANDLE EVENT CLICK /////////////////
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            FrmPhieuNhapCT f = new FrmPhieuNhapCT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
