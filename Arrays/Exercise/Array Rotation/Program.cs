﻿using System;
using System.Linq;

namespace FundC66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int n = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < n; i++)
            {
                int last = nums[0];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[nums.Length - 1] = last;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
