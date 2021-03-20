using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;

namespace BSVModeling
{
    public class AccuracyTester
    {
        public double epsilon;

        Chart chart;

        Func<double, double> NormalDistribution;


        public AccuracyTester(double epsilon)
        {
            this.epsilon = epsilon;

            chart = new Chart();
            NormalDistribution = chart.DataManipulator.Statistics.NormalDistribution;
        }


        public bool TestGMM(IGenerator random, int sampleSize)
        {
            List<double> sample = SampleGenerator.GenerateSample(random, sampleSize);

            double
                E = sample.Average(),
                D = 0;

            for (int i = 0; i < sampleSize; i++)
                D += Math.Pow(E - sample[i], 2);

            D /= sampleSize - 1;

            double[] x = new double[2];

            x[0] = E - 0.5;
            x[1] = D - 1 / 12;

            double[] c = new double[2];

            c[0] = Math.Sqrt(12 * sampleSize);

            c[1] = (sampleSize - 1) / sampleSize / Math.Sqrt((0.0056 / sampleSize 
                + 0.0028 / Math.Pow(sampleSize, 2) - 0.0083 / Math.Pow(sampleSize, 3)));

            double[] P = new double[2];

            bool[] res = new bool[2];

            for (int i = 0; i < 2; i++)
            {
                P[i] = 2 * (1 - NormalDistribution(c[i] * Math.Abs(x[i])));
                res[i] = epsilon < P[i];
            }

            return res[0] && res[1];
        }


        public bool CovarianceTest(IGenerator random, int sampleSize, int t)
        {
            List<double> sample = SampleGenerator.GenerateSample(random, sampleSize);

            List<double>
                R = new List<double>(),   //^cov
                P = new List<double>();

            double E = sample.Average();

            for (int i = 0; i < sampleSize; i++) 
            {
                int to = sampleSize - i;

                double sum = 0;

                for (int j = 0; j < to; j++)
                    sum += sample[j] * sample[j + sampleSize - to];

                R.Add(1.0 / (sampleSize - i - 1) * sum 
                    - sampleSize / (sampleSize - 1) * E * E);
            }

            double 
                r = 1.0 / 12, //cov
                c = Math.Sqrt(2);

            P.Add(2 * (1.0 - NormalDistribution(12 * Math.Sqrt(sampleSize - 1) 
                * Math.Abs(R[0] - r) / c)));

            r = 0;
            c = 1;

            for (int i = 1; i <= t; i++) 
            {
                P.Add(2 * (1.0 - NormalDistribution(12 * Math.Sqrt(sampleSize - 1)
                * Math.Abs(R[i] - r) / c)));
            }

            for (int i = 0; i <= t; i++) 
            {
                if (epsilon >= P[i])
                    return false;
            }

            return true;
        }


        public bool UniformTwoDimensionalDistributionTest(IGenerator random, int sampleSize, int t)
        {
            List<double> sample = SampleGenerator.GenerateSample(random, sampleSize);

            double 
                deltaR = 0.5 / (t - 1),
                hi = 0;

            int[] frequency = new int[t];

            int m = sampleSize / 2;

            for (int i = 0; i < sampleSize; i += 2) 
            {
                double
                    x = sample[i],
                    y = sample[i + 1];

                bool isInnerPoint = false;

                for (int j = 0; j < t - 1; j++) 
                {
                    if (Math.Pow(x - 0.5, 2) + Math.Pow(y - 0.5, 2)
                        < Math.Pow(deltaR * (j + 1), 2)) 
                    {
                        frequency[j]++;
                        isInnerPoint = true;
                        break;
                    }
                }

                if (!isInnerPoint)
                    frequency[t - 1]++;
            }

            double p;

            for (int i = 0; i < t - 1; i++)
            {
                p = Math.PI * 
                    (Math.Pow(deltaR * (i + 1), 2) - Math.Pow(deltaR * i, 2));

                hi += Math.Pow((frequency[i] - m * p), 2) / (m * p);
            }

            p = 1 - Math.PI * 0.25;

            hi += Math.Pow((frequency[t - 1] - m * p), 2) / (m * p);

            double P = 1 - MathNet.Numerics.Distributions.ChiSquared.CDF(t - 1, hi);

            return epsilon < P;
        }
    }
}
