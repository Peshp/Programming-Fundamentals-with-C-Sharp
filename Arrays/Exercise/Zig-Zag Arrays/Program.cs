using System;
using System.Linq;

namespace FundC65
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] even = new int[n];
            int[] odd = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    even[i] = numbers[0];
                    odd[i] = numbers[1];
                }
                else
                {
                    even[i] = numbers[1];
                    odd[i] = numbers[0];
                }
            }
            Console.WriteLine(String.Join(" ", even));
            Console.WriteLine(String.Join(" ", odd));
        }
    }
}
