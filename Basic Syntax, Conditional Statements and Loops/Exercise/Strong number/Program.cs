using System;

namespace FundC18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numcopy = num;
            int sum = 0;

            while (num > 0)
            {
                int factnum = 1;
                int currnum = num % 10;
                num /= 10;

                for (int i = 2; i <= currnum; i++)
                {
                    factnum *= i;
                }

                sum += factnum;
            }
            Console.WriteLine(sum == numcopy ? "yes" : "no" );
        }
    }
}
