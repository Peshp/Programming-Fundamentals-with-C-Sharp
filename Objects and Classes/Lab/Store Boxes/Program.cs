using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC198
{
    public class Start
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split();

                Box box = new Box()
                {
                    SerialNumber = token[0],
                    Item = new Item(token[1], decimal.Parse(token[3])),
                    ItemQuantity = int.Parse(token[2])
                };

                boxes.Add(box);
            }
            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.Price).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"--{box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"--${box.Price:f2}");
            }
        }
    }

    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        public decimal Price
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }
    }
}
