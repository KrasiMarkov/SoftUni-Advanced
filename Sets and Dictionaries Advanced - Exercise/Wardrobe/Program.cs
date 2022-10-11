using System;
using System.Linq;
using System.Collections.Generic;
namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> myDict = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] myArr = Console.ReadLine().Split(" -> ").ToArray();

                string color = myArr[0];

                string[] clothes = myArr[1].Split(",").ToArray();

                if (!myDict.ContainsKey(color))
                {
                    myDict[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string oneClothes = clothes[j];

                    if (!myDict[color].ContainsKey(oneClothes))
                    {
                        myDict[color][oneClothes] = 0;
                    }

                    myDict[color][oneClothes]++;
                }
            }

            string[] wantedClothes = Console.ReadLine().Split().ToArray();

            string wantedColor = wantedClothes[0];

            string wantedCloth = wantedClothes[1];

            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key} clothes:");

                if (item.Key == wantedColor)
                {
                    foreach (var itemm in item.Value)
                    {
                        if (itemm.Key == wantedCloth)
                        {
                            Console.WriteLine($"* {itemm.Key} - {itemm.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {itemm.Key} - {itemm.Value}");
                        }
                    }
                }

                else
                {
                    foreach (var itemm in item.Value)
                    {
                        
                        Console.WriteLine($"* {itemm.Key} - {itemm.Value}");
                        
                    }
                }

            }
        }
    }
}
