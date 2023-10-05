using System.Drawing;
using System.Windows.Forms;

namespace Distribution
{
    public partial class MainForm
    {
        private void InitializeComponent()
        {
            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Distribution";

            ResumeLayout(true);
        }
    }
}
