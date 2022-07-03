using System;

namespace FunC193
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random randomize = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomize2 = randomize.Next(words.Length);

                var a = words[i];
                var b = words[randomize2];

                words[i] = b;
                words[randomize2] = a;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
