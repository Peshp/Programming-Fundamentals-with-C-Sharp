using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01eXAN2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder valid = new StringBuilder();

            var regex = @"([|#])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}[\/]\d{2}[\/]\d{2})\1(?<calories>\d+)\1";

            MatchCollection food = Regex.Matches(text, regex);
            int days = 0;
            int sum = 0;

            for (int i = 0; i < food.Count; i++)
            {
                var itemName = food[i].Groups["name"].Value;
                var date = food[i].Groups["date"].Value;
                var cal = food[i].Groups["calories"].Value;

                sum += int.Parse(cal);
                days = sum / 2000;

                valid.Append($"Item: {itemName}, Best before: {date}, Nutrition: {cal}\n");
            }
            Console.WriteLine($"You have food to last you for: {days} days!");
            Console.WriteLine(valid);
        }
    }
}
