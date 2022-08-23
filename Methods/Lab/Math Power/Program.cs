using System;

namespace FundC80
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = FinalResult(a, b);
            Console.WriteLine(result);
        }
        static double FinalResult(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
