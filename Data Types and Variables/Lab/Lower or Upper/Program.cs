using System;

namespace FundC37
{
    class Program
    {
        static void Main(string[] args)
        {
            char word = char.Parse(Console.ReadLine());
            bool result = Char.IsUpper(word);
            if(result == false)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
