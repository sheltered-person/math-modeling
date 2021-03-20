using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSVModeling
{
    public class MacLarenRandom : IGenerator
    {
        private static int K = 128;

        RandomBSV rand1, rand2;

        private double[] table;


        public MacLarenRandom(RandomBSV rand1, RandomBSV rand2)
        {
            table = new double[K];

            this.rand1 = rand1;
            this.rand2 = rand2;

            for (int i = 0; i < K; i++)
                table[i] = rand1.Next();
        }


        public double Next()
        {
            int index = (int)(K * rand2.Next());
            double result = table[index];

            table[index] = rand1.Next();

            return result;
        }


        public void Refresh()
        {
            rand1.Refresh();
            rand2.Refresh();
        }
    }
}
