using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Distribution
{
    public partial class MainForm
    {
        private GroupBox parameterBox;
        private GroupBox distributionBox;

        private Chart chart;
        private ChartArea chartArea;
        private Series chartSeries;

        private Button generateButton;
        private Button clearButton;

        private Label label1;
        private Label label2;

        private NumericUpDown upDown1;
        private NumericUpDown upDown2;

        private void InitializeComponent()
        {
            parameterBox = new GroupBox();
            distributionBox = new GroupBox();

            chart = new Chart();
            chartArea = new ChartArea();
            chartSeries = new Series();

            generateButton = new Button();
            clearButton = new Button();

            label1 = new Label();
            label2 = new Label();

            upDown1 = new NumericUpDown();
            upDown2 = new NumericUpDown();

            parameterBox.SuspendLayout();
            distributionBox.SuspendLayout();

            SuspendLayout();

            //
            // parameterBox.
            //
            parameterBox.Controls.AddRange(new Control[]
            {
                label1,
                label2,
                upDown1,
                upDown2
            });

            parameterBox.Location = new Point(5, 5);
            parameterBox.Margin = new Padding(0, 0, 0, 0);
            parameterBox.Name = "parameterBox";
            parameterBox.Size = new Size(300, 95);
            parameterBox.TabIndex = 0;
            parameterBox.Text = "Parameters";

            //
            // distributionBox.
            //
            distributionBox.Location = new Point(5, 105);
            distributionBox.Margin = new Padding(0, 0, 0, 0);
            distributionBox.Name = "distributionBox";
            distributionBox.Size = new Size(300, 490);
            distributionBox.TabIndex = 0;
            distributionBox.Text = "Distributions";

            //
            // chart.
            //
            chart.ChartAreas.Add(chartArea);
            chart.Location = new Point(310, 15);
            chart.Margin = new Padding(0, 0, 0, 0);
            chart.Name = "chart";
            chart.Series.Add(chartSeries);
            chart.Size = new Size(885, 545);
            chart.TabIndex = 0;
            chart.TabStop = false;

            //
            // chartArea.
            //
            chartArea.Name = "chartArea";

            //
            // chartSeries.
            //
            chartSeries.Name = "chartSeries";

            //
            // generateButton.
            //
            generateButton.Click += GenerateButtonClick;
            generateButton.Location = new Point(310, 565);
            generateButton.Margin = new Padding(0, 0, 0, 0);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(440, 30);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate";

            //
            // clearButton.
            //
            clearButton.Click += ClearButtonClick;
            clearButton.Location = new Point(755, 565);
            clearButton.Margin = new Padding(0, 0, 0, 0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(440, 30);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";

            //
            // label1.
            //
            label1.Font = new Font(label1.Font, FontStyle.Italic);
            label1.Location = new Point(5, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.Text = "N";
            label1.TextAlign = ContentAlignment.MiddleLeft;

            //
            // label2.
            //
            label2.Font = new Font(label2.Font, FontStyle.Italic);
            label2.Location = new Point(5, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.Text = "M";
            label2.TextAlign = ContentAlignment.MiddleLeft;

            //
            // upDown1.
            //
            upDown1.Location = new Point(70, 25);
            upDown1.Maximum = 100_000_000;
            upDown1.Minimum = 100;
            upDown1.Name = "upDown1";
            upDown1.Size = new Size(225, 30);

            upDown1.Value = 10_000;

            //
            // upDown2.
            //
            upDown2.Location = new Point(70, 60);
            upDown2.Maximum = 1_000;
            upDown2.Minimum = 10;
            upDown2.Name = "upDown2";
            upDown2.Size = new Size(225, 30);

            upDown2.Value = 100;

            //
            // MainForm.
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Distribution";

            Controls.AddRange(new GroupBox[]
            {
                parameterBox,
                distributionBox
            });

            Controls.Add(chart);

            Controls.AddRange(new Button[]
            {
                generateButton,
                clearButton
            });

            parameterBox.ResumeLayout(true);
            distributionBox.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
