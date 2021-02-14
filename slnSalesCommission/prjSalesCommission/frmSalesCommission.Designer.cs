namespace prjSalesCommission
{
    partial class frmSalesCommission
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblCommissionfor = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculateCommission = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(35, 29);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(35, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(59, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSales
            // 
            this.lblSales.Location = new System.Drawing.Point(35, 95);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(59, 13);
            this.lblSales.TabIndex = 8;
            this.lblSales.Text = "Sales";
            // 
            // lblCommissionfor
            // 
            this.lblCommissionfor.Location = new System.Drawing.Point(51, 192);
            this.lblCommissionfor.Name = "lblCommissionfor";
            this.lblCommissionfor.Size = new System.Drawing.Size(194, 16);
            this.lblCommissionfor.TabIndex = 9;
            this.lblCommissionfor.Text = "Commission for ";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(54, 223);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(89, 24);
            this.lblResult.TabIndex = 10;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculateCommission
            // 
            this.btnCalculateCommission.Location = new System.Drawing.Point(38, 139);
            this.btnCalculateCommission.Name = "btnCalculateCommission";
            this.btnCalculateCommission.Size = new System.Drawing.Size(146, 29);
            this.btnCalculateCommission.TabIndex = 3;
            this.btnCalculateCommission.Text = "&Calculate Commission";
            this.btnCalculateCommission.UseVisualStyleBackColor = true;
            this.btnCalculateCommission.Click += new System.EventHandler(this.btnCalculateCommission_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(171, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(128, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(128, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(128, 95);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 2;
            this.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmSalesCommission
            // 
            this.AcceptButton = this.btnCalculateCommission;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(287, 321);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateCommission);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCommissionfor);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Name = "frmSalesCommission";
            this.Text = "Sales Commision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblCommissionfor;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculateCommission;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSales;
    }
}

