using System;
using System.Linq;
using System.Collections.Generic;
namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Party!")
                {
                    break;
                }

                else if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        string text = command[2];

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.Contains(text))
                            {
                                names.RemoveAt(i);

                                i--;
                            }
                        }
                    }

                    else if (command[1] == "EndsWith")
                    {
                        string text = command[2];

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.Contains(text))
                            {
                                names.RemoveAt(i);

                                i--;
                            }
                        }
                    }

                    else if (command[1] == "Length")
                    {
                        int length = int.Parse(command[2]);

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.Length == length)
                            {
                                names.RemoveAt(i);

                                i--;
                            }
                        }
                    }

                }

                else if (command[0] == "Double")
                {
                    if (command[1] == "StartsWith")
                    {
                        string text = command[2];

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.Contains(text))
                            {
                                names.Insert(i + 1, current);

                                i = i + 1;
                            }
                        }
                    }

                    else if (command[1] == "EndsWith")
                    {
                        string text = command[2];

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.Contains(text))
                            {
                                names.Insert(i + 1, current);

                                i = i + 1;
                            }
                        }
                    }

                    else if (command[1] == "Length")
                    {
                        int length = int.Parse(command[2]);

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.Length == length)
                            {
                                names.Insert(i + 1, current);

                                i = i + 1;
                            }
                        }
                    }

                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            

        }
    }
}
