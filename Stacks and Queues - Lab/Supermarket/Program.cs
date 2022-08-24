using System;
using System.Collections.Generic;
using System.Linq;
namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> myQueue = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                else if (name == "Paid")
                {
                    while (myQueue.Count > 0)
                    {
                        Console.WriteLine(myQueue.Dequeue());
                    }

                    continue;
                }
                myQueue.Enqueue(name);

            }

            Console.WriteLine($"{myQueue.Count} people remaining.");


        }
    }
}
