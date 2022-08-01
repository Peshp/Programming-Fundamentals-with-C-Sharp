using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var music = new Dictionary<string, Dictionary<string, string>>();
            for (int i = 0; i < n; i++)
            {
                string[] pieces = Console.ReadLine().Split('|');
                string piece = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];

                music.Add(piece, new Dictionary<string, string>());
                music[piece].Add(composer, key);
            }

            string command = "";
            while (command != "Stop")
            {
                command = Console.ReadLine();
                string[] token = command.Split('|');
                string type = token[0];              

                switch (type)
                {
                    case "Add":
                        AddMethod(token, music);                   
                        break;
                    case "Remove":
                        RemoveMethod(token, music);
                        break;
                    case "ChangeKey":
                        ChangeMethod(token, music);
                        break;
                }
            }

            foreach (var piece in music)
            {
                string composer = piece.Value.FirstOrDefault().Key;
                string key = piece.Value.FirstOrDefault().Value;
                Console.WriteLine($"{piece.Key} -> Composer: {composer}, Key: {key}");
            }
        }

        private static void ChangeMethod(string[] token, Dictionary<string, Dictionary<string, string>> music)
        {            
            string piece = token[1];
            string key = token[2];

            if(music.ContainsKey(piece))
            {
                var thisComposer = music[piece].Keys.First();
                music[piece][thisComposer] = key;
                Console.WriteLine($"Changed the key of {piece} to {key}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void RemoveMethod(string[] token, Dictionary<string, Dictionary<string, string>> music)
        {           
            string piece = token[1];          

            if(music.ContainsKey(piece))
            {
                music.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void AddMethod(string[] token, Dictionary<string, Dictionary<string, string>> music)
        {          
            string piece = token[1];
            string composer = token[2];
            string key = token[3];

            if (music.ContainsKey(piece))
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            else
            {
                music.Add(piece, new Dictionary<string, string>());
                music[piece].Add(composer, key);
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
            }
        }
    }
}
