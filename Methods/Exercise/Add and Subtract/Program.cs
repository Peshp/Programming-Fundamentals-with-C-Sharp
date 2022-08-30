using System;

namespace FundC88
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int res = Sum(one, two);
            Console.WriteLine(res - three);
        }
        private static int Sum(int one, int two)
        {
            int res = one + two;
            return res;
        }
    }
}
