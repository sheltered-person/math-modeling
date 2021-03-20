using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloIntegration
{
    public partial class Form1 : Form
    {
        private int integralsCount = 2;
        private int sampleSize = 10000;
        private int pointsCount;
        private int i;

        private IIntegrator[] integrals;
        private string[] integralImageFiles;
        private double[] expectedResults;

        public Form1()
        {
            InitializeComponent();

            pointsCount = 100;
            i = 0;

            integrals = new IIntegrator[integralsCount];

            Func<double, double> firstIntegrand = 
                new Func<double, double>((double x) => 
                {
                    return Math.Log(x) * Math.Sin(x);
                });

            Func<double, double, double> secondIntegrand = 
                new Func<double, double, double>((double x, double y) => 
                {
                    double result = Math.Pow(x, 3) + 3 * x * y;
                    return result * Math.Pow(Math.E, y);
                });

            Func<double, double, double> indicator =
                new Func<double, double, double>((double x, double y) =>
                {
                    return Math.Abs(x) + Math.Abs(y) < 1 ? 1.0 : 0.0;
                });

            integrals[0] = new MCIntegrator(
                new Random(), firstIntegrand, 99.0, 88.0);
            integrals[1] = new MCTwoDimensionalIntegrator(
                new Random(), 2.0, indicator, secondIntegrand, 1, 1, -1, -1);

            integralImageFiles = new string[integralsCount];

            integralImageFiles[0] = "logarythmic.jpg";
            integralImageFiles[1] = "twodimension.jpg";

            expectedResults = new double[integralsCount];

            expectedResults[0] = 4.28118;
            expectedResults[1] = 0.0;

            LoadFormContents();
        }

        private void LoadFormContents()
        {
            integralPictureBox.Load(integralImageFiles[i]);

            List<double> sample = new List<double>(sampleSize);

            double max = int.MinValue;
            double min = int.MaxValue;

            for (int j = 0; j < sampleSize; j++)
            {
                sample.Add(integrals[i].Integrate(pointsCount));

                if (sample[j] > max)
                    max = sample[j];

                if (sample[j] < min)
                    min = sample[j];
            }

            resultLabel.Text = string.Format("{0:f5}", sample.Average());
            trueResultLabel.Text = expectedResults[i].ToString();

            BuildChart(sample, min, max - min);
            chart.Visible = true;

            i++;
            i %= integralsCount;
        }

        private void BuildChart(List<double> sample, double min, double delta)
        {
            chart.Series[0].Points.Clear();

            int columnsCount = 30;
            int[] frequency = new int[columnsCount];

            double lenght = delta / (columnsCount - 1);

            for (int i = 0; i < sampleSize; i++)
            {
                int k = (int)((sample[i] - min) / lenght);
                frequency[k]++;
            }

            for (int i = 0; i < columnsCount; i++)
                chart.Series[0].Points.AddXY(
                    string.Format("{0:f3}", min + lenght * i), frequency[i]);
        }

        private void radio100Button_CheckedChanged(object sender, EventArgs e)
        {
            if (radio100Button.Checked)
            {
                radio500Button.Checked = false;
                radio1000Button.Checked = false;

                pointsCount = 100;
            }

            LoadFormContents();
        }

        private void radio500Button_CheckedChanged(object sender, EventArgs e)
        {
            if (radio500Button.Checked)
            {
                radio100Button.Checked = false;
                radio1000Button.Checked = false;

                pointsCount = 500;
            }

            LoadFormContents();
        }

        private void radio1000Button_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1000Button.Checked)
            {
                radio500Button.Checked = false;
                radio100Button.Checked = false;

                pointsCount = 1000;
            }

            LoadFormContents();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            LoadFormContents();
        }
    }
}
