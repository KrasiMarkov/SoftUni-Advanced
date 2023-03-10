using System;
using System.Linq;
using System.Collections.Generic;
namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, bool> myFunc = x => x.Length <= n;

            names = names.Where(myFunc).ToList();

            names.ForEach(Console.WriteLine);

            


        }
    }
}
