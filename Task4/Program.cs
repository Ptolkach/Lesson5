using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            Random rand = new Random();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(-50, 50);
                if (nums[i] > 0 && nums[i] % 2 != 0 && i % 2 == 0)
                {
                    count++;
                }
            }
            /*
            foreach (int item in nums)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
            */
            Console.WriteLine(count);
            Console.ReadKey();
        }

    }
}
