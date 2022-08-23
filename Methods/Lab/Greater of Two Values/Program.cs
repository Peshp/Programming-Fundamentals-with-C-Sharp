using System;

namespace FundC81
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch(type)
            {
                case "int":
                    int intInput = int.Parse(Console.ReadLine());
                    int secondintInput = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(intInput, secondintInput));
                    break;
                case "char":
                    char charInput = char.Parse(Console.ReadLine());
                    char secondcharInput = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(charInput, secondcharInput));
                    break;
                case "string":
                    string stringInput = Console.ReadLine();
                    string secondstringInput = Console.ReadLine();
                    Console.WriteLine(GetMax(stringInput, secondstringInput));
                    break;
            }           
        } 
        static int GetMax(int first, int second)
        {          
            if(first > second)
            {
                return first;
            }
            return second;
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            return second;
        }
    }
}
