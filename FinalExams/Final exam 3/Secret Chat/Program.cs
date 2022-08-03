using System;

namespace _03Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = "";

            while (command != "Reveal")
            {
                command = Console.ReadLine();
                string[] token = command.Split(":|:");

                string type = token[0];
                switch (type)
                {
                    case "InsertSpace":
                        int index = int.Parse(token[1]);
                        text = text.Insert(index, " ");
                        Console.WriteLine(text);
                        break;
                    case "Reverse":
                        string message = token[1];
                        string reverse = "";

                        if (text.Contains(message))
                        {
                            for (int i = message.Length - 1; i >= 0; i--)
                            {
                                reverse += message[i];
                            }
                            int indexof = text.IndexOf(message);
                            while (indexof != -1)
                            {
                                text = text.Remove(indexof, message.Length);
                                indexof = text.IndexOf(message);
                            }
                            text = text.Insert(text.Length, reverse);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string old = token[1];
                        string newOne = token[2];
                        text = text.Replace(old, newOne);
                        Console.WriteLine(text);
                        break;
                }

            }
            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
