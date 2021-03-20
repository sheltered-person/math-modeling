using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloIntegration
{
    public class MCTwoDimensionalIntegrator : IIntegrator
    {
        private Random random;

        private double upperXBound;
        private double upperYBound;

        private double lowerXBound;
        private double lowerYBound;

        private Func<double, double, double> func;
        private Func<double, double, double> indicator;

        private double square;

        public MCTwoDimensionalIntegrator(
            Random random, double square,
            Func<double, double, double> indicator,
            Func<double, double, double> integrand,
            double upperXBound, double upperYBound,
            double lowerXBound, double lowerYBound)
        {
            this.square = square;

            func = integrand;
            this.indicator = indicator;
            this.random = random;

            this.upperXBound = upperXBound;
            this.upperYBound = upperYBound;

            this.lowerXBound = lowerXBound;
            this.lowerYBound = lowerYBound;
        }

        public double Integrate(int pointsCount)
        {
            double deltaX = upperXBound - lowerXBound;
            double deltaY = upperYBound - lowerYBound;

            double sum = 0;

            for (int i = 0; i < pointsCount * 2; i++) 
            {
                double x = random.NextDouble() * deltaX + lowerXBound;
                double y = random.NextDouble() * deltaY + lowerYBound;

                sum += func(x, y) * indicator(x, y);
            }

            return square * sum / pointsCount;
        }
    }
}
