using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmChiTietPhieuDatBan : Form
    {
        public frmManHinhChinh objManHinhChinh;
        public frmChiTietPhieuDatBan()
        {
            InitializeComponent();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuuPhieuDat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Đặt Phiếu Thành Công");
            this.Close();
        }
    }
}
