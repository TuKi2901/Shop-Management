using BUS_QLBanHang;
using DTO_QLBanHang;
using System.Data;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace GUI_QLBanHang
{
    public partial class FrmKhach : Form
    {
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        DTO_KhachHang kh = new DTO_KhachHang();
        public FrmKhach()
        {
            InitializeComponent();
        }



        private void LoadDataGridViewKhachHang()
        {
            dtgvKhachHang.DataSource = busKhachHang.LayTatCaKhachHang();

            dtgvKhachHang.Columns[0].Width = 120;
            dtgvKhachHang.Columns[1].Width = 200;
            dtgvKhachHang.Columns[2].Width = 380;
            dtgvKhachHang.Columns[3].Width = 57;

            dtgvKhachHang.Columns[0].HeaderText = "Số Điện Thoại";
            dtgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dtgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dtgvKhachHang.Columns[3].HeaderText = "Phái";

        }

        private void ResetValue()
        {
            txtTimKiem.Text = "Nhập tên nhân viên";
            txtDiaChi.Text = null;
            txtDienThoai.Text = null;
            txtHoVaTen.Text = null;
            rdNam.Checked = true;
            rdNu.Checked = false;
            txtDienThoai.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtDiaChi.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
            btThem.Enabled = true;
            btLuu.Enabled = false;
            btDong.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;


        }

        private string IsValidPhoneNumber(string phone)
        {
            try
            {
                if (!int.TryParse(phone, out _))
                    return "Vui lòng chỉ nhập số";
                if (phone.Length > 15)
                    return "Số điện thoại phải ngắn hơn 15 chữ số";
                return "True";
            }
            catch (Exception ex)
            {
                return "Lỗi " + ex.Message;
            }
        }

        private string CheckNullTextBox()
        {
            try
            {
                string sdt = txtDienThoai.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string ten = txtHoVaTen.Text.Trim();
                string phai = rdNam.Checked ? "Nam" : "Nữ";

                if (sdt.Length == 0)
                {
                    txtDienThoai.Focus();
                    return "Bạn phải số điện thoại";
                }
                else if (ten.Length == 0)
                {
                    return "Bạn phải nhập họ và tên";
                }
                else if (IsValidPhoneNumber(sdt) != "True")
                {
                    return IsValidPhoneNumber(sdt);
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

        private void ThemVaSua(string chucNang)
        {
            try
            {

                if (chucNang == "Thêm")
                {
                    if (CheckNullTextBox() == "True")
                    {

                        GanGiaTri();
                        kh.MaNV = busKhachHang.Get_MaNV_From_Email(FrmMain.mail);
                        if (busKhachHang.CheckPhoneNumberDuplicate(txtDienThoai.Text))
                            if (busKhachHang.InsertKhachHang(kh))
                            {
                                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetValue();
                                LoadDataGridViewKhachHang();
                            }
                            else
                            {
                                MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetValue();
                                LoadDataGridViewKhachHang();
                            }
                        else
                        {
                            MessageBox.Show("Trùng số điện thoại, vui lòng nhập số điện thoại khác");
                        }

                    }
                    else
                    {
                        MessageBox.Show(CheckNullTextBox(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtDienThoai.Text = null;
                        txtHoVaTen.Text = null;
                        txtDiaChi.Text = null;
                        txtDienThoai.Focus();
                    }

                }
                else if (chucNang == "Sửa")
                {
                    if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (CheckNullTextBox() == "True")
                        {
                            GanGiaTri();
                            if (busKhachHang.UpdateKhachHang(kh))
                            {
                                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetValue();
                                LoadDataGridViewKhachHang();
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
                MessageBox.Show("Lỗi SQL " + se.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void GanGiaTri()
        {
            string sdt = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string ten = txtHoVaTen.Text.Trim();
            string phai = rdNam.Checked ? "Nam" : "Nữ";
            kh.DienThoai = sdt;
            kh.TenKhach = ten;
            kh.DiaChi = diaChi;
            kh.Phai = phai;
        }


        private void FrmKhach_Load(object sender, System.EventArgs e)
        {
            LoadDataGridViewKhachHang();
            ResetValue();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTimKiem.Text;
            DataTable ds = busKhachHang.TimKiemKhachHang(tenKhachHang);

            try
            {
                if (ds.Rows.Count > 0)
                {
                    dtgvKhachHang.DataSource = ds;
                    dtgvKhachHang.Columns[0].Width = 120;
                    dtgvKhachHang.Columns[1].Width = 200;
                    dtgvKhachHang.Columns[2].Width = 380;
                    dtgvKhachHang.Columns[3].Width = 57;

                    dtgvKhachHang.Columns[0].HeaderText = "Số Điện Thoại";
                    dtgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
                    dtgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
                    dtgvKhachHang.Columns[3].HeaderText = "Phái";
                }
                else
                {
                    
                    MessageBox.Show("Không tìm thấy khách hàng" , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTimKiem.Text = "Tìm Kiếm Khách Hàng";
            txtTimKiem.ForeColor = Color.DimGray;
            ResetValue();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }


        private void txtTimKiem_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtDienThoai.Text = null;
            txtHoVaTen.Text = null;
            txtDiaChi.Text = null;
            txtDienThoai.Enabled = true;
            txtHoVaTen.Enabled = true;
            txtDiaChi.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            btLuu.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            txtDienThoai.Focus();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ThemVaSua("Thêm");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ThemVaSua("Sửa");
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridViewKhachHang();
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridViewKhachHang();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            GanGiaTri();

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
                    if (busKhachHang.DeleteKhachHang(kh))
                    {
                        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetValue();
                        LoadDataGridViewKhachHang();
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

        private void dtgvKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvKhachHang.Rows.Count > 1)
                {
                    btLuu.Enabled = false;
                    txtHoVaTen.Enabled = true;
                    txtDiaChi.Enabled = true;
                    rdNam.Enabled = true;
                    rdNu.Enabled = true;
                    btXoa.Enabled = true;
                    btSua.Enabled = true;
                    txtDienThoai.Text = dtgvKhachHang.CurrentRow.Cells["DienThoai"].Value.ToString();
                    txtHoVaTen.Text = dtgvKhachHang.CurrentRow.Cells["TenKhach"].Value.ToString();
                    txtDiaChi.Text = dtgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();

                    if (dtgvKhachHang.CurrentRow.Cells["Phai"].Value.ToString() == "Nam")
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                }
                else
                {
                    btThem_Click(sender, e);
                    //MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Application: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}
