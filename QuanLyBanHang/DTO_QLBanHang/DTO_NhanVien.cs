namespace DTO_QLBanHang
{
    public class DTO_NhanVien
    {
        private string tenNhanVien;
        private string diaChi;
        private int vaiTro;
        private string emailNv;
        private string matKhau;
        private int tinhTrang;

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }

        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }

        }
        public int VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }

        }
        public string EmailNv
        {
            get { return emailNv; }
            set { emailNv = value; }

        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }

        }
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }

        }

        public DTO_NhanVien(string tenNhanVien, string diaChi, int vaiTro, string emailNv, string matKhau, int tinhTrang)
        {
            this.TenNhanVien = tenNhanVien;
            this.DiaChi = diaChi;
            this.VaiTro = vaiTro;
            this.EmailNv = emailNv;
            this.MatKhau = matKhau;
            this.TinhTrang = tinhTrang;
        }
        public DTO_NhanVien()
        { }
    }
}
