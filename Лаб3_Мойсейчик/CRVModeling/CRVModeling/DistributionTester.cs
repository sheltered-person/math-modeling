using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class DistributionTester
    {
        private int n;
        private List<double> sample;


        public DistributionTester(int sampleSize)
        {
            this.n = sampleSize;
        }

        public double SampleMean(IDistribution distribution)
        {
            sample = SampleGenerator.GenerateSample(distribution, n);

            double sum = 0;
            foreach (double x in sample)
                sum += x;

            return sum / n;
        }

        public double MomentAboutTheMean(IDistribution distribution, int k)
        {
            double xMean = SampleMean(distribution);

            double sum = 0;
            foreach (double x in sample)
                sum += Math.Pow(x - xMean, k);

            return sum / n;
        }

        public double SampleVariance(IDistribution distribution)
        {
            return MomentAboutTheMean(distribution, 2) * n / (n - 1);
        }

        public double SampleSkewness(IDistribution distribution)
        {
            double b = MomentAboutTheMean(distribution, 3);
            return b / Math.Pow(Math.Sqrt(SampleVariance(distribution)), 3);
        }

        public double SampleKurtosis(IDistribution distribution)
        {
            double g = MomentAboutTheMean(distribution, 4);
            return g / Math.Pow(SampleVariance(distribution), 2) - 3;
        }

        public double SampleCorrelation(IDistribution distribution)
        {
            Tuple<List<double>, List<double>> samples 
                = SampleGenerator.GenerateSubsamples(distribution, n);

            double
                _x = samples.Item1.Average(),
                _y = samples.Item2.Average();

            double 
                numerator = 0.0,
                denominator = 0.0;

            for (int i = 0; i < n / 2; i++) 
            {
                numerator += (samples.Item1[i] - _x) * (samples.Item2[i] - _y);
                denominator += Math.Pow(samples.Item1[i] - _x, 2) * Math.Pow(samples.Item2[i] - _y, 2);
            }

            denominator = Math.Sqrt(denominator);
            return numerator / denominator;
        }
    }
}
