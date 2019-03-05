using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKho.DTO
{
    class NhanVienDTO
    {
        private int maNV;
        private string tenNV;
        private int sdtNV;
        private string emailNV;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int SdtNV { get => sdtNV; set => sdtNV = value; }
        public string EmailNV { get => emailNV; set => emailNV = value; }

        public NhanVienDTO(int maNV, string tenNV, int sdtNV, string emailNV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.sdtNV = sdtNV;
            this.emailNV = emailNV;
        }

        public NhanVienDTO(DataRow row)
        {
            Int32.TryParse(row["MA_NV"].ToString(), out this.maNV);
            this.tenNV = row["TEN_NV"].ToString();
            Int32.TryParse(row["SDT_NV"].ToString(), out this.sdtNV);
            this.emailNV = row["EMAIL_NV"].ToString();
        }
    }
}
