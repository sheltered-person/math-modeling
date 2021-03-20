using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloIntegration
{
    public class MCIntegrator : IIntegrator
    {
        private Random random;

        private double upperBound;
        private double lowerBound;

        private Func<double, double> func;

        public MCIntegrator(Random random, 
            Func<double, double> integrand, 
            double upperBound, double lowerBound)
        {
            func = integrand;
            this.random = random;

            this.upperBound = upperBound;
            this.lowerBound = lowerBound;
        }

        public double Integrate(int pointsCount)
        {
            double delta = upperBound - lowerBound;
            double sum = 0;

            for (int i = 0; i < pointsCount; i++) 
            {
                double x = random.NextDouble() * delta + lowerBound;
                sum += func(x);
            }

            return sum * delta / pointsCount;
        }
    }
}
