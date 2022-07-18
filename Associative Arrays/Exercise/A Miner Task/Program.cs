using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC213
{
    class Program
    {
        static void Main(string[] args)
        {
            var miner = new Dictionary<string, int>();
            string mine = "";
            int count = 0;

            while (true)
            {
                mine = Console.ReadLine();
                if (mine == "stop")
                {
                    break;
                }
                count = int.Parse(Console.ReadLine());

                if (miner.ContainsKey(mine))
                {
                    miner[mine] += count;
                }
                else
                {
                    miner.Add(mine, count);
                }
            }

            foreach (var mines in miner)
            {
                Console.WriteLine($"{mines.Key} -> {mines.Value}");
            }
        }
    }
}
