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
            LoadInToCombobox();
            BindingDataToFrom();
        }

        private void BindingDataToFrom()
        {
            lblMaPhieu.DataBindings.Add(new Binding("Text", dgvDanhSachPhieuNhap.DataSource, "MaPhieuNhap", true, DataSourceUpdateMode.Never));
            cboMaNhanVien.DataBindings.Add(new Binding("Text", dgvDanhSachPhieuNhap.DataSource, "MaNhanVien", true, DataSourceUpdateMode.Never));
            cboMaNhaCungCap.DataBindings.Add(new Binding("Text", dgvDanhSachPhieuNhap.DataSource, "MaNhaCungCap", true, DataSourceUpdateMode.Never));
            dtpNgaynhap.DataBindings.Add(new Binding("Text", dgvDanhSachPhieuNhap.DataSource, "NgayNhap", true, DataSourceUpdateMode.Never));

        }
        private void LoadInToCombobox()
        {
            cboMaNhaCungCap.DataSource = PhieuNhapDAO.Instance.GetListMaNhaCungCap();
            cboMaNhaCungCap.DisplayMember = "maNCC";
            cboMaNhanVien.DataSource = PhieuNhapDAO.Instance.GetListMaNhanVien();
            cboMaNhanVien.DisplayMember = "maNV";

        }
        private void LoadListPhieuNhap()
        {
            try
            {
                   phieuNhapList.DataSource = PhieuNhapDAO.Instance.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Không tìm thấy danh sách phiếu nhập. Vui lòng khởi động lại!");
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
            try
            {
                int maNhaCungCap;
                Int32.TryParse(cboMaNhaCungCap.Text, out maNhaCungCap);
                int maNhanVien;
                Int32.TryParse(cboMaNhanVien.Text, out maNhanVien);
                DateTime ngayNhap;
                DateTime.TryParse(dtpNgaynhap.Text, out ngayNhap);
                if (maNhanVien == null || maNhaCungCap == null || ngayNhap == null)
                {
                    MessageBox.Show("Yêu cầu nhập thông tin đầy đủ");
                    return;
                }
                bool result = PhieuNhapDAO.Instance.Insert(maNhanVien, maNhaCungCap, ngayNhap);
                if (result)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadListPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                    LoadListPhieuNhap();
                }
            } catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuNhap;
                Int32.TryParse(lblMaPhieu.Text, out maPhieuNhap);
                int maNhaCungCap;
                Int32.TryParse(cboMaNhaCungCap.Text, out maNhaCungCap);
                int maNhanVien;
                Int32.TryParse(cboMaNhanVien.Text, out maNhanVien);
                DateTime ngayNhap;
                DateTime.TryParse(dtpNgaynhap.Text, out ngayNhap);
                if (maPhieuNhap == null || maNhanVien == null || maNhaCungCap == null || ngayNhap == null)
                {
                    MessageBox.Show("Yêu cầu nhập thông tin đầy đủ");
                    return;
                }
                bool result = PhieuNhapDAO.Instance.Update(maPhieuNhap, maNhanVien, maNhaCungCap, ngayNhap);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadListPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                    LoadListPhieuNhap();
                }
            } catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra", err.ToString());
                LoadListPhieuNhap();
            }
        }
        private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            int maPhieuNhap;
            Int32.TryParse(lblMaPhieu.Text, out maPhieuNhap);
            FrmPhieuNhapCT f = new FrmPhieuNhapCT(maPhieuNhap);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuNhap;
                Int32.TryParse(lblMaPhieu.Text, out maPhieuNhap);
                bool result = PhieuNhapDAO.Instance.Delete(maPhieuNhap);
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadListPhieuNhap();
                } else
                
                    MessageBox.Show("Xóa không thành công");
            }
             catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra");

            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListPhieuNhap();
        }
    }
}
