using System;

namespace FundC26
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] stringArray = word.ToCharArray();
            Array.Reverse(stringArray);
            string reverse = new string(stringArray);

            Console.WriteLine(reverse);
        }
    }
}
