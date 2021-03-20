using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSVModeling
{
    public class BernoulliDistribution : IDistribution
    {
        private double p;
        private RandomBSV random;


        public string Name => "Распределение Бернулли Bi(1, " + p + ")";


        public BernoulliDistribution(double p)
        {
            this.p = p;
            this.random = new RandomBSV(24149775, 19581355);
        }

        public double Mean()
        {
            return p;
        }

        public double Variance()
        {
            return p * (1 - p);
        }

        public double Next()
        {
            double a = random.Next();
            return (a > p) ? 0 : 1;
        }

        public void Refresh()
        {
            random.Refresh();
        }

        public double Skewness()
        {
            return (1 - 2 * p) / Math.Sqrt(p * (1 - p));
        }

        public double Kurtosis()
        {
            return (6 * p * p - 6 * p + 1) / (p * (1 - p));
        }

        public double PMF(int x)
        {
            return MathNet.Numerics.Distributions.Bernoulli.PMF(p, x);
        }

        public double CDF(int x)
        {
            return MathNet.Numerics.Distributions.Bernoulli.CDF(p, x);
        }
    }
}
