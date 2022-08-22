using System;

namespace FundC77
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            switch(product)
            {
                case "coffee":
                    price = 1.50;
                    Price(price, quantity);
                    break;
                case "water":
                    price = 1.00;
                    Price(price, quantity);
                    break;
                case "coke":
                    price = 1.40;
                    Price(price, quantity);
                    break;
                case "snacks":
                    price = 2.00;
                    Price(price, quantity);
                    break;
            }
        }
        private static void Price(double price, int quantity)
        {
            Console.WriteLine($"{(price * quantity):f2}");
        }
    }
}
