using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class Laplace : IDistribution
    {
        private double a;

        private RandomBSV random;


        public Laplace(double a)
        {
            this.a = a;
            random = new RandomBSV(179029053, 457816087);
        }

        public string Name => "Распределение Лапласа L(" + a.ToString() + ")";

        public double Mean()
        {
            return 0.0;
        }

        public double Variance()
        {
            return 2.0 / a / a;
        }

        public double Next()
        {
            double y = random.Next();

            if (y < 0.5)
                return 1.0 / a * Math.Log(2 * y);
            else
                return -1.0 / a * Math.Log(2 * (1 - y));
        }

        public void Refresh()
        {
            random.Refresh();
        }
    }
}
