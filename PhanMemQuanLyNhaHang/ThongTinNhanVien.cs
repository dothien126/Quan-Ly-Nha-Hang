using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmCapNhatThongTinNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        cla_crud connect = new cla_crud();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhanvien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvThongTinNhanVien.DataSource = table;
        }
        public frmCapNhatThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            DataTable dt = connect.readdata("SELECT * FROM NhanVien");
            if (dt != null)
            {
                dtgvThongTinNhanVien.DataSource = dt;
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (connect.exedata("insert into NhanVien values('" + tb_maNV.Text + "', N'" + tb_tenNV.Text + "', '"+tb_luongNV.Text+"', '"+tb_ngaySinhNV.Text+"', '"+tb_gioiTinh.Text+"', N'" + tb_diaChi.Text + "', N'"+tb_maChiNhanh.Text+"', '"+tb_maBoPhan.Text+"')") == true)
            {
                MessageBox.Show("Đã thêm dữ liệu thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }

        private void frmCapNhatThongTinNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dtgvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maNV.ReadOnly = true;
            int i;
            i = dtgvThongTinNhanVien.CurrentRow.Index;
            tb_maNV.Text = dtgvThongTinNhanVien.Rows[i].Cells[0].Value.ToString();
            tb_tenNV.Text = dtgvThongTinNhanVien.Rows[i].Cells[1].Value.ToString();
            tb_luongNV.Text = dtgvThongTinNhanVien.Rows[i].Cells[2].Value.ToString();
            tb_ngaySinhNV.Text = dtgvThongTinNhanVien.Rows[i].Cells[3].Value.ToString();
            tb_gioiTinh.Text = dtgvThongTinNhanVien.Rows[i].Cells[4].Value.ToString();
            tb_diaChi.Text = dtgvThongTinNhanVien.Rows[i].Cells[5].Value.ToString();
            tb_maChiNhanh.Text = dtgvThongTinNhanVien.Rows[i].Cells[6].Value.ToString();
            tb_maBoPhan.Text = dtgvThongTinNhanVien.Rows[i].Cells[7].Value.ToString();
            loaddata();
        }

        

        private void btnTimKiemTTNV_Click(object sender, EventArgs e)
        {
            if (connect.exedata("update NhaCungCap set TenNCC = N'" + tb_tenNV.Text + "', DiaChi = N'" + tb_diaChi + "' where MaChiNhanh ='" + tb_maNV.Text + "' ") == true)
            {
                MessageBox.Show("Đã xóa dữ liệu thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại");
            }
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            tb_maNV.Text = "";
            tb_tenNV.Text = "";
            tb_luongNV.Text = "";
            tb_ngaySinhNV.Text = "";
            tb_diaChi.Text = "";
            tb_maChiNhanh.Text = "";
            tb_maBoPhan.Text = "";
        }
    }
}