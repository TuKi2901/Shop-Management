using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_KhachHang
    {
        private string dienThoai;
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string maNV;

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        public string TenKhach
        {
            get { return tenKhach; }
            set { tenKhach = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string Phai
        {
            get { return phai; }
            set { phai = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai, string maNV)
        {
            this.DienThoai = dienThoai;
            this.TenKhach = tenKhach;
            this.DiaChi = diaChi;
            this.Phai = phai;
            this.MaNV = maNV;
        }
        public DTO_KhachHang() { }
    }
}
