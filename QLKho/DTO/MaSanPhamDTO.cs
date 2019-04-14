using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKho.DTO
{
    class MaSanPhamDTO
    {
        private int maSanPham;

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }

        public MaSanPhamDTO() { }

        public MaSanPhamDTO(int maSanPham)
        {
            this.maSanPham = maSanPham;
        }

        public MaSanPhamDTO(DataRow row)
        {
            Int32.TryParse(row["MA_SP"].ToString(), out this.maSanPham );
        }
    }
}
