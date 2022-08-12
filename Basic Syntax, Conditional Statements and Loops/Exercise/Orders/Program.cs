using System;

namespace FundC22
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());          
            double total = 0;

            for (int i = 0; i < N; i++)
            {
                double pricecapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());

                double price = days * capsules * pricecapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                total += price;
            }
            
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
