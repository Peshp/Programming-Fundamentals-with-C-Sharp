using System;

namespace FundC47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = 0;
            double biggestkeg = double.MinValue;
            string biggest = "";
            for (int i = 0; i < n; i++)
            {
                string kegmodel = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                volume = Math.PI * radius * radius * height;

                if(volume > biggestkeg)
                {
                    biggestkeg = volume;
                    biggest = kegmodel;
                }               
            }
            Console.WriteLine(biggest);
        }
    }
}
