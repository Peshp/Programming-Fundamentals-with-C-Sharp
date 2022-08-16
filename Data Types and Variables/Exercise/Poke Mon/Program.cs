using System;

namespace FundC49
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); 
            int M = int.Parse(Console.ReadLine()); 
            sbyte Y = sbyte.Parse(Console.ReadLine());            
            int pokedtargets = 0;
            int originalvaluebytwo = N / 2;
            while (N >= M)
            {
                N -= M;
                pokedtargets++;               
                if(N == originalvaluebytwo)
                {
                    if(Y == 0)
                    {
                        N *= 1;
                    }
                    else if(N / Y >= 1)
                    {
                        N /= Y;
                    }
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokedtargets);
        }
    }
}
