using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSVModeling
{
    public class RandomBSV : IGenerator
    {
        private long a0;

        private static long M = 2147483648;

        private long a, b, c;


        public RandomBSV(int a, int c)
        {
            this.a0 = a;
            this.c = c;

            long temp = M - c;
            b = (c < temp) ? temp : c;

            Refresh();
        }


        public double Next()
        {
            a = (b * a) % M;
            return (double)a / M;
        }


        public void Refresh()
        {
            a = a0;
        }
    }
}
