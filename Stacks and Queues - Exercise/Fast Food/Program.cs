using System;
using System.Collections.Generic;
using System.Linq;
	
namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFoodForDay = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> quantityAnOrder = new Queue<int>();

            

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                quantityAnOrder.Enqueue(current);
            }

            Console.WriteLine(quantityAnOrder.Max());

            while (quantityAnOrder.Any())
            {
                int currentNumber = quantityAnOrder.Peek();

                if (quantityFoodForDay < currentNumber)
                {
                    break;

                }

                else
                {
                    quantityFoodForDay -= currentNumber;

                    quantityAnOrder.Dequeue();
                }
            }

            if (!quantityAnOrder.Any())
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", quantityAnOrder)}");
            }
        }
    }
}
