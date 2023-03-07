using System;
using System.Linq;
using System.Collections.Generic;
namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> total = new List<int>();

            int arrayLength = numbers.Length;

            for (int i = 1; i <= N; i++)
            {
                int counter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int current = numbers[j];

                    if (i % current == 0)
                    {
                        counter++;
                    }

                    else
                    {
                        break;
                    }
                }

                if (counter == arrayLength)
                {
                    total.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", total));

        }
    }
}
