using System;

namespace FundC38
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, height = 0;           
            lenght = double.Parse(Console.ReadLine());           
            width = double.Parse(Console.ReadLine());           
            height = double.Parse(Console.ReadLine());
            double Volume = (lenght * width * height) / 3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {Volume:f2}");
        }
    }
}
