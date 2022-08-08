using System;

namespace FundC10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int secnum = int.Parse(Console.ReadLine());           
            int mult = 0;
            if(secnum > 10)
            {
                mult = num * secnum;
                Console.WriteLine($"{num} X {secnum} = {mult}");
            }
            for (int i = secnum; i <= 10; i++)
            {
                mult = num * i;
                Console.WriteLine($"{num} X {i} = {mult}");
            }
        }
    }
}
