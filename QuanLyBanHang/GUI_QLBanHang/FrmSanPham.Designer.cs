namespace GUI_QLBanHang
{
    partial class FrmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.btMoHinh = new System.Windows.Forms.Button();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbDonGiaNhap = new System.Windows.Forms.Label();
            this.lbDonGiaBan = new System.Windows.Forms.Label();
            this.lbHinh = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.btDanhSach = new System.Windows.Forms.Button();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaHang.Location = new System.Drawing.Point(166, 72);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(192, 26);
            this.txtMaHang.TabIndex = 0;
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.lbSanPham.Location = new System.Drawing.Point(368, 9);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(146, 32);
            this.lbSanPham.TabIndex = 1;
            this.lbSanPham.Text = "Sản Phẩm";
            // 
            // btMoHinh
            // 
            this.btMoHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btMoHinh.Location = new System.Drawing.Point(542, 169);
            this.btMoHinh.Name = "btMoHinh";
            this.btMoHinh.Size = new System.Drawing.Size(127, 26);
            this.btMoHinh.TabIndex = 2;
            this.btMoHinh.Text = "Mở Hình";
            this.btMoHinh.UseVisualStyleBackColor = true;
            this.btMoHinh.Click += new System.EventHandler(this.btMoHinh_Click);
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Location = new System.Drawing.Point(37, 338);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.ReadOnly = true;
            this.dtgvSanPham.Size = new System.Drawing.Size(813, 150);
            this.dtgvSanPham.TabIndex = 3;
            this.dtgvSanPham.Click += new System.EventHandler(this.dtgvSanPham_Click);
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMaHang.Location = new System.Drawing.Point(33, 75);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(74, 20);
            this.lbMaHang.TabIndex = 1;
            this.lbMaHang.Text = "Mã Hàng";
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTenHang.Location = new System.Drawing.Point(33, 125);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(79, 20);
            this.lbTenHang.TabIndex = 1;
            this.lbTenHang.Text = "Tên Hàng";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSoLuong.Location = new System.Drawing.Point(33, 175);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(78, 20);
            this.lbSoLuong.TabIndex = 1;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // lbDonGiaNhap
            // 
            this.lbDonGiaNhap.AutoSize = true;
            this.lbDonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDonGiaNhap.Location = new System.Drawing.Point(33, 225);
            this.lbDonGiaNhap.Name = "lbDonGiaNhap";
            this.lbDonGiaNhap.Size = new System.Drawing.Size(110, 20);
            this.lbDonGiaNhap.TabIndex = 1;
            this.lbDonGiaNhap.Text = "Đơn Giá Nhập";
            // 
            // lbDonGiaBan
            // 
            this.lbDonGiaBan.AutoSize = true;
            this.lbDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDonGiaBan.Location = new System.Drawing.Point(33, 279);
            this.lbDonGiaBan.Name = "lbDonGiaBan";
            this.lbDonGiaBan.Size = new System.Drawing.Size(101, 20);
            this.lbDonGiaBan.TabIndex = 1;
            this.lbDonGiaBan.Text = "Đơn Giá Bán";
            // 
            // lbHinh
            // 
            this.lbHinh.AutoSize = true;
            this.lbHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHinh.Location = new System.Drawing.Point(472, 75);
            this.lbHinh.Name = "lbHinh";
            this.lbHinh.Size = new System.Drawing.Size(42, 20);
            this.lbHinh.TabIndex = 1;
            this.lbHinh.Text = "Hình";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGhiChu.Location = new System.Drawing.Point(469, 209);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(67, 20);
            this.lbGhiChu.TabIndex = 1;
            this.lbGhiChu.Text = "Ghi Chú";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenHang.Location = new System.Drawing.Point(166, 122);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(192, 26);
            this.txtTenHang.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Location = new System.Drawing.Point(166, 172);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(192, 26);
            this.txtSoLuong.TabIndex = 0;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonGiaNhap.Location = new System.Drawing.Point(166, 222);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(192, 26);
            this.txtDonGiaNhap.TabIndex = 0;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonGiaBan.Location = new System.Drawing.Point(166, 276);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(192, 26);
            this.txtDonGiaBan.TabIndex = 0;
            // 
            // txtHinh
            // 
            this.txtHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHinh.Location = new System.Drawing.Point(542, 78);
            this.txtHinh.Multiline = true;
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(127, 85);
            this.txtHinh.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(542, 209);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(308, 93);
            this.txtGhiChu.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiem.Location = new System.Drawing.Point(380, 520);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(213, 26);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.Text = "Nhập tên sản phẩm";
            this.txtTimKiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseDown);
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(675, 78);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(175, 117);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHinh.TabIndex = 15;
            this.pbHinh.TabStop = false;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btTimKiem.Image = global::GUI_QLBanHang.Properties.Resources.search;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(614, 516);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(123, 34);
            this.btTimKiem.TabIndex = 14;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDong.Image = global::GUI_QLBanHang.Properties.Resources.closed;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(727, 578);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 34);
            this.btDong.TabIndex = 5;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btDanhSach
            // 
            this.btDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDanhSach.Image = global::GUI_QLBanHang.Properties.Resources.clipboard;
            this.btDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDanhSach.Location = new System.Drawing.Point(235, 516);
            this.btDanhSach.Name = "btDanhSach";
            this.btDanhSach.Size = new System.Drawing.Size(123, 34);
            this.btDanhSach.TabIndex = 6;
            this.btDanhSach.Text = "Danh Sách";
            this.btDanhSach.UseVisualStyleBackColor = true;
            this.btDanhSach.Click += new System.EventHandler(this.btDanhSach_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBoQua.Image = global::GUI_QLBanHang.Properties.Resources.forward;
            this.btBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBoQua.Location = new System.Drawing.Point(586, 578);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(123, 34);
            this.btBoQua.TabIndex = 7;
            this.btBoQua.Text = "Bỏ Qua";
            this.btBoQua.UseVisualStyleBackColor = true;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSua.Image = global::GUI_QLBanHang.Properties.Resources.pencil;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(310, 578);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(123, 34);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btXoa.Image = global::GUI_QLBanHang.Properties.Resources.close;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(175, 578);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(123, 34);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThem.Image = global::GUI_QLBanHang.Properties.Resources.plus;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(37, 578);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(123, 34);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btLuu.Image = global::GUI_QLBanHang.Properties.Resources.floppy_disk;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(448, 578);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(123, 34);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 627);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btDanhSach);
            this.Controls.Add(this.btBoQua);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.dtgvSanPham);
            this.Controls.Add(this.btMoHinh);
            this.Controls.Add(this.lbDonGiaBan);
            this.Controls.Add(this.lbDonGiaNhap);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbHinh);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.lbMaHang);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtHinh);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Button btMoHinh;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbDonGiaNhap;
        private System.Windows.Forms.Label lbDonGiaBan;
        private System.Windows.Forms.Label lbHinh;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btDanhSach;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.PictureBox pbHinh;
    }
}