using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKho.DTO
{
    class SanPhamDTO
    {
        private int maSP;      
        private string tenSP;
        private int maNCC;
        private string tsKT;
        private float gia;
        private int soLUONG;

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TsKT { get => tsKT; set => tsKT = value; }
        public float Gia { get => gia; set => gia = value; }
        public int SoLUONG { get => soLUONG; set => soLUONG = value; }

        public SanPhamDTO(int maSP, string tenSP, int maNCC, string tsKT, float gia, int soLUONG)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.maNCC = maNCC;
            this.tsKT = tsKT;
            this.gia = gia;
            this.soLUONG = soLUONG;
        }
        public SanPhamDTO(DataRow row)
        {
            Int32.TryParse(row["MA_SP"].ToString(), out this.maSP);
            this.tenSP = row["TEN_SP"].ToString();
            Int32.TryParse(row["MA_NCC"].ToString(), out this.maNCC);
            this.tsKT = row["THONGSO_KT"].ToString();
            Int32.TryParse(row["SOLUONG"].ToString(), out this.soLUONG);
            float.TryParse(row["GIA"].ToString(), out this.gia);
        }
    }
}
