using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[15];
            Random rand = new Random();
            int max = 0;
            int min = 50;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(0, 50);
            }
            foreach (int item in nums)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine(min + max);
            Console.ReadKey();
        }
    }
}
