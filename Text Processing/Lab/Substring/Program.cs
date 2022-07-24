using System;

namespace FundC224
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int txt = text.IndexOf(word);
            while (txt != -1)
            {
                text = text.Remove(txt, word.Length);
                txt = text.IndexOf(word);
            }

            Console.WriteLine(text);
        }
    }
}
