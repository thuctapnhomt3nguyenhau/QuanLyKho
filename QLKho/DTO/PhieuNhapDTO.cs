using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class PhieuNhapDTO
    {
        private int maPhieuNhap;
        private int maNhanVien;
        private int maNhaCungCap;
        private DateTime ngayNhap;

        public int MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }

        public PhieuNhapDTO()
        {
            // Constructor;
        }

        public PhieuNhapDTO(int maPhieuNhap, int maNhanVien, int maNhaCungCap, DateTime ngayNhap)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maNhanVien = maNhanVien;
            this.maNhaCungCap = maNhaCungCap;
            this.ngayNhap = ngayNhap;
        }
        
        public PhieuNhapDTO(DataRow row)
        {
            Int32.TryParse(row["MA_PN"].ToString(), out this.maPhieuNhap);
            Int32.TryParse(row["MA_NV"].ToString(), out this.maNhanVien);
            Int32.TryParse(row["MA_NCC"].ToString(), out this.maNhaCungCap);
            ngayNhap = (DateTime)row["NGAYNHAP"];
        }

    }
}
