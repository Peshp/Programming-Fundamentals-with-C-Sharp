using System;

namespace FundC4
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            m += 30;
            if(m > 60)
            {
                h += 1;
                m -= 60;
            }
            if(h > 23)
            {
                h = 0;
            }
            Console.WriteLine($"{h}:{m:D2}");
        }
    }
}
