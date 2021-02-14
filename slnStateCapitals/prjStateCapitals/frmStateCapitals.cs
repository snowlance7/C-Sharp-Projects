using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Created by Gage Vail
namespace prjStateCapitals
{
    public partial class frmStateCapitals : Form
    {
        public frmStateCapitals()
        {
            InitializeComponent();
        }

        private void btnWisconsin_Click(object sender, EventArgs e)
        {
            // This will display "Wisconsin" in lblStateName
            lblStateName.Text = "Wisconsin";
            // This will display "Madison" in lblStateCapitalName
            lblStateCapitalName.Text = "Madison";
        }

        private void btnMichigan_Click(object sender, EventArgs e)
        {
            // This will display "Michigan" in lblStateName
            lblStateName.Text = "Michigan";
            // This will display "Lansing" in lblStateCapitalName
            lblStateCapitalName.Text = "Lansing";
        }

        private void btnMinnesota_Click(object sender, EventArgs e)
        {
            // This will display "Minnesota" in lblStateName
            lblStateName.Text = "Minnesota";
            // This will display "Saint Paul" in lblStateCapitalName
            lblStateCapitalName.Text = "Saint Paul";
        }

        private void btnIowa_Click(object sender, EventArgs e)
        {
            // This will display "Iowa" in lblStateName
            lblStateName.Text = "Iowa";
            // This will display "Des Moines" in lblStateCapitalName
            lblStateCapitalName.Text = "Des Moines";
        }

        private void btnIllinois_Click(object sender, EventArgs e)
        {
            // This will display "Illinois" in lblStateName
            lblStateName.Text = "Illinois";
            // This will display "Springfield" in lblStateCapitalName
            lblStateCapitalName.Text = "Springfield";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // This will clear text in lblStateName
            lblStateName.Text = "";
            // This will clear text in lblStateCapitalName
            lblStateCapitalName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // This will exit the application
            Application.Exit();
        }
    }
}
