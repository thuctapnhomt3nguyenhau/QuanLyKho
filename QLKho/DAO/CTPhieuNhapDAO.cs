using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKho.DTO;

namespace QLKho.DAO
{
    class CTPhieuNhapDAO
    {
        private static CTPhieuNhapDAO instance;

        internal static CTPhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new CTPhieuNhapDAO(); return instance; }
            private set { instance = value; }
        }

        public List<CTPhieuNhapDTO> GetAll()
        {
            List<CTPhieuNhapDTO> list = new List<CTPhieuNhapDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SP_CTPhieuNhap_GetAll");
            foreach(DataRow row in table.Rows)
            {
                list.Add(new CTPhieuNhapDTO(row));
            }
            return list;
        }

        public bool Insert(int maPhieuNhap, int maSanPham, int soLuong, float donGia)
        {
            int rowEffected = DataProvider.Instance.ExecuteNonQuery("SP_CTPhieuNhap_Insert @maPhieuNhap , @maSanPham , @soLuong , @donGia", new object[] { maPhieuNhap, maSanPham, soLuong, donGia });
            return rowEffected > 0;
        }

        public bool Delete(int maChiTietPhieuNhap)
        {
            int rowEffected = DataProvider.Instance.ExecuteNonQuery("SP_CTPhieuNhap_Delete @maChiTietPhieuNhap", new object[] { maChiTietPhieuNhap });
            return rowEffected > 0;
        }

        public bool Update(int maChiTietPhieuNhap, int maPhieuNhap, int maSanPham, int soLuong, int donGia)
        {
            int rowEffected = DataProvider.Instance.ExecuteNonQuery("SP_CTPhieuNhap_Update @maChiTietPhieuNhap , @maPhieuNhap , @maSanPham , @soLuong , @donGia float", new object[] { maChiTietPhieuNhap, maPhieuNhap, maSanPham, soLuong, donGia });
            return rowEffected > 0;
        }

        public List<CTPhieuNhapDTO> Search(string searchValue)
        {
            List<CTPhieuNhapDTO> list = new List<CTPhieuNhapDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SP_CTPhieuNhap_Search @searchValue", new object[] { searchValue });
            foreach(DataRow row in table.Rows)
            {
                list.Add(new CTPhieuNhapDTO(row));
            }
            return list;
        }
    }
}
