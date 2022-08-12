using System;

namespace FundC21
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostgames = double.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double headsettrash = Math.Floor(lostgames / 2);
            double mousetrash = Math.Floor(lostgames / 3);
            double keyboardtrash = Math.Floor(lostgames / 6);
            double displaytrash = Math.Floor(keyboardtrash / 2);

            double rage = (headsettrash * headset) + (mousetrash * mouse) + (keyboardtrash * keyboard) + (displaytrash * display);

            Console.WriteLine($"Rage expenses: {rage:f2} lv.");
        }
    }
}
