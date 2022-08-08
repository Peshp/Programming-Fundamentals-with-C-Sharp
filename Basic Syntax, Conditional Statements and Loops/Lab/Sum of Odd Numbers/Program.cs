using System;

namespace Fund8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num = 1 + (i * 2);
                sum += num;
                Console.WriteLine(num);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
