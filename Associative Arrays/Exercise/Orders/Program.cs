using System;
using System.Collections.Generic;

namespace FundC215
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double>();
            var quan = new Dictionary<string, int>();

            string command = "";
            while (command != "buy")
            {
                command = Console.ReadLine();
                if (command == "buy")
                {
                    break;
                }
                string[] token = command.Split();

                string product = token[0];
                double price = double.Parse(token[1]);
                int quantity = int.Parse(token[2]);

                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                    quan[product] = 0;
                }

                products[product] = price;
                quan[product] += quantity;
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value * quan[item.Key]:f2}");
            }
        }
    }
}
