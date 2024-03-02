namespace GUI_QLBanHang
{
    partial class FrmDangNhap
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.cbNhoTaiKhoan = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.picboxDangNhap = new System.Windows.Forms.PictureBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbQuenMatKhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(27, 139);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(137, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email Đăng Nhập:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(27, 207);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(81, 20);
            this.lbMatKhau.TabIndex = 0;
            this.lbMatKhau.Text = "Mật Khẩu:";
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(101, 83);
            this.lbDangNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(220, 25);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "Đăng Nhập Hệ Thống";
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(67, 352);
            this.btDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(290, 35);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // cbNhoTaiKhoan
            // 
            this.cbNhoTaiKhoan.AutoSize = true;
            this.cbNhoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhoTaiKhoan.Location = new System.Drawing.Point(31, 289);
            this.cbNhoTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.cbNhoTaiKhoan.Name = "cbNhoTaiKhoan";
            this.cbNhoTaiKhoan.Size = new System.Drawing.Size(161, 24);
            this.cbNhoTaiKhoan.TabIndex = 2;
            this.cbNhoTaiKhoan.Text = "Ghi Nhớ Tài Khoản";
            this.cbNhoTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 164);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 26);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(31, 232);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(345, 26);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // picboxDangNhap
            // 
            this.picboxDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxDangNhap.ErrorImage = null;
            this.picboxDangNhap.Image = global::GUI_QLBanHang.Properties.Resources.login;
            this.picboxDangNhap.Location = new System.Drawing.Point(178, 14);
            this.picboxDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.picboxDangNhap.Name = "picboxDangNhap";
            this.picboxDangNhap.Size = new System.Drawing.Size(68, 64);
            this.picboxDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDangNhap.TabIndex = 4;
            this.picboxDangNhap.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(67, 397);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(290, 35);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbQuenMatKhau
            // 
            this.lbQuenMatKhau.AutoSize = true;
            this.lbQuenMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.lbQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenMatKhau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbQuenMatKhau.Location = new System.Drawing.Point(256, 290);
            this.lbQuenMatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbQuenMatKhau.Name = "lbQuenMatKhau";
            this.lbQuenMatKhau.Size = new System.Drawing.Size(120, 20);
            this.lbQuenMatKhau.TabIndex = 3;
            this.lbQuenMatKhau.Text = "Quên Mật Khẩu";
            this.lbQuenMatKhau.Click += new System.EventHandler(this.lbQuenMatKhau_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 453);
            this.Controls.Add(this.picboxDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbNhoTaiKhoan);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.lbQuenMatKhau);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.CheckBox cbNhoTaiKhoan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.PictureBox picboxDangNhap;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbQuenMatKhau;
    }
}

