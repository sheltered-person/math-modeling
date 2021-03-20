using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSVModeling
{
    public partial class Form1 : Form
    {
        private IDistribution[] distributions;
        private string[] distLabels;
        private int[] freqSizes;

        private int distNum;
        private int sampleSize = 1000;

        private List<double> sample;

        public Form1()
        {
            InitializeComponent();

            distributions = new IDistribution[4];

            distributions[0] = new GeometricDistribution(0.3);
            distributions[1] = new BinomialDistribution(4, 0.2);
            distributions[2] = new BernoulliDistribution(0.2013);
            distributions[3] = new BinomialDistribution(8, 0.5);

            distLabels = new string[4];

            for (int i = 0; i < 4; i++)
                distLabels[i] = distributions[i].Name;

            freqSizes = new int[4];

            freqSizes[0] = 22;
            freqSizes[1] = 8;
            freqSizes[2] = 4;
            freqSizes[3] = 10;

            chart.Series.Add("line");
            funcChart.Series.Clear();
            funcChart.Series.Add("func");
            funcChart.Series.Add("sampleFunc");

            distNum = 1;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            DistributionTester tester = new DistributionTester(sampleSize);

            distributionLabel.Text = distLabels[distNum];

            meanLabel.Text = distributions[distNum].Mean().ToString();
            sampleMeanLabel.Text = tester.SampleMean(distributions[distNum]).ToString();

            varianceLabel.Text = distributions[distNum].Variance().ToString();
            sampleVarianceLabel.Text = tester.SampleVariance(distributions[distNum]).ToString();

            skewnessLabel.Text = distributions[distNum].Skewness().ToString();
            sampleSkewnessLabel.Text = tester.SampleSkewness(distributions[distNum]).ToString();

            kurtosisLabel.Text = distributions[distNum].Kurtosis().ToString();
            sampleKurtosisLabel.Text = tester.SampleKurtosis(distributions[distNum]).ToString();

            sample = SampleGenerator.GenerateSample(distributions[distNum], sampleSize);

            chiLabel.Text = ChiSquared(sample).ToString();

            PaintChart();
            chart.Visible = true;

            distNum++;
            distNum = distNum % 4;
        }

        private void PaintChart()
        {
            chart.Series[0].Points.Clear();
            chart.Series["line"].Points.Clear();
            funcChart.Series["sampleFunc"].Points.Clear();
            funcChart.Series["func"].Points.Clear();

            chart.Series[0].ChartType = SeriesChartType.Column;
            chart.Series["line"].ChartType = SeriesChartType.Spline;
            chart.Series["line"].BorderWidth = 2;
            funcChart.Series["sampleFunc"].ChartType = SeriesChartType.Spline;
            funcChart.Series["sampleFunc"].BorderWidth = 2;
            funcChart.Series["func"].ChartType = SeriesChartType.Spline;
            funcChart.Series["func"].BorderWidth = 2;

            int size = freqSizes[distNum];
            int[] frequency = new int[size];

            for (int i = 0; i < sampleSize; i++)
            {
                int val = (int)(sample[i]);
                frequency[val]++;
            }

            for (int i = 0; i < size; i++)
            {
                chart.Series[0].Points.AddY(frequency[i]);
                chart.Series["line"].Points.AddXY(i + 1, distributions[distNum].PMF(i) * 1000);
                funcChart.Series["sampleFunc"].Points.AddXY(i + 1, SamplePMF(sample, i + 1) * 1000);
                funcChart.Series["func"].Points.AddXY(i + 1, distributions[distNum].CDF(i) * 1000);
            }
        }

        private double SamplePMF(List<double> sample, double x)
        {
            double amount = 0.0;

            foreach(var element in sample)
            {
                if (element < x)
                    amount++;
            }

            return amount / sample.Count;
        }

        private static int freeDeg = 26;
        private static double lvl = 37.7;

        private bool ChiSquared(List<double> sample)
        {
            int[] hits = new int[freeDeg];
            double chi2 = 0;
            double probability = 1.0 / freeDeg;

            for (int i = 0; i < sampleSize; i++)
            { 
                int idx = (int)(sample[i] * freeDeg / freqSizes[distNum]);
                ++hits[idx];
            }

            for (int i = 0; i < freeDeg; i++)
                chi2 += ((double)hits[i] / sampleSize - probability) 
                    * ((double)hits[i] / sampleSize - probability) / probability;

            return lvl > chi2;
        }
    }
}
