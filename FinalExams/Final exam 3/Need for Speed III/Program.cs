using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Dictionary<int, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split("|");
                string type = car[0];
                int mileage = int.Parse(car[1]);
                int fuel = int.Parse(car[2]);              

                cars.Add(type, new Dictionary<int, int>());
                cars[type].Add(mileage, fuel);
            }

            string command = "";
            while (command != "Stop")
            {
                command = Console.ReadLine();
                string[] token = command.Split(" : ");

                string type = token[0];
                switch (type)
                {
                    case "Drive":
                        DriveMethod(token, cars);
                        break;
                    case "Refuel":
                        RefuelMethod(token, cars);
                        break;
                    case "Revert":
                        RevertMethod(token, cars);
                        break;
                }
            }
            foreach (var car in cars)
            {
                int mileage = car.Value.FirstOrDefault().Key;
                int fuel = car.Value.FirstOrDefault().Value;

                Console.WriteLine($"{car.Key} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }

        private static void RevertMethod(string[] token, Dictionary<string, Dictionary<int, int>> cars)
        {
            string car = token[1];
            int km = int.Parse(token[2]);
            var thisCar = cars[car].Values.First();
            var mileage = cars[car].Keys.First();          

            if (mileage - km < 10000)
            {
                cars[car].Clear();
                cars[car].Add(10000, thisCar);          
            }
            else
            {
                cars[car].Clear();               
                cars[car].Add(mileage - km, thisCar);
                Console.WriteLine($"{car} mileage decreased by {km} kilometers");
            }          
        }

        private static void RefuelMethod(string[] token, Dictionary<string, Dictionary<int, int>> cars)
        {
            string car = token[1];
            int fuel = int.Parse(token[2]);          
            var thisCar = cars[car].Values.First();
            var plusFuel = cars[car].Keys.First();            

            if(thisCar + fuel > 75)
            {                                          
                cars[car][plusFuel] = 75;
                Console.WriteLine($"{car} refueled with {75 - thisCar} liters");
            }
            else
            {
                cars[car][plusFuel] = thisCar + fuel;
                Console.WriteLine($"{car} refueled with {fuel} liters");
            }                   
        }

        private static void DriveMethod(string[] token, Dictionary<string, Dictionary<int, int>> cars)
        {
            string car = token[1];
            int distance = int.Parse(token[2]);
            int currFuel = int.Parse(token[3]);
            var thisCar = cars[car].Values.First();             
            var mileage = cars[car].Keys.First();

            if(thisCar < currFuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                cars[car].Clear();
                cars[car].Add(mileage + distance, thisCar - currFuel);              

                Console.WriteLine($"{car} driven for {distance} kilometers. {currFuel} liters of fuel consumed.");
            }           
            if (cars[car].Keys.First() >= 100000)
            {
                cars.Remove(car);
                Console.WriteLine($"Time to sell the {car}!");
            }
        }
    }
}
