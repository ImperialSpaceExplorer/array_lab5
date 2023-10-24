using System;

namespace maslab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            int[] matr1 = new int[N*N], matr2 = new int[N*N], res = new int[N*N];

            Random rand = new Random();
            for (int i = 0; i < N*N; i++) { matr1[i] = rand.Next(0, 10); matr2[i] = rand.Next(0, 10); }

            for (int i = 0; i < N; i++) 
            {
                for (int j = 0; j < N; j++) 
                {
                    Console.Write("{0} ",matr1[j+i*N]);
                }
                Console.Write("\n");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", matr2[j + i * N]);
                }
                Console.Write("\n");
            }

            Console.WriteLine(" ");

            int sum;
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                {
                    sum = 0;
                    for (int k = 0; k < N; ++k)
                        sum += matr1[k+i*N] * matr2[j+k*N];
                    res[j+i*N] = sum;
                }

            Console.WriteLine("Результат: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", res[j + i * N]);
                }
                Console.Write("\n");
            }
        }
    }
}
