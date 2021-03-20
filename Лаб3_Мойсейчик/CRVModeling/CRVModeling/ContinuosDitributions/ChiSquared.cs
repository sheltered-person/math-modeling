using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class ChiSquared : IDistribution
    {
        private double m;

        private RandomBSV random;


        public ChiSquared(double m)
        {
            this.m = m;
            random = new RandomBSV(179029053, 457816087);
        }

        public string Name => "Распределение Хи-квадрат с "
            + m.ToString() + " степенями свободы";

        public double Mean()
        {
            return m;
        }

        public double Variance()
        {
            return 2.0 * m;
        }

        public double Next()
        {
            double sum = 0.0;
            Normal n = new Normal();

            for (int i = 0; i < m; i++)
                sum += Math.Pow(n.Next(random), 2);

            return sum;
        }

        public void Refresh()
        {
            random.Refresh();
        }
    }
}
