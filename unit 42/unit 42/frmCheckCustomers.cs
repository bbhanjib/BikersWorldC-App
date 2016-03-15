﻿using System;
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
    public partial class frmCheckCustomers : Form
    {
        public frmCheckCustomers()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer form3 = new frmAddCustomer();
            this.Hide();
            form3.Show(); 
        }

        private void checkCostomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckCustomers form4 = new frmCheckCustomers();
            this.Hide();
            form4.Show();  
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders1 form5 = new frmOrders1();
            this.Hide(); 
            form5.Show();
            
        }

        private void bntCheck_Click(object sender, EventArgs e)
        {

            frmSales form1 = new frmSales();
this.Hide();
            form1.Show();  
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSales form1 = new frmSales();
            this.Hide();
            form1.Show();  
        }
    }
}
