using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSVModeling
{
    public class GeometricDistribution : IDistribution
    {
        private double p;
        RandomBSV random;


        public string Name => "Геометрическое распределение G(" + p + ")";


        public GeometricDistribution(double p)
        {
            this.p = p;
            this.random = new RandomBSV(146051657, 1928884637);
        }

        public double Mean()
        {
            return 1 / p;
        }

        public double Variance()
        {
            return (1 - p) / (p * p);
        }

        public double Next()
        {
            return Math.Ceiling(Math.Log(random.Next()) / Math.Log(1 - p));
        }

        public void Refresh()
        {
            random.Refresh();
        }

        public double Skewness()
        {
            return (2 - p) / Math.Sqrt(1 - p);
        }

        public double Kurtosis()
        {
            return 6 + p * p / (1 - p);
        }

        public double PMF(int x)
        {
            return MathNet.Numerics.Distributions.Geometric.PMF(p, x);
        }

        public double CDF(int x)
        {
            return MathNet.Numerics.Distributions.Geometric.CDF(p, x);
        }
    }
}
