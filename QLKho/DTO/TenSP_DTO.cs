using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class TenSP_DTO
    {
        private string tenSP;

        public string TenSP { get => tenSP; set => tenSP = value; }
        public TenSP_DTO(string tenSP)
        {
            this.tenSP = tenSP;
        }
        public TenSP_DTO(DataRow row)
        {
            this.tenSP = row["TEN_SP"].ToString();
        }
    }
}
