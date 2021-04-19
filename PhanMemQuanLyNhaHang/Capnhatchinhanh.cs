using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmCapNhatChiNhanh : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CHINHANH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCapNhatChiNhanh.DataSource = table;
        }

        cla_crud connect = new cla_crud();
        public frmCapNhatChiNhanh()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaCapNhatLichLamViec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatChiNhanh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvCapNhatChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvCapNhatChiNhanh.CurrentRow.Index;
            tb_maChiNhanh.Text = dgvCapNhatChiNhanh.Rows[i].Cells[0].Value.ToString();
            tb_tenChiNhanh.Text = dgvCapNhatChiNhanh.Rows[i].Cells[1].Value.ToString();
            tb_diaChi.Text = dgvCapNhatChiNhanh.Rows[i].Cells[2].Value.ToString();
            loaddata();
        }

        private void btnThemChiNhanh_Click(object sender, EventArgs e)
        {     
            if (connect.exedata("insert into Chinhanh values ('" + tb_maChiNhanh.Text + "', N'" + tb_tenChiNhanh.Text + "', N'" + tb_diaChi + "')") == true)
            {
                MessageBox.Show("Đã thêm dữ liệu");
                loaddata();
            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu");
            }
            
        }
        private void loaddata()
        {
            DataTable dt = connect.readdata("SELECT * FROM Chinhanh");
            if (dt != null)
            {
                dgvCapNhatChiNhanh.DataSource = dt;
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            tb_maChiNhanh.Text = "";
            tb_tenChiNhanh.Text = "";
            tb_diaChi.Text = "";
        }

        private void btnXoaChiNhanh_Click(object sender, EventArgs e)
        {
            /*command = connection.CreateCommand();
            command.CommandText = "delete from ChiNhanh where MaChiNhanh = '" + tb_maChiNhanh.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
            loadData();
            */
            if (connect.exedata("delete from ChiNhanh where MaChiNhanh = '" +tb_maChiNhanh.Text+"' ") == true)
            {
                MessageBox.Show("Đã xóa dữ liệu thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại");
            }

        }

        private void btnSuaChiNhanh_Click(object sender, EventArgs e)
        {
            if (connect.exedata("update ChiNhanh set TenChiNhanh = N'" + tb_tenChiNhanh.Text + "', DiaChi = N'" + tb_diaChi + "' where MaChiNhanh ='" + tb_maChiNhanh.Text + "' ") == true)
            {
                MessageBox.Show("Đã sửa dữ liệu thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại");
            }
        }
    }
}
