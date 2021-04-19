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
    public partial class frmCapNhatBoPhanNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BoPhanNhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCapNhatBoPhanNV.DataSource = table;
        }

        public frmCapNhatBoPhanNhanVien()
        {
            InitializeComponent();
        }

        private void btnTroVeBPNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatBoPhanNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();

        }

        private void dgvCapNhatBoPhanNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maBoPhan.ReadOnly = true;
            int i;
            i = dgvCapNhatBoPhanNV.CurrentRow.Index;
            tb_maBoPhan.Text = dgvCapNhatBoPhanNV.Rows[i].Cells[0].Value.ToString();
            tb_tenBoPhan.Text = dgvCapNhatBoPhanNV.Rows[i].Cells[1].Value.ToString();
        }
    }
}
