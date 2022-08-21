using System;
using System.Linq;

namespace FundC70
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            string sequence = "";
            int count = 0;
            int currcount = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    currcount++;
                    if(currcount > count)
                    {
                        count = currcount;
                        sequence = arr[i];
                    }
                }
                else
                {
                    currcount = 0;
                }
            }

            for (int i = 0; i <= count; i++)
            {
                Console.Write(sequence + " ");
            }
        }
    }
}
