using System;
using System.Collections.Generic;

namespace FundC216
{
    class Program
    {
        static void Main(string[] args)
        {
            var registered = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "register":
                        RegisterMethod(registered, command);
                        break;
                    case "unregister":
                        UnRegisterMethod(registered, command);
                        break;
                }
            }
            foreach (var people in registered)
            {
                Console.WriteLine($"{people.Key} => {people.Value}");
            }
        }
        static void RegisterMethod(Dictionary<string, string> registered, string[] command)
        {
            string name = command[1];
            string num = command[2];
            if(registered.ContainsKey(name))
            {
                Console.WriteLine($"ERROR: already registered with plate number {num}");
            }
            else
            {
                registered.Add(name, num);
                Console.WriteLine($"{name} registered {num} successfully");
            }
        }
        static void UnRegisterMethod(Dictionary<string, string> registered, string[] command)
        {
            string name = command[1];           
            if (registered.ContainsKey(name))
            {
                Console.WriteLine($"{name} unregistered successfully");
                registered.Remove(name);                          
            }
            else
            {
                Console.WriteLine($"ERROR: user {name} not found");
            }
        }
    }
}
