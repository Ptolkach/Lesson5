using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[7];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in nums)
            {
                sum += item;
            }
            Console.WriteLine(sum / 7.0);
            Console.ReadKey();
        }
    }
}
