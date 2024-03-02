using DTO_QLBanHang;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBanHang
{
    public class DAL_NhanVien : DBConnect
    {
        public DataTable XemTatCaNhanVien()
        {
            try
            {
                //mở kết nối db
                _conn.Open();
                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();
                //kết nối cmd với db
                cmd.Connection = _conn;
                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayTatCaNhanVien";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;

            }
            finally { _conn.Close(); }
        }

        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();

                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertNhanVien_tblNhanVien";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@Email", nv.EmailNv);
                cmd.Parameters.AddWithValue("@TenNV", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
                cmd.Parameters.AddWithValue("@TinhTrang", nv.TinhTrang);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();

                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateNhanVien_tblNhanVien";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@Email", nv.EmailNv);
                cmd.Parameters.AddWithValue("@TenNV", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
                cmd.Parameters.AddWithValue("@TinhTrang", nv.TinhTrang);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool DeleteNhanVien(DTO_NhanVien nv)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();

                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteNhanVien_tblNhanVien";
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@Email", nv.EmailNv);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable TimKiemNhanVien(string tenNhanVien)
        {
            _conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimKiemNhanVien_tblNhanVien";
                cmd.Parameters.AddWithValue("@TenNv", tenNhanVien);
                DataTable dtTimKiemNhanVien = new DataTable();
                dtTimKiemNhanVien.Load(cmd.ExecuteReader());
                return dtTimKiemNhanVien;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();
                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("@email", nv.EmailNv);
                cmd.Parameters.AddWithValue("@matkhau", nv.MatKhau);

                if (Convert.ToUInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
                return false;
            }
            finally { _conn.Close(); }

        }

        public bool CheckEmailTonTai(DTO_NhanVien nv)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();
                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CheckEmailTonTai";
                cmd.Parameters.AddWithValue("@email", nv.EmailNv);
                if (Convert.ToUInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool QuenMatKhau(DTO_NhanVien nv)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();
                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;

                //tên của proc
                cmd.CommandText = "QuenMatKhau";

                //truyền các thuộc tính của nv vào các biến trong proc
                cmd.Parameters.AddWithValue("@email", nv.EmailNv);
                cmd.Parameters.AddWithValue("@matkhau", nv.MatKhau);

                //thực thi proc, trả về 0 hoặc 1
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DoiMatKhau(DTO_NhanVien nv, string matKhauMoi)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();
                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;

                //tên của proc
                cmd.CommandText = "DoiMatKhau";

                //truyền các thuộc tính của nv vào các biến trong proc
                cmd.Parameters.AddWithValue("@email", nv.EmailNv);
                cmd.Parameters.AddWithValue("@matKhauCu", nv.MatKhau);
                cmd.Parameters.AddWithValue("@matKhauMoi", matKhauMoi);

                //thực thi proc, trả về 0 hoặc 1
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public int LayVaiTro(string email)
        {
            try
            {
                //mở kết nối db
                _conn.Open();

                //tạo biến cho phép thực thi lệnh trong sql
                SqlCommand cmd = new SqlCommand();
                //kết nối cmd với db
                cmd.Connection = _conn;

                //chọn kiểu để sử dụng
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayVaiTro";
                cmd.Parameters.AddWithValue("@email", email);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            return 0;
        }

    }
}
