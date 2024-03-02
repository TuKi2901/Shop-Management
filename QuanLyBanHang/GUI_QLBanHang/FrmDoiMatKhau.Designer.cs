namespace GUI_QLBanHang
{
    partial class FrmDoiMatKhau
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
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDoiMatKhau = new System.Windows.Forms.Button();
            this.lbDoiMatKhau = new System.Windows.Forms.Label();
            this.lbMatKhauCu = new System.Windows.Forms.Label();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.picboxDoiMatKhau = new System.Windows.Forms.PictureBox();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lbNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDoiMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatKhauCu.Location = new System.Drawing.Point(39, 232);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhauCu.MaxLength = 32;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(345, 26);
            this.txtMatKhauCu.TabIndex = 0;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.txtMatKhauCu.TextChanged += new System.EventHandler(this.txtMatKhauCu_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(39, 164);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThoat.Location = new System.Drawing.Point(67, 485);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(290, 35);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btDoiMatKhau
            // 
            this.btDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiMatKhau.Location = new System.Drawing.Point(67, 440);
            this.btDoiMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.btDoiMatKhau.Name = "btDoiMatKhau";
            this.btDoiMatKhau.Size = new System.Drawing.Size(290, 35);
            this.btDoiMatKhau.TabIndex = 3;
            this.btDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btDoiMatKhau.UseVisualStyleBackColor = true;
            this.btDoiMatKhau.Click += new System.EventHandler(this.btDoiMatKhau_Click);
            // 
            // lbDoiMatKhau
            // 
            this.lbDoiMatKhau.AutoSize = true;
            this.lbDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiMatKhau.Location = new System.Drawing.Point(141, 83);
            this.lbDoiMatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDoiMatKhau.Name = "lbDoiMatKhau";
            this.lbDoiMatKhau.Size = new System.Drawing.Size(142, 25);
            this.lbDoiMatKhau.TabIndex = 7;
            this.lbDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.AutoSize = true;
            this.lbMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhauCu.Location = new System.Drawing.Point(35, 207);
            this.lbMatKhauCu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(105, 20);
            this.lbMatKhauCu.TabIndex = 8;
            this.lbMatKhauCu.Text = "Mật Khẩu Cũ:";
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.Location = new System.Drawing.Point(35, 139);
            this.lbNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(130, 20);
            this.lbNhanVien.TabIndex = 9;
            this.lbNhanVien.Text = "Email Nhân Viên:";
            // 
            // picboxDoiMatKhau
            // 
            this.picboxDoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxDoiMatKhau.ErrorImage = null;
            this.picboxDoiMatKhau.Image = global::GUI_QLBanHang.Properties.Resources.refresh;
            this.picboxDoiMatKhau.Location = new System.Drawing.Point(176, 14);
            this.picboxDoiMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.picboxDoiMatKhau.Name = "picboxDoiMatKhau";
            this.picboxDoiMatKhau.Size = new System.Drawing.Size(68, 64);
            this.picboxDoiMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDoiMatKhau.TabIndex = 13;
            this.picboxDoiMatKhau.TabStop = false;
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhauMoi.Location = new System.Drawing.Point(35, 277);
            this.lbMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(110, 20);
            this.lbMatKhauMoi.TabIndex = 8;
            this.lbMatKhauMoi.Text = "Mật Khẩu Mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatKhauMoi.Location = new System.Drawing.Point(39, 302);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhauMoi.MaxLength = 32;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(345, 26);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.TextChanged += new System.EventHandler(this.txtMatKhauMoi_TextChanged);
            // 
            // lbNhapLaiMatKhau
            // 
            this.lbNhapLaiMatKhau.AutoSize = true;
            this.lbNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapLaiMatKhau.Location = new System.Drawing.Point(35, 351);
            this.lbNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNhapLaiMatKhau.Name = "lbNhapLaiMatKhau";
            this.lbNhapLaiMatKhau.Size = new System.Drawing.Size(148, 20);
            this.lbNhapLaiMatKhau.TabIndex = 8;
            this.lbNhapLaiMatKhau.Text = "Nhập Lại Mật Khẩu:";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(39, 376);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtNhapLaiMatKhau.MaxLength = 32;
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(345, 26);
            this.txtNhapLaiMatKhau.TabIndex = 2;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 553);
            this.Controls.Add(this.picboxDoiMatKhau);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDoiMatKhau);
            this.Controls.Add(this.lbNhapLaiMatKhau);
            this.Controls.Add(this.lbDoiMatKhau);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.lbMatKhauCu);
            this.Controls.Add(this.lbNhanVien);
            this.Name = "FrmDoiMatKhau";
            this.Text = "FrmDoiMatKhau";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxDoiMatKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDoiMatKhau;
        private System.Windows.Forms.Label lbDoiMatKhau;
        private System.Windows.Forms.Label lbMatKhauCu;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lbNhapLaiMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
    }
}