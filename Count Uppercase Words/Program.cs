using System;
using System.Linq;
using System.Collections.Generic;
namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = word => word[0] == word.ToUpper()[0];

            var words = Console.ReadLine().Split().Where(func).ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        } 
    }
}
