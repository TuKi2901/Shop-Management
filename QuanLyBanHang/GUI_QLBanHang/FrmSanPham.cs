using BUS_QLBanHang;
using DTO_QLBanHang;
using System.Net.Mail;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace GUI_QLBanHang
{
    public partial class FrmSanPham : Form
    {
        BUS_SanPham busSanPham = new BUS_SanPham();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        DTO_SanPham sp = new DTO_SanPham();

        string mail = FrmMain.mail;
        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;
        public FrmSanPham()
        {
            InitializeComponent();
        }


        private void LoadDataGridViewSanPham()
        {
            dtgvSanPham.AutoResizeColumns();
            txtMaHang.Text = busSanPham.LayMaHang().ToString();
            dtgvSanPham.DataSource = busSanPham.LayTatCaSanPham();
            dtgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dtgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtgvSanPham.Columns[2].HeaderText = "Số Lượng";
            dtgvSanPham.Columns[3].HeaderText = "Đơn Giá Nhập";
            dtgvSanPham.Columns[4].HeaderText = "Đơn Giá Bán";
            dtgvSanPham.Columns[5].HeaderText = "Hình Ảnh";
            dtgvSanPham.Columns[6].HeaderText = "Ghi Chú";
        }
        private void ResetValue()
        {
            txtTimKiem.Text = "Nhập tên sản phẩm";
            txtMaHang.Text = null;
            txtTenHang.Text = null;
            txtSoLuong.Text = null;
            txtDonGiaNhap.Text = null;
            txtDonGiaBan.Text = null;
            txtHinh.Text = null;
            txtGhiChu.Text = null;
            pbHinh.Image = null;
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtHinh.Enabled = false;
            txtGhiChu.Enabled = false;
            btThem.Enabled = true;
            btLuu.Enabled = false;
            btDong.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
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
                        sp.MaNV = busKhachHang.Get_MaNV_From_Email(FrmMain.mail);
                        if (busSanPham.InsertSanPham(sp))
                        {
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            File.Copy(fileAddress, fileSavePath, true);
                            ResetValue();
                            LoadDataGridViewSanPham();
                        }
                    }
                    else
                    {
                        MessageBox.Show(CheckNullTextBox(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtMaHang.Text = null;
                        txtTenHang.Text = null;
                        txtSoLuong.Text = null;
                        txtMaHang.Focus();
                    }

                }
                else if (chucNang == "Sửa")
                {
                    if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (CheckNullTextBox() == "True")
                        {
                            GanGiaTri();
                            sp.MaNV = busKhachHang.Get_MaNV_From_Email(FrmMain.mail);
                            if (busSanPham.UpdateSanPham(sp))
                            {
                                if (txtHinh.Text != checkUrlImage)
                                    File.Copy(fileAddress, fileSavePath, true);
                                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetValue();
                                LoadDataGridViewSanPham();
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
            int maHang = int.Parse(txtMaHang.Text.Trim());
            string tenHang = txtTenHang.Text.Trim();
            int soLuong = int.Parse(txtSoLuong.Text.Trim());
            float donGiaNhap = float.Parse(txtDonGiaNhap.Text.Trim());
            float donGiaBan = float.Parse(txtDonGiaBan.Text.Trim());
            string hinh = txtHinh.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();


            sp.MaHang = maHang;
            sp.TenHang = tenHang;
            sp.SoLuong = soLuong;
            sp.DonGiaNhap = donGiaNhap;
            sp.DonGiaBan = donGiaBan;
            sp.HinhAnh = hinh;
            sp.GhiChu = ghiChu;
        }
        private string CheckNullTextBox()
        {
            try
            {
                int soLuong;
                float donGiaNhap, donGiaBan;
                int maHang = int.Parse(txtMaHang.Text.Trim());
                string tenHang = txtTenHang.Text.Trim();
                string hinh = txtHinh.Text.Trim();
                string ghiChu = txtGhiChu.Text.Trim();

                if (!int.TryParse(txtSoLuong.Text, out _))
                    return "Phải nhập số nguyên ở ô Số Lượng";

                else if (!float.TryParse(txtDonGiaNhap.Text.Trim(), out _))
                    return "Phải nhập số ở ô Đơn Giá Nhập";

                if (!float.TryParse(txtDonGiaBan.Text.Trim(), out _))
                    return "Phải nhập số ở ô Đơn Giá Bán";
                else
                {
                    soLuong = int.Parse(txtSoLuong.Text.Trim());
                    donGiaNhap = float.Parse(txtDonGiaNhap.Text.Trim());
                    donGiaBan = float.Parse(txtDonGiaBan.Text.Trim());
                }
                if (tenHang.Length == 0)
                {
                    txtTenHang.Focus();
                    return "Bạn phải nhập tên hàng";
                }
                else if (soLuong < 1)
                {
                    return "Số lượng phải lớn hơn 0";
                }
                else if (donGiaNhap <= 0)
                {
                    return "Đơn giá nhập phải lớn hơn  0";
                }
                else if (donGiaBan < 0)
                {
                    return "Đơn giá bán phải lớn hơn hoặc bằng 0";
                }
                else if (hinh.Length == 0)
                {
                    return "Hình không được để trống";
                }
                else if (ghiChu.Length == 0)
                {
                    return "Ghi chú không được để trống";
                }
                else
                    return "True";
            }
            catch (Exception ex)
            {
                return "Lỗi Application " + ex.Message;
            }
        }




        private void btMoHinh_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*bmp|JPEG(*.jpg)|*jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pbHinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txtHinh.Text = "\\Images\\" + fileName;
            }
        }

        private void btThem_Click(object sender, System.EventArgs e)
        {
            txtMaHang.Text = busSanPham.LayMaHang().ToString();
            txtTenHang.Text = null;
            txtSoLuong.Text = null;
            txtDonGiaNhap.Text = null;
            txtDonGiaBan.Text = null;
            txtHinh.Text = null;
            txtGhiChu.Text = null;

            txtMaHang.Enabled = false;
            txtTenHang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtHinh.Enabled = false;
            txtGhiChu.Enabled = true;
            btLuu.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            txtTenHang.Focus();
        }

        private void btXoa_Click(object sender, System.EventArgs e)
        {
            sp.MaHang = int.Parse(txtMaHang.Text);

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
                    if (busSanPham.DeleteSanPham(sp))
                    {
                        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetValue();
                        LoadDataGridViewSanPham();
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


        private void btSua_Click(object sender, System.EventArgs e)
        {
            ThemVaSua("Sửa");
        }

        private void btLuu_Click(object sender, System.EventArgs e)
        {
            ThemVaSua("Thêm");
        }

        private void btBoQua_Click(object sender, System.EventArgs e)
        {
            ResetValue();
            LoadDataGridViewSanPham();
        }

        private void btDong_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


        private void btTimKiem_Click(object sender, System.EventArgs e)
        {
            string tenSanPham = txtTimKiem.Text;
            DataTable ds = busSanPham.TimKiemSanPham(tenSanPham);

            try
            {
                if (ds.Rows.Count > 0)
                {
                    dtgvSanPham.DataSource = ds;
                    dtgvSanPham.AutoResizeColumns();
                    dtgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
                    dtgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
                    dtgvSanPham.Columns[2].HeaderText = "Số Lượng";
                    dtgvSanPham.Columns[3].HeaderText = "Đơn Giá Nhập";
                    dtgvSanPham.Columns[4].HeaderText = "Đơn Giá Bán";
                    dtgvSanPham.Columns[5].HeaderText = "Hình Ảnh";
                    dtgvSanPham.Columns[6].HeaderText = "Ghi Chú";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTimKiem.Text = "Tìm Kiếm Sản Phẩm";
            txtTimKiem.ForeColor = Color.DimGray;
            ResetValue();
        }

        private void btDanhSach_Click(object sender, System.EventArgs e)
        {
            ResetValue();
            LoadDataGridViewSanPham();
        }

        private void txtTimKiem_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";

        }

        private void dtgvSanPham_Click(object sender, System.EventArgs e)
        {
            string saveDirectory = "";
            saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            try
            {
                if (dtgvSanPham.Rows.Count > 0)
                {
                    btLuu.Enabled = false;
                    txtTenHang.Enabled = true;
                    txtSoLuong.Enabled = true;
                    txtHinh.Enabled = false;
                    txtGhiChu.Enabled = true;
                    txtDonGiaNhap.Enabled = true;
                    txtDonGiaBan.Enabled = true;
                    btXoa.Enabled = true;
                    btSua.Enabled = true;
                    try
                    {
                        txtMaHang.Text = dtgvSanPham.CurrentRow.Cells["MaHang"].Value.ToString();
                        txtTenHang.Text = dtgvSanPham.CurrentRow.Cells["TenHang"].Value.ToString();
                        txtSoLuong.Text = dtgvSanPham.CurrentRow.Cells["SoLuong"].Value.ToString();
                        txtDonGiaNhap.Text = dtgvSanPham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
                        txtDonGiaBan.Text = dtgvSanPham.CurrentRow.Cells["DonGiaBan"].Value.ToString();
                        txtHinh.Text = dtgvSanPham.CurrentRow.Cells["HinhAnh"].Value.ToString();
                        txtGhiChu.Text = dtgvSanPham.CurrentRow.Cells["GhiChu"].Value.ToString();
                        checkUrlImage = txtHinh.Text;
                        if (pbHinh.Image != null)
                            pbHinh.Image = Image.FromFile(saveDirectory + dtgvSanPham.CurrentRow.Cells["HinhAnh"].Value.ToString());
                    }
                    catch
                    {
                        btThem_Click(sender, e);
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

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridViewSanPham();
        }

    }
}
