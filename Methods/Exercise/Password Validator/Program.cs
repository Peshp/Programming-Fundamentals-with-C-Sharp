using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FundC87
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            bool isTenchars = TenChars(pass);
            bool isOnlyletters = OnlyLetter(pass);
            bool isTwodigits = Twodigits(pass);

            if (isTenchars == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (isOnlyletters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (isTwodigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isOnlyletters == true && isTenchars == true && isTwodigits == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
        private static bool Twodigits(string pass)
        {
            int count = 0;
            foreach (char symbol in pass)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count > 1;
        }
        private static bool OnlyLetter(string pass)
        {
            foreach (char symbol in pass)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool TenChars(string pass)
        {
            return pass.Length >= 6 && pass.Length <= 10;
        }
    }
}