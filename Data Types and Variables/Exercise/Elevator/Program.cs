using System;

namespace FundC42
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double courses = Math.Ceiling(n / p);
            Console.WriteLine(courses);
        }
    }
}
