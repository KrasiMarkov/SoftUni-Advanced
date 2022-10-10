using System;
using System.Linq;
using System.Collections.Generic;
namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> firstSet = new List<int>();

            List<int> secondSet = new List<int>();

            HashSet<int> repeatNumbers = new HashSet<int>();

            int lengthFirstSet = numbers[0];

            int lengthSecondSet = numbers[1];

            

            for (int i = 0; i < lengthFirstSet; i++)
            {
                int num = int.Parse(Console.ReadLine());

                firstSet.Add(num);
            }

            for (int i = 0; i < lengthSecondSet; i++)
            {
                int num = int.Parse(Console.ReadLine());

                secondSet.Add(num);
            }

            for (int i = 0; i < firstSet.Count; i++)
            {
                int currentFirstSet = firstSet[i];

                

                if (secondSet.Contains(currentFirstSet))
                {
                    repeatNumbers.Add(currentFirstSet);
                }
            }

            Console.WriteLine(string.Join(" ", repeatNumbers));

        }
    }
}
