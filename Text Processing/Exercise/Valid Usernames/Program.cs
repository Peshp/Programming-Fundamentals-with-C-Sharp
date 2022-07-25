
using System;
using System.Collections.Generic;
using System.Text;

namespace FundC227
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(", ");
            List<string> valid = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                string user = names[i];
                if (user.Length > 2 && user.Length < 17)
                {
                    bool isvalid = IsValid(user);
                    if (isvalid == true)
                    {
                        valid.Add(user);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, valid));
        }

        public static bool IsValid(string user)
        {
            foreach (var let in user)
            {
                if (char.IsLetterOrDigit(let) || let == '-' || let == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
