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
using QLKho.DAO;

namespace QLKho.GUI
{
    public partial class FrmSanPham : Form
    {
        BindingSource SPList = new BindingSource();
        public FrmSanPham()
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
            dgvSanpham.DataSource = SPList;
            LoadListSP();
            AddBinding();
            LoadIntoComBoBoxMaPB(cboMancc);
        }
        void LoadListSP()
        {
            SPList.DataSource = SanPhamDAO.Instance.GetSP();
        }
        void LoadIntoComBoBoxMaPB(ComboBox cb)
        {
            cb.DataSource = SanPhamDAO.Instance.GetMaNcc();
            cb.DisplayMember = "maNCC";
        }
        void AddBinding()
        {
            lblGetMa.DataBindings.Add(new Binding("Text", dgvSanpham.DataSource, "maSP", true, DataSourceUpdateMode.Never));
            txtTensp.DataBindings.Add(new Binding("Text", dgvSanpham.DataSource, "tenSP", true, DataSourceUpdateMode.Never));
            txtGiasp.DataBindings.Add(new Binding("Text", dgvSanpham.DataSource, "gia", true, DataSourceUpdateMode.Never));
            txtSoluongsp.DataBindings.Add(new Binding("Text", dgvSanpham.DataSource, "soLuong", true, DataSourceUpdateMode.Never));
            txtThongsokt.DataBindings.Add(new Binding("Text", dgvSanpham.DataSource, "tsKT", true, DataSourceUpdateMode.Never));
            cboMancc.DataBindings.Add(new Binding("Text", dgvSanpham.DataSource, "maNCC", true, DataSourceUpdateMode.Never));
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm sản phẩm có tên là: " + txtTensp.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTensp.Text == "" || txtGiasp.Text == "" || txtSoluongsp.Text == "" || txtThongsokt.Text=="" ||  Int64.TryParse(txtSoluongsp.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                   
                }
                else
                {
                    string TenSP = txtTensp.Text;
                    int Mancc;
                    Int32.TryParse(cboMancc.Text, out Mancc);
                    float gia;
                    float.TryParse(txtGiasp.Text, out gia);
                    int soLUONG;
                    Int32.TryParse(txtSoluongsp.Text, out soLUONG);
                    string Thongsokt = txtThongsokt.Text;
                    if (SanPhamDAO.Instance.InseartSP(TenSP,Mancc, Thongsokt, gia,soLUONG))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công! ");
                        LoadListSP();
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
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa sản phẩm có tên là: " + txtTensp.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTensp.Text == "" || txtGiasp.Text == "" || txtSoluongsp.Text == "" || txtThongsokt.Text ==""|| Int64.TryParse(txtTensp.Text, out check) == true)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int MaSP;
                    int Mancc;
                    float gia;
                    Int32.TryParse(lblGetMa.Text, out MaSP);
                    string TenSP = txtTensp.Text;
                    Int32.TryParse(cboMancc.Text, out Mancc);
                    float.TryParse(txtGiasp.Text, out gia);
                    int soLUONG;
                    Int32.TryParse(txtSoluongsp.Text, out soLUONG);
                    string Thongsokt = txtThongsokt.Text;
                    if (SanPhamDAO.Instance.UpdateSP(MaSP, TenSP, Mancc, Thongsokt, gia, soLUONG))

                    {
                        MessageBox.Show("Sửa sản phẩm thành công! ");
                        LoadListSP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa sản phẩm! ");
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa sản phẩm có tên là: " + txtTensp.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maSP;
                Int32.TryParse(lblGetMa.Text, out maSP);
                if (SanPhamDAO.Instance.DeleteSP(maSP))
          
                {
                    MessageBox.Show("Xóa sản phẩm thành công! ");
                    LoadListSP();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa sản phẩm! ");
                }
            }
        }
        void Reset()
        {
            lblGetMa.Text = "";
            txtTensp.Text = "";
            cboMancc.Text = "";
            txtGiasp.Text = "";
            txtSoluongsp.Text = "";
            txtThongsokt.Text = "";
            
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListSP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvSanpham.DataSource = SPList;
            SPList.DataSource = SanPhamDAO.Instance.SearchSP(str);
        }

        private void txtSoluongsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMancc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



 