using System;
using System.Linq;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] info = Console.ReadLine().Split(", ").ToArray();

                if (info[0] == "Revision")
                {
                    break;
                }

                string shop = info[0];

                string product = info[1];

                double price = double.Parse(info[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }

                shops[shop][product] = price;
            }

            foreach (var item in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}-> ");

                foreach (var itemm in item.Value)
                {
                    Console.WriteLine($"Product: {itemm.Key}, Price: {itemm.Value}");
                }
            }
        }
    }
}
