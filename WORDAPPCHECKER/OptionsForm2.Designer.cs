namespace WordFileChecker
{
    partial class OptionsForm2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFontSize = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();          
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(12, 15);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(54, 13);
            this.lblFontSize.TabIndex = 0;
            this.lblFontSize.Text = "Font Size:";            
            this.txtFontSize.Location = new System.Drawing.Point(100, 12);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(100, 20);
            this.txtFontSize.TabIndex = 1;             
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(12, 50);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(65, 13);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "Percentage:";           
            this.txtPercentage.Location = new System.Drawing.Point(100, 47);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 3;           
            this.btnOK.Location = new System.Drawing.Point(44, 83);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);           
            this.btnCancel.Location = new System.Drawing.Point(125, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);          
            this.ClientSize = new System.Drawing.Size(224, 121);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.lblFontSize);
            this.Name = "OptionsForm2";
            this.Text = "Font Options";
            this.Load += new System.EventHandler(this.OptionsForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
