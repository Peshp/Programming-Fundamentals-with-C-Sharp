﻿using System;

namespace FundC9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = num * i;
                Console.WriteLine($"{num} X {i} = {sum}");
            }
        }
    }
}
