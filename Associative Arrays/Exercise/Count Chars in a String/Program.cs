using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC212
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            var count = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (count.ContainsKey(letter))
                {
                    count[letter]++;
                }
                else
                {
                    count.Add(letter, 1);
                }
            }

            foreach (KeyValuePair<char, int> item in count.Where(a => a.Key != ' '))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
