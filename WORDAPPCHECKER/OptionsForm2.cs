using System;
using System.Windows.Forms;

namespace WordFileChecker
{
    public partial class OptionsForm2 : Form
    {
        public string SelectedFontSize { get; private set; }
        public string SelectedPercentage { get; private set; }

        public OptionsForm2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedFontSize = txtFontSize.Text;
            SelectedPercentage = txtPercentage.Text;

            if (string.IsNullOrEmpty(SelectedFontSize) || string.IsNullOrEmpty(SelectedPercentage))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OptionsForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
