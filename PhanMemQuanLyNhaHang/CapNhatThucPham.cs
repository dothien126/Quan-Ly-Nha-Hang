
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmthucphamnhahang : Form
    {
        public frmthucphamnhahang()
        {
            InitializeComponent();
        }

        private void btnThoatCapNhatVatTu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataSet GetThucPham()
        {
            DataSet data = new DataSet();
            string query = "select*from ThucPham";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void frmthucphamnhahang_Load(object sender, EventArgs e)
        {
            dgvCapNhatThucPham.DataSource = GetThucPham().Tables[0];
        }

        private void btnThemThucPham_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            try
            {
                connection.Open();
                string MaTP = textMTP.Text;
                string TenTP = textTTP.Text;
                string DVT = textDVT.Text;
                string GB = textGB.Text;
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaThucPham_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            try
            {
                connection.Open();
                string MaTP = textMTP.Text;
                string TenTP = textTTP.Text;
                string DVT = textDVT.Text;
                string GB = textGB.Text;
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuCapNhatThucPham_Click(object sender, EventArgs e)
        {
            dgvCapNhatThucPham.DataSource = GetThucPham().Tables[0];
        }
    }
}
