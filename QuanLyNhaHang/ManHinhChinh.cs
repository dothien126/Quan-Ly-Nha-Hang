using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmManHinhChinh : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmManHinhChinh()
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
        private void QuanLyNhaHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyNhaHang());

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyNhanVien());
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyKhachHang());
        }

        private void cmbBan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan1.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan1.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan1.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan2.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan2.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan2.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan2.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan3.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan3.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan3.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan3.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan4.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan4.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan4.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan4.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan5.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan5.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan5.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan5.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan6.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan6.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan6.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan6.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan7.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan7.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan7.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan7.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan8.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan8.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan8.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan8.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan9.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan9.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan9.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan9.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan10.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan10.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan10.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan10.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan11.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan11.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan11.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan11.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbBan12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbBan12.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Bàn Đang Sử Dụng":
                    lblBan12.BackColor = Color.Green;
                    break;
                case "Bàn Trống":
                    lblBan12.BackColor = Color.IndianRed;
                    break;
                case "Bàn Đang Dọn":
                    lblBan12.BackColor = Color.Gray;
                    break;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLienHe());
        }

        private void ChiTiet_CLick(object sender, EventArgs e)
        {
            frmChiTietPhieuDatBan chiTietPhieuDatBan = new frmChiTietPhieuDatBan();
            chiTietPhieuDatBan.ShowDialog();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
           
        }

       
    }
}
