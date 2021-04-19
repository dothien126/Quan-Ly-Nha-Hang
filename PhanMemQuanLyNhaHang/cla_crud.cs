using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQuanLyKhachSan
{
    class cla_crud
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True");


        private void openconnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void closeconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public Boolean exedata(string cmd)
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }


        public DataTable readdata(string cmd)
        {
            openconnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            closeconnect();
            return da;
        }
    }
    

}
