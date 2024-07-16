using System;
using System.Windows.Forms;

namespace WordFileChecker
{
    partial class OptionsForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbPercentage;
        private ComboBox cmbColor;
        private Button btnOK;
        private Button btnCancel;
        private Label lblPercentage;
        private Label lblColor;

        private void InitializeComponent()
        {
            this.cmbPercentage = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.SuspendLayout();            
            this.cmbPercentage.FormattingEnabled = true;
            this.cmbPercentage.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.cmbPercentage.Location = new System.Drawing.Point(20, 30);
            this.cmbPercentage.Name = "cmbPercentage";
            this.cmbPercentage.Size = new System.Drawing.Size(121, 21);
            this.cmbPercentage.TabIndex = 0;           
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "None",
            "Yellow",
            "Green",
            "Blue",
            "Red"});
            this.cmbColor.Location = new System.Drawing.Point(160, 30);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 1;            
            this.btnOK.Location = new System.Drawing.Point(20, 70);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);            
            this.btnCancel.Location = new System.Drawing.Point(120, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);           
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(20, 10);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(65, 13);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "Percentage:";            
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(160, 10);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color:";           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbPercentage);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
