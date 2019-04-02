using QLKho.DAO;
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
    public partial class FrmThongKe : Form
    {
        BindingSource ThongKeList = new BindingSource();
        public FrmThongKe()
        {
            InitializeComponent();
            Load();
            //tinhtongtien();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        void Load()
        {
            dgvthongke.DataSource = ThongKeList;
            LoadListThongKe();       
        }

        void LoadListThongKe()
        {
            DateTime tungay = dtptungay.Value;
            DateTime denngay = dtpdenngay.Value;
            ThongKeList.DataSource = ThongKeDAO.Instance.GetTHONGKE( tungay, denngay);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            LoadListThongKe();
            tinhtongtien();
        }



        public void tinhtongtien()
        {
            int sc = dgvthongke.Rows.Count;
            float tongtien = 0;
            for(int i=0 ; i <= sc-1; i++ )
            {
                tongtien += float.Parse(dgvthongke.Rows[i].Cells["THANHTIEN"].Value.ToString());
            }
            lblsum.Text = tongtien.ToString();

        }

   

    
    }
}
