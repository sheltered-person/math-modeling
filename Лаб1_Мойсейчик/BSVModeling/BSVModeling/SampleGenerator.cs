using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSVModeling
{
    public class SampleGenerator
    {
        public static List<double> GenerateSample(IGenerator random, int sampleSize)
        {
            List<double> sample = new List<double>(sampleSize);

            for (int i = 0; i < sampleSize; i++)
                sample.Add(random.Next());

            random.Refresh();
            return sample;
        }
    }
}
