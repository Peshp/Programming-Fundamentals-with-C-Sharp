using System;
using System.Text;

namespace FundC233
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string big = Console.ReadLine();
            int small = int.Parse(Console.ReadLine());
            int remained = 0;

            for (int i = big.Length - 1; i >= 0; i--)
            {
                if(small == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                int currNum = int.Parse(big[i].ToString());
                int result = currNum * small + remained;
                sb.Append(result % 10);
                remained = result / 10;
            }
            if(remained > 0)
            {
                sb.Append(remained);
            }

            char[] resultArray = sb.ToString().ToCharArray();
            Array.Reverse(resultArray);
            Console.WriteLine(resultArray);
        }
    }
}
