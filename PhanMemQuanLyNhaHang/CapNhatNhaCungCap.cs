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
    public partial class frmNhaCungCap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhaCungCap";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCapNhatNhaCungCap.DataSource = table;
        }

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        cla_crud connect = new cla_crud();
        private void dgvCapNhatNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maNCC.ReadOnly = true;
            int i;
            i = dgvCapNhatNhaCungCap.CurrentRow.Index;
            tb_maNCC.Text = dgvCapNhatNhaCungCap.Rows[i].Cells[0].Value.ToString();
            tb_tenNCC.Text = dgvCapNhatNhaCungCap.Rows[i].Cells[1].Value.ToString();
            tb_diaChi.Text = dgvCapNhatNhaCungCap.Rows[i].Cells[2].Value.ToString();
        }

        private void loaddata()
        {
            DataTable dt = connect.readdata("SELECT * FROM NhaCungCap");
            if (dt != null)
            {
                dgvCapNhatNhaCungCap.DataSource = dt;
            }
        }

        private void btnHuyCapNhatBanAn_Click(object sender, EventArgs e)
        {
            tb_tenNCC.Text = "";
            tb_maNCC.Text = "";
            tb_diaChi.Text = "";
        }

        private void btnLuuCapNhatBanAn_Click(object sender, EventArgs e)
        {
            if (connect.exedata("update NhaCungCap set TenNCC = N'" + tb_tenNCC.Text + "', DiaChi = N'" + tb_diaChi + "' where MaChiNhanh ='" + tb_maNCC.Text + "' "))
            {
                MessageBox.Show("Đã xóa dữ liệu thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại");
            }
        }
    }
}
