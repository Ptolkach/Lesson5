using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (размер квадратной матрицы)");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        mass[i, j] = 1;
                    }
                    else 
                    {
                        mass[i, j] = 0;
                    }
                    Console.Write("{0} ", mass[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
