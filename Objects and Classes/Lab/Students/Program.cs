using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC196x2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> inf = new List<Students>();
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                string[] token = command.Split();

                string first = token[0];
                if (first == "end")
                {
                    break;
                }
                string last = token[1];
                int age = int.Parse(token[2]);
                string town = token[3];

                Students student = new Students();
                {
                    student.FirstName = first;
                    student.LastName = last;
                    student.Age = age;
                    student.HomeTown = town;
                }
                
                inf.Add(student);
            }

            string city = Console.ReadLine();
            foreach (Students student in inf)
            {
                if (city == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
