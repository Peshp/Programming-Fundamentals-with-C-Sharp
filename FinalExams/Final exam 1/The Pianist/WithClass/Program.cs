using System;
using System.Collections.Generic;
using System.Linq;

namespace _01ExamClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var musician = new List<Music>();
            for (int i = 0; i < n; i++)
            {
                string music = Console.ReadLine();
                string[] token = music.Split("|");

                musician.Add(new Music(token[0], token[1], token[2]));
            }

            string command = "";
            while (command != "Stop")
            {
                command = Console.ReadLine();
                string[] token = command.Split("|");

                string type = token[0];
                switch (type)
                {
                    case "Add":
                        AddMethod(musician, token);
                        break;
                    case "Remove":
                        RemoveMethod(musician, token);
                        break;
                    case "ChangeKey":
                        ChangeKeyMethod(musician, token);
                        break;
                }
            }
            Console.WriteLine(string.Join("\n", musician.Select(x => $"{x.Piece} -> Composer: {x.Composer}, Key: {x.Key}")));

        }

        private static void ChangeKeyMethod(List<Music> musician, string[] token)
        {
            string piece = token[1];
            string newKey = token[2];

            if(musician.Any(x => x.Piece == piece))
            {
                musician.First(x => x.Piece == piece).Key = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void RemoveMethod(List<Music> musician, string[] token)
        {
            string piece = token[1];
            if(musician.Any(x => x.Piece == piece))
            {
                Music removePiece = musician.Find(x => x.Piece == piece);
                musician.Remove(removePiece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void AddMethod(List<Music> musician, string[] token)
        {
            string piece = token[1];
            string composer = token[2];
            string key = token[3];

            if(musician.Any(x => x.Piece == piece))
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            else
            {
                musician.Add(new Music(piece, composer, key));
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
            }
        }
    }
    class Music
    {
        public string Piece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
        public Music(string piece, string composer, string key)
        {
            this.Piece = piece;
            this.Composer = composer;
            this.Key = key;
        }
    }
}
