using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSVModeling
{
    public class BinomialDistribution : IDistribution
    {
        private int m;
        private double p;

        private RandomBSV random;


        public string Name => "Биномиальное распределение Bi(" + m + ", " + p + ")";


        public BinomialDistribution(int m, double p)
        {
            this.m = m;
            this.p = p;
            this.random = new RandomBSV(24149775, 19581355);
        }

        public double Mean()
        {
            return m * p;
        }

        public double Variance()
        {
            return m * p * (1 - p);
        }

        public double Next()
        {
            int sum = 0;

            for (int i = 0; i < m; i++) 
            {
                double a = random.Next();
                sum += (p - a > 0) ? 1 : 0;
            }

            return sum;
        }

        public void Refresh()
        {
            random.Refresh();
        }

        public double Skewness()
        {
            return (1 - 2 * p) / Math.Sqrt(m * p * (1 - p));
        }

        public double Kurtosis()
        {
            return (1 - 6 * p * (1 - p)) / (m * p * (1 - p));
        }

        public double PMF(int x)
        {
            return MathNet.Numerics.Distributions.Binomial.PMF(p, m, x);
        }

        public double CDF(int x)
        {
            return MathNet.Numerics.Distributions.Binomial.CDF(p, m, x);
        }
    }
}
