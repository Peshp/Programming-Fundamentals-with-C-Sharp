using System;
using System.Text;
using System.Xml;

namespace FundC226
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());

            string nums = "";
            string letter = "";
            string chars = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    nums += text[i];
                }
                else if (Char.IsLetter(text[i]))
                {
                    letter += text[i];
                }
                else
                {
                    chars += text[i];
                }
            }

            Console.WriteLine(nums);
            Console.WriteLine(letter);
            Console.WriteLine(chars);
        }
    }
}
