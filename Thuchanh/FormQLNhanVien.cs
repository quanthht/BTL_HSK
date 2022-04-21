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
using System.Collections;

namespace Thuchanh
{
    public partial class FormQLNhanVien : Form
    {
        static DataTable dttable= new DataTable();
        static string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            Load_dgvNhanVien();
            Load_cbo();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select tblNhanvien.*,stenPB from tblNhanvien inner join tblPhongBan on tblnhanvien.smaPB = tblPhongBan.smaPB", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dttable = new DataTable();
                        adapter.Fill(dttable);

                        
                    }
                }
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
           
            
        }
        private void Load_dgvNhanVien()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tblNhanvien.*,stenPB from tblNhanvien inner join tblPhongBan on tblnhanvien.smaPB = tblPhongBan.smaPB";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dttable);
            dgvNhanvien.DataSource = dttable;
        }

        private void Load_cbo()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlCommand cmb = new SqlCommand("select * from tblPhongBan", conn);
                cmb.CommandType = CommandType.Text;
                conn.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmb);
                dttable = new DataTable("tblPhongBan");
                adapter1.Fill(dttable);
                cboChucvu.DataSource = dttable;
                cboChucvu.ValueMember = "smaPB";
                cboChucvu.DisplayMember = "stenPB";
               
            }
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            this.Hide();
            formHome.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtManv.Text;
            string hoten = txtHoTen.Text;
            string ngaysinh = txtngaysinh.Text.ToString();
            string ngayvaolam = DateTime.Now.Month.ToString()+"/"+ DateTime.Now.Day.ToString() + "/"+DateTime.Now.Year.ToString();
            string sdt = txtSDT.Text;
            string gioitinh;
            
            if (rbNam.Checked) gioitinh = "Nam";
            else gioitinh = "Nữ";
            string diachi = txtDiachi.Text;
            float luong = float.Parse(txtLCB.Text.ToString());
            float hsl = float.Parse(txtHSL.Text.ToString());
            string phong = cboChucvu.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "prInsertNhanvien";
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@ten", hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@hsl", hsl);
            cmd.Parameters.AddWithValue("@lcb", luong);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@mapb", phong);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                { MessageBox.Show("Thêm thành công!", " Thông báo ");
                    Load_dgvNhanVien(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại! "+ex, "Hỏng rồi!");
            }
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "prXoaNhanvien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", txtManv.Text);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa thất bại !");
            Load_dgvNhanVien();
            connection.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dttable = new DataTable();
            Load_dgvNhanVien();
            txtDiachi.Text = "";
            txtHoTen.Text = "";
            txtHSL.Text = "";
            txtLCB.Text = "";
            txtManv.Text = "";
            txtngaysinh.Text = "";
            txtSDT.Text = "";
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            FormBaocao formBaocao = new FormBaocao(dttable);
            this.Hide();
            formBaocao.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "prSuaNhanvien";
            cmd.CommandType = CommandType.StoredProcedure;
            string gt;
            if (rbNam.Checked == true) gt = "Nam";
            else gt = "Nữ";
            cmd.Parameters.AddWithValue("@ma",txtManv.Text);
            cmd.Parameters.AddWithValue("@ten",txtHoTen.Text);
            cmd.Parameters.AddWithValue("@ngaysinh",txtngaysinh.Text);
            cmd.Parameters.AddWithValue("@gioitinh",gt);
            cmd.Parameters.AddWithValue("@diachi",txtDiachi.Text);
            cmd.Parameters.AddWithValue("@sdt",txtSDT.Text);
            cmd.Parameters.AddWithValue("@hsl",txtHSL.Text);
            cmd.Parameters.AddWithValue("@lcb",txtLCB.Text);
            cmd.Parameters.AddWithValue("@mapb",cboChucvu.SelectedValue);
            if(cmd.ExecuteNonQuery()>0) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
            Load_dgvNhanVien();
            connection.Close();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["sDiachi"].Value.ToString();
            txtHoTen.Text = dgvNhanvien.CurrentRow.Cells["sTenNV"].Value.ToString();
            txtHSL.Text = dgvNhanvien.CurrentRow.Cells["fHSL"].Value.ToString();
            txtLCB.Text = dgvNhanvien.CurrentRow.Cells["fLCB"].Value.ToString();
            txtManv.Text = dgvNhanvien.CurrentRow.Cells["smanv"].Value.ToString();
            String[] a = dgvNhanvien.CurrentRow.Cells["dNgaysinh"].Value.ToString().Split('/');
            txtngaysinh.Text = a[1] + '/' + a[0] + '/' + a[2];
            if (dgvNhanvien.CurrentRow.Cells["sGioitinh"].Value.ToString().Equals("Nam"))
                rbNam.Checked = true;
            else rbNu.Checked = true;
                
             
            txtSDT.Text = dgvNhanvien.CurrentRow.Cells["sSDT"].Value.ToString();
            cboChucvu.Text = dgvNhanvien.CurrentRow.Cells["sTenPB"].Value.ToString();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "prNhanvienChucvu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", cboChucvu.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            dttable = new DataTable();
            sqlDataAdapter.Fill(dttable);
            dgvNhanvien.DataSource = dttable;
            dgvNhanvien.Refresh();
            connection.Close();
        }

    }
}
