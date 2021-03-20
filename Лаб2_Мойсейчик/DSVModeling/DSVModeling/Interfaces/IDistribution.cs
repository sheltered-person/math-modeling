using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSVModeling
{
    public interface IDistribution : IGenerator
    {
        string Name { get; }

        double Mean();
        double Variance();

        double Skewness();
        double Kurtosis();

        double PMF(int x);
        double CDF(int x);
    }
}
