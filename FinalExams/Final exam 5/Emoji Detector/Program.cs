using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _05Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"([:*])\1(?<emoji>[A-Z][a-z]{2,})\1\1";
            string emoji = Console.ReadLine();
            var cool = new List<string>();

            string nums = @"\d";
            MatchCollection num = Regex.Matches(emoji, nums);
            BigInteger treshold = new BigInteger(1);

            foreach (Match item in num)
            {
                treshold *= int.Parse(item.Value);
            }

            int count = 0;
            MatchCollection valid = Regex.Matches(emoji, regex);
            foreach (Match item in valid)
            {
                count++;
                string emote = item.Groups["emoji"].Value;
                int sum = 0;
                for (int i = 0; i < emote.Length; i++)
                {
                    sum += (int)emote[i];
                }
                if(sum > treshold)
                {
                    cool.Add(item.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
            for (int i = 0; i < cool.Count; i++)
            {
                Console.WriteLine(cool[i]);
            }
        }
    }
}
