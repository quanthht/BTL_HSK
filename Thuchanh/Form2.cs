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
using System.Configuration;

namespace Thuchanh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtTen.Enabled = false;
            txtNgaysinh.Enabled = false;
            txtLuong.Enabled = false;
            txtDiachi.Enabled = false;
            txtMa.Enabled = false;
            rbtnnu.Enabled = false;
            rbtnnam.Enabled = false;
            Load_2();
            Load_cbo();
        }
        private void Load_2()
        {   
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select NHANVIEN.*,stenP from NHANVIEN , PHONG where NHANVIEN.smaP = PHONG.smaP";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }
        private void Load_cbo()
        {
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  PHONG";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("PHONG");
            adapter.Fill(dt);
            cboPhong.DataSource = dt;
            cboPhong.DisplayMember = "sTenP";
            cboPhong.ValueMember = "sMaP";
            

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string hoten = txtTen.Text;
            string date = txtNgaysinh.Text.ToString();
            string gioitinh;
            if (rbtnnam.Checked) gioitinh = "Nam";
            else gioitinh = "Nữ";
            string diachi =txtDiachi.Text;
            float luong = float.Parse(txtLuong.Text.ToString());
            string phong = cboPhong.SelectedValue.ToString();
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "prInsertNHANVIEN";
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@ten",hoten);
            cmd.Parameters.AddWithValue("@ngaysinh",date);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@diachi",diachi);
            cmd.Parameters.AddWithValue("@luong",luong);
            cmd.Parameters.AddWithValue("@maphong",phong);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                { MessageBox.Show("Thêm thành công!", "< Thông báo >"); Load_2(); }
            }catch(Exception ex)
            {
                MessageBox.Show("Trùng mã nhân viên ","Hỏng rồi!");
            }
            
        
            conn.Close();
            


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string macu = dgv.CurrentRow.Cells["sMaNV"].Value.ToString();
            string mamoi = txtMa.Text;
            string hoten = txtTen.Text;
            string date = txtNgaysinh.Text.ToString();
            string gioitinh;
            if (rbtnnam.Checked) gioitinh = "Nam";
            else gioitinh = "Nữ";
            string diachi = txtDiachi.Text;
            float luong = float.Parse(txtLuong.Text.ToString());
            string phong = cboPhong.SelectedValue.ToString();
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "prSuaNV";
            cmd.Parameters.AddWithValue("@manvcu", macu);
            cmd.Parameters.AddWithValue("@manvmoi", mamoi);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", date);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@luong", luong);
            cmd.Parameters.AddWithValue("@maphong", phong);
            try
            {
            if (cmd.ExecuteNonQuery() > 0)
            { MessageBox.Show("Sửa thành công!", "< Thông báo >"); Load_2(); }
            }catch (Exception ex)
            {
                MessageBox.Show("Hỏng rồi!");
            }  
            conn.Close();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn kết thúc chứ ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gioitinh;
            try
            {
                txtMa.Text = dgv.CurrentRow.Cells["sMaNV"].Value.ToString();
                txtTen.Text = dgv.CurrentRow.Cells["sHoTen"].Value.ToString();
                txtNgaysinh.Text = dgv.CurrentRow.Cells["dNgaysinh"].Value.ToString();
                gioitinh = dgv.CurrentRow.Cells["sGioitinh"].Value.ToString();
                if (gioitinh == "Nam" || gioitinh == "nam") rbtnnam.Checked = true;
                else rbtnnu.Checked = true;
                txtDiachi.Text = dgv.CurrentRow.Cells["sDiachi"].Value.ToString();
                txtLuong.Text = dgv.CurrentRow.Cells["fLuong"].Value.ToString();
                cboPhong.SelectedValue = dgv.CurrentRow.Cells["sMaP"].Value.ToString();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                txtTen.Enabled = true;
                txtNgaysinh.Enabled = true;
                txtLuong.Enabled = true;
                txtDiachi.Enabled = true;
                txtMa.Enabled = true;
                rbtnnam.Enabled = true;
                rbtnnu.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thử lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;
            string ma = dgv.CurrentRow.Cells["sMaNV"].Value.ToString();
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "prXoaNV";
            cmd.Parameters.AddWithValue("@manv", ma);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                { MessageBox.Show("Xóa thành công!", "< Thông báo >"); Load_2(); }
            }catch (Exception ex)
            {
                MessageBox.Show("Hỏng rồi!");
            }
            conn.Close();
            
            
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string ten = cboPhong.Text.Trim();
            
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select NHANVIEN.*,sTenP from NHANVIEN, PHONG where NHANVIEN.sMaP = PHONG.sMaP and stenP = N'"+ten+"'";
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
            
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand sqlCommand = con.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select * from vvPhong_NhanVien";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgv.DataSource= dt;




        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();

            formHome.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=Demo;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "prThongKe";
                cmd.Parameters.AddWithValue("@tenphong",cboPhong.Text.Trim());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    dgv.DataSource = dt;
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : "+ex.Message, " Thông báo");
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Form2 form2  = new Form2();
            Form2_Load(sender,e);
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
