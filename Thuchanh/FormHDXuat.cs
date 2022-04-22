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
    public partial class FormHDXuat : Form
    {
        static string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
        public FormHDXuat()
        {
            InitializeComponent();
        }

        private void FormHDXuat_Load(object sender, EventArgs e)
        {
            LoadHDX();
            LoadCTXuat();
            LoadMaHD();
            LoadTenSP();
            LoadMaNV();
            LoadHTTT();
        }
        private void dgvHDXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHDXuat.CurrentRow.Cells["sMaHDX"].Value.ToString();
            cbbMaNV.Text = dgvHDXuat.CurrentRow.Cells["sMaNV"].Value.ToString();
            txtSDT.Text = dgvHDXuat.CurrentRow.Cells["sSDTKH"].Value.ToString();
            txtTenKH.Text = dgvHDXuat.CurrentRow.Cells["sTenKH"].Value.ToString();
            txtEmail.Text = dgvHDXuat.CurrentRow.Cells["sEmail"].Value.ToString();
            txtDiaChi.Text = dgvHDXuat.CurrentRow.Cells["sDiachi"].Value.ToString();
            cbbThanhToan.Text = dgvHDXuat.CurrentRow.Cells["sHinhthucTT"].Value.ToString();
        }

        private void dgvCTXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaHD.Text = dgvCTXuat.CurrentRow.Cells["sMaHDX"].Value.ToString();
            cbbMaSP.Text = dgvCTXuat.CurrentRow.Cells["sTenSP"].Value.ToString();
            txtSoLuong.Text = dgvCTXuat.CurrentRow.Cells["iSoLuong"].Value.ToString();
            txtDG.Text = dgvCTXuat.CurrentRow.Cells["fDongiaxuat"].Value.ToString();
        }
    
        public void LoadHDX()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from vvHDXuat", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvHDXuat.DataSource = dt;
                    }
                }
            }
        }
        public void LoadCTXuat()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from vvCTHD", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCTXuat.DataSource = dt;
                    }
                }
            }
        }

        private void LoadMaHD()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from tblHDXuat";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbMaHD.DataSource = dt;
            cbbMaHD.DisplayMember = "sMaHDX";
            cbbMaHD.ValueMember = "sMaHDX";
        }
        private void LoadTenSP()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from tblSanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbMaSP.DataSource = dt;
            cbbMaSP.DisplayMember = "sTenSP";
            cbbMaSP.ValueMember = "sMaSP";
        }
        private void LoadMaNV()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from tblNhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbMaNV.DataSource = dt;
            cbbMaNV.DisplayMember = "sMaNV";
            cbbMaNV.ValueMember = "sMaNV";
        }
        private void LoadHTTT()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select sHinhThucTT from tblHDXuat group by sHinhThucTT";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbThanhToan.DataSource = dt;
            cbbThanhToan.DisplayMember = "sHinhThucTT";
            cbbThanhToan.ValueMember = "sHinhThucTT";
        }

        

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblKhachHang where sSDTKH= " + txtSDT.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "prInsertKH";
                cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@sdtkh", txtSDT.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "prInsertHDX";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahdx", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@manv", cbbMaNV.Text);
                    cmd.Parameters.AddWithValue("@sdtkh", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@httt", cbbThanhToan.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadHDX();
                        return;
                    }
                    //}
                    else
                        MessageBox.Show("thêm không thành công");
                    return;
                }
            }
            reader.Close();
            MessageBox.Show("Khách hàng đã từng mua hàng nên sẽ lấy thông tin cũ !", "Thông báo");
            txtSDT.Text = dgvHDXuat.CurrentRow.Cells["sSDTKH"].Value.ToString();
            txtTenKH.Text = dgvHDXuat.CurrentRow.Cells["sTenKH"].Value.ToString();
            txtEmail.Text = dgvHDXuat.CurrentRow.Cells["sEmail"].Value.ToString();
            txtDiaChi.Text = dgvHDXuat.CurrentRow.Cells["sDiachi"].Value.ToString();
            txtTenKH.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;

            cmd = conn.CreateCommand();
            cmd.Parameters.Clear();
            cmd.CommandText = "prInsertHDX";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahdx", txtMaHD.Text);
            cmd.Parameters.AddWithValue("@manv", cbbMaNV.Text);
            cmd.Parameters.AddWithValue("@sdtkh", txtSDT.Text);
            cmd.Parameters.AddWithValue("@httt", cbbThanhToan.Text);
            try {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadHDX();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công vì "+ex.Message);
            };
            txtTenKH.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "prXoaHDX";
            cmd.Parameters.AddWithValue("@mahdx", txtMaHD.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LoadHDX();
                }
            }
            else
                MessageBox.Show("Xoá không thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from tblSanPham where sMaSP = '" + cbbMaSP.SelectedValue + "'";
            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();
            float dongianhap, dongiaxuat;
            dongianhap = float.Parse(reader["fDonGiaNhap"].ToString());
            dongiaxuat = float.Parse(reader["fDonGiaXuat"].ToString());
            if (dongianhap < float.Parse(txtDG.Text) && float.Parse(txtDG.Text) < dongiaxuat)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "prInsertCTX";
                cmd.Parameters.AddWithValue("@mahdx", cbbMaHD.Text);
                cmd.Parameters.AddWithValue("@masp", cbbMaSP.SelectedValue);
                cmd.Parameters.AddWithValue("@soluong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@dongiaxuat", txtDG.Text);
                reader.Close();
                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        LoadCTXuat();
                        LoadHDX();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm không thành công vì : "+ex.Message);
                };              
            }
            else
                MessageBox.Show("Đơn giá xuất phải lớn hơn đơn giá nhập");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            MessageBox.Show(cbbMaHD.Text + "    " + cbbMaSP.SelectedValue, "Thông báo");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "prXoaCTHDX";
            cmd.Parameters.AddWithValue("@mahdx", cbbMaHD.Text);
            cmd.Parameters.AddWithValue("@masp", cbbMaSP.SelectedValue);
            cmd.Parameters.AddWithValue("@soluong", int.Parse(txtSoLuong.Text.ToString()));
            cmd.Parameters.AddWithValue("@dongiaxuat", float.Parse(txtDG.Text.ToString()));
            if (cmd.ExecuteNonQuery() > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    LoadHDX();
                    LoadCTXuat();
                }
            }
            else
            {
                MessageBox.Show("Xoá không thành công");
            }
            
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            this.Hide();
            home.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FormHDXuat_Load(sender, e);
                txtDiaChi.Text="";
                txtEmail.Text = "";
                txtTenKH.Text = "";
                txtSDT.Text = "";
                cbbMaNV.Text = "";
                txtMaHD.Text = "";
                txtDG.Text = "";
                txtSoLuong.Text = "";
    }
    }
}
