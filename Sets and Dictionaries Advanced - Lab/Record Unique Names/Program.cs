using System;
using System.Linq;
using System.Collections.Generic;
namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> myHash = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {

                string name = Console.ReadLine();

                myHash.Add(name);

            }

            foreach (var item in myHash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
