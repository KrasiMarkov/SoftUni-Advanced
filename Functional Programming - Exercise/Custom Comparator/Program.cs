using System;
using System.Linq;
using System.Collections.Generic;
namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //List<int> evenNumbers = new List<int>();

            //List<int> oddNumbers = new List<int>();

            //Action<int[]> myFunc = x => Console.WriteLine(string.Join(" ", numbers));

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int current = numbers[i];

            //    if (current % 2 == 0)
            //    {
            //        evenNumbers.Add(current);
            //    }

            //    else if (current % 2 != 0)
            //    {
            //        oddNumbers.Add(current);
            //    }

            //}

            //evenNumbers.Sort();

            //oddNumbers.Sort();

            //int index = 0;

            //for (int i = 0; i < evenNumbers.Count; i++)
            //{
            //    int current = evenNumbers[i];

            //    numbers[i] = current;

            //    index = i;
            //}

            //for (int i = 0; i < oddNumbers.Count; i++)
            //{
            //    int current = oddNumbers[i];

            //    numbers[index + 1 + i] = current;


            //}

            //myFunc(numbers);


            Array.Sort(numbers, (x, y) =>
            {
                int sorter = 0;

                if (x % 2 == 0 && y % 2 != 0)
                {
                    sorter = -1;
                }

                else if (x % 2 != 0 && y % 2 == 0)
                {
                    sorter = 1;
                }

                else
                {
                    sorter = x - y;
                }

                return sorter;

            });

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
