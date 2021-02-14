using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalesCommission
{
    public partial class frmSalesCommission : Form
    {
        public frmSalesCommission()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtSales.Text = "";
            lblCommissionfor.Visible = false;
            lblResult.Text = "";

            txtLastName.Focus();
            txtLastName.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculateCommission_Click(object sender, EventArgs e)
        {
            double dblSales;
            double dblResult;
            string Commissionfor;

            if (double.TryParse(txtSales.Text, out dblSales))
            {
                dblResult = dblSales * 1.1;
                lblResult.Text = dblResult.ToString("c2");

                if (txtFirstName.Text != "")
                {

                }
            }
            else
            {
                MessageBox.Show("Data for Sales is not numeric", "Error");
                txtSales.Focus();
                txtSales.SelectAll();
            }
        }
    }
}
