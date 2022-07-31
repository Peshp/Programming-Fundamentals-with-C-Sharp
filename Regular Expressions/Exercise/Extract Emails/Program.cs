using System;
using System.Text.RegularExpressions;

namespace FundC242
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regex = @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]*.[A-Za-z]@[A-Za-z]*([.-][A-Za-z]+)+\b";          
            MatchCollection valid = Regex.Matches(text, regex);

            foreach (Match item in valid)
            {
                Console.WriteLine(item.Value);
            }         
        }
    }
}
