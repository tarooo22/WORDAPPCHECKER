using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;
using WordApp = Microsoft.Office.Interop.Word.Application;

namespace WordFileChecker
{
    public partial class Form1 : Form
    {
        private string controlFilePath;
        private string controlFolderPath;

        public Form1()
        {
            InitializeComponent();
            InitializeCheckedListBox();

            
            btnBrowseControlFile.Click += btnBrowseControlFile_Click;
            btnBrowseControlFolder.Click += btnBrowseControlFolder_Click;
            btnCompareFiles.Click += btnCompareFiles_Click;
            btnAbout.Click += btnAbout_Click;
            btnSettings.Click += btnSettings_Click;
        }

        private void InitializeCheckedListBox()
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("ფუნქცია 1");
            checkedListBox1.Items.Add("ფუნქცია 2");
            checkedListBox1.Items.Add("ფუნქცია 3");
        }

        private void btnBrowseControlFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Files|*.doc;*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                controlFilePath = openFileDialog.FileName;
                txtControlFilePath.Text = controlFilePath;
                controlFolderPath = null;
            }
        }

        private void btnBrowseControlFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    controlFolderPath = folderDialog.SelectedPath;
                    txtControlFilePath.Text = controlFolderPath;
                    controlFilePath = null;
                }
            }
        }

        private void lstStudentFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lstStudentFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                lstStudentFiles.Items.AddRange(files);
            }
        }

        private void btnCompareFiles_Click(object sender, EventArgs e)
        {
            if (controlFilePath == null && controlFolderPath == null)
            {
                MessageBox.Show("Please select a control file or folder.");
                return;
            }

            if (lstStudentFiles.Items.Count == 0)
            {
                MessageBox.Show("Please add student files to compare.");
                return;
            }

            foreach (string studentFile in lstStudentFiles.Items)
            {
                if (controlFilePath != null)
                {
                    CompareFiles(controlFilePath, studentFile);
                }
                else if (controlFolderPath != null)
                {
                    string controlFile = Path.Combine(controlFolderPath, Path.GetFileName(studentFile));
                    if (File.Exists(controlFile))
                    {
                        CompareFiles(controlFile, studentFile);
                    }
                    else
                    {
                        MessageBox.Show($"Control file for {Path.GetFileName(studentFile)} not found.");
                    }
                }
            }
        }

        private void CompareFiles(string controlFilePath, string studentFilePath)
        {
            WordApp wordApp = new WordApp();
            Document controlDoc = null;
            Document studentDoc = null;

            try
            {
               
                controlDoc = wordApp.Documents.Open(controlFilePath);

                studentDoc = wordApp.Documents.Open(studentFilePath);

                
                string resultPath = Path.Combine(Path.GetDirectoryName(studentFilePath), $"{Path.GetFileNameWithoutExtension(studentFilePath)}_ComparisonResult.docx");

                
                controlDoc.SaveAs2(resultPath); 

                
                MessageBox.Show($"Comparison of {Path.GetFileName(studentFilePath)} completed. Results saved to {resultPath}");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                
                if (controlDoc != null) controlDoc.Close(false);
                if (studentDoc != null) studentDoc.Close(false);
                wordApp.Quit();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtControlFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblControlFilePath_Click(object sender, EventArgs e)
        {

        }
    }
}
