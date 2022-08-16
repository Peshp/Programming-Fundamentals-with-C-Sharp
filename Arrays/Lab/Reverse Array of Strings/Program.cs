using System;

namespace FundC58
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Array.Reverse(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }          
        }
    }
}
