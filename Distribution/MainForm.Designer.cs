using System.Drawing;
using System.Windows.Forms;

namespace Distribution
{
    public partial class MainForm
    {
        private GroupBox distributionBox;

        private void InitializeComponent()
        {
            distributionBox = new GroupBox();

            distributionBox.SuspendLayout();

            SuspendLayout();

            //
            // distributionBox.
            //
            distributionBox.Location = new Point(5, 5);
            distributionBox.Margin = new Padding(0, 0, 0, 0);
            distributionBox.Name = "distributionBox";
            distributionBox.Size = new Size(300, 590);
            distributionBox.TabIndex = 0;
            distributionBox.Text = "Distributions";

            //
            // MainForm.
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Distribution";

            Controls.Add(distributionBox);

            distributionBox.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
