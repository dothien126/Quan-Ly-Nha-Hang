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
using System.Data.SqlClient;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();          
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);

            try
            {
                connection.Open();

                string taiKhoan = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                string sql = "select * from DANGNHAP where Taikhoan = '" + taiKhoan + "' and Matkhau = '" + matKhau + "'";

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    frmManHinhChinh manHinhChinh = new frmManHinhChinh();
                    manHinhChinh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }

       
    }
    
}
