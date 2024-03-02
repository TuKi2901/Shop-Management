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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public bool CheckPhoneNumberDuplicate(string sdt)
        {
            return dalKhachHang.CheckPhoneNumberDuplicate(sdt);
        }
        public string Get_MaNV_From_Email(string email)
        {
            return dalKhachHang.Get_MaNV_From_Email(email);
        }
        public DataTable LayTatCaKhachHang()
        {
            return dalKhachHang.LayTatCaKhachHang();
        }
        public bool InsertKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.InsertKhachHang(kh);
        }
        public bool UpdateKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.UpdateKhachHang(kh);
        }
        public bool DeleteKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.DeleteKhachHang(kh);
        }
        public DataTable TimKiemKhachHang(string tenKhachHang)
        {
            return dalKhachHang.TimKiemKhachHang(tenKhachHang);
        }

    }
}
