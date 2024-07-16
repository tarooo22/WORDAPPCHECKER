using System;
using System.Windows.Forms;

namespace WordFileChecker
{
    public partial class OptionsForm1 : Form
    {
        public string SelectedFontColor { get; private set; }
        public string SelectedFontPercentage { get; private set; }

        public OptionsForm1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedFontColor = cmbFontColor.SelectedItem.ToString();
            SelectedFontPercentage = txtFontPercentage.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OptionsForm1_Load(object sender, EventArgs e)
        {
            
            cmbFontColor.Items.AddRange(new string[]
            {
                "Red", "Green", "Yellow", "Green, Accent 6", "Blue, Accent 1", "Blue, Accent 5",
                "Orange, Accent 2", "Light Gray", "Light Blue", "Orange", "Blue", "Dark Blue",
                "Purple", "White", "Blue-Gray", "Brown", "Black", "Silver", "Dark Gray",
                "Crimson", "Hot Pink", "Deep Pink", "Pink", "Magenta", "Gray", "Gold",
                "Goldenrod", "Dark Goldenrod", "Indian Red", "Light Green", "Lime Green",
                "Forest Green", "Dark Green", "Dark Olive Green", "Olive", "Cyan",
                "Light Cyan", "Dark Turquoise", "Teal", "Deep Sky Blue", "Dodge Blue",
                "Cornflower Blue", "Dark Slate Blue", "Slate Blue", "Chartreuse", "Tan",
                "Khaki", "Dark Khaki", "Wheat"
            });

            cmbFontColor.SelectedIndex = 0; 
        }
    }
}
