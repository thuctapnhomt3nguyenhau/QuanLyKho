using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.DTO;
using System.Data;

namespace QLKho.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;

        internal static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set { instance = value; }
        }

        public List<SanPhamDTO> GetSP()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.SP_SANPHAM_GETALL");
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO SP = new SanPhamDTO(item);
                list.Add(SP);
            }
            return list;

        }
        public List<Ma_NccDTO> GetMaNcc()
        {
            List<Ma_NccDTO> list = new List<Ma_NccDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select MA_NCC from NHACUNGCAP");
            foreach (DataRow item in data.Rows)
            {
                Ma_NccDTO SP = new Ma_NccDTO(item);
                list.Add(SP);
            }
            return list;

        }

        public bool InseartSP(string TENSP, int MANCC, string THONGSOKT,float GIA,int SOLUONG)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_SANPHAM_INSERT @TENSP , @MANCC , @THONGSOKT , @GIA , @SOLUONG", new object[] { TENSP , MANCC , THONGSOKT , GIA , SOLUONG});
            return result > 0;
        }

        public bool UpdateSP(int MASP, string TENSP, int MANCC, string THONGSOKT, float GIA, int SOLUONG)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_SANPHAM_UPDATE @MASP , @TENSP , @MANCC , @THONGSOKT , @GIA , @SOLUONG", new object[] {MASP , TENSP , MANCC , THONGSOKT , GIA , SOLUONG});
            return result > 0; 
        }

        public bool DeleteSP(int MASP)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC SP_SANPHAM_DELETE @MASP ", new object[] { MASP });

            return result > 0;
        }

        public List<SanPhamDTO> SearchSP(string str)
        {
            List<SanPhamDTO> SPList = new List<SanPhamDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SP_SANPHAM_SEARCH @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO SanPham = new SanPhamDTO(item);
                SPList.Add(SanPham);
            }
            return SPList;
        }

    }
}
