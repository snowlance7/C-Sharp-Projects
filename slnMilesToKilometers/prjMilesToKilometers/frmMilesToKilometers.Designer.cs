namespace prjMilesToKilometers
{
    partial class frmMilesToKilometers
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
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMiles
            // 
            this.lblMiles.Location = new System.Drawing.Point(37, 48);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(35, 13);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Miles";
            // 
            // lblKilometers
            // 
            this.lblKilometers.Location = new System.Drawing.Point(37, 93);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(59, 20);
            this.lblKilometers.TabIndex = 1;
            this.lblKilometers.Text = "Kilometers";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.Control;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(122, 93);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(118, 20);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(25, 160);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(82, 34);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(245, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiles.Location = new System.Drawing.Point(122, 45);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(118, 20);
            this.txtMiles.TabIndex = 2;
            this.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiles.TextChanged += new System.EventHandler(this.tbMiles_TextChanged);
            // 
            // frmMilesToKilometers
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 223);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.lblMiles);
            this.Name = "frmMilesToKilometers";
            this.Text = "Miles to Kilometers";
            this.Load += new System.EventHandler(this.frmMilesToKilometers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMiles;
    }
}

