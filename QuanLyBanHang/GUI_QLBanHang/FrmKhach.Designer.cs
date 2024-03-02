namespace GUI_QLBanHang
{
    partial class FrmKhach
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btDong = new System.Windows.Forms.Button();
            this.btDanhSach = new System.Windows.Forms.Button();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(530, 98);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(327, 26);
            this.txtDiaChi.TabIndex = 27;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoVaTen.Location = new System.Drawing.Point(156, 151);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(246, 26);
            this.txtHoVaTen.TabIndex = 26;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDienThoai.Location = new System.Drawing.Point(156, 98);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(246, 26);
            this.txtDienThoai.TabIndex = 25;
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Location = new System.Drawing.Point(40, 208);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.ReadOnly = true;
            this.dtgvKhachHang.Size = new System.Drawing.Size(817, 150);
            this.dtgvKhachHang.TabIndex = 15;
            this.dtgvKhachHang.Click += new System.EventHandler(this.dtgvKhachHang_Click);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdNu.Location = new System.Drawing.Point(677, 154);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 24);
            this.rdNu.TabIndex = 12;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdNam.Location = new System.Drawing.Point(584, 153);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(60, 24);
            this.rdNam.TabIndex = 11;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDiaChi.Location = new System.Drawing.Point(464, 101);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lbDiaChi.TabIndex = 9;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGioiTinh.Location = new System.Drawing.Point(464, 154);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lbGioiTinh.TabIndex = 7;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHoVaTen.Location = new System.Drawing.Point(36, 154);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(85, 20);
            this.lbHoVaTen.TabIndex = 6;
            this.lbHoVaTen.Text = "Họ Và Tên";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDienThoai.Location = new System.Drawing.Point(36, 101);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(85, 20);
            this.lbDienThoai.TabIndex = 10;
            this.lbDienThoai.Text = "Điện Thoại";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.lbKhachHang.Location = new System.Drawing.Point(358, 10);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(170, 32);
            this.lbKhachHang.TabIndex = 5;
            this.lbKhachHang.Text = "Khách Hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiem.Location = new System.Drawing.Point(387, 388);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(213, 26);
            this.txtTimKiem.TabIndex = 36;
            this.txtTimKiem.Text = "Nhập tên khách hàng";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseDown);
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDong.Image = global::GUI_QLBanHang.Properties.Resources.closed;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(734, 446);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 34);
            this.btDong.TabIndex = 28;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btDanhSach
            // 
            this.btDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDanhSach.Image = global::GUI_QLBanHang.Properties.Resources.clipboard;
            this.btDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDanhSach.Location = new System.Drawing.Point(239, 388);
            this.btDanhSach.Name = "btDanhSach";
            this.btDanhSach.Size = new System.Drawing.Size(123, 34);
            this.btDanhSach.TabIndex = 29;
            this.btDanhSach.Text = "Danh Sách";
            this.btDanhSach.UseVisualStyleBackColor = true;
            this.btDanhSach.Click += new System.EventHandler(this.btDanhSach_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBoQua.Image = global::GUI_QLBanHang.Properties.Resources.forward;
            this.btBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBoQua.Location = new System.Drawing.Point(593, 446);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(123, 34);
            this.btBoQua.TabIndex = 30;
            this.btBoQua.Text = "Bỏ Qua";
            this.btBoQua.UseVisualStyleBackColor = true;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSua.Image = global::GUI_QLBanHang.Properties.Resources.pencil;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(317, 446);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(123, 34);
            this.btSua.TabIndex = 32;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btXoa.Image = global::GUI_QLBanHang.Properties.Resources.close;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(182, 446);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(123, 34);
            this.btXoa.TabIndex = 33;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThem.Image = global::GUI_QLBanHang.Properties.Resources.plus;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(40, 446);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(123, 34);
            this.btThem.TabIndex = 34;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btLuu.Image = global::GUI_QLBanHang.Properties.Resources.floppy_disk;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(455, 446);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(123, 34);
            this.btLuu.TabIndex = 35;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btTimKiem.Image = global::GUI_QLBanHang.Properties.Resources.search;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(612, 384);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(123, 34);
            this.btTimKiem.TabIndex = 37;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // FrmKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 496);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btDanhSach);
            this.Controls.Add(this.btBoQua);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.dtgvKhachHang);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbHoVaTen);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.lbKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhach";
            this.Load += new System.EventHandler(this.FrmKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btDanhSach;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btTimKiem;
    }
}