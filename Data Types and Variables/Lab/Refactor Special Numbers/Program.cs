using System;

namespace FundC39
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digits = 0;
            bool isSpecial = false;
            for (int num = 1; num <= number; num++)
            {
                digits = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digits, isSpecial);
                sum = 0;
                num = digits;
            }
        }
    }
}
