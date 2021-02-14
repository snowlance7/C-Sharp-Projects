using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Project Name:    Variable Demo plus more
// Created by:      Gage Vail
//Created Date:     9/19/2016
// Project Description: Working with variables of different data types
//
//
//
namespace prjVariableDemo
{
    public partial class frmVariableDemo : Form
    {
        public frmVariableDemo()
        {
            InitializeComponent();
        }

        private void frmVariableDemo_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // predefined variable
            DialogResult dlgResult;

            dlgResult = MessageBox.Show("Are you sure you want to exit?", "Exiting App", MessageBoxButtons.YesNo);
            if(dlgResult == DialogResult.Yes)
            { // exit the application
                Application.Exit();
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // messagebox to user - commented out for demo purpose
            // MessageBox.Show("Thanks for clicking on the View button!", "View Button");
            // declare variable
            string strFirstName = "Gage";

            // assign value from variable to label on screen
            lblVar1.Text = strFirstName;
        }

        private void lblVar1_Click(object sender, EventArgs e)
        {

        }

        private void btnVarInt_Click(object sender, EventArgs e)
        {
            // declare/define int variable
            int intAge = 0;

            intAge = 21;

            lblVar1.Text = intAge.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //declare variable
            int intInput;
            try
            {
                //assign value for variable
                intInput = Convert.ToInt16(txtInput.Text);
                //Adding 10 to the value entered in text box thats
                //  stored in our variable intInput
                intInput = intInput + 10; // Add
                //intInput = intInput - 10; // Subtract
                //intInput = intInput * 10; // Multiply
                //intInput = intInput / 10; // Divide

                //place variable into label for user to see answer
                lblVar1.Text = intInput.ToString();
            }
            catch
            {
                //catch any error that occurs inside the TRY
                MessageBox.Show("Error on data entered!", "Error");
            }

            // make sure to put focus where it belongs
            txtInput.Focus();
                txtInput.SelectAll();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //when text is changed in txtInput we want to do what?
            //      I think we should clear the label on the form
            // clear value in label on screen that the user sees
            lblVar1.Text = "";
        }
    }
}
