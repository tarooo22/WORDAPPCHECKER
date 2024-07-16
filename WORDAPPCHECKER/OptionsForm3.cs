using System;
using System.Windows.Forms;

namespace WordFileChecker
{
    public partial class OptionsForm3 : Form
    {
        public string SelectedFontFamily { get; private set; }
        public string SelectedPercentage { get; private set; }

        public OptionsForm3()
        {
            InitializeComponent();
            InitializeFontList();
            InitializeEventHandlers();
        }

        private void InitializeFontList()
        {
            
            lstFonts.Items.Add("Calibri Light (Headings)");
            lstFonts.Items.Add("Calibri (Body)");
            lstFonts.Items.Add("Sylfaen");
            lstFonts.Items.Add("Agency FB");
            lstFonts.Items.Add("Algerian");
            lstFonts.Items.Add("Aptos");
            lstFonts.Items.Add("Aptos Display");
            lstFonts.Items.Add("Aptos Narrow");
            lstFonts.Items.Add("Arial");
            lstFonts.Items.Add("Arial Black");
            lstFonts.Items.Add("Arial Narrow");
            lstFonts.Items.Add("Arial Nova");
            lstFonts.Items.Add("Arial Rounded MT Bold");
            lstFonts.Items.Add("Bahnschrift");
            lstFonts.Items.Add("Bahnschrift Condensed");
            lstFonts.Items.Add("Bahnschrift Light");
            lstFonts.Items.Add("Bahnschrift Light Condensed");
            //სხვა ფერებიც დაემატება..
        }

        private void InitializeEventHandlers()
        {
            btnOK.Click += btnOK_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstFonts.SelectedItem != null)
            {
                SelectedFontFamily = lstFonts.SelectedItem.ToString();
                SelectedPercentage = txtPercentage.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a font.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OptionsForm3_Load(object sender, EventArgs e)
        {

        }
    }
}
