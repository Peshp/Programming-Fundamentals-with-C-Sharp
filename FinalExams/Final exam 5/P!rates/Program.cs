using System;
using System.Collections.Generic;
using System.Linq;

namespace _05Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            var anno = new Dictionary<string, Dictionary<int, int>>();

            while (line != "Sail")
            {
                line = Console.ReadLine();
                string[] token = line.Split("||");
                if(token[0] == "Sail")
                {
                    break;
                }
                string city = token[0];
                int population = int.Parse(token[1]);
                int gold = int.Parse(token[2]);

                if(anno.ContainsKey(city))
                {
                    int newPop = anno[city].Keys.First();
                    int newGold = anno[city].Values.First();
                    anno[city].Clear();

                    anno[city].Add(population + newPop, gold + newGold);
                }
                else
                {
                    anno.Add(city, new Dictionary<int, int>());
                    anno[city].Add(population, gold);
                }
            }

            string command = "";
            while (command != "End")
            {
                command = Console.ReadLine();
                string[] token = command.Split("=>");

                string type = token[0];
                switch (type)
                {
                    case "Plunder":
                        PlunderMethod(token, anno);
                        break;
                    case "Prosper":
                        ProsperMethod(token, anno);
                        break;
                }
            }
            if(anno.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {anno.Count} wealthy settlements to go to:");
                foreach (var item in anno)
                {
                    int people = item.Value.FirstOrDefault().Key;
                    int gold = item.Value.FirstOrDefault().Value;

                    Console.WriteLine($"{item.Key} -> Population: {people} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static void ProsperMethod(string[] token, Dictionary<string, Dictionary<int, int>> anno)
        {
            string town = token[1];
            int gold = int.Parse(token[2]);

            if(gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
            else
            {
                int currGold = anno[town].Values.First();
                int population = anno[town].Keys.First();

                anno[town].Clear();
                anno[town].Add(population, currGold + gold);

                Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {currGold + gold} gold.");
            }
        }

        private static void PlunderMethod(string[] token, Dictionary<string, Dictionary<int, int>> anno)
        {
            string town = token[1];
            int people = int.Parse(token[2]);
            int gold = int.Parse(token[3]);

            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

            int currPeople = anno[town].Keys.First();
            int currGold = anno[town].Values.First();
            anno[town].Clear();

            anno[town].Add(currPeople - people, currGold - gold);
            if(anno[town].Keys.First() <= 0 || anno[town].Values.First() <= 0)
            {
                Console.WriteLine($"{town} has been wiped off the map!");
                anno.Remove(town);
            }
        }
    }
}
