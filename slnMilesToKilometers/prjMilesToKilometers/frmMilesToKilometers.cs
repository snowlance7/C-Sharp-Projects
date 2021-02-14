using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Created By: Gage Vail
// Project: Miles To Kilometers
// Date: 09/29/16
namespace prjMilesToKilometers
{
    public partial class frmMilesToKilometers : Form
    {
        public frmMilesToKilometers()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //attempt to perform, if not then it displays an error message
            try
            {
                //Initialize variables for Miles and Kilometers
                double Miles;
                double Kilometers;
                // Pulls data from tbMiles and converts it into a double data type
                Miles = double.Parse(txtMiles.Text);
                // Converts miles into kilometers
                Kilometers = Miles * 1.61;
                // Converts kilometers data into string to be displayed in lblResult label
                lblResult.Text = Kilometers.ToString();
            }
            catch
            {
                //displays a message box if data in tbMiles was invalid
                MessageBox.Show("Error on data entered", "Error");
            }
            //focuses on the Miles textbox after showing kilometers result
            txtMiles.Focus();
            txtMiles.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears text in tbMiles and lblResult
            txtMiles.Text = "";
            lblResult.Text = "";
            //focuses on Miles Textbox after data is cleared
            txtMiles.Focus();
        }

        private void tbMiles_TextChanged(object sender, EventArgs e)
        {
            //clears the data in kilometers result
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }

        private void frmMilesToKilometers_Load(object sender, EventArgs e)
        {

        }
    }
}
