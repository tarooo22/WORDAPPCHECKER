using System;
using System.Windows.Forms;

namespace WordFileChecker
{
    public partial class OptionsForm4 : Form
    {
        public int MinParagraphCount { get; private set; }
        public int MaxParagraphCount { get; private set; }

        public OptionsForm4()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinParagraphCount.Text, out int min) && int.TryParse(txtMaxParagraphCount.Text, out int max))
            {
                MinParagraphCount = min;
                MaxParagraphCount = max;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for paragraph counts.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OptionsForm4_Load(object sender, EventArgs e)
        {

        }
    }
}
