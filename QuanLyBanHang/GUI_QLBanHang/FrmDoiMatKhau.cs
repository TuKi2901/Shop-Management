using BUS_QLBanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class FrmDoiMatKhau : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        DTO_NhanVien nv = new DTO_NhanVien();
        public static string email;
        //Không được khai báo form Main khi đang chạy Main -> Gây lỗi không xuất hiện form main 
        //FrmMain Fmain = new FrmMain();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
            txtEmail.Enabled = false;
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (CheckDoiMatKhau())
            {
                if (txtMatKhauMoi.Text.Trim().Length > 7)
                {
                    string matKhauCu = busNhanVien.Encryption(txtMatKhauCu.Text.Trim());
                    string matKhauMoi = busNhanVien.Encryption(txtMatKhauMoi.Text.Trim());
                    string xacNhanmatKhau = busNhanVien.Encryption(txtNhapLaiMatKhau.Text.Trim());
                    nv.MatKhau = matKhauCu;
                    nv.EmailNv = email;
                    if (matKhauCu == matKhauMoi)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ");
                        return;
                    }
                    if (matKhauMoi != xacNhanmatKhau)
                    {
                        MessageBox.Show("xác nhận mật khẩu không đúng");
                        return;
                    }
                    if (busNhanVien.DoiMatKhau(nv, matKhauMoi))
                    {
                        FrmMain.session = 0;
                        FrmMain.profile = 1;
                        busNhanVien.SendMail(email, txtMatKhauMoi.Text, "Đổi Mật Khẩu");
                        MessageBox.Show("Đã đổi mật khẩu thành công. Vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng kiểm tra lại mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới phải tối thiểu 8 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtMatKhauCu.Focus();
                MessageBox.Show("Thông tin không đúng, hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }
        public bool CheckDoiMatKhau()
        {
            if (txtMatKhauCu.Text != "")
                if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
                    return true;
            return false;
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
