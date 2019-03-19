using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class NhaCungCapDTO
    {
        private int maNCC;
        private string tenNCC;
        private string diachiNCC;
        private int sdtNCC;
        private string websiteNCC;

        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiachiNCC { get => diachiNCC; set => diachiNCC = value; }
        public int SdtNCC { get => sdtNCC; set => sdtNCC = value; }
        public string WebsiteNCC { get => websiteNCC; set => websiteNCC = value; }

        public NhaCungCapDTO (int maNCC , string tenNCC , string diachiNCC , int sdtNCC , string websiteNCC)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diachiNCC = diachiNCC;
            this.sdtNCC = sdtNCC;
            this.websiteNCC = websiteNCC;
        }
        public NhaCungCapDTO (DataRow row)
        {
            Int32.TryParse(row["MA_NCC"].ToString(), out this.maNCC);
            this.TenNCC = row["TEN_NCC"].ToString();
            this.DiachiNCC = row["DIACHI_NCC"].ToString();
            Int32.TryParse(row["SDT_NCC"].ToString(), out this.sdtNCC);
            this.WebsiteNCC = row["WEBSITE_NCC"].ToString();
        }
    }
}
