﻿using System;
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
        public frSanPham()
        {
            InitializeComponent();
        }
    }
}
