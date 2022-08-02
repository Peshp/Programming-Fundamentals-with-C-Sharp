using System;
using System.Collections.Generic;

namespace _01Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = "";
            while (command != "Travel")
            {               
                command = Console.ReadLine();
                if(command == "Travel")
                {
                    break;
                }
                string[] token = command.Split(':');
                string type = token[0];
               

                switch (type)
                {
                    case "Add Stop":
                        int index = int.Parse(token[1]);
                        string destination = token[2];

                        if(index > -1 && index < stops.Length)
                        {
                            stops = stops.Insert(index, destination);               
                        }
                        break;
                    case "Remove Stop":
                        int first = int.Parse(token[1]);
                        int second = int.Parse(token[2]);

                        if(first > -1 && first < stops.Length && second > -1 && second < stops.Length)
                        {
                            stops = stops.Remove(first, second - first + 1);
                        }
                        break;
                    case "Switch":
                        string old = token[1];
                        string newOne = token[2];

                        if(stops.Contains(old))
                        {
                            stops = stops.Replace(old, newOne);
                        }
                        break;
                }
                Console.WriteLine(stops);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
