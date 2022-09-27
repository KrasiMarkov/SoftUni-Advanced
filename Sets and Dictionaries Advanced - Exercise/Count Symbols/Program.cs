using System;
using System.Linq;
using System.Collections.Generic;
namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            SortedDictionary<char, int> sortedSymbols = new SortedDictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                char symbol = word[i];

                if (!sortedSymbols.ContainsKey(symbol))
                {
                    sortedSymbols[symbol] = 0;
                }

                sortedSymbols[symbol]++;

            }

            foreach (var item in sortedSymbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");


            }
        }
    }
}
