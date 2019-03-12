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
    public partial class FrmNhanVien : Form
    {
        BindingSource NvList = new BindingSource();
        public FrmNhanVien()
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
            dgvNhanvien.DataSource = NvList;
            LoadListNV();
            AddBinding();
        }

        void LoadListNV()
        {
            NvList.DataSource = NhanVienDAO.Instance.GetNV();

        }

        void AddBinding()
        {
            lblMaNV.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "maNV", true, DataSourceUpdateMode.Never));
            txtHotennv.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "tenNV", true, DataSourceUpdateMode.Never));
            txtSdtnv.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "sdtNV", true, DataSourceUpdateMode.Never));
            txtEmailnv.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "emailNV", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm nhân viên có tên là: " + txtHotennv.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtHotennv.Text == "" || txtEmailnv.Text == "" || txtSdtnv.Text == "" || Int64.TryParse(txtSdtnv.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string tenNV = txtHotennv.Text;
                    int sdtNV;
                    Int32.TryParse(txtSdtnv.Text, out sdtNV);
                    string emailNV = txtEmailnv.Text;
                    if (NhanVienDAO.Instance.InseartNV(tenNV, sdtNV, emailNV))
                    {
                        MessageBox.Show("Thêm nhân viên thành công! ");
                        LoadListNV();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm nhân viên! ");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa nhân viên có tên là: " + txtHotennv.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtHotennv.Text == "" || txtEmailnv.Text == "" || txtSdtnv.Text == "" || txtSdtnv.Text.Length != 10 || Int64.TryParse(txtSdtnv.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int maNV;
                    Int32.TryParse(lblMaNV.Text, out maNV);
                    string tenNV = txtHotennv.Text;
                    string emailNV = txtEmailnv.Text;
                    int sdtNV;
                    Int32.TryParse(txtSdtnv.Text, out sdtNV);
                    if (NhanVienDAO.Instance.UpdateNV(maNV, tenNV, sdtNV, emailNV))
                    {
                        MessageBox.Show("Sửa nhân viên thành công! ");
                        LoadListNV();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa nhân viên! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có tên là: " + txtHotennv.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maNV;
                Int32.TryParse(lblMaNV.Text, out maNV);
                if (NhanVienDAO.Instance.DeleteNV(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công! ");
                    LoadListNV();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhân viên! ");
                }
            }
        }

        void Reset()
        {
            lblMaNV.Text = "";
            txtHotennv.Text = "";
            txtEmailnv.Text = "";
            txtSdtnv.Text = "";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListNV();
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
            dgvNhanvien.DataSource = NvList;
            NvList.DataSource = NhanVienDAO.Instance.SearchNV(str);
        }
    }
}
