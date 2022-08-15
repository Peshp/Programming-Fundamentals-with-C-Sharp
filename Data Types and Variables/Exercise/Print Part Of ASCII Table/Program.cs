using System;

namespace FundC44
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = start; i < second; i++)
            {
                char curr = (char)i;
                Console.WriteLine($"{curr} ");
            }
        }
    }
}
