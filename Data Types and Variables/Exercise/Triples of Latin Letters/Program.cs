using System;

namespace FundC45
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char firstchar = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char secondchar = (char)('a' + j);
                    for (int t = 0; t < n; t++)
                    {
                        char thirdchar = (char)('a' + t);
                        Console.WriteLine($"{firstchar}{secondchar}{thirdchar}");
                    }
                }
            }
        }
    }
}
