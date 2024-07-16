namespace WordFileChecker
{
    partial class OptionsForm4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMinParagraphCount;
        private System.Windows.Forms.Label lblMaxParagraphCount;
        private System.Windows.Forms.TextBox txtMinParagraphCount;
        private System.Windows.Forms.TextBox txtMaxParagraphCount;
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
            this.lblMinParagraphCount = new System.Windows.Forms.Label();
            this.lblMaxParagraphCount = new System.Windows.Forms.Label();
            this.txtMinParagraphCount = new System.Windows.Forms.TextBox();
            this.txtMaxParagraphCount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblMinParagraphCount.AutoSize = true;
            this.lblMinParagraphCount.Location = new System.Drawing.Point(13, 13);
            this.lblMinParagraphCount.Name = "lblMinParagraphCount";
            this.lblMinParagraphCount.Size = new System.Drawing.Size(110, 13);
            this.lblMinParagraphCount.TabIndex = 0;
            this.lblMinParagraphCount.Text = "Min Paragraph Count:";
            this.lblMaxParagraphCount.AutoSize = true;
            this.lblMaxParagraphCount.Location = new System.Drawing.Point(13, 50);
            this.lblMaxParagraphCount.Name = "lblMaxParagraphCount";
            this.lblMaxParagraphCount.Size = new System.Drawing.Size(113, 13);
            this.lblMaxParagraphCount.TabIndex = 1;
            this.lblMaxParagraphCount.Text = "Max Paragraph Count:";
            this.txtMinParagraphCount.Location = new System.Drawing.Point(130, 10);
            this.txtMinParagraphCount.Name = "txtMinParagraphCount";
            this.txtMinParagraphCount.Size = new System.Drawing.Size(142, 20);
            this.txtMinParagraphCount.TabIndex = 2;
            this.txtMaxParagraphCount.Location = new System.Drawing.Point(130, 47);
            this.txtMaxParagraphCount.Name = "txtMaxParagraphCount";
            this.txtMaxParagraphCount.Size = new System.Drawing.Size(142, 20);
            this.txtMaxParagraphCount.TabIndex = 3;
            this.btnOK.Location = new System.Drawing.Point(116, 85);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnCancel.Location = new System.Drawing.Point(197, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMaxParagraphCount);
            this.Controls.Add(this.txtMinParagraphCount);
            this.Controls.Add(this.lblMaxParagraphCount);
            this.Controls.Add(this.lblMinParagraphCount);
            this.Name = "OptionsForm4";
            this.Text = "Paragraph Count Options";
            this.Load += new System.EventHandler(this.OptionsForm4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
