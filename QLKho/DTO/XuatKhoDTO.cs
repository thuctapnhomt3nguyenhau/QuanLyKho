using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DTO
{
    class XuatKhoDTO
    {
        private int maPX;
        private int maNV;
        private string hoTen;
        private DateTime ngayXuat;
        private string tenSP;
        private int maCTPX;
        private int maSP;
        private int soLuong;
        private float donGia;
        private int maCt;
        
        public int MaPX { get => maPX; set => maPX = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public int MaCTPX { get => maCTPX; set => maCTPX = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int MaCt { get => maCt; set => maCt = value; }

        public XuatKhoDTO(int maPX,int maNV,DateTime ngayXuat,string tenSP,int maCTPX,int maSP,int soLuong,float donGia,int maCt)
        {
            this.maPX = maPX;
            this.maNV = maNV;
            this.ngayXuat = ngayXuat;
            this.tenSP = tenSP;
            this.maCTPX = maCTPX;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.maCt = maCt;
        }
        public XuatKhoDTO(DataRow row)
        {
            Int32.TryParse(row["MA_PX"].ToString(), out this.maPX);
            Int32.TryParse(row["MA_NV"].ToString(), out this.maNV);
            this.hoTen = row["TEN_NV"].ToString();
            DateTime.TryParse(row["NGAYXUAT"].ToString(), out this.ngayXuat);
            this.tenSP = row["TEN_SP"].ToString();
            Int32.TryParse(row["MA_CTPX"].ToString(), out this.maCTPX);
            Int32.TryParse(row["MA_SP"].ToString(), out this.maSP);
            Int32.TryParse(row["SOLUONG"].ToString(), out this.soLuong);
            float.TryParse(row["DONGIA"].ToString(), out this.donGia);
            Int32.TryParse(row["MA_CTPX"].ToString(), out this.maCt);
        }
    }
}
