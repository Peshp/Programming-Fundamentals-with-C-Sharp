using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var words = new List<string>();
            var reversed = new Dictionary<string, string>();

            var regex = @"([@#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";           

            MatchCollection valid = Regex.Matches(word, regex);          

            if (valid.Count > 0)
            {
                foreach (Match match in valid)
                {
                    words.Add(match.Value);
                }
                Console.WriteLine($"{words.Count} word pairs found!");

                string reverse = "";
                for (int i = 0; i < words.Count; i++)
                {
                    char[] ch = new char[] { '@', '#' };
                    string[] token = words[i].Split(ch);
                    string a = token[3];

                    for (int j = a.Length - 1; j >= 0; j--)
                    {
                        reverse += a[j];
                    }                   
                    if(token[1] == reverse)
                    {
                        reversed.Add(token[1], token[3]);
                    }
                    reverse = "";                  
                }

                if (reversed.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.Write(string.Join(", ", reversed.Select(x => $"{x.Key} <=> {x.Value}")));
                } 
                else
                {
                    Console.WriteLine("No mirror words!");
                }
                             
            }           
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
