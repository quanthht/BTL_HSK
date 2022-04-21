using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Collections;

namespace Thuchanh
{
    public partial class FormBaocao : Form
    {
        static DataTable dt = new DataTable();
        static string constr = "Data Source=LAPTOP-B66GKD0P;Initial Catalog=KinhDoanhMayTinh;Integrated Security=True";
        public FormBaocao(DataTable dtb)
        {
            dt = dtb;
            InitializeComponent();
        }


        private void FormBaocao_Load(object sender, EventArgs e)
        {
            rptNhanvien r = new rptNhanvien();
            r.SetDataSource(dt);
            crystalReportViewer1.ReportSource = r;
            crystalReportViewer1.Refresh();
        }
    }
}
 
