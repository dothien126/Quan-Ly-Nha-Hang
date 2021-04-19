
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public class CSDL
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True";
        private SqlConnection conn;

        //private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        public CSDL()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                //conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected Failed: " + ex.Message);
            }

        }
        public DataTable SelectData(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)

            {
                MessageBox.Show("Data Loading ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean deleteLH(String id)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From LOPHOC where MaLH = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch (Exception)
            {
                check = false;
                throw;
            }


            return check;
        }
    }
}
