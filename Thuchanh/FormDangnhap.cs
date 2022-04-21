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
    public partial class FormDangnhap : Form
    {
        public static String constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
        public FormDangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(constr);
            sql.Open();
            SqlCommand cmd = new SqlCommand("prChecktaikhoan", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", txtTenTK.Text.ToString());
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd["matkhau"].ToString().Equals(txtPass.Text.ToString()))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                sql.Close();
                this.Hide();
                FormHome home = new FormHome();
                home.Show();
            }
            else MessageBox.Show("Đăng nhập thất bại !", "Thông báo");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDangky form = new FormDangky();
            form.ShowDialog();
        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {

        }
        //LMC đã ở đây
        //ảo thật tôi đã xem đc design r
    }
}
