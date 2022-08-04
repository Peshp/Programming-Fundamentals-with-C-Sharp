using System;

namespace _04Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string command = "";
            string odd = "";

            while (command != "Done")
            {
                command = Console.ReadLine();
                string[] token = command.Split();
                string type = token[0];

                switch (type)
                {
                    case "TakeOdd":
                        for (int i = 0; i < pass.Length; i++)
                        {
                            if(i % 2 != 0)
                            {
                                odd += pass[i];
                            }
                        }
                        pass = odd;
                        Console.WriteLine(pass);
                        break;
                    case "Cut":
                        int index = int.Parse(token[1]);
                        int length = int.Parse(token[2]);
                       
                        pass = pass.Remove(index, length);
                        Console.WriteLine(pass);
                        break;
                    case "Substitute":
                        string oldOne = token[1];
                        string newOne = token[2];
                        if(pass.Contains(oldOne))
                        {
                            pass = pass.Replace(oldOne, newOne);
                            Console.WriteLine(pass);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }
            Console.WriteLine($"Your password is: {pass}");
        }      
    }
}
