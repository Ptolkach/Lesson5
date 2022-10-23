using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вевдеите размер квадратной матрицы");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] nums = new int[n, n];
            Console.WriteLine("Введите значения, заполняющие матрицу");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    nums[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            // идея решения следующая: создаем суммы строк, суммы столбцов, суммы главной и побочной диагоналей
            // создаем массив, который хранит суммы nums2 потом пройдемся по нему и сравним на равенстово элементы
            // между собой
            int s_line= 0;
            int s_column = 0;
            int s1 = 0;
            int s2 = 0;
            int[] nums2 = new int[(2 * n)+2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        s1 += nums[i, j];
                    }
                    if (i+j == n-1)
                    {
                        s2 += nums[i, j];
                    }
                    s_line += nums[i, j];
                    s_column += nums[j, i];
                }
                nums2[i] = s_line;
                nums2[n + i] = s_column;
                s_line = 0;
                s_column = 0;
            }
            nums2[2 * n ] = s1;
            nums2[2 * n + 1] = s2;
            /*
            foreach (int item in nums2)
            {
                Console.Write("{0} ", item);
            }
            */
            int k = nums2[0];
            bool f = true;
            for (int i = 1; i < nums2.Length; i++)
            {
                if (k != nums2[i])
                {
                    Console.WriteLine("Матрица не магическая");
                    f = false;
                    break;
                }
            }
            if (f)
            {
                Console.WriteLine("Это магический квадрат!");
            }
            Console.ReadKey();
        }
    }
}
