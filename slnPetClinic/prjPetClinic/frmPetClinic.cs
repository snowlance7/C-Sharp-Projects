using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Made by: Gage Vail
// Date: 10/18/2016
namespace prjPetClinic
{
    public partial class frmPetClinic : Form
    {
        //establish variables
        const double dblOfficeCall = 29.99;
        const double dblVaccination = 151.56;
        const double dblGrooming = 49.99;
        const double dblDiagnosis = 39.99;
        const double dblDentistry = 75.59;
        const double dblCounseling = 69.99;
        const double dblDeclawing = 99.99;
        const double dblBoarding = 249.99;
        double dblTotal;
        public frmPetClinic()
        {
            InitializeComponent();
        }

        private void frmPetClinic_Load(object sender, EventArgs e)
        {

        }

        private void chkOfficeCall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOfficeCall.Checked)
            {
                //display price of service and add to total
                lblOfficeCallPrice.Text = dblOfficeCall.ToString("c2");
                dblTotal = dblTotal + dblOfficeCall;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblOfficeCallPrice.Text = "";
                dblTotal = dblTotal - dblOfficeCall;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void chkVaccination_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVaccination.Checked)
            {
                //display price of service and add to total
                lblVaccinationPrice.Text = dblVaccination.ToString("c2");
                dblTotal = dblTotal + dblVaccination;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblVaccinationPrice.Text = "";
                dblTotal = dblTotal - dblVaccination;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void chkGrooming_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrooming.Checked)
            {
                //display price of service and add to total
                lblGroomingPrice.Text = dblGrooming.ToString("c2");
                dblTotal = dblTotal + dblGrooming;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblGroomingPrice.Text = "";
                dblTotal = dblTotal - dblGrooming;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void chkDiagnosis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiagnosis.Checked)
            {
                //display price of service and add to total
                lblDiagnosisPrice.Text = dblDiagnosis.ToString("c2");
                dblTotal = dblTotal + dblDiagnosis;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblDiagnosisPrice.Text = "";
                dblTotal = dblTotal - dblDiagnosis;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void chkDentistry_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDentistry.Checked)
            {
                //display price of service and add to total
                lblDentistryPrice.Text = dblDentistry.ToString("c2");
                dblTotal = dblTotal + dblDentistry;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblDentistryPrice.Text = "";
                dblTotal = dblTotal - dblDentistry;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void chkCounseling_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCounseling.Checked)
            {
                //display price of service and add to total
                lblCounselingPrice.Text = dblCounseling.ToString("c2");
                dblTotal = dblTotal + dblCounseling;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblCounselingPrice.Text = "";
                dblTotal = dblTotal - dblCounseling;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void chkDeclawing_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeclawing.Checked)
            {
                //display price of service and add to total
                lblDeclawingPrice.Text = dblDeclawing.ToString("c2");
                dblTotal = dblTotal + dblDeclawing;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblDeclawingPrice.Text = "";
                dblTotal = dblTotal - dblDeclawing;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void chkBoarding_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoarding.Checked)
            {
                //display price of service and add to total
                lblBoardingPrice.Text = dblBoarding.ToString("c2");
                dblTotal = dblTotal + dblBoarding;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
            else
            {
                //clear price label and subtract from total
                lblBoardingPrice.Text = "";
                dblTotal = dblTotal - dblBoarding;
                lblTotalPriceDue.Text = dblTotal.ToString("c2");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all price labels
            lblOfficeCallPrice.Text = "";
            lblVaccinationPrice.Text = "";
            lblGroomingPrice.Text = "";
            lblDiagnosisPrice.Text = "";
            lblDentistryPrice.Text = "";
            lblCounselingPrice.Text = "";
            lblDeclawingPrice.Text = "";
            lblBoardingPrice.Text = "";
            //uncheck check boxes
            chkOfficeCall.Checked = false;
            chkVaccination.Checked = false;
            chkGrooming.Checked = false;
            chkDiagnosis.Checked = false;
            chkDentistry.Checked = false;
            chkCounseling.Checked = false;
            chkDeclawing.Checked = false;
            chkBoarding.Checked = false;
            //clear total
            lblTotalPriceDue.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }
    }
}
