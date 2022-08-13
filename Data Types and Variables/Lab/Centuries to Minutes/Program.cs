using System;

namespace FundC31
{
    class Program
    {
        static void Main(string[] args)
        {
            int cent = int.Parse(Console.ReadLine());
            int years = cent * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine($"{cent} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
