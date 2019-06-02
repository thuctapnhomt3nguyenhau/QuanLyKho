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
    public partial class FrmTTSanPham : Form
    {
        BindingSource SPList = new BindingSource();
        public FrmTTSanPham()
        {
            InitializeComponent();
            Load();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Load()
        {
            dgvttsanpham.DataSource = SPList;
            LoadListThongTinSP();
            AddBinding();
            LoadIntoComBoBoxMaNCC(cboMancc);
        }

        void LoadListThongTinSP()
        {
            SPList.DataSource = TTSanPhamDAO.Instance.GetTTSP();
        }

        void LoadIntoComBoBoxMaNCC(ComboBox cb)
        {
            cb.DataSource = TTSanPhamDAO.Instance.GetMaNcc();
            cb.DisplayMember = "maNCC";
        }

        void AddBinding()
        {
            lblGetMa.DataBindings.Add(new Binding("Text", dgvttsanpham.DataSource, "maSP", true, DataSourceUpdateMode.Never));
            txtTensp.DataBindings.Add(new Binding("Text", dgvttsanpham.DataSource, "tenSP", true, DataSourceUpdateMode.Never));
            txtThongsokt.DataBindings.Add(new Binding("Text", dgvttsanpham.DataSource, "tsKT", true, DataSourceUpdateMode.Never));
            cboMancc.DataBindings.Add(new Binding("Text", dgvttsanpham.DataSource, "maNCC", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm sản phẩm có tên là: " + txtTensp.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTensp.Text == "" || txtThongsokt.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");

                }
                else
                {
                    string TenSP = txtTensp.Text;
                    int Mancc;
                    Int32.TryParse(cboMancc.Text, out Mancc);
                    string Thongsokt = txtThongsokt.Text;
                    if (TTSanPhamDAO.Instance.InseartTTSP(TenSP, Mancc, Thongsokt))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công! ");
                        LoadListThongTinSP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm sản phẩm! ");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa sản phẩm có tên là: " + txtTensp.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                long check;
                if (txtTensp.Text == "" || txtThongsokt.Text == "" || Int64.TryParse(txtTensp.Text, out check) == true)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int MaSP;
                    int Mancc;                    
                    Int32.TryParse(lblGetMa.Text, out MaSP);
                    string TenSP = txtTensp.Text;
                    Int32.TryParse(cboMancc.Text, out Mancc);
                    string Thongsokt = txtThongsokt.Text;
                    if (TTSanPhamDAO.Instance.UpdateTTSP(MaSP, TenSP, Mancc, Thongsokt))

                    {
                        MessageBox.Show("Sửa sản phẩm thành công! ");
                        LoadListThongTinSP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa sản phẩm! ");
                    }
                }
            }
        }

        void Reset()
        {
            lblGetMa.Text = "";
            txtTensp.Text = "";
            cboMancc.Text = "";
            txtThongsokt.Text = "";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tác vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListThongTinSP();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvttsanpham.DataSource = SPList;
            SPList.DataSource = TTSanPhamDAO.Instance.SearchTTSP(str);
        }
    }
}
