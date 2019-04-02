using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class ThongKeDTO
    {
        private int maSP;
        private string tenSP;
        private int soLuong;
        private float donGia;
        private float thanhTien;
        private DateTime ngayXuat;


        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }

        public ThongKeDTO(int maSP, string tenSP, int soLuong, float donGia, float thanhTien, DateTime ngayXuat)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
            this.ngayXuat = ngayXuat;
        }

        public ThongKeDTO(DataRow row)
        {
            Int32.TryParse(row["MA_SP"].ToString(), out this.maSP);
            this.tenSP = row["TEN_SP"].ToString();
            Int32.TryParse(row["TONGSL"].ToString(), out this.soLuong);
            float.TryParse(row["DONGIA"].ToString(), out this.donGia);
            float.TryParse(row["THANHTIEN"].ToString(), out this.thanhTien);
            DateTime.TryParse(row["NGAYXUAT"].ToString(), out this.ngayXuat);
        }
    }
}
