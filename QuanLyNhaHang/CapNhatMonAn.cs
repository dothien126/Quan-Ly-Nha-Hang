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

namespace QuanLyNhaHang
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
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_MONAN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAMA", SqlDbType.VarChar, (10)).Value = textMTP.Text;
                aa.SelectCommand.Parameters.Add("@TENMA", SqlDbType.NVarChar, (50)).Value = textTTP.Text;
                aa.SelectCommand.Parameters.Add("@DVT", SqlDbType.NVarChar, (10)).Value = textDVT.Text;
                aa.SelectCommand.Parameters.Add("@GIABAN", SqlDbType.Int).Value = textGB.Text;
                aa.SelectCommand.Parameters.Add("@MANHOMMA", SqlDbType.VarChar, (10)).Value = textMNMA.Text;
                aa.SelectCommand.Parameters.Add("@TRANGTHAIMONAN", SqlDbType.NVarChar, (50)).Value = textTT.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_MONAN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAMA", SqlDbType.VarChar, (10)).Value = textMTP.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
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
