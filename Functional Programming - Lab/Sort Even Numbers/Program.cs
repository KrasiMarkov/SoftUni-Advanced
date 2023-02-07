using System;
using System.Collections.Generic;
using System.Linq;
namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ", line));





        }
    }
}
