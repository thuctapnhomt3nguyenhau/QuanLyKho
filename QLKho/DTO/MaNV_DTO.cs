using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class MaNV_DTO
    {
        private int maNV;

        public int MaNV { get => maNV; set => maNV = value; }
        public MaNV_DTO(int maNV)
        {
            this.maNV = maNV;
        }
        public MaNV_DTO(DataRow row)
        {
            Int32.TryParse(row["MA_NV"].ToString(), out this.maNV);
        }
    }
}
