namespace WordFileChecker
{
    partial class OptionsForm3
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();            
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.Location = new System.Drawing.Point(12, 12);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(200, 95);
            this.lstFonts.TabIndex = 0;         
            this.txtPercentage.Location = new System.Drawing.Point(230, 35);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 1;           
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(227, 19);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(89, 13);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "Percentage (0-1):";           
            this.btnOK.Location = new System.Drawing.Point(230, 70);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnCancel.Location = new System.Drawing.Point(311, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.lstFonts);
            this.Name = "OptionsForm3";
            this.Text = "Select Font";
            this.Load += new System.EventHandler(this.OptionsForm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lstFonts;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
