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

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;

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

            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();

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
            distributionBox.Controls.AddRange(new RadioButton[]
            {
                radioButton1,
                radioButton2,
                radioButton3,
                radioButton4,
                radioButton5,
                radioButton6,
                radioButton7
            });

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
            // radioButton1.
            //
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton1.Location = new Point(5, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(200, 30);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "Uniform";

            //
            // radioButton2.
            //
            radioButton2.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton2.Location = new Point(5, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(200, 30);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Gauss";

            //
            // radioButton3.
            //
            radioButton3.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton3.Location = new Point(5, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(200, 30);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "Exponential";

            //
            // radioButton4.
            //
            radioButton4.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton4.Location = new Point(5, 130);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(200, 30);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Gamma";

            //
            // radioButton5.
            //
            radioButton5.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton5.Location = new Point(5, 165);
            radioButton5.Name = "radioButton4";
            radioButton5.Size = new Size(200, 30);
            radioButton5.TabIndex = 3;
            radioButton5.Text = "TriangleMax";

            //
            // radioButton6.
            //
            radioButton6.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton6.Location = new Point(5, 200);
            radioButton6.Name = "radioButton4";
            radioButton6.Size = new Size(200, 30);
            radioButton6.TabIndex = 3;
            radioButton6.Text = "TriangleMin";

            //
            // radioButton7.
            //
            radioButton7.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton7.Location = new Point(5, 235);
            radioButton7.Name = "radioButton4";
            radioButton7.Size = new Size(200, 30);
            radioButton7.TabIndex = 3;
            radioButton7.Text = "Simpson";

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
