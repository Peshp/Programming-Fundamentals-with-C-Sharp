using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC228
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split().ToList();
            string first = words[0];
            string second = words[1];

            int min = Math.Min(first.Length, second.Length);
            int max = Math.Max(first.Length, second.Length);
            int sum = 0;

            for (int i = 0; i < min; i++)
            {
                sum += (int)first[i] * (int)second[i];
            }

            if (first.Length != second.Length)
            {
                string inputLen = first.Length > second.Length ? inputLen = first : inputLen = second;
                for (int i = min; i < max; i++)
                {
                    sum += inputLen[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
