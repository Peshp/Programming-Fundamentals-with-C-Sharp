using System;

namespace FundC46
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           
            int pourwater = 0;
            for (int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                pourwater += quantities;
                if (pourwater > 255)
                {
                    pourwater -= quantities;
                    Console.WriteLine("Insufficient capacity!");
                }                              
            }
            Console.WriteLine(pourwater);
        }
    }
}
