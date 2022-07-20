using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC217
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string command = "";

            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] token = command.Split(" : ");
                string course = token[0];
                string name = token[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(name);
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
