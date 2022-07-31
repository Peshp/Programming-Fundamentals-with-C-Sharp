using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace FundC241
{
    class Program
    {
        static void Main(string[] args)
        {
            string demon = Console.ReadLine();

            var split = @"[,\s]+";
            var health = @"[^*\+\^\-\/\.,0-9]";
            var dmg = @"-?\d+\.?\d*";
            var multi = @"[\*\/]";

            string[] token = Regex.Split(demon, split).ToArray();
            var demons = new List<string>();
            var result = new Dictionary<string, Dictionary<int, double>>();
            for (int i = 0; i < token.Length; i++)
            {
                demons.Add(token[i]);
            }          

            int h = 0;
            double d = 0;          

            for (int i = 0; i < demons.Count; i++)
            {
                MatchCollection demonHealth = Regex.Matches(demons[i], health);
                MatchCollection demonDmg = Regex.Matches(demons[i], dmg);
                MatchCollection multiDmg = Regex.Matches(demons[i], multi);

                foreach (Match item in demonHealth)
                {
                    for (int j = 0; j < item.Value.Length; j++)
                    {
                        h += (int)item.Value[j];
                    }
                }
                foreach (Match item in demonDmg)
                {
                    double a = double.Parse(item.Value);
                    d += a;
                }

                foreach (Match item in multiDmg)
                {                   
                    for (int j = 0; j < item.Value.Length; j++)
                    {
                        if (item.Value[j] == '*')
                        {
                            d *= 2;
                        }
                        if (item.Value[j] == '/')
                        {
                            d /= 2;
                        }
                    }
                }
                result.Add(demons[i], new Dictionary<int, double>());
                result[demons[i]].Add(h, d);

                h = 0;
                d = 0;
            }

            foreach (var item in result.OrderBy(x => x.Key))
            {
                var demonHealth = item.Value.FirstOrDefault().Key;
                var demonDmg = item.Value.FirstOrDefault().Value;

                Console.WriteLine($"{item.Key} - {demonHealth} health, {demonDmg:f2} damage");
            }
        }
    }
}
