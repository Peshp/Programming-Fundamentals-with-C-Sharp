using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FundC238
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            double total = 0;
            List<string> buy = new List<string>();
            var regex = @">>(?<product>[A-Za-z\s]+)<<(?<money>\d+(.\d+)?)!(?<quantity>\d+)";

            while (command != "Purchase")
            {
                command = Console.ReadLine();
                
                MatchCollection valid = Regex.Matches(command, regex);
                
                foreach (Match item in valid)
                {
                    var money = item.Groups["money"].Value;
                    var quan = item.Groups["quantity"].Value;
                    var product = item.Groups["product"].Value;

                    total += double.Parse(money) * int.Parse(quan);

                    buy.Add(product);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in buy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
