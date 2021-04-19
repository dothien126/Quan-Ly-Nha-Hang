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
    public partial class frmQuanLyKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KHACHHANG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvQuanLyKhachHang.DataSource = table;
        }

        cla_crud connect = new cla_crud();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaQLKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void loaddata()
        {
            DataTable dt = connect.readdata("SELECT * FROM KhachHang");
            if (dt != null)
            {
                dgvQuanLyKhachHang.DataSource = dt;
            }
        }

        private void dgvQuanLyKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvQuanLyKhachHang.CurrentRow.Index;
            tb_maKH.Text = dgvQuanLyKhachHang.Rows[i].Cells[0].Value.ToString();
            tb_tenKH.Text = dgvQuanLyKhachHang.Rows[i].Cells[1].Value.ToString();
            tb_diaChiKH.Text = dgvQuanLyKhachHang.Rows[i].Cells[3].Value.ToString();
            tb_SdtKH.Text = dgvQuanLyKhachHang.Rows[i].Cells[2].Value.ToString();
            loaddata();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tb_maKH.Text = "";
            tb_tenKH.Text = "";
            tb_diaChiKH.Text = "";
            tb_SdtKH.Text = "";
        }
    }
}