using System;
using System.Text;

namespace FundC235
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();

            int explosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '>')
                {
                    explosion += int.Parse(input[i + 1].ToString());
                    sb.Append('>');
                }
                else if(explosion == 0)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    explosion--;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
