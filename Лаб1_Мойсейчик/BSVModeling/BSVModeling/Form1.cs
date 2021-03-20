using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSVModeling
{
    public partial class Form1 : Form
    {
        private IGenerator rand;

        private List<double> sample;

        private int sampleSize = 1000;

        private int nextDistribution;


        public Form1()
        {
            InitializeComponent();
            nextDistribution = 0;
        }


        private void runButton_Click(object sender, EventArgs e)
        {
            methodLabel.Text = "";

            element100Label.Text = "";
            element900Label.Text = "";
            element1000Label.Text = "";

            gmmTestLabel.Text = "";
            covariationLabel.Text = "";
            uniOfTwoTestLabel.Text = "";

            dispersionPatternBox.Visible = false;

            if (nextDistribution == 0)
            {
                methodLabel.Text = "Мультипликативный конгруэнтный метод";
                rand = new RandomBSV(24149775, 19581355);
            }
            else
            {
                methodLabel.Text = "Метод Макларена-Марсальи";
                rand = new MacLarenRandom(
                    new RandomBSV(24149775, 19581355),
                    new RandomBSV(179029053, 457816087));
            }

            sample = SampleGenerator.GenerateSample(rand, sampleSize);

            element100Label.Text = sample[99].ToString();
            element900Label.Text = sample[899].ToString();
            element1000Label.Text = sample[999].ToString();

            PaintChart();
            dispersionPatternBox.Visible = true;

            TestAccuracy();

            nextDistribution++;
            nextDistribution %= 2;
        }


        private void PaintChart()
        {
            chart.Series[0].Points.Clear();

            int[] frequency = new int[10];

            for (int i = 0; i < sampleSize; i++)
            {
                int val = (int)(sample[i] * 10);
                frequency[val]++;
            }

            for (int i = 0; i < 10; i++)
                chart.Series[0].Points.AddY(frequency[i]);
        }


        private void TestAccuracy()
        {
            AccuracyTester tester = new AccuracyTester(0.05);

            bool
                gmmTest = tester.TestGMM(rand, sampleSize),
                covarianceTest = tester.CovarianceTest(rand, sampleSize, 30),
                uniOfTwoTest = tester.UniformTwoDimensionalDistributionTest(rand, sampleSize, 100);

            gmmTestLabel.Text = gmmTest.ToString();
            covariationLabel.Text = covarianceTest.ToString();
            uniOfTwoTestLabel.Text = uniOfTwoTest.ToString();
        }


        private void dispersionPatternBox_Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < sampleSize; i += 2)
            {
                float x = (float)sample[i];
                float y = (float)sample[i + 1];

                e.Graphics.DrawEllipse(new Pen(Color.FromArgb(random.Next(256),
                    random.Next(256),
                    random.Next(256)), 3),
                    x * e.ClipRectangle.Width,
                    y * e.ClipRectangle.Height,
                    3,
                    3);
            }
        }
    }
}
