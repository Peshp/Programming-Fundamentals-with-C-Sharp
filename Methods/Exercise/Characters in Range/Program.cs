﻿using System;

namespace FundC86
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Range(first, second);
        }
        static void Range(char first, char second)
        {
            int start = Math.Min(first, second);
            int end = Math.Max(first, second);
            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
