using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC199
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog lists = new Catalog();
            List<Truck> listtruck = new List<Truck>();
            List<Car> listcar = new List<Car>();

            while (true)
            {
                string command = Console.ReadLine();
                string[] token = command.Split("/");

                if (token[0] == "end")
                {
                    break;
                }

                switch (token[0])
                {
                    case "Truck":
                        Truck inf = new Truck()
                        {
                            Brand = token[1],
                            Model = token[2],
                            Weight = int.Parse(token[3])
                        };
                        listtruck.Add(inf);
                        break;
                    case "Car":
                        Car infcar = new Car()
                        {
                            Brand = token[1],
                            Model = token[2],
                            HorsePower = int.Parse(token[3])
                        };
                        listcar.Add(infcar);
                        break;
                }
            }

            if (listcar.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> filterCars = listcar.OrderBy(cars => cars.Brand).ToList();
                foreach (Car infcar in filterCars)
                {
                    Console.WriteLine($"{infcar.Brand}: {infcar.Model} - {infcar.HorsePower}hp");
                }
            }

            if (listtruck.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> filterTrucks = listtruck.OrderBy(trucks => trucks.Brand).ToList();
                foreach (Truck inf in filterTrucks)
                {
                    Console.WriteLine($"{inf.Brand}: {inf.Model} - {inf.Weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public List<Truck> CollectionOfTrucks { get; set; }
        public List<Car> CollectionOfCars { get; set; }
    }
}
