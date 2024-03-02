using BUS_QLBanHang;
using DTO_QLBanHang;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class FrmDangNhap : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        DTO_NhanVien nv = new DTO_NhanVien();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {

            nv.EmailNv = txtEmail.Text;

            //Mã hóa mật khẩu của người dùng
            nv.MatKhau = busNhanVien.Encryption(txtMatKhau.Text);

            //Kiểm tra mật khẩu người dùng nhập vào (đã mã hóa) với mật khẩu trong database(đã mã hóa)
            if (busNhanVien.NhanVienDangNhap(nv))
            {
                FrmMain.mail = nv.EmailNv;
                FrmMain.vaitro = busNhanVien.LayVaiTro(nv.EmailNv);
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain.session = 1;
                Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra email hoặc mật khẩu và thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Text = null;
                txtMatKhau.Text = null;
                txtEmail.Focus();
            }
        }
        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            //lấy email trong textbox gán vào thuộc tính của "nv"
            //Bỏ các khoảng trắng thừa khi nhập email
            nv.EmailNv = txtEmail.Text.Trim();

            //kiểm tra xem thuộc tính email có trong db hay không
            if (busNhanVien.CheckEmailTonTai(nv))
            {
                //newPassword: password được cấp mới bằng random > 
                string newPassword = busNhanVien.RandomPassword();

                //Gửi mail với password mới
                busNhanVien.SendMail(txtEmail.Text, newPassword, "Quên Mật Khẩu");

                //mã hóa password mới
                nv.MatKhau = busNhanVien.Encryption(newPassword);

                //đưa password đã mã hóa vào database
                busNhanVien.QuenMatKhau(nv);
            }
            else if (nv.EmailNv == "")
            {
                txtEmail.Text = "";
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Email không tồn tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            
        }

    }
}
