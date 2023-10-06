using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Distribution.Algorithms;
using Distribution.Generators;
using Distribution.Utilities;

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
            chartSeries.IsValueShownAsLabel = checkBox.Checked;
        }

        private void GenerateButtonClick(Object sender, EventArgs args)
        {
            Text = "Distribution — Generating…";

            List<Double> values = new List<Double>();

            IRandomable generator = new MPM(19_283_865, 9_817_279_234_659);

            if (generatorButton2.Checked)
            {
                generator = new LFSR(UInt64.MaxValue - 103_875_636_285);
            }

            IDistributable distribution = new Uniform(generator, 10, 15);

            UInt64 n = (UInt64)parameterUpDown1.Value;

            for (UInt64 i = 0; i < n; i++)
            {
                values.Add(distribution.Next());
            }

            Double expectE = 0.0;
            Double expectV = 0.0;

            expectE = (10 + 15) / 2.0;
            expectV = (15 - 10) * (15 - 10) / 12;

            Double computeE = Expectation.Compute(values);
            Double computeV = Variation.Compute(values);

            expectedTextBox1.Text = String.Format("{0}", expectE);
            expectedTextBox2.Text = String.Format("{0}", expectV);

            computedTextBox1.Text = String.Format("{0}", computeE);
            computedTextBox2.Text = String.Format("{0}", computeV);

            UInt64 m = (UInt64)parameterUpDown2.Value;

            UInt64[] counts = new UInt64[m];

            Double min = values.Min();
            Double max = values.Max();

            foreach (Double value in values)
            {
                UInt64 index = (UInt64)Math.Floor(m * (value - min) / (max - min));

                if (index >= m)
                {
                    index = m - 1;
                }

                counts[index] += 1;
            }

            chartSeries.Points.Clear();

            for (UInt64 i = 0; i < m; i++)
            {
                chartSeries.Points.AddXY(i, counts[i]);
            }

            Text = "Distribution — Done!";
        }

        private void ClearButtonClick(Object sender, EventArgs args)
        {
            Text = "Distribution";

            chartSeries.Points.Clear();

            expectedTextBox1.Text = "";
            expectedTextBox2.Text = "";

            computedTextBox1.Text = "";
            computedTextBox2.Text = "";
        }
    }
}
