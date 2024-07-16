using System;
using System.Windows.Forms;

namespace WordFileChecker
{
    partial class OptionsForm1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbFontColor;
        private TextBox txtFontPercentage;
        private Label lblFontColor;
        private Label lblFontPercentage;
        private Button btnOK;
        private Button btnCancel;

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
            this.cmbFontColor = new ComboBox();
            this.txtFontPercentage = new TextBox();
            this.lblFontColor = new Label();
            this.lblFontPercentage = new Label();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();         
            this.cmbFontColor.FormattingEnabled = true;
            this.cmbFontColor.Location = new System.Drawing.Point(150, 30);
            this.cmbFontColor.Name = "cmbFontColor";
            this.cmbFontColor.Size = new System.Drawing.Size(121, 21);
            this.cmbFontColor.TabIndex = 0;           
            this.txtFontPercentage.Location = new System.Drawing.Point(150, 70);
            this.txtFontPercentage.Name = "txtFontPercentage";
            this.txtFontPercentage.Size = new System.Drawing.Size(121, 20);
            this.txtFontPercentage.TabIndex = 1;           
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.Location = new System.Drawing.Point(30, 30);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(58, 13);
            this.lblFontColor.TabIndex = 2;
            this.lblFontColor.Text = "Font Color:";            
            this.lblFontPercentage.AutoSize = true;
            this.lblFontPercentage.Location = new System.Drawing.Point(30, 70);
            this.lblFontPercentage.Name = "lblFontPercentage";
            this.lblFontPercentage.Size = new System.Drawing.Size(89, 13);
            this.lblFontPercentage.TabIndex = 3;
            this.lblFontPercentage.Text = "Font Percentage:";            
            this.btnOK.Location = new System.Drawing.Point(50, 110);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new EventHandler(this.btnOK_Click);           
            this.btnCancel.Location = new System.Drawing.Point(150, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFontPercentage);
            this.Controls.Add(this.lblFontColor);
            this.Controls.Add(this.txtFontPercentage);
            this.Controls.Add(this.cmbFontColor);
            this.Name = "OptionsForm1";
            this.Text = "Select Font Color and Percentage";
            this.Load += new EventHandler(this.OptionsForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
