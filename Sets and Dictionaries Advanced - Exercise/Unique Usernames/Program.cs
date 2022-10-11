using System;
using System.Linq;
using System.Collections.Generic;
namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                names.Add(word);
            }


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
