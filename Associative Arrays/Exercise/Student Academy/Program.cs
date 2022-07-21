using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC218
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                double avg = student.Value.Average();
                if (avg >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {avg:f2}");
                }
            }
        }
    }
}
