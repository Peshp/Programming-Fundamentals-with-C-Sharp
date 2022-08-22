using System;

namespace FundC74
{
    class Program
    {
        static void Main()
        {
            grades(double.Parse(Console.ReadLine()));
        }

        static void grades(double grade)
        {
            if(grade < 3.00)
            {
                Console.WriteLine("Fail");
            }          
            else if(grade > 2.99 && grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if(grade > 3.49 && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if(grade > 4.49 && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
