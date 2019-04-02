using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.DTO;
using System.Data;

namespace QLKho.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;

        internal static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return instance; }
            private set { instance = value; }
        }

        public List<ThongKeDTO> GetTHONGKE(DateTime TUNGAY, DateTime DENNGAY)
        {
            List<ThongKeDTO> list = new List<ThongKeDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.THONGKE_GETALL @TUNGAY , @DENNGAY ", new object[] { TUNGAY , DENNGAY });
            foreach (DataRow item in data.Rows)
            {
                ThongKeDTO thongke = new ThongKeDTO(item);
                list.Add(thongke);
            }
            return list;

        }

        public List<ThongKeDTO> ThongKeDT(string str)
        {
            List<ThongKeDTO> ThongKeList = new List<ThongKeDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC THONGKE @TUNGAY , @DENNGAY ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                ThongKeDTO ThongKe = new ThongKeDTO(item);
                ThongKeList.Add(ThongKe);
            }
            return ThongKeList;
        }
    }
}
