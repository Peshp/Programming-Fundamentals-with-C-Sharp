using System;
using System.Collections.Generic;

namespace FundC209
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            var counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string inLower = word.ToLower();
                if (counts.ContainsKey(inLower))
                {
                    counts[inLower]++;
                }
                else
                { 
                    counts.Add(inLower, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
