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
    public partial class FormDangky : Form
    {
        public static String constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
        public FormDangky()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.TextLength == 0 || txtTenTK.TextLength == 0)
            {
                MessageBox.Show("Không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtMatKhau.Text.Equals(txtNhaplai.Text))
            {
                MessageBox.Show("Mật khẩu chưa khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            SqlCommand cmd = new SqlCommand("prChecktaikhoan", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", txtTenTK.Text.ToString());
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows) 
            {
                if (rd["ten"].ToString().Equals(txtTenTK.Text.ToString()))
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } }
            else
            {
                rd.Close();
                cmd = new SqlCommand("prInsertTaikhoan", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", txtTenTK.Text.ToString());
                cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text.ToString());
                if(cmd.ExecuteNonQuery()>0)
                MessageBox.Show("Đăng kí thành công!", "Thông báo");
                FormDangnhap form = new FormDangnhap();
                this.Hide();
                form.ShowDialog();
                sql.Close();
            }

        }
    }
}
