using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;

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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (file.EndsWith(".doc") || file.EndsWith(".docx"))
                {
                    lstStudentFiles.Items.Add(file);
                }
            }
        }

        private void btnCompareFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(controlFilePath) && string.IsNullOrEmpty(controlFolderPath))
            {
                MessageBox.Show("Please select the control Word file or folder first.");
                return;
            }

            if (lstStudentFiles.Items.Count == 0)
            {
                MessageBox.Show("Please drop student Word files to compare.");
                return;
            }

            foreach (string studentFilePath in lstStudentFiles.Items)
            {
                CompareDocuments(controlFilePath, studentFilePath);
            }

            MessageBox.Show("shedareba dasrulda.");
        }

        private void CompareDocuments(string controlFilePath, string studentFilePath)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document controlDoc = null;
            Microsoft.Office.Interop.Word.Document studentDoc = null;

            try
            {
                controlDoc = wordApp.Documents.Open(controlFilePath);
                studentDoc = wordApp.Documents.Open(studentFilePath);

                object missing = Type.Missing;
                wordApp.CompareDocuments(
                    OriginalDocument: controlDoc,
                    RevisedDocument: studentDoc,
                    Destination: WdCompareDestination.wdCompareDestinationNew,
                    Granularity: WdGranularity.wdGranularityWordLevel,
                    CompareFormatting: true,
                    CompareCaseChanges: false,
                    CompareWhitespace: false,
                    CompareTables: true,
                    CompareHeaders: true,
                    CompareFootnotes: true,
                    CompareTextboxes: true,
                    CompareFields: true,
                    CompareComments: true,
                    CompareMoves: true
                );

                string resultPath = string.Empty;

                if (!string.IsNullOrEmpty(controlFolderPath))
                {
                    resultPath = Path.Combine(
                        controlFolderPath,
                        $"{Path.GetFileNameWithoutExtension(studentFilePath)}_comparison{Path.GetExtension(studentFilePath)}"
                    );
                }
                else
                {
                    resultPath = Path.Combine(
                        Path.GetDirectoryName(studentFilePath),
                        $"{Path.GetFileNameWithoutExtension(studentFilePath)}_comparison{Path.GetExtension(studentFilePath)}"
                    );
                }

                Microsoft.Office.Interop.Word.Document comparedDoc = wordApp.ActiveDocument;
                comparedDoc.SaveAs2(resultPath);

                comparedDoc.Close(false);

                controlDoc.Close(false);
                studentDoc.Close(false);

                AddWordToList($"shedareba dasrulda : {Path.GetFileName(studentFilePath)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                wordApp.Quit();
            }
        }

        private void AddWordToList(string word)
        {
            if (checkedListBox1.InvokeRequired)
            {
                Invoke(new Action<string>(AddWordToList), word);
            }
            else
            {
                checkedListBox1.Items.Add(word);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
