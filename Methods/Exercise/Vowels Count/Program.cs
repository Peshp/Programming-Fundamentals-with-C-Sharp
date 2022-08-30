using System;

namespace FundC85
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentences = Console.ReadLine().ToLower();
            int result = VowelsCount(sentences);
            Console.WriteLine(result);
        }
        private static int VowelsCount(string sentences)
        {
            int count = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                if(sentences[i] == 'a' || sentences[i] == 'e' || sentences[i] == 'i' || 
                    sentences[i] == 'o' || sentences[i] == 'u')
                {
                    count++;
                }

            }
            return count;
        }
    }
}
