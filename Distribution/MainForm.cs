using System;
using System.Windows.Forms;

namespace Distribution
{
    /// <summary>
    /// Represents the main window of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckBoxCheckedChange(Object sender, EventArgs args)
        {

        }

        private void GenerateButtonClick(Object sender, EventArgs args)
        {
            Text = "Distribution — Generating…";

            Text = "Distribution — Done!";
        }

        private void ClearButtonClick(Object sender, EventArgs args)
        {
            Text = "Distribution";
        }
    }
}
