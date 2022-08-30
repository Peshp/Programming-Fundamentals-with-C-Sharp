using System;

namespace FundC84
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());        
            
            int result = WhoisBiggest(one, two, three);
            Console.WriteLine(result);
        }
        private static int WhoisBiggest(int one, int two, int three)
        {
            int min = 0;
            if (one <= two && one <= three)
                min = one;
            if (two <= one && two <= three)
                min = two;
            if (three <= one && three <= two)
                min = three;

            return min;
        }
    }
}
