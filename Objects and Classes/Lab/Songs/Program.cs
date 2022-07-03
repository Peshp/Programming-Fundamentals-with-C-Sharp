using System;
using System.Collections.Generic;

namespace FundC195
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < num; i++)
            {
                string[] things = Console.ReadLine().Split("_");

                var type = things[0];
                var name = things[1];
                var time = things[2];

                Song song = new Song();

                song.Type = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.Type == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
