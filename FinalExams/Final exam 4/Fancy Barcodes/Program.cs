using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FundC245
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            int n = int.Parse(Console.ReadLine());
            var fancyCodes = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string code = Console.ReadLine();
                MatchCollection fancy = Regex.Matches(code, regex);

                if(Regex.IsMatch(code, regex))
                {                                       
                    foreach (Match item in fancy)
                    {
                        string a = item.Value;
                        string result = new String(a.Where(Char.IsDigit).ToArray());

                        if (String.IsNullOrEmpty(result))
                        {
                            result = "00";
                        }
                        fancyCodes.Add($"Product group: {result}");
                    }                                                                            
                }
                else
                {
                    fancyCodes.Add("Invalid barcode");
                }
            }

            for (int i = 0; i < fancyCodes.Count; i++)
            {
                Console.WriteLine(fancyCodes[i]);
            }
        }
    }
}
