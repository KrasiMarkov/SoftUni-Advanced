using System;
using System.Linq;
namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(line.Count());
            Console.WriteLine(line.Sum());


        }
    }
}
