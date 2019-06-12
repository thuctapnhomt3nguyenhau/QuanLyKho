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
    public partial class FrmPhieuNhapCT : Form
    {
        BindingSource phieuNhapCTList = new BindingSource();
        private int maPhieuNhap;
        public FrmPhieuNhapCT(int maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
            LoadFirstTime();
        }
        private void LoadFirstTime()
        {
            dgvChiTietPhieuNhap.DataSource = phieuNhapCTList;
            LoadDataGridView();
            LoadCombobox();
            BindingDataToFrom();
            //LoadIntoComBoBoxTenSP(cboMaSanPhan);
        }

        //void LoadIntoComBoBoxTenSP(ComboBox cb)
        //{
        //    cb.DataSource = CTPhieuNhapDAO.Instance.GetListTenSP();
        //    cb.DisplayMember = "TENSP";
        //}

        private void LoadDataGridView()
        {
            try
            {
                phieuNhapCTList.DataSource = CTPhieuNhapDAO.Instance.GetById(this.maPhieuNhap);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không tìm thấy danh sách phiếu nhập. Vui lòng khởi động lại!");
                Console.WriteLine(err);
            }
        }
        private void BindingDataToFrom()
        {
            lblMaPhieuNhap.Text = this.maPhieuNhap.ToString();
            lblMaChiTietPhieuNhap.DataBindings.Add(new Binding("Text", dgvChiTietPhieuNhap.DataSource, "MaChiTietPhieuNhap", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvChiTietPhieuNhap.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvChiTietPhieuNhap.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }

        private void LoadCombobox()
        {
            cboMaSanPhan.DataSource = CTPhieuNhapDAO.Instance.GetMaSanPham();
            cboMaSanPhan.DisplayMember = "MaSanPham";
        }

        /// //////////////////////////HANDLE EVENT CLICK /////////////////
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuNhap;
                int soLuong;
                int donGia;
                int maSanPham;


                Int32.TryParse(lblMaPhieuNhap.Text, out maPhieuNhap);
                Int32.TryParse(txtSoLuong.Text, out soLuong);
                Int32.TryParse(txtDonGia.Text, out donGia);
                Int32.TryParse(cboMaSanPhan.Text, out maSanPham);

                bool result = CTPhieuNhapDAO.Instance.Insert(maPhieuNhap, maSanPham, soLuong, donGia);
                if (result)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }

            } catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", err.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maChiTietPhieuNhap;
                int maPhieuNhap;
                int soLuong;
                float donGia;
                int maSanPham;

                Int32.TryParse(lblMaChiTietPhieuNhap.Text, out maChiTietPhieuNhap);
                Int32.TryParse(lblMaPhieuNhap.Text, out maPhieuNhap);
                Int32.TryParse(txtSoLuong.Text, out soLuong);
                float.TryParse(txtDonGia.Text, out donGia);
                Int32.TryParse(cboMaSanPhan.Text, out maSanPham);

                bool result = CTPhieuNhapDAO.Instance.Update(maChiTietPhieuNhap, maPhieuNhap, maSanPham, soLuong, donGia);
                if (result)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại"+ err.ToString(), "Error");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maChiTietPhieuNhap;
                Int32.TryParse(lblMaChiTietPhieuNhap.Text, out maChiTietPhieuNhap);

                bool result = CTPhieuNhapDAO.Instance.Delete(maChiTietPhieuNhap);
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại" + err.ToString(), "Error");
            }

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtSearch.Text = "";
            LoadCombobox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearch.Text;
                int maChiTietPhieuNhap;
                Int32.TryParse(lblMaChiTietPhieuNhap.Text, out maChiTietPhieuNhap);
                phieuNhapCTList.DataSource = CTPhieuNhapDAO.Instance.Search(searchValue, maChiTietPhieuNhap);
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại" + err.ToString(), "Error");
            }
        }
    }
}
