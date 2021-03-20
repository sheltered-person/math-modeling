using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloSolving
{
    class Program
    {
        public static double[,] A = new double[3, 3]
        {
            { 1.2, -0.4, 0.3 },
            { 0.1, 0.7, -0.2 },
            { -0.4, 0.0, 1.4 }
        };

        public static double[] f = new double[3]
        {
            1.0,
            2.0,
            -2.0
        };

        public static double[] exactSolution = new double[]
        {
            1.83800623052959,
            2.33644859813084,
            -0.903426791277259
        };

        public static void Main(String[] args)
        {
            MonteCarloSolver solver = new MonteCarloSolver(3, A, f);
            solver.Solve(1, 1000, 10, exactSolution);

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
