using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class LogNormal : IDistribution
    {
        private double m;

        private double s;

        private RandomBSV random;


        public LogNormal(double m, double s)
        {
            this.m = m;
            this.s = s;

            random = new RandomBSV(179029053, 457816087);
        }

        public string Name => "Лог-нормальное распределение LN(" 
            + m.ToString() + ", " + s.ToString() + ")";

        public double Mean()
        {
            return Math.Exp(m + s / 2);
        }

        public double Variance()
        {
            return (Math.Exp(s) - 1) * Math.Exp(2 * m + s);
        }

        public double Next()
        {
            Normal n = new Normal(m, s);
            return Math.Exp(n.Next(random));
        }

        public void Refresh()
        {
            random.Refresh();
        }
    }
}
