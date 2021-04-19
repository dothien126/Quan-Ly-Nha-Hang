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
    public partial class frmCapNhatMonAn : Form
    {
        public frmCapNhatMonAn()
        {
            InitializeComponent();
        }

        private void btnThoatCapNhatDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatMonAn_Load(object sender, EventArgs e)
        {
            dgvCapNhatMonAn.DataSource = GetMonAn().Tables[0];
        }
        DataSet GetMonAn()
        {
            DataSet data = new DataSet();
            string query = "select*from MonAn";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            try
            {
                connection.Open();
                string MaTP = textMTP.Text;
                string TenTP = textTTP.Text;
                string DVT = textDVT.Text;
                string GB = textGB.Text;
                string MaNMA = textMNMA.Text;
                string TT = textTT.Text;
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            try
            {
                connection.Open();
                string MaTP = textMTP.Text;
                string TenTP = textTTP.Text;
                string DVT = textDVT.Text;
                string GB = textGB.Text;
                string MaNMA = textMNMA.Text;
                string TT = textTT.Text;
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuCapNhatMonAn_Click(object sender, EventArgs e)
        {
            dgvCapNhatMonAn.DataSource = GetMonAn().Tables[0];
        }
    }
}
