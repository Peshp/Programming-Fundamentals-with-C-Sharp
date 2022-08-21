using System;
using System.Linq;

namespace FundC68
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftsum = 0;
                for (int j = i; j > 0; j--) // 1 2 3 3
                {
                    int leftnums = j - 1; // 1 2 
                    if(j > 0) // 1 2 3
                    {
                        leftsum += nums[leftnums]; // +1 +2
                    }        
                }

                rightsum = 0;
                for (int t = i; t < nums.Length; t++) // 1 2 3 3
                {
                    int rightnums = t + 1; // 3 3
                    if(t < nums.Length - 1) // 3
                    {
                        rightsum += nums[rightnums];
                    }                 
                }

                if(rightsum == leftsum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
