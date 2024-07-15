namespace WordFileChecker
{
    partial class AboutForm
    {
        private System.Windows.Forms.Label label;

        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // label
             
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(287, 52);
            this.label.TabIndex = 0;
            this.label.Text = "მოვიფიქრებ!" +
    "!!!!.";
             
            // AboutForm
            
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.label);
            this.Name = "AboutForm";
            this.Text = "About Word File Comparer";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
