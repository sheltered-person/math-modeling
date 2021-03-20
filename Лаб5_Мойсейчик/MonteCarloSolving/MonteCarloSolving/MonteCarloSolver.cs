using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloSolving
{
    public class MonteCarloSolver
    {
        private int n;

        private Random random;

        private double[,] A;
        private double[,] h;
        private double[,] P;

        private double[] Af;
        private double[] f;
        private double[] X;

        public MonteCarloSolver(int size, double[,] A, double[] f)
        {
            n = size;
            random = new Random();

            this.A = new double[size, size];
            this.h = new double[size, size];
            this.P = new double[size, size];

            this.Af = new double[size * (size + 1)];
            this.f = f.Clone() as double[];
            this.X = new double[size];

            int k = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Af[k++] = A[i, j];
            }

            for (int i = 0; i < size; i++)
                Af[k++] = f[i];

            InitMatrices(size, this.A, this.f);
        }

        private void InitMatrices(int size, double[,] A, double[] f)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = Af[j + i * n];
                    h[i, j] = 0.0;
                    P[i, j] = 1.0 / n;
                }

                f[i] = Af[n * n + i];

                //Приводим систему к нужному виду
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        A[i, j] = 1 - A[i, j];
                        h[i, j] = 1;
                    }
                    else
                        A[i, j] *= -1.0;
                }
            }
        }

        public void Solve(int chainLength, int chainCount, int steps, double[] exactSolution)
        {
            Console.Write("\n\nТочное решение:");

            for (int i = 0; i < n; i++)
                Console.Write("  {0:f5}", exactSolution[i]);

            Console.WriteLine("\n\n         Результат              Отклонение            Цепи Маркова\n" +
                    "    X1       X2       X3        (среднее)         Число          Длина\n\n");

            for (int j = 0; j < steps; j++)
            {
                for (int i = 0; i < n; i++)
                    X[i] = CalcX(A, i, f, P, chainLength, chainCount);

                for (int i = 0; i < n - 1; i++)
                    Console.Write("{0:f5}  ", X[i]);

                Console.Write("{0:f5}", X[n - 1]);

                double diff = 0;
                for (int i = 0; i < n; i++)
                    diff += exactSolution[i] - X[i];

                Console.Write("       {0:f5}", Math.Abs(diff / n));
                Console.Write("      {0,9}    {1,9}\n", chainCount, chainLength);

                chainLength *= 2;
                //chainCount *= 4;

                Console.WriteLine();
            }
        }

        private double CalcX(double[,] matrix, int idx, double[] f, 
            double[,] P, int chainLength, int chainCount)
        {
            double Qprev, Qcurr;
            int Mprev, Mcurr;
            double X = 0.0;

            //вычисляем веса для состояний цепи Маркова
            //chainCount - номер реализации цепи Маркова
            for (int i = 0; i < chainCount; i++)
            {
                Mprev = idx;
                Qprev = 1.0;

                //g = a/p, p > 0
                //g = 0, p = 0
                for (int j = 1; j < chainLength; j++)
                {
                    Mcurr = MarkovChain(P, Mprev);

                    if (P[Mprev, Mcurr] > 0)
                        Qcurr = Qprev * matrix[Mprev, Mcurr] / P[Mprev, Mcurr];
                    else
                        Qcurr = 0.0;

                    X += Qcurr * f[Mcurr]; //случайная величина
                    Qprev = Qcurr;
                    Mprev = Mcurr;
                }
            }

            return (f[idx] + X / chainCount);
        }

        //моделируем вспомогательную цепь Маркова
        private int MarkovChain(double[,] P, int curr)
        {
            double rd = random.NextDouble();

            for (int i = 0; i < n; i++)
            {
                rd -= P[curr, i];

                if (rd < 0)
                    return i;
            }

            return (n - 1);
        }
    }
}
