namespace prjBookSales
{
    partial class frmBookSales
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.lblDiscountedSalesResult = new System.Windows.Forms.Label();
            this.lblDiscountedSalesAmount = new System.Windows.Forms.Label();
            this.lblTotalSalesAmount = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblDiscountResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 175);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 40);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(283, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(169, 24);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(149, 20);
            this.txtTotalSales.TabIndex = 2;
            this.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalSales.TextChanged += new System.EventHandler(this.tbTotalSalesAmount_TextChanged);
            // 
            // lblDiscountedSalesResult
            // 
            this.lblDiscountedSalesResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscountedSalesResult.Location = new System.Drawing.Point(169, 108);
            this.lblDiscountedSalesResult.Name = "lblDiscountedSalesResult";
            this.lblDiscountedSalesResult.Size = new System.Drawing.Size(149, 20);
            this.lblDiscountedSalesResult.TabIndex = 3;
            this.lblDiscountedSalesResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscountedSalesResult.Click += new System.EventHandler(this.lblDiscountedSalesResult_Click);
            // 
            // lblDiscountedSalesAmount
            // 
            this.lblDiscountedSalesAmount.AutoSize = true;
            this.lblDiscountedSalesAmount.Location = new System.Drawing.Point(16, 112);
            this.lblDiscountedSalesAmount.Name = "lblDiscountedSalesAmount";
            this.lblDiscountedSalesAmount.Size = new System.Drawing.Size(132, 13);
            this.lblDiscountedSalesAmount.TabIndex = 1;
            this.lblDiscountedSalesAmount.Text = "Discounted Sales Amount:";
            // 
            // lblTotalSalesAmount
            // 
            this.lblTotalSalesAmount.AutoSize = true;
            this.lblTotalSalesAmount.Location = new System.Drawing.Point(31, 24);
            this.lblTotalSalesAmount.Name = "lblTotalSalesAmount";
            this.lblTotalSalesAmount.Size = new System.Drawing.Size(102, 13);
            this.lblTotalSalesAmount.TabIndex = 0;
            this.lblTotalSalesAmount.Text = "Total Sales Amount:";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(37, 68);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountAmount.TabIndex = 7;
            this.lblDiscountAmount.Text = "Discount Amount:";
            // 
            // lblDiscountResult
            // 
            this.lblDiscountResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscountResult.Location = new System.Drawing.Point(169, 66);
            this.lblDiscountResult.Name = "lblDiscountResult";
            this.lblDiscountResult.Size = new System.Drawing.Size(149, 20);
            this.lblDiscountResult.TabIndex = 8;
            this.lblDiscountResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscountResult.Click += new System.EventHandler(this.lblDiscountResult_Click);
            // 
            // frmBookSales
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(416, 255);
            this.Controls.Add(this.lblDiscountResult);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblTotalSalesAmount);
            this.Controls.Add(this.lblDiscountedSalesAmount);
            this.Controls.Add(this.lblDiscountedSalesResult);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmBookSales";
            this.Text = "Book Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Label lblDiscountedSalesResult;
        private System.Windows.Forms.Label lblDiscountedSalesAmount;
        private System.Windows.Forms.Label lblTotalSalesAmount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblDiscountResult;
    }
}

