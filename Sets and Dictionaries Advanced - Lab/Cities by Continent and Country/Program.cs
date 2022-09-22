using System;
using System.Linq;
using System.Collections.Generic;
namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> myDic = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();

                string continent = info[0];

                string countrie = info[1];

                string town = info[2];

                if (!myDic.ContainsKey(continent))
                {
                    myDic[continent] = new Dictionary<string, List<string>>();


                }

                if (!myDic[continent].ContainsKey(countrie))
                {

                    myDic[continent][countrie] = new List<string>();

                }

                myDic[continent][countrie].Add(town);
            }

            foreach (var item in myDic)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var itemm in item.Value)
                {
                    Console.WriteLine($"  {itemm.Key} -> {string.Join(", ", itemm.Value)}");
                }
                
            }
        }
    }
}
