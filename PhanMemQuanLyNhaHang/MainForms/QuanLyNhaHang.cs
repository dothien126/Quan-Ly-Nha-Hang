using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PhanMemQuanLyKhachSan.Model;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmQuanLyNhaHang : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmQuanLyNhaHang()
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // lblTitleChildForm.Text = childForm.Text;
        }
        private void btnTroVeCuaCTPP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatThucPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmthucphamnhahang());
        }

        private void btnCapNhatMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCapNhatMonAn());
        }

        private void btnCapNhatBanAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCapNhatBanAn());
        }

        private void btQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCungCap());
        }
    }
}
