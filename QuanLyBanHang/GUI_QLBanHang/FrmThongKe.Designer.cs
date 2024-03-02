namespace GUI_QLBanHang
{
    partial class FrmThongKe
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
            this.tcThongKe = new System.Windows.Forms.TabControl();
            this.tabNhapKho = new System.Windows.Forms.TabPage();
            this.dtgvNhapKho = new System.Windows.Forms.DataGridView();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.dtgvTonKho = new System.Windows.Forms.DataGridView();
            this.tcThongKe.SuspendLayout();
            this.tabNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapKho)).BeginInit();
            this.tabTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tcThongKe
            // 
            this.tcThongKe.Controls.Add(this.tabNhapKho);
            this.tcThongKe.Controls.Add(this.tabTonKho);
            this.tcThongKe.Location = new System.Drawing.Point(12, 12);
            this.tcThongKe.Name = "tcThongKe";
            this.tcThongKe.SelectedIndex = 0;
            this.tcThongKe.Size = new System.Drawing.Size(565, 270);
            this.tcThongKe.TabIndex = 0;
            // 
            // tabNhapKho
            // 
            this.tabNhapKho.Controls.Add(this.dtgvNhapKho);
            this.tabNhapKho.Location = new System.Drawing.Point(4, 22);
            this.tabNhapKho.Name = "tabNhapKho";
            this.tabNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapKho.Size = new System.Drawing.Size(557, 244);
            this.tabNhapKho.TabIndex = 0;
            this.tabNhapKho.Text = "Sản Phẩm Tồn Kho";
            this.tabNhapKho.UseVisualStyleBackColor = true;
            // 
            // dtgvNhapKho
            // 
            this.dtgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhapKho.Location = new System.Drawing.Point(0, 0);
            this.dtgvNhapKho.Name = "dtgvNhapKho";
            this.dtgvNhapKho.Size = new System.Drawing.Size(557, 244);
            this.dtgvNhapKho.TabIndex = 0;
            // 
            // tabTonKho
            // 
            this.tabTonKho.Controls.Add(this.dtgvTonKho);
            this.tabTonKho.Location = new System.Drawing.Point(4, 22);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKho.Size = new System.Drawing.Size(557, 244);
            this.tabTonKho.TabIndex = 1;
            this.tabTonKho.Text = "Sản Phẩm Nhập Kho";
            this.tabTonKho.UseVisualStyleBackColor = true;
            // 
            // dtgvTonKho
            // 
            this.dtgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTonKho.Location = new System.Drawing.Point(0, 0);
            this.dtgvTonKho.Name = "dtgvTonKho";
            this.dtgvTonKho.Size = new System.Drawing.Size(557, 244);
            this.dtgvTonKho.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 294);
            this.Controls.Add(this.tcThongKe);
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tcThongKe.ResumeLayout(false);
            this.tabNhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapKho)).EndInit();
            this.tabTonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcThongKe;
        private System.Windows.Forms.TabPage tabNhapKho;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.DataGridView dtgvTonKho;
        private System.Windows.Forms.DataGridView dtgvNhapKho;
    }
}