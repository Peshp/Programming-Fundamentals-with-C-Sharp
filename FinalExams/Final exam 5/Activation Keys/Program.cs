using System;

namespace _05Rxam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string command = "";

            while (command != "Generate")
            {
                command = Console.ReadLine();
                string[] token = command.Split(">>>");

                string type = token[0];
                switch (type)
                {
                    case "Contains":
                        string substring = token[1];
                        if(key.Contains(substring))
                        {
                            Console.WriteLine($"{key} contains {substring}");
                            Console.WriteLine(key);
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }                       
                        break;
                    case "Flip":
                        string upOrlow = token[1];
                        int start = int.Parse(token[2]);
                        int end = int.Parse(token[3]);

                        switch (upOrlow)
                        {
                            case "Upper":
                                if(start == end)
                                {
                                    char letter = key[start];
                                    string up = letter.ToString().ToUpper();
                                    key = key.Replace(letter.ToString(), up);
                                }
                                string upper = key.Substring(start, end - start);
                                string toUpper = upper.ToUpper();
                                key = key.Replace(upper, toUpper);
                                break;
                            case "Lower":
                                if (start == end)
                                {
                                    char letter = key[start];
                                    string low = letter.ToString().ToLower();
                                    key = key.Replace(letter.ToString(), low);
                                }
                                string lower = key.Substring(start, end - start);
                                string toLower = lower.ToLower();
                                key = key.Replace(lower, toLower);
                                break;
                        }
                        Console.WriteLine(key);
                        break;
                    case "Slice":
                        int startIndex = int.Parse(token[1]);
                        int endIndex = int.Parse(token[2]);
                        key = key.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(key);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
