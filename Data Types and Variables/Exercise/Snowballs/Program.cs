using System;
using System.Numerics;

namespace FundC50
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger highest = 0;
            int highestsnow = 0;
            int highesttime = 0;
            int highestquality = 0;
            for (int i = 0; i < N; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if(snowballValue > highest)
                {
                    highest = snowballValue;
                    highestsnow = snowballSnow;
                    highesttime = snowballTime;
                    highestquality = snowballQuality;
                }
            }
            Console.WriteLine($"{highestsnow} : {highesttime} = {highest} ({highestquality})");
        }
    }
}
