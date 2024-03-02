using DTO_QLBanHang;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLBanHang
{
    public class DAL_KhachHang:DBConnect
    {
        DTO_KhachHang kh = new DTO_KhachHang();
        public DataTable LayTatCaKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayTatCaKhachHang";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool InsertKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertKhachHang_tblKhachHang";
                cmd.Parameters.AddWithValue("@dienThoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@tenKhach", kh.TenKhach);
                cmd.Parameters.AddWithValue("@diaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@phai", kh.Phai);
                cmd.Parameters.AddWithValue("@maNV", kh.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool UpdateKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateKhachHang_tblKhachHang";
                cmd.Parameters.AddWithValue("@dienThoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@tenKhach", kh.TenKhach);
                cmd.Parameters.AddWithValue("@diaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@phai", kh.Phai);
                cmd.Parameters.AddWithValue("@maNV", kh.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool DeleteKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteKhachHang_tblKhachHang";
                cmd.Parameters.AddWithValue("@dienThoai", kh.DienThoai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable TimKiemKhachHang(string tenKhachHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimKiemKhachHang_tblKhachHang";
                cmd.Parameters.AddWithValue("@tenKhach", tenKhachHang);
                DataTable tk = new DataTable();
                tk.Load(cmd.ExecuteReader());
                return tk;
            }
            finally
            {
                _conn.Close();
            }
        }
        public string Get_MaNV_From_Email(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Get_MaNV_From_Email";
                cmd.Parameters.AddWithValue("@email", email);
                return cmd.ExecuteScalar().ToString();
            }
            catch(SqlException se)
            {
                return se.Message;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool CheckPhoneNumberDuplicate(string sdt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CheckPhoneNumberDuplicate";
                cmd.Parameters.AddWithValue("@dienThoai", sdt);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
