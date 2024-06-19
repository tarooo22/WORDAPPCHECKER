namespace WordFileChecker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtControlFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseControlFile = new System.Windows.Forms.Button();
            this.btnBrowseControlFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lstStudentFiles = new System.Windows.Forms.ListBox();
            this.btnCompareFiles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtControlFilePath);
            this.groupBox1.Controls.Add(this.btnBrowseControlFile);
            this.groupBox1.Controls.Add(this.btnBrowseControlFolder);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecture Word File/Folder";
            // 
            // txtControlFilePath
            // 
            this.txtControlFilePath.Location = new System.Drawing.Point(5, 19);
            this.txtControlFilePath.Name = "txtControlFilePath";
            this.txtControlFilePath.ReadOnly = true;
            this.txtControlFilePath.Size = new System.Drawing.Size(578, 20);
            this.txtControlFilePath.TabIndex = 1;
            // 
            // btnBrowseControlFile
            // 
            this.btnBrowseControlFile.Location = new System.Drawing.Point(588, 19);
            this.btnBrowseControlFile.Name = "btnBrowseControlFile";
            this.btnBrowseControlFile.Size = new System.Drawing.Size(64, 20);
            this.btnBrowseControlFile.TabIndex = 0;
            this.btnBrowseControlFile.Text = "Browse File";
            this.btnBrowseControlFile.UseVisualStyleBackColor = true;
            this.btnBrowseControlFile.Click += new System.EventHandler(this.btnBrowseControlFile_Click);
            // 
            // btnBrowseControlFolder
            // 
            this.btnBrowseControlFolder.Location = new System.Drawing.Point(588, 45);
            this.btnBrowseControlFolder.Name = "btnBrowseControlFolder";
            this.btnBrowseControlFolder.Size = new System.Drawing.Size(64, 20);
            this.btnBrowseControlFolder.TabIndex = 2;
            this.btnBrowseControlFolder.Text = "Browse Folder";
            this.btnBrowseControlFolder.UseVisualStyleBackColor = true;
            this.btnBrowseControlFolder.Click += new System.EventHandler(this.btnBrowseControlFolder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.lstStudentFiles);
            this.groupBox2.Controls.Add(this.btnCompareFiles);
            this.groupBox2.Location = new System.Drawing.Point(10, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Word Files";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(416, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(236, 154);
            this.checkedListBox1.TabIndex = 4;
            // 
            // lstStudentFiles
            // 
            this.lstStudentFiles.AllowDrop = true;
            this.lstStudentFiles.FormattingEnabled = true;
            this.lstStudentFiles.Location = new System.Drawing.Point(5, 19);
            this.lstStudentFiles.Name = "lstStudentFiles";
            this.lstStudentFiles.Size = new System.Drawing.Size(266, 251);
            this.lstStudentFiles.TabIndex = 2;
            this.lstStudentFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstStudentFiles_DragDrop);
            this.lstStudentFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstStudentFiles_DragEnter);
            // 
            // btnCompareFiles
            // 
            this.btnCompareFiles.Location = new System.Drawing.Point(5, 282);
            this.btnCompareFiles.Name = "btnCompareFiles";
            this.btnCompareFiles.Size = new System.Drawing.Size(655, 29);
            this.btnCompareFiles.TabIndex = 3;
            this.btnCompareFiles.Text = "Start";
            this.btnCompareFiles.UseVisualStyleBackColor = true;
            this.btnCompareFiles.Click += new System.EventHandler(this.btnCompareFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Word File Comparer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtControlFilePath;
        private System.Windows.Forms.Button btnBrowseControlFile;
        private System.Windows.Forms.Button btnBrowseControlFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstStudentFiles;
        private System.Windows.Forms.Button btnCompareFiles;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
