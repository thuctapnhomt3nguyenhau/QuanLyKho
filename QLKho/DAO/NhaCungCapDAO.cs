using QLKho.DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DAO
{
    class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        internal static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhaCungCapDTO> GetNCC()
        {
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallNCC");
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO(item);
                list.Add(ncc);
            }
            return list;

        }
        public bool InsertNCC(string TEN_NCC,string DIACHI_NCC, int SDT_NCC, string WEBSITE_NCC)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertNCC @TEN_NCC , @DIACHI_NCC , @SDT_NCC , @WEBSITE_NCC", new object[] { TEN_NCC,DIACHI_NCC, SDT_NCC, WEBSITE_NCC });
            return result > 0;
        }
        public bool UpdateNCC(int MA_NCC, string TEN_NCC, string DIACHI_NCC, int SDT_NCC, string WEBSITE_NCCL)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateNCC @MA_NCC  , @TEN_NCC , @DIACHI_NCC , @SDT_NCC , @WEBSITE_NCC", new object[] { MA_NCC, TEN_NCC, DIACHI_NCC, SDT_NCC, WEBSITE_NCCL });
            return result > 0;
        }
        public bool DeleteNCC(int MANCC)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteNCC @MA_NCC ", new object[] { MANCC });

            return result > 0;
        }

        public List<NhaCungCapDTO> SearchNCC(string str)
        {
            List<NhaCungCapDTO> NCCList = new List<NhaCungCapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchNCC @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO NhaCungCap = new NhaCungCapDTO(item);
                NCCList.Add(NhaCungCap);
            }
            return NCCList;
        }

    }
}
