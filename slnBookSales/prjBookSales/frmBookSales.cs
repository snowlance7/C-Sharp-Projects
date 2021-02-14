using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookSales
{
    public partial class frmBookSales : Form
    {
        public frmBookSales()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Attempts to run this operation
            try
            {
                //establish variables
                decimal decInput;
                decimal decDiscount;
                decimal decDiscountedSales;
                decInput = decimal.Parse(txtTotalSales.Text);
                
                //calculate the discount amount and discounted sales amount
                decDiscount = decInput / 4;
                decDiscountedSales = decInput - decDiscount;

                //put convert dec values and place in proper labels
                lblDiscountResult.Text = decDiscount.ToString();
                lblDiscountedSalesResult.Text = decDiscountedSales.ToString();

                //focuses and selects the textbox
                txtTotalSales.Focus();
                txtTotalSales.SelectAll();
            }
            catch
            {
                //shows the error message box if data entered was invalid
                MessageBox.Show("Error with data entered", "Error");
            }
        }

        private void tbTotalSalesAmount_TextChanged(object sender, EventArgs e)
        {
            //clears text in Discount Result and Discounted Sales Amount when text changed
            lblDiscountedSalesResult.Text = "";
            lblDiscountResult.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the three texts on the form
            txtTotalSales.Text = "";
            lblDiscountedSalesResult.Text = "";
            lblDiscountResult.Text = "";
            //focuses on the textbox
            txtTotalSales.Focus();
        }

        private void lblDiscountResult_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscountedSalesResult_Click(object sender, EventArgs e)
        {

        }
    }
}
