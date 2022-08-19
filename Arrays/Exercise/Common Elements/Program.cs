using System;

namespace FundC64
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();
            string common = "";
      

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if(second[j] == first[i])
                    {
                        Console.Write(first[i] + " ");
                    }
                }               
            }           
        }
    }
}
