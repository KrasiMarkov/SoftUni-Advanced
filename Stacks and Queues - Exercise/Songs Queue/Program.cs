using System;
using System.Collections.Generic;
using System.Linq;
namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(", ").ToArray();

            Queue<string> songs = new Queue<string>(sequence);

            while (songs.Count > 0)
            {
                string[] command = Console.ReadLine().Split(" ", 2);

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }

                else if (command[0] == "Add")
                {
                    string song = command[1];

                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }

                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }

                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
