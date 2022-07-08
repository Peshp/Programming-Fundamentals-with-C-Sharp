using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC206
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> guys = new List<People>();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                string name = command[0];
                int id = int.Parse(command[1]);
                int age = int.Parse(command[2]);

                if (IsIDExist(guys, id))
                {
                    People guy = guys.Find(guy => guy.ID == id);
                    guy.Name = name;
                    guy.Age = age;
                }
                else
                {
                    People guy = new People()
                    {
                        Name = name,
                        ID = id,
                        Age = age
                    };
                    guys.Add(guy);
                }
            }

            foreach (var guy in guys.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{guy.Name} with ID: {guy.ID} is {guy.Age} years old.");
            }
        }

        static bool IsIDExist(List<People> guys, int id)
        {
            foreach (var guy in guys)
            {
                if (guy.ID == id)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class People
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
    }
}
