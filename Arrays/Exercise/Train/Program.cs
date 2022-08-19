using System;

namespace FundC63
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];
            int totalpeople = 0;

            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                totalpeople += people[i];
            }

            for (int i = 0; i < people.Length; i++)
            {
                Console.Write(people[i] + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine(totalpeople);
        }
    }
}
