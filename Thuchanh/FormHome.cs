using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLNhanVien form = new FormQLNhanVien();
            form.Show();

           
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
