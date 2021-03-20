using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloIntegration
{
    public interface IIntegrator
    {
        double Integrate(int pointsCount);
    }
}
