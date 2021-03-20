using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class MixtureDistribution : IDistribution
    {
        private RandomBSV random;

        private IDistribution[] distributions;

        private double[] pi;


        public MixtureDistribution(IDistribution[] distributions, double[] pi)
        {
            this.distributions = distributions;
            this.pi = pi;

            random = new RandomBSV(179029053, 457816087);
        }

        public string Name
        {
            get
            {
                StringBuilder name = new StringBuilder("Mixure distribution: ");

                for (int i = 0; i < distributions.Length; i++)
                    name.Append(distributions[i].Name + " (" + pi[i] + ") ");

                return name.ToString();
            }
        }

        public double Mean()
        {
            double m = 0.0;

            for (int i = 0; i < distributions.Length; i++)
                m += pi[i] * distributions[i].Mean();

            return m;
        }

        public double Variance()
        {
            double 
                v = 0.0,
                m = Mean();

            for (int i = 0; i < distributions.Length; i++)
                v += pi[i] * (distributions[i].Variance() + 
                    Math.Pow(distributions[i].Mean(), 2) - m * m);

            return v;
        }

        public double Next()
        {
            double a = random.Next();

            if (a < pi[0])
                return distributions[0].Next();
            else
                return distributions[1].Next();
        }

        public void Refresh()
        {
            random.Refresh();
        }
    }
}
