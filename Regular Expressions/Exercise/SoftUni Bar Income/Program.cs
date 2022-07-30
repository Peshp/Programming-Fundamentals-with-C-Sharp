using System;
using System.Text.RegularExpressions;

namespace FundC239
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            double total = 0;

            while (command != "end of shift")
            {
                command = Console.ReadLine();
                var regex = @"\%(?<name>[A-Z][a-z]+)\%[^[$%.]*\<(?<product>\w+)\>[^[$%.]*\|(?<count>\d+)\|[^[$%.]*?(?<price>\d+([.]\d+)?)\$";

                MatchCollection valid = Regex.Matches(command, regex);
                foreach  (Match item in valid)
                {
                    var name = item.Groups["name"].Value;
                    var money = item.Groups["price"].Value;
                    var quantity = item.Groups["count"].Value;
                    var product = item.Groups["product"].Value;

                    total += double.Parse(money) * double.Parse(quantity);

                    Console.WriteLine($"{name}: {product} - {double.Parse(money) * int.Parse(quantity):f2}");                 
                }
            }
            Console.WriteLine($"Total income; {total:f2}");
        }
    }
}
