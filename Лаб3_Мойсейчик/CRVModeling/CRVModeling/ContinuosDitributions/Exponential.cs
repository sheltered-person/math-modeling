using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class Exponential : IDistribution
    {
        private double a;

        private RandomBSV random;


        public Exponential(double a)
        {
            this.a = a;
            random = new RandomBSV(179029053, 457816087);
        }

        public string Name => "Экспоненциальное распределение E(" 
            + a.ToString() + ")";

        public double Mean()
        {
            return 1.0 / a;
        }

        public double Variance()
        {
            return 1.0 / a / a;
        }

        public double Next()
        {
            double x = 0.0;

            do
            {
                x = random.Next();
            } while (x == 0.0);

            return -Math.Log(x) / a;
        }

        public void Refresh()
        {
            random.Refresh();
        }
    }
}
