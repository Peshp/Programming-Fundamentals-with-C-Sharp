using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            var plant = new Dictionary<string, Dictionary<int, List<double>>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("<->");
                string typePlant = info[0];
                int rare = int.Parse(info[1]);

                if (plant.ContainsKey(typePlant))
                {
                    plant[typePlant].Clear();
                    plant[typePlant].Add(rare, new List<double>());
                }
                else
                {
                    plant.Add(typePlant, new Dictionary<int, List<double>>());
                    plant[typePlant].Add(rare, new List<double>());
                }
            }
            string command = "";
            while (command != "Exhibition")
            {
                command = Console.ReadLine();
                string[] token = command.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string type = token[0];

                switch (type)
                {
                    case "Rate":
                        RateMethod(token, plant);
                        break;
                    case "Update":
                        UpdateMethod(token, plant);
                        break;
                    case "Reset":
                        ResetMethod(token, plant);
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var p in plant)
            {
                int rare = p.Value.FirstOrDefault().Key;
                var rating = p.Value.FirstOrDefault().Value;
                double sum = 0;

                for (int i = 0; i < rating.Count; i++)
                {
                    sum += rating[i];
                }
                double result = rating.Count > 0 ? sum / rating.Count : 0.00;
                Console.WriteLine($"- {p.Key}; Rarity: {rare}; Rating: {result:f2}");
            }
        }

        private static void ResetMethod(string[] token, Dictionary<string, Dictionary<int, List<double>>> plant)
        {
            string flower = token[1];

            if (plant.ContainsKey(flower))
            {
                var rarity = plant[flower].Keys.First();
                var rating = plant[flower].Values.First();
                plant[flower].Clear();
                plant[flower].Add(rarity, new List<double>());
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void UpdateMethod(string[] token, Dictionary<string, Dictionary<int, List<double>>> plant)
        {
            string flower = token[1];
            int rarity = int.Parse(token[2].Trim());

            if (plant.ContainsKey(flower))
            {
                var rating = plant[flower].Values.First();
                plant[flower].Clear();
                plant[flower].Add(rarity, rating);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void RateMethod(string[] token, Dictionary<string, Dictionary<int, List<double>>> plant)
        {
            string flower = token[1];
            double rating = double.Parse(token[2].Trim());
            if (plant.ContainsKey(flower))
            {
                var rare = plant[flower].Keys.First();
                plant[flower][rare].Add(rating);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
