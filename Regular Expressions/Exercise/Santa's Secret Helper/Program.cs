using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FundC243
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = @"@(?<name>[A-Za-z]*)([^\@\-\!\:\>])*![G]!";
            
            int n = int.Parse(Console.ReadLine());
            string decode = "";           
            string kids = "";
            var goodKids = new List<string>();

            while (kids != "end")
            {
                kids = Console.ReadLine();
                for (int j = 0; j < kids.Length; j++)
                {
                    int a = (int)(kids[j]);
                    int b = a - n;
                    char letter = (char)b;
                    decode += letter;
                }
                MatchCollection good = Regex.Matches(decode, name);
                foreach (Match item in good)
                {
                    var Kidname = item.Groups["name"].Value;
                    goodKids.Add(Kidname);
                }               
                decode = "";
            }
            for (int i = 0; i < goodKids.Count; i++)
            {
                Console.WriteLine(goodKids[i]);
            }
        }
    }
}
