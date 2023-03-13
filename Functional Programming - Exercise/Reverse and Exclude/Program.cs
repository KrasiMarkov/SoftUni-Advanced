using System;
using System.Linq;
using System.Collections.Generic;
namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();

            Func<List<int>, int, List<int>> myFunc = RemoveNumbers;

            var result = myFunc(numbers, n);

            Console.WriteLine(string.Join(" ", result));

        }

        static List<int> RemoveNumbers(List<int> numbers, int n)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int current = numbers[i];

                if (current % n == 0)
                {
                    numbers.Remove(current);
                    
                    i--;
                }


            }


            return numbers;
        }
    }
}
