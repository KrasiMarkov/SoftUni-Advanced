using System;
using System.Linq;
using System.Collections.Generic;
namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Statistics")
                {
                    break;
                }

                else if (command[1] == "joined")
                {
                    string vloggerName = command[0];

                    if (!app.ContainsKey(vloggerName))
                    {
                        app.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        app[vloggerName].Add("followers", new SortedSet<string>());
                        app[vloggerName].Add("following", new SortedSet<string>());

                    }
                }

                else
                {
                    string vloggerName = command[0];

                    string secondVloggerName = command[2];

                    if (vloggerName == secondVloggerName || !app.ContainsKey(vloggerName) || !app.ContainsKey(secondVloggerName))
                    {
                        continue;
                    }

                    app[vloggerName]["following"].Add(secondVloggerName);
                    app[secondVloggerName]["followers"].Add(vloggerName);
                }
            }

            Console.WriteLine($"The V-Logger has a total of {app.Count} vloggers in its logs.");

            int counter = 1;

            app = app.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count).ToDictionary(x => x.Key, y => y.Value);

            foreach ((string vlogger, Dictionary<string, SortedSet<string>> vloggerProfile) in app)
            {

                Console.WriteLine($"{counter++}. {vlogger} : {vloggerProfile["followers"].Count} followers, {vloggerProfile["following"].Count} following");

                if (counter == 2)
                {
                    foreach (string f in vloggerProfile["followers"])
                    {
                        Console.WriteLine($"*  {f}");
                    }
                }
            }
                        
        }
    }
}
