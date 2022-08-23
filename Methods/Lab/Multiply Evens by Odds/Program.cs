using System;

namespace FundC82
{
    class Program
    {
        static void Main(string[] args)
        {
            int currnum = Math.Abs(int.Parse(Console.ReadLine()));
            int num = 0;                       
            int evensum = 0;
            int oddsum = 0;         

            while (currnum > 0)
            {
                num = currnum % 10;
                currnum /= 10;                

                if (num % 2 == 0)
                {
                    evensum += num;                  
                }
                else
                {
                    oddsum += num;                  
                }
                num = 1;
            }
                     
            int result = GetMultipleOfEvenAndOdds(evensum, oddsum);
            Console.WriteLine(result);
        }
       
        static int GetMultipleOfEvenAndOdds(int evensum, int oddsum)
        {
            return evensum * oddsum;
        }       
    }
}
