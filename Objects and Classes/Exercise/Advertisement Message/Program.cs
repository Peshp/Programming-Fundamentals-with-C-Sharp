using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC200
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] one = {"Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] two =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] three = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] four = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            one = one.OrderBy(x => rnd.Next()).ToArray();
            two = two.OrderBy(x => rnd.Next()).ToArray();
            three = three.OrderBy(x => rnd.Next()).ToArray();
            four = four.OrderBy(x => rnd.Next()).ToArray();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{one[i]} {two[i]} {three[i]} - {four[i]}");
            }
        }
    }
}
