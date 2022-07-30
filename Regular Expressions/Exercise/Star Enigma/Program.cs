using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace FundC240
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"@(?<name>[A-Z][a-z]+)[^@\-:!>]*:(?<population>\d+)[^@\-:!>]*!(?<action>[A,D])![^@\-:!>]*->(?<soldiers>\d+)";
            int n = int.Parse(Console.ReadLine());
            int ascii = 0;
            var attacked = new List<string>();
            var destroyed = new List<string>();

            string input = "";
            string decrypted = "";
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string lower = input.ToLower();

                ascii = 0;
                for (int j = 0; j < lower.Length; j++)
                {
                    if(lower[j] == 's' || lower[j] == 't' || lower[j] == 'a' || lower[j] == 'r')
                    {
                        ascii++;
                    }
                }
                lower = "";
                decrypted = "";
                for (int j = 0; j < input.Length; j++)
                {
                    int a = (int)(input[j]);
                    int b = a - ascii;
                    char letter = (char)b;
                    decrypted += letter;
                }

                MatchCollection valid = Regex.Matches(decrypted, regex);
                foreach (Match item in valid)
                {
                    var planet = item.Groups["name"].Value;
                    var action = item.Groups["action"].Value;                   

                    switch (action)
                    {
                        case "A":
                            attacked.Add(planet);
                            break;
                        case "D":
                            destroyed.Add(planet);
                            break;
                    }
                }
            }            
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var item in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach(var item in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
