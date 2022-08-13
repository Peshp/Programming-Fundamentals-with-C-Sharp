using System;

namespace FundC29
{
    class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine());
            double dolar = pound * 1.31;
            Console.WriteLine($"{dolar:f3}");
        }
    }
}
