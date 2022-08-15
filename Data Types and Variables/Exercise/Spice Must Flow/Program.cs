using System;

namespace FundC48
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());           
            int days = 0;
            int consumespice = 0;
            if(yield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(consumespice);
            }
            else
            {
                while (yield >= 100)
                {
                    days++;
                    consumespice += yield - 26;                                   
                    yield -= 10;
                }               
                consumespice -= 26;                             
                Console.WriteLine(days);
                Console.WriteLine(consumespice);
            }                                             
        }
    }
}
