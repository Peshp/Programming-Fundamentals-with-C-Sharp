using System;
using System.Linq;

namespace FundC61
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < firstNums.Length; i++)
            {
                if(firstNums[i] != secondNums[i])
                {                   
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += firstNums[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
