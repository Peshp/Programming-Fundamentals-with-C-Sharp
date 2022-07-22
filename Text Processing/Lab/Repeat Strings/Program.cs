using System;
using System.Text;

namespace FundC223
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            string result = "";
            foreach (var word in line)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}
