using BUS_QLBanHang;
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
    public partial class FrmThongKe : Form
    { BUS_SanPham busSanpham = new BUS_SanPham();
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadDataGridViewThongKe();
        }

        private void LoadDataGridViewThongKe()
        {
            dtgvNhapKho.AutoResizeColumns();
            dtgvNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvNhapKho.DataSource = busSanpham.ThongKeSanPham();
            dtgvNhapKho.Columns[0].HeaderText = "Mã nhân viên";
            dtgvNhapKho.Columns[1].HeaderText = "Tên nhân viên";
            dtgvNhapKho.Columns[2].HeaderText = "Số lượng sản phẩm";
            dtgvNhapKho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvNhapKho.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dtgvTonKho.AutoResizeColumns();
            dtgvTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvTonKho.DataSource = busSanpham.ThongKeTonKho();
            dtgvTonKho.Columns[0].HeaderText = "Tên Hàng";
            dtgvTonKho.Columns[1].HeaderText = "Tổng Số Lượng";
            dtgvTonKho.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        
    }
}
