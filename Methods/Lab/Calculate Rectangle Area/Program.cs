using System;

namespace FundC78
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = RectangleArea(a, b);
            Console.WriteLine(area);
        }
        static double RectangleArea(double a, double b)
        {
            return a * b;          
        }
    }
}
