using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC203
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> std = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[] inf = Console.ReadLine().Split();
                var students = new Students (inf[0], inf[1], double.Parse(inf[2]));
                std.Add(students);
            }

            std = std.OrderByDescending(currStudent => currStudent.Grade).ToList();
            foreach (var students in std)
            {
                Console.WriteLine(students);
            }
        }
    }

    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
