using System;

namespace _01Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = "";

            while (command != "Decode")
            {
                command = Console.ReadLine();
                string[] token = command.Split('|');
                string type = token[0];

                switch (type)
                {
                    case "Move":
                        int length = int.Parse(token[1]);
                        string moveMessage = message.Substring(0, length);

                        message = message.Remove(0, length);
                        message += moveMessage;
                        break;
                    case "Insert":
                        int index = int.Parse(token[1]);
                        string value = token[2];
                        message = message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string substring = token[1];
                        string replace = token[2];

                        message = message.Replace(substring, replace);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {string.Join(" ", message)}");
        }
    }
}
