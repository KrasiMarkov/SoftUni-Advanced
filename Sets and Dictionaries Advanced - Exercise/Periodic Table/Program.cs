using System;
using System.Linq;
using System.Collections.Generic;
namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    chemicalElements.Add(elements[j]);


                }
            }

            foreach (var item in chemicalElements)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
