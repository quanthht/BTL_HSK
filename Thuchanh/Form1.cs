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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_1();

        }
        private void Load_1()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtDiachi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            txtTen.Enabled = false;
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblKhachHang", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvKhachHang.DataSource = dt;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string diachi = txtDiachi.Text;
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("prInsertKH", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenkh", ten);
                    cmd.Parameters.AddWithValue("@sdtkh", sdt);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        Load_1();
                    }
                    else MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {

            string sdtcu = dgvKhachHang.CurrentRow.Cells["sSDTKH"].Value.ToString();
            string ten = txtTen.Text;
            string sdtmoi = txtSDT.Text;
            string email = txtEmail.Text;
            string diachi = txtDiachi.Text;
            string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("prSuaKH", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sdtcu", sdtcu);
                    cmd.Parameters.AddWithValue("@sdtmoi", sdtmoi);
                    cmd.Parameters.AddWithValue("@ten", ten);

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@diachi", diachi);




                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                        Load_1();
                    }
                    else MessageBox.Show("Sửa thất bại!", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sdt = dgvKhachHang.CurrentRow.Cells["sSDTKH"].Value.ToString();
            if (MessageBox.Show("Chắc chưa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

                string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("prXoaKH", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@sdtkh", sdt);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        Load_1();
                    }
                    else MessageBox.Show("Xóa thất bại!", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chưa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e )
        {
            txtTen.Text= dgvKhachHang.CurrentRow.Cells["sTenKH"].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells["sSDTKH"].Value.ToString();
            
            txtEmail.Text = dgvKhachHang.CurrentRow.Cells["sEmail"].Value.ToString();
            txtDiachi.Text = dgvKhachHang.CurrentRow.Cells["sDiachi"].Value.ToString();
            txtDiachi.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtTen.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
