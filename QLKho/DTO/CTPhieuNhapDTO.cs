using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class CTPhieuNhapDTO
    {
        private int maChiTietPhieuNhap;
        private int maPhieuNhap;
        private int maSanPham;
        private int soLuong;
        private float donGia;

        public int MaChiTietPhieuNhap { get => maChiTietPhieuNhap; set => maChiTietPhieuNhap = value; }
        public int MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }

        public CTPhieuNhapDTO() {
            // Constructor
        }

        public CTPhieuNhapDTO(int maChiTietPhieuNhap, int maPhieuNhap, int maSanPham, int soLuong, float donGia)
        {
            this.maChiTietPhieuNhap = maChiTietPhieuNhap;
            this.maPhieuNhap = maPhieuNhap;
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public CTPhieuNhapDTO(DataRow row)
        {
            Int32.TryParse(row["MA_CTPN"].ToString(), out this.maChiTietPhieuNhap);
            Int32.TryParse(row["MA_PN"].ToString(), out this.maPhieuNhap);
            Int32.TryParse(row["MA_SP"].ToString(), out this.maSanPham);
            Int32.TryParse(row["SOLUONG"].ToString(), out this.soLuong);
            float.TryParse(row["DONGIA"].ToString(), out this.donGia);
        }
    }
}
