﻿using System;

namespace FundC222
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "end")
                {
                    break;
                }

                string reverse = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse += word[i];
                }

                Console.WriteLine($"{word} = {reverse}");
            }
        }
    }
}
