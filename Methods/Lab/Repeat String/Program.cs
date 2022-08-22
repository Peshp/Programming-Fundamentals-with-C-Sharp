using System;
using System.Text;

namespace FundC79
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatWord(word, n);
            Console.Write(result);
        }
        private static string RepeatWord(string word, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(word);
            }
            return result.ToString();
        }
    }
}
