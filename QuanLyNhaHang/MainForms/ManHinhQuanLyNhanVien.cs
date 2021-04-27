using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmQuanLyNhanVien : Form
    {

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlQLNV.Controls.Add(childForm);
            pnlQLNV.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // lblTitleChildForm.Text = childForm.Text;
        }


        private void btnTroVeCuaQLNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatThongTinNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCapNhatThongTinNhanVien());
        }

        private void btnCapNhatChiNhanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCapNhatChiNhanh());
        }

        private void btCapNhatBoPhanNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCapNhatBoPhanNhanVien());
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
