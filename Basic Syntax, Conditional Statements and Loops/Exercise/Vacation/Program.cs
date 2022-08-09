using System;

namespace FundC15
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typegroup = Console.ReadLine();
            string day = Console.ReadLine();
            int type = 0;
            double price = 0;
            double discount = 0;

            switch (typegroup)
            {
                case "Students":
                    type = 1;
                    break;
                case "Business":
                    type = 2;
                    break;
                case "Regular":
                    type = 3;
                    break;
            }

            switch(day)
            {
                case "Friday":
                    if(type == 1)
                    {
                        price = 8.45 * people;
                    }
                    else if(type == 2)
                    {
                        price = 10.9 * people;
                        discount = 10.9 * 10;
                    }
                    else if(type == 3)
                    {
                        price = 15 * people;
                    }
                    break;
                case "Saturday":
                    if (type == 1)
                    {
                        price = 9.8 * people;
                    }
                    else if (type == 2)
                    {
                        price = 15.6 * people;
                        discount = 15.6 * 10;
                    }
                    else if (type == 3)
                    {
                        price = 20 * people;
                    }
                    break;
                case "Sunday":
                    if (type == 1)
                    {
                        price = 10.46 * people;
                    }
                    else if (type == 2)
                    {
                        price = 16 * people;
                        discount = 16 * 10;
                    }
                    else if (type == 3)
                    {
                        price = 22.5 * people;
                    }
                    break;
            }
            if(type == 1 && people > 29)
            {
                price -= price * 0.15;
            }
            else if(type == 2 && people > 99)
            {
                price -= discount;
            }
            else if (type > 9 && people < 21 && type == 3)
            {
                price -= price * 0.05;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
