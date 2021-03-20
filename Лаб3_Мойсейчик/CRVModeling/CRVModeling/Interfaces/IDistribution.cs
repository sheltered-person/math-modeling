using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public interface IDistribution : IGenerator
    {
        string Name { get; }

        double Mean();
        double Variance(); 
    }
}
