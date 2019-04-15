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

        public List<CTPhieuNhapDTO> GetById(int maPhieuNhap)
        {
            List<CTPhieuNhapDTO> list = new List<CTPhieuNhapDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SP_CTPhieuNhap_GetAll @maPhieuNhap", new object[] { maPhieuNhap});
            foreach(DataRow row in table.Rows)
            {
                list.Add(new CTPhieuNhapDTO(row));
            }
            return list;
        }

        public List<MaSanPhamDTO> GetMaSanPham()
        {
            List<MaSanPhamDTO> list = new List<MaSanPhamDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("Select MA_SP from SanPham");
            foreach(DataRow row in table.Rows)
            {
                list.Add(new MaSanPhamDTO(row));
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

        public bool Update(int maChiTietPhieuNhap, int maPhieuNhap, int maSanPham, int soLuong, float donGia)
        {
            int rowEffected = DataProvider.Instance.ExecuteNonQuery("SP_CTPhieuNhap_Update @maChiTietPhieuNhap , @maPhieuNhap , @maSanPham , @soLuong , @donGia ", new object[] { maChiTietPhieuNhap, maPhieuNhap, maSanPham, soLuong, donGia });
            return rowEffected > 0;
        }

        public List<CTPhieuNhapDTO> Search(string searchValue, int maChiTietPhieuNhap)
        {
            List<CTPhieuNhapDTO> list = new List<CTPhieuNhapDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("SP_CTPhieuNhap_Search @searchValue , @maChiTietPhieuNhap", new object[] { searchValue, maChiTietPhieuNhap});
            foreach(DataRow row in table.Rows)
            {
                list.Add(new CTPhieuNhapDTO(row));
            }
            return list;
        }
    }
}
