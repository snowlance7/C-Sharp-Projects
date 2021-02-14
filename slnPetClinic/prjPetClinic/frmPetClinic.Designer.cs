namespace prjPetClinic
{
    partial class frmPetClinic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkOfficeCall = new System.Windows.Forms.CheckBox();
            this.chkDentistry = new System.Windows.Forms.CheckBox();
            this.chkVaccination = new System.Windows.Forms.CheckBox();
            this.chkCounseling = new System.Windows.Forms.CheckBox();
            this.chkDeclawing = new System.Windows.Forms.CheckBox();
            this.chkDiagnosis = new System.Windows.Forms.CheckBox();
            this.chkBoarding = new System.Windows.Forms.CheckBox();
            this.lblOfficeCallPrice = new System.Windows.Forms.Label();
            this.lblDentistryPrice = new System.Windows.Forms.Label();
            this.lblVaccinationPrice = new System.Windows.Forms.Label();
            this.lblCounselingPrice = new System.Windows.Forms.Label();
            this.lblGroomingPrice = new System.Windows.Forms.Label();
            this.lblDeclawingPrice = new System.Windows.Forms.Label();
            this.lblDiagnosisPrice = new System.Windows.Forms.Label();
            this.lblBoardingPrice = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalDueLabel = new System.Windows.Forms.Label();
            this.lblTotalPriceDue = new System.Windows.Forms.Label();
            this.chkGrooming = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkOfficeCall
            // 
            this.chkOfficeCall.AutoSize = true;
            this.chkOfficeCall.Location = new System.Drawing.Point(40, 52);
            this.chkOfficeCall.Name = "chkOfficeCall";
            this.chkOfficeCall.Size = new System.Drawing.Size(74, 17);
            this.chkOfficeCall.TabIndex = 0;
            this.chkOfficeCall.Text = "Office Call";
            this.chkOfficeCall.UseVisualStyleBackColor = true;
            this.chkOfficeCall.CheckedChanged += new System.EventHandler(this.chkOfficeCall_CheckedChanged);
            // 
            // chkDentistry
            // 
            this.chkDentistry.AutoSize = true;
            this.chkDentistry.Location = new System.Drawing.Point(228, 52);
            this.chkDentistry.Name = "chkDentistry";
            this.chkDentistry.Size = new System.Drawing.Size(67, 17);
            this.chkDentistry.TabIndex = 4;
            this.chkDentistry.Text = "Dentistry";
            this.chkDentistry.UseVisualStyleBackColor = true;
            this.chkDentistry.CheckedChanged += new System.EventHandler(this.chkDentistry_CheckedChanged);
            // 
            // chkVaccination
            // 
            this.chkVaccination.AutoSize = true;
            this.chkVaccination.Location = new System.Drawing.Point(40, 91);
            this.chkVaccination.Name = "chkVaccination";
            this.chkVaccination.Size = new System.Drawing.Size(82, 17);
            this.chkVaccination.TabIndex = 1;
            this.chkVaccination.Text = "Vaccination";
            this.chkVaccination.UseVisualStyleBackColor = true;
            this.chkVaccination.CheckedChanged += new System.EventHandler(this.chkVaccination_CheckedChanged);
            // 
            // chkCounseling
            // 
            this.chkCounseling.AutoSize = true;
            this.chkCounseling.Location = new System.Drawing.Point(228, 91);
            this.chkCounseling.Name = "chkCounseling";
            this.chkCounseling.Size = new System.Drawing.Size(78, 17);
            this.chkCounseling.TabIndex = 5;
            this.chkCounseling.Text = "Counseling";
            this.chkCounseling.UseVisualStyleBackColor = true;
            this.chkCounseling.CheckedChanged += new System.EventHandler(this.chkCounseling_CheckedChanged);
            // 
            // chkDeclawing
            // 
            this.chkDeclawing.AutoSize = true;
            this.chkDeclawing.Location = new System.Drawing.Point(228, 129);
            this.chkDeclawing.Name = "chkDeclawing";
            this.chkDeclawing.Size = new System.Drawing.Size(76, 17);
            this.chkDeclawing.TabIndex = 6;
            this.chkDeclawing.Text = "Declawing";
            this.chkDeclawing.UseVisualStyleBackColor = true;
            this.chkDeclawing.CheckedChanged += new System.EventHandler(this.chkDeclawing_CheckedChanged);
            // 
            // chkDiagnosis
            // 
            this.chkDiagnosis.AutoSize = true;
            this.chkDiagnosis.Location = new System.Drawing.Point(40, 173);
            this.chkDiagnosis.Name = "chkDiagnosis";
            this.chkDiagnosis.Size = new System.Drawing.Size(72, 17);
            this.chkDiagnosis.TabIndex = 3;
            this.chkDiagnosis.Text = "Diagnosis";
            this.chkDiagnosis.UseVisualStyleBackColor = true;
            this.chkDiagnosis.CheckedChanged += new System.EventHandler(this.chkDiagnosis_CheckedChanged);
            // 
            // chkBoarding
            // 
            this.chkBoarding.AutoSize = true;
            this.chkBoarding.Location = new System.Drawing.Point(228, 170);
            this.chkBoarding.Name = "chkBoarding";
            this.chkBoarding.Size = new System.Drawing.Size(68, 17);
            this.chkBoarding.TabIndex = 7;
            this.chkBoarding.Text = "Boarding";
            this.chkBoarding.UseVisualStyleBackColor = true;
            this.chkBoarding.CheckedChanged += new System.EventHandler(this.chkBoarding_CheckedChanged);
            // 
            // lblOfficeCallPrice
            // 
            this.lblOfficeCallPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOfficeCallPrice.Location = new System.Drawing.Point(149, 49);
            this.lblOfficeCallPrice.Name = "lblOfficeCallPrice";
            this.lblOfficeCallPrice.Size = new System.Drawing.Size(50, 23);
            this.lblOfficeCallPrice.TabIndex = 10;
            this.lblOfficeCallPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDentistryPrice
            // 
            this.lblDentistryPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDentistryPrice.Location = new System.Drawing.Point(337, 49);
            this.lblDentistryPrice.Name = "lblDentistryPrice";
            this.lblDentistryPrice.Size = new System.Drawing.Size(50, 23);
            this.lblDentistryPrice.TabIndex = 14;
            this.lblDentistryPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVaccinationPrice
            // 
            this.lblVaccinationPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVaccinationPrice.Location = new System.Drawing.Point(149, 87);
            this.lblVaccinationPrice.Name = "lblVaccinationPrice";
            this.lblVaccinationPrice.Size = new System.Drawing.Size(50, 23);
            this.lblVaccinationPrice.TabIndex = 11;
            this.lblVaccinationPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCounselingPrice
            // 
            this.lblCounselingPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounselingPrice.Location = new System.Drawing.Point(337, 87);
            this.lblCounselingPrice.Name = "lblCounselingPrice";
            this.lblCounselingPrice.Size = new System.Drawing.Size(50, 23);
            this.lblCounselingPrice.TabIndex = 15;
            this.lblCounselingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGroomingPrice
            // 
            this.lblGroomingPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGroomingPrice.Location = new System.Drawing.Point(149, 126);
            this.lblGroomingPrice.Name = "lblGroomingPrice";
            this.lblGroomingPrice.Size = new System.Drawing.Size(50, 23);
            this.lblGroomingPrice.TabIndex = 12;
            this.lblGroomingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeclawingPrice
            // 
            this.lblDeclawingPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeclawingPrice.Location = new System.Drawing.Point(337, 126);
            this.lblDeclawingPrice.Name = "lblDeclawingPrice";
            this.lblDeclawingPrice.Size = new System.Drawing.Size(50, 23);
            this.lblDeclawingPrice.TabIndex = 16;
            this.lblDeclawingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiagnosisPrice
            // 
            this.lblDiagnosisPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiagnosisPrice.Location = new System.Drawing.Point(149, 170);
            this.lblDiagnosisPrice.Name = "lblDiagnosisPrice";
            this.lblDiagnosisPrice.Size = new System.Drawing.Size(50, 23);
            this.lblDiagnosisPrice.TabIndex = 13;
            this.lblDiagnosisPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBoardingPrice
            // 
            this.lblBoardingPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBoardingPrice.Location = new System.Drawing.Point(337, 167);
            this.lblBoardingPrice.Name = "lblBoardingPrice";
            this.lblBoardingPrice.Size = new System.Drawing.Size(50, 23);
            this.lblBoardingPrice.TabIndex = 17;
            this.lblBoardingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(110, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(228, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalDueLabel
            // 
            this.lblTotalDueLabel.Location = new System.Drawing.Point(137, 213);
            this.lblTotalDueLabel.Name = "lblTotalDueLabel";
            this.lblTotalDueLabel.Size = new System.Drawing.Size(62, 23);
            this.lblTotalDueLabel.TabIndex = 18;
            this.lblTotalDueLabel.Text = "Total Due:";
            // 
            // lblTotalPriceDue
            // 
            this.lblTotalPriceDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPriceDue.Location = new System.Drawing.Point(228, 213);
            this.lblTotalPriceDue.Name = "lblTotalPriceDue";
            this.lblTotalPriceDue.Size = new System.Drawing.Size(67, 23);
            this.lblTotalPriceDue.TabIndex = 19;
            this.lblTotalPriceDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkGrooming
            // 
            this.chkGrooming.AutoSize = true;
            this.chkGrooming.Location = new System.Drawing.Point(40, 130);
            this.chkGrooming.Name = "chkGrooming";
            this.chkGrooming.Size = new System.Drawing.Size(71, 17);
            this.chkGrooming.TabIndex = 2;
            this.chkGrooming.Text = "Grooming";
            this.chkGrooming.UseVisualStyleBackColor = true;
            this.chkGrooming.CheckedChanged += new System.EventHandler(this.chkGrooming_CheckedChanged);
            // 
            // frmPetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(444, 325);
            this.Controls.Add(this.lblTotalPriceDue);
            this.Controls.Add(this.lblTotalDueLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBoardingPrice);
            this.Controls.Add(this.lblDiagnosisPrice);
            this.Controls.Add(this.lblDeclawingPrice);
            this.Controls.Add(this.lblGroomingPrice);
            this.Controls.Add(this.lblCounselingPrice);
            this.Controls.Add(this.lblVaccinationPrice);
            this.Controls.Add(this.lblDentistryPrice);
            this.Controls.Add(this.lblOfficeCallPrice);
            this.Controls.Add(this.chkBoarding);
            this.Controls.Add(this.chkDiagnosis);
            this.Controls.Add(this.chkDeclawing);
            this.Controls.Add(this.chkGrooming);
            this.Controls.Add(this.chkCounseling);
            this.Controls.Add(this.chkVaccination);
            this.Controls.Add(this.chkDentistry);
            this.Controls.Add(this.chkOfficeCall);
            this.Name = "frmPetClinic";
            this.Text = "Lions, Tigers and Bears Pet Clinic";
            this.Load += new System.EventHandler(this.frmPetClinic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOfficeCall;
        private System.Windows.Forms.CheckBox chkDentistry;
        private System.Windows.Forms.CheckBox chkVaccination;
        private System.Windows.Forms.CheckBox chkCounseling;
        private System.Windows.Forms.CheckBox chkDeclawing;
        private System.Windows.Forms.CheckBox chkDiagnosis;
        private System.Windows.Forms.CheckBox chkBoarding;
        private System.Windows.Forms.Label lblOfficeCallPrice;
        private System.Windows.Forms.Label lblDentistryPrice;
        private System.Windows.Forms.Label lblVaccinationPrice;
        private System.Windows.Forms.Label lblCounselingPrice;
        private System.Windows.Forms.Label lblGroomingPrice;
        private System.Windows.Forms.Label lblDeclawingPrice;
        private System.Windows.Forms.Label lblDiagnosisPrice;
        private System.Windows.Forms.Label lblBoardingPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalDueLabel;
        private System.Windows.Forms.Label lblTotalPriceDue;
        private System.Windows.Forms.CheckBox chkGrooming;
    }
}

