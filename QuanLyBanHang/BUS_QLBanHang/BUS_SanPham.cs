using DAL_QLBanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBanHang
{
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();

        public int LayMaHang()
        {
            return dalSanPham.LayMaHang();
        }
        public DataTable LayTatCaSanPham()
        {
            return dalSanPham.LayTatCaSanPham();
        }

        public bool InsertSanPham(DTO_SanPham sp)
        {
            return dalSanPham.InsertSanPham(sp);
        }

        public bool UpdateSanPham(DTO_SanPham sp)
        {
            return dalSanPham.UpdateSanPham(sp);
        }

        public bool DeleteSanPham(DTO_SanPham sp)
        {
            return dalSanPham.DeleteSanPham(sp);
        }

        public DataTable TimKiemSanPham(string tenSanPham)
        {
            return dalSanPham.TimKiemSanPham(tenSanPham);
        }

        public DataTable ThongKeTonKho()
        {
            return dalSanPham.ThongKeTonKho();
        }
        public DataTable ThongKeSanPham()
        {
            return dalSanPham.ThongKeSanPham();
        }
    }
}
