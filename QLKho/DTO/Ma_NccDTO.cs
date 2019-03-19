using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class Ma_NccDTO
    {
        private int maNCC;

        public int MaNCC { get => maNCC; set => maNCC = value; }

        public Ma_NccDTO(int maNCC)
        {
            this.maNCC = maNCC;
        }

        public Ma_NccDTO(DataRow row)
        {
            Int32.TryParse(row["MA_NCC"].ToString(), out this.maNCC);
        }
    }
}
