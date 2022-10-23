using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rand = new Random();
            Console.WriteLine("Массив до сортировки:");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(-50, 50);
                Console.Write("{0} ",nums[i]);
            }
            Console.WriteLine("");

            // сортируем первую половину массивва
            int temp;
            for (int i = 0; i < (nums.Length/2)-1; i++)
            {
                for (int j = i+1; j < nums.Length / 2; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            //сортируем вторую половину массива

            for (int i = (nums.Length / 2); i < nums.Length ; i++)
            {
                for (int j = i+1; j < nums.Length ; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Массив после сортировки:");
            foreach (int item in nums)
            {
                Console.Write("{0} ", item);
            }
            Console.ReadKey();
        }
    }
}
