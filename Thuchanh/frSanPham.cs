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

namespace Thuchanh
{
    public partial class frSanPham : Form
    {
        static String constr = @"
            Data Source=CUONG\CUONG;
            Integrated Security=True;
            Initial Catalog=KinhDoanhMayTinh";
        //static string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
        public frSanPham()
        {
            InitializeComponent();
        }

        private void frSanPham_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                cbBoxLoad();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vwDSSP", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSP.DataSource = dt;
                    }
                }
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            tbDonGiaXuat.Enabled = false;
        }
        private void cbBoxLoad()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT sHangSX FROM tblSanPham GROUP BY sHangSX", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbFilter.DataSource = dt;
                        cbFilter.ValueMember = "sHangSX";
                        cbFilter.DisplayMember = "sHangSX";
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "prInsertSP";
                cmd.Parameters.AddWithValue("@masp", tbMaSP.Text);
                cmd.Parameters.AddWithValue("@tensp", tbTenSP.Text);
                cmd.Parameters.AddWithValue("@hangsx", tbHangSX.Text);
                cmd.Parameters.AddWithValue("@namsx", tbNamSX.Text);
                cmd.Parameters.AddWithValue("@dongianhapSP", tbDonGiaNhap.Text);
                float dongiaxuat = (float)(1.2 * float.Parse(tbDonGiaNhap.Text));
                cmd.Parameters.AddWithValue("@dongiaxuatSP", dongiaxuat);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frSanPham_Load(sender, e);
                    tbMaSP.Clear();
                    tbTenSP.Clear();
                    tbHangSX.Clear();
                    tbNamSX.Clear();
                    tbDonGiaNhap.Clear();
                    tbDonGiaXuat.Clear();
                }
                else
                    MessageBox.Show("Trùng mã sản phẩm, không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dsSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbMaSP_Validating(object sender, CancelEventArgs e)
        {
            if (tbMaSP.Text == "")
            {
                errorProviderSP.SetError(tbMaSP, "Bắt buộc nhập!");
                btnThem.Enabled = false;
            }
            else
            {
                errorProviderSP.SetError(tbMaSP, "");
                btnThem.Enabled = true;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frSanPham_Load(sender, e);
            tbMaSP.Clear();
            tbTenSP.Clear();
            tbHangSX.Clear();
            tbNamSX.Clear();
            tbDonGiaNhap.Clear();
            tbDonGiaXuat.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "prXoaSP";
                    cmd.Parameters.AddWithValue("@masp", tbMaSP.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Xóa sản phẩm thất bại, không tìm thấy mã sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frSanPham_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "prSuaSP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma", tbMaSP.Text);
                cmd.Parameters.AddWithValue("@ten", tbTenSP.Text);
                cmd.Parameters.AddWithValue("@hang", tbHangSX.Text);
                cmd.Parameters.AddWithValue("@nam", tbNamSX.Text);
                cmd.Parameters.AddWithValue("@dgnhap", tbDonGiaNhap.Text);
                float dongiaxuat = (float)(1.2 * float.Parse(tbDonGiaNhap.Text));
                cmd.Parameters.AddWithValue("@dgxuat", dongiaxuat);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa sản phẩm thất bại, không tìm thấy mã sản phẩm cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frSanPham_Load(sender, e);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "prSPFilter";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hang", cbFilter.Text);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSP.DataSource = dt;
                    dgvSP.Refresh();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "prSearchSP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maTenHang", tbSearch.Text);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSP.DataSource = dt;
                    dgvSP.Refresh();
                }

            }
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSP.Rows[e.RowIndex];
                tbMaSP.Text = row.Cells[0].Value.ToString();
                tbTenSP.Text = row.Cells[1].Value.ToString();
                tbHangSX.Text = row.Cells[2].Value.ToString();
                tbNamSX.Text = row.Cells[3].Value.ToString();
                tbDonGiaNhap.Text = row.Cells[4].Value.ToString();
                tbDonGiaXuat.Text = row.Cells[5].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void tbSearch_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "prSearchSP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maTenHang", tbSearch.Text);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSP.DataSource = dt;
                    dgvSP.Refresh();
                }

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            this.Hide();
            formHome.Show();
        }
    }
}
