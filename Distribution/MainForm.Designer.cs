using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Distribution
{
    public partial class MainForm
    {
        private GroupBox distributionBox;

        private Chart chart;
        private ChartArea chartArea;
        private Series chartSeries;

        private Button generateButton;
        private Button clearButton;

        private void InitializeComponent()
        {
            distributionBox = new GroupBox();

            chart = new Chart();
            chartArea = new ChartArea();
            chartSeries = new Series();

            generateButton = new Button();
            clearButton = new Button();

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
            // MainForm.
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Distribution";

            Controls.Add(distributionBox);

            Controls.Add(chart);

            Controls.AddRange(new Button[]
            {
                generateButton,
                clearButton
            });

            distributionBox.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
