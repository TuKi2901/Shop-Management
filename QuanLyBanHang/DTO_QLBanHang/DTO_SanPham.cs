using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_SanPham
    {
        private int maHang;
        private string tenHang;
        private int soLuong;
        private float donGiaNhap;
        private float donGiaBan;
        private string hinhAnh;
        private string ghiChu;
        private string maNV;

        public int MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public float DonGiaNhap
        {
            get { return donGiaNhap; }
            set { donGiaNhap = value; }
        }
        public float DonGiaBan
        {
            get { return donGiaBan; }
            set { donGiaBan = value; }
        }
        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public DTO_SanPham(int maHang, string tenHang, int soLuong, float donGiaNhap, float donGiaBan, string hinhAnh, string ghiChu, string maNV)
        {
            this.maHang = maHang;
            this.TenHang = tenHang;
            this.DonGiaBan = donGiaBan;
            this.DonGiaNhap = donGiaNhap;
            this.HinhAnh = hinhAnh;
            this.GhiChu = ghiChu;
            this.MaNV = maNV;
        }
        public DTO_SanPham() { }

    }
}
