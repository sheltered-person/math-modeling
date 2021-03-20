using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVModeling
{
    public class SampleGenerator
    {
        public static List<double> GenerateSample(IGenerator generator, int sampleSize)
        {
            List<double> sample = new List<double>(sampleSize);

            for (int i = 0; i < sampleSize; i++)
                sample.Add(generator.Next());

            return sample;
        }

        public static Tuple<List<double>, List<double>> 
            GenerateSubsamples(IGenerator generator, int sampleSize)
        {
            List<double>
                odd = new List<double>(sampleSize / 2),
                even = new List<double>(sampleSize / 2);

            for (int i=0;i<sampleSize;i++)
            {
                if (i % 2 == 0)
                    odd.Add(generator.Next());
                else
                    even.Add(generator.Next());
            }

            return new Tuple<List<double>, List<double>>(odd, even);
        }
    }
}
