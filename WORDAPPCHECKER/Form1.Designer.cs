namespace WordFileChecker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnBrowseControlFile;
        private System.Windows.Forms.RibbonButton btnBrowseControlFolder;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton btnCompareFiles;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnAbout;
        private System.Windows.Forms.RibbonButton btnSettings;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox lstStudentFiles;
        private System.Windows.Forms.TextBox txtControlFilePath;
        private System.Windows.Forms.Label lblControlFilePath;
        private System.Windows.Forms.Label lblStudentFiles;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnBrowseControlFile = new System.Windows.Forms.RibbonButton();
            this.btnBrowseControlFolder = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnCompareFiles = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.btnAbout = new System.Windows.Forms.RibbonButton();
            this.btnSettings = new System.Windows.Forms.RibbonButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lstStudentFiles = new System.Windows.Forms.ListBox();
            this.txtControlFilePath = new System.Windows.Forms.TextBox();
            this.lblControlFilePath = new System.Windows.Forms.Label();
            this.lblStudentFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // ribbon
             
            this.ribbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
             
             
            
            this.ribbon.OrbDropDown.BorderRoundness = 8;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbImage = null;
            this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.Size = new System.Drawing.Size(800, 100);
            this.ribbon.TabIndex = 0;
            this.ribbon.Tabs.Add(this.ribbonTab1);
            this.ribbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
             
            // ribbonTab1
             
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "File";
             
            // ribbonPanel1
             
            this.ribbonPanel1.Items.Add(this.btnBrowseControlFile);
            this.ribbonPanel1.Items.Add(this.btnBrowseControlFolder);
            this.ribbonPanel1.Text = "Open";
            
            // btnBrowseControlFile
            
            this.btnBrowseControlFile.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseControlFile.Image")));
            this.btnBrowseControlFile.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseControlFile.SmallImage")));
            this.btnBrowseControlFile.Text = "Browse File";
            
            // btnBrowseControlFolder
             
            this.btnBrowseControlFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseControlFolder.Image")));
            this.btnBrowseControlFolder.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseControlFolder.SmallImage")));
            this.btnBrowseControlFolder.Text = "Browse Folder";
            
            // ribbonPanel2
             
            this.ribbonPanel2.Items.Add(this.btnCompareFiles);
            this.ribbonPanel2.Text = "Actions";
            
            // btnCompareFiles
            
            this.btnCompareFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnCompareFiles.Image")));
            this.btnCompareFiles.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCompareFiles.SmallImage")));
            this.btnCompareFiles.Text = "Compare Files";
             
            // ribbonPanel3
            
            this.ribbonPanel3.Items.Add(this.btnAbout);
            this.ribbonPanel3.Items.Add(this.btnSettings);
            this.ribbonPanel3.Text = "Help";
             
            // btnAbout
             
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.SmallImage")));
            this.btnAbout.Text = "About";
            
            // btnSettings
            
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.SmallImage")));
            this.btnSettings.Text = "Settings";
             
            // checkedListBox1
             
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(500, 150);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(236, 154);
            this.checkedListBox1.TabIndex = 4;
            
            // lstStudentFiles
             
            this.lstStudentFiles.AllowDrop = true;
            this.lstStudentFiles.FormattingEnabled = true;
            this.lstStudentFiles.Location = new System.Drawing.Point(20, 150);
            this.lstStudentFiles.Name = "lstStudentFiles";
            this.lstStudentFiles.Size = new System.Drawing.Size(460, 238);
            this.lstStudentFiles.TabIndex = 2;
            this.lstStudentFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstStudentFiles_DragDrop);
            this.lstStudentFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstStudentFiles_DragEnter);
            
            // txtControlFilePath
            
            this.txtControlFilePath.Location = new System.Drawing.Point(0, 107);
            this.txtControlFilePath.Name = "txtControlFilePath";
            this.txtControlFilePath.ReadOnly = true;
            this.txtControlFilePath.Size = new System.Drawing.Size(460, 20);
            this.txtControlFilePath.TabIndex = 1;
            this.txtControlFilePath.TextChanged += new System.EventHandler(this.txtControlFilePath_TextChanged);
            // 
            // lblControlFilePath
            // 
            this.lblControlFilePath.Location = new System.Drawing.Point(-3, 94);
            this.lblControlFilePath.Name = "lblControlFilePath";
            this.lblControlFilePath.Size = new System.Drawing.Size(460, 20);
            this.lblControlFilePath.TabIndex = 5;
            this.lblControlFilePath.Text = "Control File/Folder Path:";
            this.lblControlFilePath.Click += new System.EventHandler(this.lblControlFilePath_Click);
            
            // lblStudentFiles
            
            this.lblStudentFiles.Location = new System.Drawing.Point(20, 130);
            this.lblStudentFiles.Name = "lblStudentFiles";
            this.lblStudentFiles.Size = new System.Drawing.Size(460, 20);
            this.lblStudentFiles.TabIndex = 6;
            this.lblStudentFiles.Text = "Student Files:";
             
            // Form1
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lstStudentFiles);
            this.Controls.Add(this.txtControlFilePath);
            this.Controls.Add(this.lblControlFilePath);
            this.Controls.Add(this.lblStudentFiles);
            this.Controls.Add(this.ribbon);
            this.Name = "Form1";
            this.Text = "Word File Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
