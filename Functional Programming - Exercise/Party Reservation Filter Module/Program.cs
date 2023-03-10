using System;
using System.Linq;
using System.Collections.Generic;
namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            List<string> removedNames = new List<string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(";").ToArray();

                if (command[0] == "Print")
                {
                    break;
                }

                else if (command[0] == "Remove filter")
                {
                    if (command[1] == "Starts with")
                    {
                        string text = command[2];

                        for (int i = 0; i < removedNames.Count; i++)
                        {
                            string current = removedNames[i];

                            if (current.StartsWith(text))
                            {
                                names.Insert(0, current);

                                removedNames.RemoveAt(i);

                                break;
                            }
                        }
                    }

                    else if (command[1] == "Ends with")
                    {
                        string text = command[2];

                        for (int i = 0; i < removedNames.Count; i++)
                        {
                            string current = removedNames[i];

                            if (current.EndsWith(text))
                            {
                                names.Insert(0, current);

                                removedNames.RemoveAt(i);

                                break;
                            }
                        }
                    }

                    else if (command[1] == "Length")
                    {
                        int length = int.Parse(command[2]);


                        for (int i = 0; i < removedNames.Count; i++)
                        {
                            string current = removedNames[i];

                            if (current.Length == length)
                            {
                                names.Insert(0, current);

                                removedNames.RemoveAt(i);

                                break;
                            }
                        }
                    }

                    else if (command[1] == "Contains")
                    {
                        string text = command[2];

                        for (int i = 0; i < removedNames.Count; i++)
                        {
                            string current = removedNames[i];

                            if (current.Contains(text))
                            {
                                names.Insert(0, current);

                                removedNames.RemoveAt(i);

                                break;
                            }
                        }
                    }

                }

                else if (command[0] == "Add filter")
                {
                    if (command[1] == "Starts with")
                    {
                        string text = command[2];

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.StartsWith(text))
                            {
                                names.RemoveAt(i);

                                removedNames.Add(current);

                                break;
                            }
                        }
                    }

                    else if (command[1] == "Ends with")
                    {
                        string text = command[2];

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.EndsWith(text))
                            {
                                names.RemoveAt(i);

                                removedNames.Add(current);

                                break;
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

                                removedNames.Add(current);

                                break;
                            }
                        }
                    }

                    else if (command[1] == "Contains")
                    {
                        string text = command[2];

                        for (int i = 0; i < names.Count; i++)
                        {
                            string current = names[i];

                            if (current.Contains(text))
                            {
                                names.RemoveAt(i);

                                removedNames.Add(current);

                                break;
                            }
                        }
                    }

                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
