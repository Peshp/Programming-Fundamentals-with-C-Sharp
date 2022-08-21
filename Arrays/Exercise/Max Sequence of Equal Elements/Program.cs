using System;
using System.Linq;

namespace FundC69
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int secondnums = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                bool isSum = false;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == num)
                    {
                        isSum = true;
                        secondnums = nums[j];
                    }                  
                }
                if (isSum == true)
                {
                    Console.WriteLine($"{nums[i]} {secondnums}");
                }

            }
        }
    }
}
