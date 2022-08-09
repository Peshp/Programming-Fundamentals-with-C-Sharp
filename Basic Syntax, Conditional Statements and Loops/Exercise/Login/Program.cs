using System;

namespace FundC17
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            char[] stringArray = name.ToCharArray();
            Array.Reverse(stringArray);
            string reversename = new string(stringArray);
            string pass = "";
            int wrong = 0;

            while (true)
            {
                pass = Console.ReadLine();              
                wrong++;
                if(wrong > 3)
                {                   
                    break;
                }
                else if(pass == reversename)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            if(pass == reversename)
            {
                Console.WriteLine($"User {name} logged in.");
            }
            else
            {
                Console.WriteLine($"User {name} blocked!");
            }
        }
    }
}
