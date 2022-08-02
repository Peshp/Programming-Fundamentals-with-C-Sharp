using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var destinations = new List<string>();

            var regex = @"([=/])(?<country>[A-Z][A-Za-z]{2,})\1";

            MatchCollection valid = Regex.Matches(input, regex);
            int sum = 0;
            for (int i = 0; i < valid.Count; i++)
            {
                string destination = valid[i].Groups["country"].Value;
                destinations.Add(destination);
            }

            for (int i = 0; i < destinations.Count; i++)
            {
                for (int j = 0; j < destinations[i].Length; j++)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
