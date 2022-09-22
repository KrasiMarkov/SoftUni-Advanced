using System;
using System.Linq;
using System.Collections.Generic;
namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> counts = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];

                if (!counts.ContainsKey(currentNumber))
                {
                    counts[currentNumber] = 0;
                }

                counts[currentNumber] += 1;

            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
