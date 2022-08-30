using System;

namespace FundC89
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string result = MiddleChar(word);
            Console.WriteLine(result);
        }
        private static string MiddleChar(string word)
        {
            string result = "";

            int l = 1 - word.Length % 2;
            result = word.Substring(word.Length / 2 - l, 1 + l);
            return result;
        }
    }
}
