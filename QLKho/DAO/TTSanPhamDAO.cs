using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.DTO;

namespace QLKho.DAO
{
    class TTSanPhamDAO
    {

        private static TTSanPhamDAO instance;

        internal static TTSanPhamDAO Instance
        {
            get { if (instance == null) instance = new TTSanPhamDAO(); return instance; }
            private set { instance = value; }
        }

        public List<TTSanPhamDTO> GetTTSP()
        {
            List<TTSanPhamDTO> list = new List<TTSanPhamDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.SP_TTSANPHAM_GETALL");
            foreach (DataRow item in data.Rows)
            {
                TTSanPhamDTO SP = new TTSanPhamDTO(item);
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

        public bool InseartTTSP(string TENSP, int MANCC, string THONGSOKT)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_TTSANPHAM_INSERT @TENSP , @MANCC , @THONGSOKT ", new object[] { TENSP, MANCC, THONGSOKT });
            return result > 0;
        }

        public bool UpdateTTSP(int MASP, string TENSP, int MANCC, string THONGSOKT)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_TTSANPHAM_UPDATE @MASP , @TENSP , @MANCC , @THONGSOKT ", new object[] { MASP, TENSP, MANCC, THONGSOKT });
            return result > 0;
        }

        public List<TTSanPhamDTO> SearchTTSP(string str)
        {
            List<TTSanPhamDTO> SPList = new List<TTSanPhamDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SP_TTSANPHAM_SEARCH @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                TTSanPhamDTO SanPham = new TTSanPhamDTO(item);
                SPList.Add(SanPham);
            }
            return SPList;
        }
    }
}
