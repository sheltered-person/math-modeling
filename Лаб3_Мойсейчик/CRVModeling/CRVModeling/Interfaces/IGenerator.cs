using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public interface IGenerator
    {
        double Next();
        void Refresh();
    }
}
