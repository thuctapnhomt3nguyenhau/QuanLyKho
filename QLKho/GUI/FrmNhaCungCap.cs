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
    public partial class FrmNhaCungCap : Form
    {
        BindingSource NCCList = new BindingSource();
        public FrmNhaCungCap()
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
            dgvNhacungcap.DataSource = NCCList;
            LoadListNCC();
            AddBinding();
        }
        void LoadListNCC()
        {

            NCCList.DataSource = NhaCungCapDAO.Instance.GetNCC();

        }
        void AddBinding()
        {
            lblma.DataBindings.Add(new Binding("Text", dgvNhacungcap.DataSource, "MANCC", true, DataSourceUpdateMode.Never));
            txtTenncc.DataBindings.Add(new Binding("Text", dgvNhacungcap.DataSource, "TENNCC", true, DataSourceUpdateMode.Never));
            txtDiachincc.DataBindings.Add(new Binding("Text", dgvNhacungcap.DataSource, "DIACHINCC", true, DataSourceUpdateMode.Never));
            txtSdtncc.DataBindings.Add(new Binding("Text", dgvNhacungcap.DataSource, "SDTNCC", true, DataSourceUpdateMode.Never));
            txtWebncc.DataBindings.Add(new Binding("Text", dgvNhacungcap.DataSource, "WEBSITENCC", true, DataSourceUpdateMode.Never));

        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thêm nhà cũng cấp có tên là : " + txtTenncc.Text, "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) ;
            {
                if (txtTenncc.Text == "" || txtDiachincc.Text == "" || txtSdtncc.Text == "" || txtWebncc.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    string Tenncc = txtTenncc.Text;
                    string DiachiNCC = txtDiachincc.Text;
                    int SdtNCC;
                    Int32.TryParse(txtSdtncc.Text, out SdtNCC);
                    string WebsiteNCC = txtWebncc.Text;
                    if (NhaCungCapDAO.Instance.InsertNCC(Tenncc, DiachiNCC, SdtNCC, WebsiteNCC))
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công! ");
                        LoadListNCC();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm nhà cung cấp! ");
                    }

                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvNhacungcap.DataSource = NCCList;
            NCCList.DataSource = NhaCungCapDAO.Instance.SearchNCC(str);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListNCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa nhà cung cấp có tên là: " + txtTenncc.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenncc.Text == "" || txtDiachincc.Text == "" || txtSdtncc.Text == "" || txtWebncc.Text == "" )
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int MaNCC;
                    Int32.TryParse(lblMancc.Text, out MaNCC);
                    string TenNCC = txtTenncc.Text;
                    string DiachiNCC = txtDiachincc.Text;
                    int SdtNCC;
                    Int32.TryParse(txtSdtncc.Text, out SdtNCC);
                    string WebsiteNCC = txtWebncc.Text;
                    if (NhaCungCapDAO.Instance.UpdateNCC(MaNCC, TenNCC,DiachiNCC, SdtNCC, WebsiteNCC))
                    {
                        MessageBox.Show("Sửa nhà cung cấp thành công! ");
                        LoadListNCC();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa nhà cung cấp! ");
                    }
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhà cung cấp có tên là: " + txtTenncc.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int MaNCC;
                Int32.TryParse(lblMancc.Text, out MaNCC);
                if (NhaCungCapDAO.Instance.DeleteNCC(MaNCC))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công! ");
                    LoadListNCC();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhà cung cấp! ");
                }
            }

        }

        void Reset()
        {
            lblma.Text = "";
            txtTenncc.Text = "";
            txtDiachincc.Text = "";
            txtSdtncc.Text = "";
            txtWebncc.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tác vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }

        }
    }
}
