using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC205
{
    class Program
    {
        static void Main()
        {
            List<Venicle> catalog = new List<Venicle>();

            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] commands = line.Split();
                var currVenicle = new Venicle(commands[0], commands[1], commands[2], 
                    int.Parse(commands[3]));
                catalog.Add(currVenicle);

                line = Console.ReadLine();
            }

            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }
                Console.WriteLine(catalog.Find(x => x.Model == model));
            }
            var onlyCars = catalog.Where(x => x.Type == "car").ToList();
            var onlyTrucks = catalog.Where(x => x.Type == "truck").ToList();

            double powerCars = 0;
            double powerTruck = 0;
            foreach (var cars in onlyCars)
            {
                powerCars += cars.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                powerTruck += truck.HorsePower;
            }

            double avcar = powerCars / onlyCars.Count;
            double avtruck = powerTruck / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avcar:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avtruck:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    class Venicle
    {
        public Venicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            string str = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                         $"Model: {this.Model}{Environment.NewLine}" +
                         $"Color: {this.Color}{Environment.NewLine}" +
                         $"Horsepower: {this.HorsePower}";
            return str;
        }
    }
}
