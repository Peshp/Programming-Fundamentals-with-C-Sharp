using System;

namespace FundC225
{
    class Program
    {
        static void Main()
        {
            string[] banned = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var ban in banned)
            {
                text = text.Replace(ban, new string('*', ban.Length));
            }
            Console.WriteLine(text);
        }
    }
}
