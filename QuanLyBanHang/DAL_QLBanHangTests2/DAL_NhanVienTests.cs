using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO_QLBanHang;
using BUS_QLBanHang;
using GUI_QLBanHang;

namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests : DBConnect
    {
        DAL_NhanVien login = new DAL_NhanVien();
        DTO_NhanVien nv = new DTO_NhanVien();
        BUS_NhanVien bus = new BUS_NhanVien();
        FrmNhanVien crud = new FrmNhanVien();
        [TestMethod()]
        public void Nv001()
        {
            nv.EmailNv = "kiet43012@gmail.com";
            nv.MatKhau =  bus.Encryption("12345678");
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void Nv002()
        {
            nv.EmailNv = "";
            nv.MatKhau =  bus.Encryption("1wer2afas");
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]

        public void Nv003()
        {
            nv.EmailNv = "qwe@sad";
            nv.MatKhau =  bus.Encryption("1wer2afas");
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]

        public void Nv004()
        {
            nv.EmailNv = "qwe@sad.comas";
            nv.MatKhau =  bus.Encryption("");
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]

        public void Nv005()
        {
            nv.EmailNv = "qwe@sad.comas";
            nv.MatKhau =  bus.Encryption("");
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemNVThatBai()
        {
            nv.EmailNv = "a";
            nv.DiaChi = "";
            nv.TenNhanVien = "2";
            bool result = login.InsertNhanVien(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ThemNVThanhCong()
        {
            nv.EmailNv = "a@a.com";
            nv.TenNhanVien = "sdas";
            nv.DiaChi = "sadasd";
            nv.VaiTro = 0;
            nv.TinhTrang = 1;
            bool result = login.InsertNhanVien(nv);
            Assert.IsTrue(result);
        }



    }
}