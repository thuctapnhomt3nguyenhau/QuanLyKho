using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class TTSanPhamDTO
    {
        private int maSP;
        private string tenSP;
        private int maNCC;
        private string tsKT;
        private float gia;
        private string tenNCC;

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TsKT { get => tsKT; set => tsKT = value; }
        public float Gia { get => gia; set => gia = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }

        public TTSanPhamDTO(int maSP, string tenSP, int maNCC, string tsKT, float gia, string tenNCC)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.maNCC = maNCC;
            this.tsKT = tsKT;
            this.gia = gia;
            this.tenNCC = tenNCC;
        }
        public TTSanPhamDTO(DataRow row)
        {
            Int32.TryParse(row["MA_SP"].ToString(), out this.maSP);
            this.tenSP = row["TEN_SP"].ToString();
            Int32.TryParse(row["MA_NCC"].ToString(), out this.maNCC);
            this.tsKT = row["THONGSO_KT"].ToString();
            float.TryParse(row["GIA"].ToString(), out this.gia);
            this.tenNCC = row["TEN_NCC"].ToString();
        }
    }
}
