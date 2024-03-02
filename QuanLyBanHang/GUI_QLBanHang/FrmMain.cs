using BUS_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }
        #region Khai báo
        public static int session = 0;
        public static int profile = 0;
        public static int vaitro;
        public static string mail;
        FrmDangNhap FDangNhap = new FrmDangNhap();
        FrmDoiMatKhau FDoiMatKhau = new FrmDoiMatKhau();
        FrmKhach FKhach = new FrmKhach();
        FrmSanPham FSanPham = new FrmSanPham();
        FrmNhanVien FNhanVien = new FrmNhanVien();
        FrmThongKe FThongKe = new FrmThongKe();
        #endregion

        #region Hệ Thống
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap = new FrmDangNhap();
            ShowForm("FrmDangNhap",FDangNhap, FrmDangNhap_FormClosed);
        }


        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau.email = mail;
            FDoiMatKhau = new FrmDoiMatKhau();
            ShowForm("FrmDoiMatKhau",FDoiMatKhau, FrmDoiMatKhau_FormClosed);

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form i in MdiChildren)
            {
                i.Close();
            }
            session = 0;
            profile = 0;
            ResetValue();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Danh Mục
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSanPham = new FrmSanPham();
            ShowForm("FrmSanPham",FSanPham, FrmSanPham_FormClosed);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNhanVien = new FrmNhanVien();
            ShowForm("FrmNhanVien", FNhanVien, FrmNhanVien_FormClosed);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKhach = new FrmKhach();
            ShowForm("FrmKhach", FKhach, FrmKhach_FormClosed);
        }

        #endregion

        #region Thống Kê
        private void sảnPhẩmNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm("FrmThongKe", FThongKe, FrmThongKe_FormClosed);
        }

        private void sảnPhẩmTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm("FrmThongKe", FThongKe, FrmThongKe_FormClosed);
        }

        #endregion

        #region Hướng Dẫn
        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "D:\\FPT Polytechnic\\DuAnMau\\Assignment\\SOF205_Lab guide.pdf");
                System.Diagnostics.Process.Start(path);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file is not found in the specified location");
            }

        }

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Open Multi Form
        private bool CheckExistForm(string formName)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == formName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string formName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == formName)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void ShowForm(string formName, dynamic frmType, FormClosedEventHandler eventClose)
        {

            if (!CheckExistForm(formName))
            {
                frmType.MdiParent = this;
                frmType.Show();
                frmType.FormClosed += new FormClosedEventHandler(eventClose);
            }
            else
            {
                ActiveChildForm(formName);
            }
        }
        #endregion

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát chương trình hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public void FrmMain_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (profile == 1)
            {
                thongTinNVtoolStripMenuItem.Text = "";
                profile = 0;
            }
        }
        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        private void FrmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        private void FrmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void FrmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void FrmKhach_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void thongTinNVtoolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ResetValue()
        {
            
            if (session == 1)
            {
                thongTinNVtoolStripMenuItem.Text = "Xin Chào " + mail;
                đăngNhậpToolStripMenuItem.Enabled = false;
                nhânViênToolStripMenuItem.Visible = true;
                hồSơNhânViênToolStripMenuItem.Visible = true;
                danhMụcToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                sảnPhẩmToolStripMenuItem.Visible = true;
                if (vaitro == 0)
                {
                    nhânViênToolStripMenuItem.Visible = false;
                    thốngKêToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                thongTinNVtoolStripMenuItem.Text = "";
                đăngNhậpToolStripMenuItem.Enabled = true;
                nhânViênToolStripMenuItem.Visible = false;
                hồSơNhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                sảnPhẩmToolStripMenuItem.Visible = false;
            }
        }


    }
}
