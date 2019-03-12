using QLKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DAO
{
    class XuatKhoDAO
    {
        private static XuatKhoDAO instance;
 
        internal static XuatKhoDAO Instance
        {
            get { if (instance == null) instance = new XuatKhoDAO(); return instance; }
            private set { instance = value; }
        }
        public List<XuatKhoDTO> GetXuatKho()
        {
            List<XuatKhoDTO> list = new List<XuatKhoDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetListXuatKho");
            foreach (DataRow item in data.Rows)
            {
                XuatKhoDTO xuatkho = new XuatKhoDTO(item);
                list.Add(xuatkho);
            }
            return list;

        }
        public List<MaNV_DTO> GetListNV()
        {
            List<MaNV_DTO> maNVList = new List<MaNV_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MA_NV FROM dbo.NHANVIEN");
            foreach (DataRow item in data.Rows)
            {
                MaNV_DTO manv = new MaNV_DTO(item);
                maNVList.Add(manv);
            }
            return maNVList;
        }

        public List<TenSP_DTO> GetListTenSP()
        {
            List<TenSP_DTO> maNVList = new List<TenSP_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TEN_SP FROM dbo.SANPHAM");
            foreach (DataRow item in data.Rows)
            {
                TenSP_DTO manv = new TenSP_DTO(item);
                maNVList.Add(manv);
            }
            return maNVList;
        }
        public bool InsertXuatKho(int mapx, int manv, DateTime ngayxuat, string tensp, int soluong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_ThemPhieuXuat @mapx , @manv , @ngayxuat , @tensp , @soluong ", new object[] { mapx, manv, ngayxuat, tensp , soluong  });
            return result > 0;
        }

        public bool UpdateXuatKho(int mapx, int mact, int manv, DateTime ngayxuat, string tensp, int soluong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdatePhieuXuat @mapx , @mact , @manv , @ngayxuat , @tensp , @soluong ", new object[] { mapx, mact, manv, ngayxuat, tensp, soluong });
            return result > 0;
        }
        public bool DeleteCTPhieuXuat(int mapx,int mact)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC DeleteCTPhieuXuatXuatKho @mapx , @mact ", new object[] { mapx, mact });

            return result > 0;
        }
        public bool DeletePhieuXuat(int mapx)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC DeletePhieuXuatXuatKho @mapx ", new object[] { mapx });

            return result > 0;
        }
        public List<XuatKhoDTO> SearchXK(string str)
        {
            List<XuatKhoDTO> XkList = new List<XuatKhoDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchPhieuXuat @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                XuatKhoDTO XuatKho = new XuatKhoDTO(item);
                XkList.Add(XuatKho);
            }
            return XkList;
        }
    }
}
