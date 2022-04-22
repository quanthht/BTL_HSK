using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh
{
    public partial class HDN : Form
    {
        SqlConnection con;
        SqlCommand command;
        //string str = "Data Source=DESKTOP-7I86OTK\\SQLEXPRESS;Initial Catalog=BTL;Integrated Security=True";
        static string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";

        public HDN()
        {
            InitializeComponent();
        }
        private DataTable getHD()
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("select*from  cbnv", conn);


            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable tblTBBH = new DataTable("tblHoaDonBanHang");
                da.Fill(tblTBBH);
                return tblTBBH;
            }
        }
        public void showDSHD()
        {
            using (DataTable tblHD = getHD())
            {
                DataView dv = new DataView(tblHD);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dv;
            }

        }
        void loadCBNV()
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            var cmd = new SqlCommand("select * from tblNhanVien", conn);
            conn.Open();
            var er = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(er);

            //Combobox
            cbNV.DisplayMember = "sTenNV";
            cbNV.ValueMember = "sMaNV";
            cbNV.DataSource = dt;
            conn.Close();
        }
        private void HDN_Load(object sender, EventArgs e)
        {
            loadCBNV();
            showDSHD();
        }
     
  
        private void btnBoqua_Click_1(object sender, EventArgs e)
        {
            txtMaHD.Text = txtNgaynhap.Text = txtTenNCC.Text =
               cbNV.Text = string.Empty;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

        }

        private void txtMaHD_TextChanged_1(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTimKiem.Enabled =
               txtMaHD.Text.Trim().Length > 0;
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgv[0, e.RowIndex].Value.ToString();
            txtNgaynhap.Text = dgv[2, e.RowIndex].Value.ToString();
            txtTenNCC.Text = dgv[3, e.RowIndex].Value.ToString();
            cbNV.Text = dgv[1, e.RowIndex].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        /* private void btnBaocao_Click(object sender, EventArgs e)
{
string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
SqlConnection conn = new SqlConnection(con);
SqlCommand cmd = new SqlCommand("rpHd", conn);
cmd.CommandType = CommandType.StoredProcedure;

cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text);
conn.Open();

using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
{
DataTable dt = new DataTable();
sda.Fill(dt);
HDN rpt = new HDN();

rpt.SetDataSource(dt);
rpt.SetParameterValue("MaHD", txtMaHD.Text);



BAOCAO f = new BAOCAO();
f.crv.ReportSource = rpt;

f.Show();
}*/
    }
}

