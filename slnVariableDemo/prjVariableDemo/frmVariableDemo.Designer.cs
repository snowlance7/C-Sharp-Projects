namespace prjVariableDemo
{
    partial class frmVariableDemo
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVar1 = new System.Windows.Forms.Label();
            this.btnVarInt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnView.Location = new System.Drawing.Point(12, 287);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 40);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(307, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblVar1
            // 
            this.lblVar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVar1.Location = new System.Drawing.Point(143, 164);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(196, 39);
            this.lblVar1.TabIndex = 1;
            this.lblVar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVar1.Click += new System.EventHandler(this.lblVar1_Click);
            // 
            // btnVarInt
            // 
            this.btnVarInt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVarInt.Location = new System.Drawing.Point(153, 287);
            this.btnVarInt.Name = "btnVarInt";
            this.btnVarInt.Size = new System.Drawing.Size(107, 40);
            this.btnVarInt.TabIndex = 3;
            this.btnVarInt.Text = "View Int";
            this.btnVarInt.UseVisualStyleBackColor = true;
            this.btnVarInt.Click += new System.EventHandler(this.btnVarInt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(12, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(153, 67);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(189, 26);
            this.txtInput.TabIndex = 6;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // frmVariableDemo
            // 
            this.AcceptButton = this.btnView;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnVarInt);
            this.Controls.Add(this.lblVar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVariableDemo";
            this.Text = "Chapter 3 Variables Demo";
            this.Load += new System.EventHandler(this.frmVariableDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.Button btnVarInt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInput;
    }
}

