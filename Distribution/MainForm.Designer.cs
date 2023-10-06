using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Distribution
{
    public partial class MainForm
    {
        private GroupBox parameterBox;
        private GroupBox expectedBox;
        private GroupBox distributionBox;

        private Chart chart;
        private ChartArea chartArea;
        private Series chartSeries;

        private CheckBox checkBox;

        private Button generateButton;
        private Button clearButton;

        private Label label1;
        private Label label2;

        private NumericUpDown upDown1;
        private NumericUpDown upDown2;

        private RadioButton distButton1;
        private RadioButton distButton2;
        private RadioButton distButton3;
        private RadioButton distButton4;
        private RadioButton distButton5;
        private RadioButton distButton6;

        private void InitializeComponent()
        {
            parameterBox = new GroupBox();
            expectedBox = new GroupBox();
            distributionBox = new GroupBox();

            chart = new Chart();
            chartArea = new ChartArea();
            chartSeries = new Series();

            checkBox = new CheckBox();

            generateButton = new Button();
            clearButton = new Button();

            label1 = new Label();
            label2 = new Label();

            upDown1 = new NumericUpDown();
            upDown2 = new NumericUpDown();

            distButton1 = new RadioButton();
            distButton2 = new RadioButton();
            distButton3 = new RadioButton();
            distButton4 = new RadioButton();
            distButton5 = new RadioButton();
            distButton6 = new RadioButton();

            parameterBox.SuspendLayout();
            expectedBox.SuspendLayout();
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
            parameterBox.Name = "parameterBox";
            parameterBox.Size = new Size(300, 95);
            parameterBox.Text = "Parameters";

            //
            // expectedBox.
            //
            expectedBox.Location = new Point(5, 105);
            expectedBox.Name = "expectedBox";
            expectedBox.Size = new Size(300, 95);
            expectedBox.Text = "Expected";

            //
            // distributionBox.
            //
            distributionBox.Controls.AddRange(new RadioButton[]
            {
                distButton1,
                distButton2,
                distButton3,
                distButton4,
                distButton5,
                distButton6
            });

            distributionBox.Location = new Point(5, 205);
            distributionBox.Name = "distributionBox";
            distributionBox.Size = new Size(300, 355);
            distributionBox.Text = "Distributions";

            //
            // chart.
            //
            chart.ChartAreas.Add(chartArea);
            chart.Location = new Point(310, 15);
            chart.Name = "chart";
            chart.Series.Add(chartSeries);
            chart.Size = new Size(885, 545);
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
            // checkBox.
            //
            checkBox.CheckedChanged += CheckBoxCheckedChange;
            checkBox.Location = new Point(5, 565);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(300, 30);
            checkBox.Text = "Show Labels";

            //
            // generateButton.
            //
            generateButton.Click += GenerateButtonClick;
            generateButton.Location = new Point(310, 565);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(440, 30);
            generateButton.Text = "Generate";

            //
            // clearButton.
            //
            clearButton.Click += ClearButtonClick;
            clearButton.Location = new Point(755, 565);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(440, 30);
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
            // distButton1.
            //
            distButton1.Checked = true;
            distButton1.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            distButton1.Location = new Point(5, 25);
            distButton1.Name = "radioButton1";
            distButton1.Size = new Size(200, 30);
            distButton1.Text = "Uniform";

            //
            // distButton2.
            //
            distButton2.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            distButton2.Location = new Point(5, 60);
            distButton2.Name = "radioButton2";
            distButton2.Size = new Size(200, 30);
            distButton2.Text = "Gauss";

            //
            // distButton3.
            //
            distButton3.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            distButton3.Location = new Point(5, 95);
            distButton3.Name = "radioButton3";
            distButton3.Size = new Size(200, 30);
            distButton3.Text = "Exponential";

            //
            // distButton4.
            //
            distButton4.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            distButton4.Location = new Point(5, 130);
            distButton4.Name = "radioButton4";
            distButton4.Size = new Size(200, 30);
            distButton4.Text = "Gamma";

            //
            // distButton5.
            //
            distButton5.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            distButton5.Location = new Point(5, 165);
            distButton5.Name = "radioButton4";
            distButton5.Size = new Size(200, 30);
            distButton5.Text = "Triangle";

            //
            // distButton7.
            //
            distButton6.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            distButton6.Location = new Point(5, 200);
            distButton6.Name = "radioButton4";
            distButton6.Size = new Size(200, 30);
            distButton6.Text = "Simpson";

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
                expectedBox,
                distributionBox
            });

            Controls.Add(chart);

            Controls.Add(checkBox);

            Controls.AddRange(new Button[]
            {
                generateButton,
                clearButton
            });

            parameterBox.ResumeLayout(true);
            expectedBox.ResumeLayout(true);
            distributionBox.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
