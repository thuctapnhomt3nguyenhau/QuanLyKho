using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.DTO;
namespace QLKho.DAO
{
    class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        internal static PhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapDAO(); return instance; }
            private set { instance = value; }
        }

        public List<PhieuNhapDTO> GetAll()
        {
            List<PhieuNhapDTO> list = new List<PhieuNhapDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SP_PhieuNhap_GetAll");
            foreach(DataRow row in table.Rows)
            {
                list.Add(new PhieuNhapDTO(row));
            }
            return list;
        }

        public List<MaNV_DTO> GetListMaNhanVien()
        {
            List<MaNV_DTO> list = new List<MaNV_DTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("Select MA_NV from NhanVien");
            foreach(DataRow row in table.Rows)
            {
                list.Add(new MaNV_DTO(row));
            }
            return list;

        }

        public List<Ma_NccDTO> GetListMaNhaCungCap()
        {
            List<Ma_NccDTO> list = new List<Ma_NccDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("Select MA_NCC from NhaCungCap");
            foreach(DataRow row in table.Rows)
            {
                list.Add(new Ma_NccDTO(row));
            }
            return list;
        }

        public bool Insert(int maNhanVien, int nhaCungCap, DateTime ngayNhap)
        {
            int rowEffected = DataProvider.Instance.ExecuteNonQuery("SP_PhieuNhap_Insert @maNhanVien , @maNhaCungCap , @ngayNhap", new object[] { maNhanVien, nhaCungCap, ngayNhap });
            return rowEffected > 0;
        }

        public bool Delete(int maPhieuNhap)
        {
            int rowEffected = DataProvider.Instance.ExecuteNonQuery("SP_PhieuNhap_Delete @maPhieuNhap", new object[] { maPhieuNhap});
            return rowEffected > 0;
        }

        public bool Update(int maPhieuNhap, int maNhanVien, int maNhaCungCap, DateTime ngayNhap)
        {
            int rowEffected = DataProvider.Instance.ExecuteNonQuery("SP_PhieuNhap_Update @maPhieuNhap , @maNhanVien , @maNhaCungCap , @ngayNhap ", new object[] { maPhieuNhap, maNhanVien, maNhaCungCap, ngayNhap });
            return rowEffected > 0;
        }

        public List<PhieuNhapDTO> Search(string searchValue)
        {
            List<PhieuNhapDTO> list = new List<PhieuNhapDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SP_PhieuNhap_Search @searchValue", new object[] { searchValue });
            foreach(DataRow row in table.Rows)
            {
                list.Add(new PhieuNhapDTO(row));
            }
            return list;
        }
    }
}
