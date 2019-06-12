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
    public partial class FrmXuatSanPham : Form
    {
        BindingSource XuatKhoList = new BindingSource();
        public FrmXuatSanPham()
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
            dgvXuatsanpham.DataSource = XuatKhoList;
            LoadListXK();
            AddBinding();
            LoadIntoComBoBoxMaNV(cboManv);
            LoadIntoComBoBoxTenSP(cboTenSP);
        }

        void LoadListXK()
        {
            XuatKhoList.DataSource = XuatKhoDAO.Instance.GetXuatKho();
        }
        void LoadIntoComBoBoxMaNV(ComboBox cb)
        {
            cb.DataSource = XuatKhoDAO.Instance.GetListNV();
            cb.DisplayMember = "MANV";
        }
        void LoadIntoComBoBoxTenSP(ComboBox cb)
        {
            cb.DataSource = XuatKhoDAO.Instance.GetListTenSP();
            cb.DisplayMember = "TENSP";
        }
        void AddBinding()
        {
            lblMaPX.DataBindings.Add(new Binding("Text", dgvXuatsanpham.DataSource, "MAPX", true, DataSourceUpdateMode.Never));
            lblChiTiet.DataBindings.Add(new Binding("Text", dgvXuatsanpham.DataSource, "MACT", true, DataSourceUpdateMode.Never));
            dtpNgayxuat.DataBindings.Add(new Binding("Text", dgvXuatsanpham.DataSource, "NGAYXUAT", true, DataSourceUpdateMode.Never));
            cboManv.DataBindings.Add(new Binding("Text", dgvXuatsanpham.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            cboTenSP.DataBindings.Add(new Binding("Text", dgvXuatsanpham.DataSource, "TENSP", true, DataSourceUpdateMode.Never));
            txtGiasp.DataBindings.Add(new Binding("Text", dgvXuatsanpham.DataSource, "DONGIA", true, DataSourceUpdateMode.Never));
            txtSoluongsp.DataBindings.Add(new Binding("Text", dgvXuatsanpham.DataSource, "SOLUONG", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm phiếu xuất có mã là: " + lblMaPX.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboManv.Text == "" || cboTenSP.Text == "" || txtSoluongsp.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string tenSP = cboTenSP.Text;
                    int mapx;
                    Int32.TryParse(lblMaPX.Text, out mapx);
                    int manv;
                    Int32.TryParse(cboManv.Text, out manv);
                    DateTime ngayxuat;
                    DateTime.TryParse(dtpNgayxuat.Text, out ngayxuat);
                    int soluong;
                    Int32.TryParse(txtSoluongsp.Text, out soluong);
                    if (XuatKhoDAO.Instance.InsertXuatKho(mapx, manv, ngayxuat, tenSP, soluong))
                    {
                        MessageBox.Show("Thêm thông tin thành công! ");
                        LoadListXK();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm thông tin! ");
                    }
                }
            }
        }

        void Reset()
        {
            lblMaPX.Text = null;
            lblChiTiet.Text = null;
            dtpNgayxuat.Value = DateTime.Now;
            LoadIntoComBoBoxMaNV(cboManv);
            LoadIntoComBoBoxTenSP(cboTenSP);
            txtGiasp.Text = null;
            txtSoluongsp.Text = null;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa phiếu xuất có mã là: " + lblMaPX.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboManv.Text == "" || cboTenSP.Text == "" || txtSoluongsp.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    int mact;
                    Int32.TryParse(lblChiTiet.Text, out mact);
                    string tenSP = cboTenSP.Text;
                    int mapx;
                    Int32.TryParse(lblMaPX.Text, out mapx);
                    int manv;
                    Int32.TryParse(cboManv.Text, out manv);
                    DateTime ngayxuat;
                    DateTime.TryParse(dtpNgayxuat.Text, out ngayxuat);
                    int soluong;
                    Int32.TryParse(txtSoluongsp.Text, out soluong);
                    if (XuatKhoDAO.Instance.UpdateXuatKho(mapx, mact, manv, ngayxuat, tenSP, soluong))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListXK();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mapx;
            Int32.TryParse(lblMaPX.Text, out mapx);
            int mact;
            Int32.TryParse(lblChiTiet.Text, out mact);
            DialogResult DR = MessageBox.Show("Chọn Yes nếu muôn xóa thông tin chi tiết phiếu xuất. No nếu muốn xóa thông tin phiếu xuất. Cancel dể hủy", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch(DR)
            {
                case DialogResult.Yes:
                    if (XuatKhoDAO.Instance.DeleteCTPhieuXuat(mapx, mact))
                    {
                    MessageBox.Show("Xóa thông tin thành công! ");
                    LoadListXK();
                    }
                    else
                    {
                    MessageBox.Show("Có lỗi khi xóa thông tin! ");
                    }
                    break;
                case DialogResult.No:
                    if (XuatKhoDAO.Instance.DeletePhieuXuat(mapx))
                    {
                        MessageBox.Show("Xóa thông tin thành công! ");
                        LoadListXK();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa thông tin! ");
                    }
                    break;
                case DialogResult.Cancel: break;
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListXK();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvXuatsanpham.DataSource = XuatKhoList;
            XuatKhoList.DataSource = XuatKhoDAO.Instance.SearchXK(str);
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            FrmXuatReport f = new FrmXuatReport();
            f.id = Int32.Parse(lblMaPX.Text);
            f.Show();
        }
    }
}
