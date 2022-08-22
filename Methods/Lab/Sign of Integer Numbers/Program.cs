using System;

namespace FundC73
{
    class Program
    {
        static void Main()
        {
            Number(int.Parse(Console.ReadLine()));
        }
        static void Number(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
