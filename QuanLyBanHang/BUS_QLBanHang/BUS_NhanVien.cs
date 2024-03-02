using DAL_QLBanHang;
using DTO_QLBanHang;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace BUS_QLBanHang
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();

        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }
        public bool CheckEmailTonTai(DTO_NhanVien nv)
        {
            return dalNhanVien.CheckEmailTonTai(nv);
        }

        public bool QuenMatKhau(DTO_NhanVien nv)
        {
            return dalNhanVien.QuenMatKhau(nv);
        }
        public bool DoiMatKhau(DTO_NhanVien nv, string matKhauMoi)
        {
            return dalNhanVien.DoiMatKhau(nv, matKhauMoi);
        }
        public int LayVaiTro(string email)
        {
            return dalNhanVien.LayVaiTro(email);
        }

        public DataTable XemTatCaNhanVien()
        {
            return dalNhanVien.XemTatCaNhanVien();
        }

        //Hàm mã hóa mật khẩu
        public string Encryption(string password)
        {
            //khai báo biến md5 để sử dụng mã hóa md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //khai báo mảng byte để lưu trữ dữ liệu mã hóa
            byte[] encrypt;
            //Khai báo biến dùng utf8
            UTF8Encoding encode = new UTF8Encoding();

            //lấy password (từ người dùng nhập vào), chuyển thành dạng byte bằng hàm mã hóa "ComputeHash"
            //Chuyển thành dạng utf8 qua encode
            //Lưu các biến byte thành 1 mảng encrypt
            encrypt = md5.ComputeHash(encode.GetBytes(password));

            //trả về chuỗi đã mã hóa được ép kiểu Base64
            return Convert.ToBase64String(encrypt);
        }
        public string RandomPassword()
        {
            //giới hạn độ dài password
            byte[] bytes = new byte[8];
            //dùng thư viện để random
            RandomNumberGenerator.Create().GetBytes(bytes);
            //chuyển đổi byte thành string
            return Convert.ToBase64String(bytes);
        }
        //gửi mail khi quên mật khẩu
        public void SendMail(string recipientEmail, string randomPassword, string subject)
        {
            try
            {
                //tạo biến format nội dung(body) trong email
                string bodyHtml = $@"
                <p style=""font-size: 18px;"">
                    Bạn đã sử dụng chức năng {subject}
                    <br>
                    Đây là mật khẩu mới của bạn
                    <br>
                </p>
    
                <p style=""border: 2px ;background-color: rgb(0, 101, 209);font-size: 40px; color: white; letter-spacing: 5px; text-align: center; width: auto;"">
                        {randomPassword}
                </p>";

                //tạo biến "mail" để tùy chỉnh các thuộc tính trong thư (email)
                MailMessage mail = new MailMessage();

                //tạo biến smtp: giao thức truyền tải email, kết nối với "gmail"
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                //mail người gửi
                mail.From = new MailAddress("kiet43012@gmail.com");

                //mail người nhận (truyền tham số)
                mail.To.Add(recipientEmail);

                //tiêu đề mail
                mail.Subject = subject;

                //xác định mail được viết bằng html
                mail.IsBodyHtml = true;

                //gọi lại biến được khai báo ở trên
                mail.Body = bodyHtml;

                //chọn cổng của google
                smtp.Port = 587;

                //không dùng thông tin đăng nhập mặc định
                smtp.UseDefaultCredentials = false;

                //đăng nhập tài khoản cần gửi mail, mã đăng nhập vào mail
                smtp.Credentials = new NetworkCredential("kiet43012@gmail.com", "cywt jdam bmuw fqwq");

                //sử dụng giao thức ssl để kết nối máy chủ
                smtp.EnableSsl = true;

                //gửi mail
                smtp.Send(mail);

                //thông báo khi gửi mail thành công
                MessageBox.Show("Đã gửi thông báo vào email của bạn, Vui lòng kiểm tra email", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.InsertNhanVien(nv);
        }
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.UpdateNhanVien(nv);
        }
        public bool DeleteNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.DeleteNhanVien(nv);
        }
        public DataTable TimKiemNhanVien(string tenNhanVien)
        {
            return dalNhanVien.TimKiemNhanVien(tenNhanVien);
        }
    }
}
