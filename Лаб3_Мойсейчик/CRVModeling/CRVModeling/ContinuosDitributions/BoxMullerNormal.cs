using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class BoxMullerNormal : IDistribution
    {
        private double m;

        private double s;

        private RandomBSV random;

        private double saved;

        private bool isSaved;


        public BoxMullerNormal(double m, double stdDeviation)
        {
            this.m = m;
            this.s = stdDeviation;

            isSaved = false;
            random = new RandomBSV(24149775, 19581355);
        }

        public string Name => "Нормальное распределение через преобразование Бокса-Мюллера N(" 
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
            if (isSaved)
            {
                isSaved = false;
                return saved;
            }

            double 
                x = 1.0,
                y = 1.0,
                s = 1.0;

            do
            {
                x = 2 * random.Next() - 1;
                y = 2 * random.Next() - 1;
                s = x * x + y * y;
            } while (s > 1 || s == 0);

            double
                z0 = x * Math.Sqrt(-2.0 * Math.Log(s) / s),
                z1 = y * Math.Sqrt(-2.0 * Math.Log(s) / s);

            saved = z1;
            isSaved = true;

            return z0;
        }

        public void Refresh()
        {
            random.Refresh();
        }
    }
}
