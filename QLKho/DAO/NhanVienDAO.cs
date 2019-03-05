using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.DTO;
using System.Data;

namespace QLKho.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        public List<NhanVienDTO> GetNV()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.SP_NHANVIEN_GETALL");
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO(item);
                list.Add(nv);
            }
            return list;

        }

        public bool InseartNV(string TENNV , int SDT, string EMAIL)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_NHANVIEN_INSERT @TENNV , @SDT , @EMAIL", new object[] { TENNV, SDT, EMAIL});
            return result > 0;
        }

        public bool UpdateNV(int MANV, string TENNV, int SDT, string EMAIL)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_NHANVIEN_UPDATE @MANV , @TENNV , @SDT , @EMAIL", new object[] { MANV, TENNV, SDT, EMAIL });
            return result > 0;
        }

        public bool DeleteNV(int MANV)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC SP_NHANVIEN_DELETE @MANV ", new object[] { MANV });

            return result > 0;
        }

        public List<NhanVienDTO> SearchNV(string str)
        {
            List<NhanVienDTO> NvList = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SP_NHANVIEN_SEARCH @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO NhanVien = new NhanVienDTO(item);
                NvList.Add(NhanVien);
            }
            return NvList;
        }
    }
}
