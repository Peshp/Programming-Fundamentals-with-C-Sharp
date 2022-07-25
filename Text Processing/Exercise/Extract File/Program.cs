using System;
using System.Linq;

namespace FundC229
{
    class Program
    {
        static void Main()
        {
            string[] file = Console.ReadLine().Split("\\");
            string a = file[file.Length - 1];
            string[] substract = a.Split(".");

            Console.WriteLine($"File name: {substract[0]}");
            Console.WriteLine($"File extension: {substract[1]}");
        }
    }
}
