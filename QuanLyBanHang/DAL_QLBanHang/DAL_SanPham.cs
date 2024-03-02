using DTO_QLBanHang;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBanHang
{
    public class DAL_SanPham : DBConnect
    {
        public int LayMaHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayMaHang";
                cmd.Connection = _conn;
                //kiểm tra lấy mã hàng có đang null hay không
                if (cmd.ExecuteScalar() == DBNull.Value)
                    return 1;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable LayTatCaSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayTatCaHang";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool InsertSanPham(DTO_SanPham sp)
        {
            try
            {
                //@tenHang nvarchar(50), @soLuong  int, @donGiaNhap  float,
                //@donGiaBan float, @hinhAnh varchar(200), @ghiChu nvarchar(200), @maNV varchar(20)
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertHang_tblHang";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@tenHang ", sp.TenHang);
                cmd.Parameters.AddWithValue("@soLuong ", sp.SoLuong);
                cmd.Parameters.AddWithValue("@donGiaNhap ", sp.DonGiaNhap);
                cmd.Parameters.AddWithValue("@donGiaBan ", sp.DonGiaBan);
                cmd.Parameters.AddWithValue("@HinhAnh ", sp.HinhAnh);
                cmd.Parameters.AddWithValue("@GhiChu ", sp.GhiChu);
                cmd.Parameters.AddWithValue("@MaNV ", sp.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool UpdateSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateHang_tblHang";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@maHang ", sp.MaHang);
                cmd.Parameters.AddWithValue("@tenHang ", sp.TenHang);
                cmd.Parameters.AddWithValue("@soLuong ", sp.SoLuong);
                cmd.Parameters.AddWithValue("@donGiaNhap ", sp.DonGiaNhap);
                cmd.Parameters.AddWithValue("@donGiaBan ", sp.DonGiaBan);
                cmd.Parameters.AddWithValue("@HinhAnh ", sp.HinhAnh);
                cmd.Parameters.AddWithValue("@GhiChu ", sp.GhiChu);
                cmd.Parameters.AddWithValue("@MaNV ", sp.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool DeleteSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteHang_tblHang";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@maHang ", sp.MaHang);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable TimKiemSanPham(string tenHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimKiemHang_tblHang";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@tenHang ", tenHang);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable ThongKeTonKho()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeTonKho";
                cmd.Connection = _conn;
                DataTable tk = new DataTable();
                tk.Load(cmd.ExecuteReader());
                return tk;

            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable ThongKeSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeSP";
                cmd.Connection = _conn;
                DataTable tksp = new DataTable();
                tksp.Load(cmd.ExecuteReader());
                return tksp;
            }
            finally
            {
                _conn.Close();
            }
        }

    }
}
