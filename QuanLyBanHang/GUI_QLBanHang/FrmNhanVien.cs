using BUS_QLBanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_QLBanHang
{
    public partial class FrmNhanVien : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        DTO_NhanVien nv = new DTO_NhanVien();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridViewNhanVien();
            ResetValue();
        }


        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataGridViewNhanVien()
        {
            dtgvNhanVien.DataSource = busNhanVien.XemTatCaNhanVien();
            dtgvNhanVien.Columns[0].HeaderText = "Email";
            dtgvNhanVien.Columns[0].Width = 200;
            dtgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dtgvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
            dtgvNhanVien.Columns[2].Width = 255;
            dtgvNhanVien.Columns[3].HeaderText = "Vai Trò";
            dtgvNhanVien.Columns[4].HeaderText = "Tình Trạng";
        }

        private void ResetValue()
        {
            txtTimKiem.Text = "Nhập tên nhân viên";
            txtEmail.Text = null;
            txtTenNhanVien.Text = null;
            txtDiaChi.Text = null;
            txtEmail.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDiaChi.Enabled = false;
            rdNhanVien.Enabled = false;
            rdQuanTri.Enabled = false;
            rdHoatDong.Enabled = false;
            rdNgungHoatDong.Enabled = false;
            btThem.Enabled = true;
            btLuu.Enabled = false;
            btDong.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private string IsValidEmail(string email)
        {
            try
            {
                MailAddress checkMail = new MailAddress(email);
                return "True";
            }
            catch (FormatException e)
            {
                return e.Message;
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {

            txtEmail.Text = null;
            txtTenNhanVien.Text = null;
            txtDiaChi.Text = null;
            txtTenNhanVien.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            rdNhanVien.Enabled = true;
            rdQuanTri.Enabled = true;
            rdHoatDong.Enabled = true;
            rdNgungHoatDong.Enabled = true;
            btLuu.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            rdNhanVien.Checked = true;
            rdQuanTri.Checked = false;
            rdHoatDong.Checked = true;
            rdNgungHoatDong.Checked = false;
            txtEmail.Focus();
        }
        private void ThemVaSua(string chucNang)
        {
            try
            {

                if (chucNang == "Thêm")
                {
                    if (CheckNullTextBox() == "True")
                    {
                        GanGiaTri();
                        if (busNhanVien.InsertNhanVien(nv))
                        {
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetValue();
                            LoadDataGridViewNhanVien();
                        }
                    }
                    else
                    {
                        MessageBox.Show(CheckNullTextBox(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtEmail.Text = null;
                        txtTenNhanVien.Text = null;
                        txtDiaChi.Text = null;
                        txtEmail.Focus();
                    }

                }
                else if (chucNang == "Sửa")
                {
                    if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (CheckNullTextBox() == "True")
                        {
                            GanGiaTri();
                            if (busNhanVien.UpdateNhanVien(nv))
                            {
                                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetValue();
                                LoadDataGridViewNhanVien();
                            }
                        }
                        else
                        {
                            MessageBox.Show(CheckNullTextBox(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        ResetValue();
                    }
                }
                else
                {
                    MessageBox.Show("Nhầm Hàm ThemVaSua");
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("Lỗi SQL" + se.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void GanGiaTri()
        {
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string tenNhanVien = txtTenNhanVien.Text.Trim();
            int role = rdQuanTri.Checked ? 1 : 0, tinhtrang = rdHoatDong.Checked ? 1 : 0;
            nv.EmailNv = email;
            nv.TenNhanVien = tenNhanVien;
            nv.DiaChi = diaChi;
            nv.VaiTro = role;
            nv.TinhTrang = tinhtrang;
        }
        private string CheckNullTextBox()
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string tenNhanVien = txtTenNhanVien.Text.Trim();
                int role = rdQuanTri.Checked ? 1 : 0, tinhtrang = rdHoatDong.Checked ? 1 : 0;

                if (email.Length == 0)
                {
                    txtEmail.Focus();
                    return "Bạn phải nhập email";
                }
                else if (tenNhanVien.Length == 0)
                {
                    return "Bạn phải nhập tên";
                }
                else if (IsValidEmail(email) != "True")
                {
                    return IsValidEmail(email);
                }
                else if (diaChi.Length == 0)
                {
                    return "Bạn phải nhập địa chỉ";
                }
                else
                {
                    return "True";
                }

            }
            catch (Exception ex)
            {
                return "Lỗi Application " + ex.Message;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ThemVaSua("Thêm");
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            nv.EmailNv = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.VaiTro = rdQuanTri.Checked ? 1 : 0;
            nv.TinhTrang = rdHoatDong.Checked ? 1 : 0;

            try
            {
                DialogResult = MessageBox.Show("Bạn có chắc chắn xóa nhân viên này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.No)
                {
                    ResetValue();
                    return;
                }
                try
                {
                    if (busNhanVien.DeleteNhanVien(nv))
                    {
                        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetValue();
                        LoadDataGridViewNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Lỗi SQL: " + se.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Application: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            ThemVaSua("Sửa");
        }

        private void dtgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvNhanVien.Rows.Count > 1)
                {
                    btLuu.Enabled = false;
                    txtTenNhanVien.Enabled = true;
                    txtEmail.Enabled = true;
                    txtDiaChi.Enabled = true;
                    rdQuanTri.Enabled = true;
                    rdHoatDong.Enabled = true;
                    rdNgungHoatDong.Enabled = true;
                    rdNhanVien.Enabled = true;
                    rdQuanTri.Enabled = true;
                    btXoa.Enabled = true;
                    btSua.Enabled = true;
                    txtEmail.Text = dtgvNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                    txtTenNhanVien.Text = dtgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                    txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
                    bool tp = int.TryParse(dtgvNhanVien.CurrentRow.Cells["VaiTro"].Value.ToString(), out _);
                    if (tp)
                    {
                        if (int.Parse(dtgvNhanVien.CurrentRow.Cells["VaiTro"].Value.ToString()) == 1)
                        {
                            rdQuanTri.Checked = true;
                        }
                        else
                        {
                            rdNhanVien.Checked = true;
                        }
                        if (int.Parse(dtgvNhanVien.CurrentRow.Cells["TinhTrang"].Value.ToString()) == 1)
                        {
                            rdHoatDong.Checked = true;
                        }
                        else
                        {
                            rdNgungHoatDong.Checked = true;
                        }
                    }
                    else
                    {
                        btThem_Click(sender, e);

                    }
                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Application: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTimKiem.Text;
            DataTable ds = busNhanVien.TimKiemNhanVien(tenNhanVien);

            try
            {
                if (ds.Rows.Count > 0)
                {
                    dtgvNhanVien.DataSource = ds;
                    dtgvNhanVien.Columns[0].HeaderText = "Email";
                    dtgvNhanVien.Columns[0].Width = 200;
                    dtgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
                    dtgvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
                    dtgvNhanVien.Columns[2].Width = 255;
                    dtgvNhanVien.Columns[3].HeaderText = "Vai Trò";
                    dtgvNhanVien.Columns[4].HeaderText = "Tình Trạng";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTimKiem.Text = "Tìm Kiếm Nhân Viên";
            txtTimKiem.ForeColor = Color.DimGray;
            ResetValue();
        }


        private void btDanhSach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridViewNhanVien();
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridViewNhanVien();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
