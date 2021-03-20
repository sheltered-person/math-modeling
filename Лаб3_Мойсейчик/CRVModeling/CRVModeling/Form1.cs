using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRVModeling
{
    public partial class Form1 : Form
    {
        private IDistribution[] distributions;

        private int distAmount;

        private int i;

        private int sampleSize = 10000;


        public Form1()
        {
            InitializeComponent();

            distAmount = 9;
            i = 0;

            distributions = new IDistribution[distAmount];

            distributions[0] = new Normal(0, 64);
            distributions[1] = new Normal(1, 9);
            distributions[2] = new ChiSquared(4);
            distributions[3] = new Laplace(2);
            distributions[4] = new LogNormal(1, 9);
            distributions[5] = new Exponential(2);
            distributions[6] = new BoxMullerNormal(0, 1);

            IDistribution[] mix1 = new IDistribution[2];
            mix1[0] = distributions[2];
            mix1[1] = distributions[3];

            double[] pi1 = new double[2];
            pi1[0] = 0.5;
            pi1[1] = 0.5;

            distributions[7] = new MixtureDistribution(mix1, pi1);

            IDistribution[] mix2 = new IDistribution[2];
            mix2[0] = distributions[4];
            mix2[1] = distributions[5];

            double[] pi2 = new double[2];
            pi2[0] = 0.4;
            pi2[1] = 0.6;

            distributions[8] = new MixtureDistribution(mix2, pi2);

            correlationLabel.Visible = false;
            sampleCorrelationLabel.Visible = false;

            radio48Button.Visible = true;
            radio192Button.Visible = true;

            radio48Button.Checked = true;
            LoadData();
        }

        private void radio48Button_CheckedChanged(object sender, EventArgs e)
        {
            if (radio48Button.Checked)
            {
                (distributions[i] as Normal).N = 48;
                radio192Button.Checked = false;
                LoadData();
            }
        }

        private void radio192Button_CheckedChanged(object sender, EventArgs e)
        {
            if (radio192Button.Checked)
            {
                (distributions[i] as Normal).N = 192;
                radio48Button.Checked = false;
                LoadData();
            }
        }

        private void LoadData()
        {
            distributionLabel.Text = distributions[i].Name;

            meanLabel.Text = distributions[i].Mean().ToString();
            varianceLabel.Text = distributions[i].Variance().ToString();

            DistributionTester tester = new DistributionTester(sampleSize);

            sampleMeanLabel.Text = tester.SampleMean(distributions[i]).ToString();
            sampleVarianceLabel.Text = tester.SampleVariance(distributions[i]).ToString();

            if (i == 6)
                sampleCorrelationLabel.Text = tester.SampleCorrelation(distributions[i]).ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            i++;
            i %= distAmount;

            if (i > 1)
            {
                radio48Button.Visible = false;
                radio192Button.Visible = false;
            }
            else
            {
                radio48Button.Visible = true;
                radio192Button.Visible = true;
            }

            if (i == 6)
            {
                correlationLabel.Visible = true;
                sampleCorrelationLabel.Visible = true;
            }
            else
            {
                correlationLabel.Visible = false;
                sampleCorrelationLabel.Visible = false;
            }

            LoadData();
        }
    }
}
