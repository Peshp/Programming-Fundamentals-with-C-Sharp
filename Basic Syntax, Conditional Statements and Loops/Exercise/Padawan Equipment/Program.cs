using System;

namespace FundC20
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());           

            double sabercount = Math.Ceiling(students + (students * 0.1));
            double freebeltcount = Math.Floor(students / 6.0);

            double saberprice = sabercount * lightsaber;
            double robeprice = students * robe;
            double beltprice = (students - freebeltcount) * belt;
            double Price = saberprice + robeprice + beltprice;

            if(Price <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {Price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(Price - money):f2}lv more.");
            }
        }
    }
}
