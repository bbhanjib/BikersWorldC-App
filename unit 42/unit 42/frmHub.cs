using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit_42
{
    public partial class frmHub : Form
    {
        public frmHub()
        {
            InitializeComponent();
        }


        private void btntechnicians_Click(object sender, EventArgs e)
        {


        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            frmSales form2 = new frmSales();
 
            form2.Show();
            this.Hide();


            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHub_Load(object sender, EventArgs e)
        {

        }
    }
}
