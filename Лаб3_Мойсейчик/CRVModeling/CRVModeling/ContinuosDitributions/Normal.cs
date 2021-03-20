using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class Normal : IDistribution
    {
        public int N
        {
            get;
            set;
        } = 48;

        private RandomBSV random;

        private double m, s;


        public Normal() : this(0.0, 1.0)
        { }

        public Normal(double mean, double stdDeviation)
        {
            m = mean;
            s = stdDeviation;
            random = new RandomBSV(24149775, 19581355);
        }

        public string Name => "Нормальное распределение N("
            + m.ToString() + ", " + s.ToString() + ")";

        public double Mean()
        {
            return m;
        }

        public double Variance()
        {
            return s;
        }

        public double Next()
        {
            return Next(random);
        }

        public double Next(RandomBSV rand)
        {
            List<double> a = SampleGenerator.GenerateSample(rand, N);

            double x = 0.0;

            foreach (double element in a)
                x += element;

            x -= N / 2;
            x *= Math.Sqrt(12.0 / N);

            return m + Math.Sqrt(s) * x;
        }

        public void Refresh()
        {
            random.Refresh();
        }
    }
}
