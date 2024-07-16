using System;
using System.Windows.Forms;

namespace WordFileChecker
{
    public partial class OptionsForm : Form
    {
        public string SelectedPercentage { get; private set; }
        public string SelectedColor { get; private set; }

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedPercentage = cmbPercentage.SelectedItem?.ToString();
            SelectedColor = cmbColor.SelectedItem?.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
