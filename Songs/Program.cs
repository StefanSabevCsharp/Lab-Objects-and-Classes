using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Song song = new Song();
                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];
                songList.Add(song);


            }
            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var item in songList)
                {
                    Console.WriteLine(item.Name);
                }

            }
            else
            {
                foreach (Song item in songList)
                {
                    if (command == item.TypeList)
                    {

                        Console.WriteLine(item.Name);
                    }

                }

            }
        }
    }
    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
