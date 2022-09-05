using System;
using System.Linq;
using System.Collections.Generic;
namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {

                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (query[0] == 1)
                {
                    int element = query[1];

                    numbers.Push(element);
                }

                else if (query[0] == 2)
                {
                    if (numbers.Any())
                    {
                        numbers.Pop();
                    }
                    
                }

                else if (query[0] == 3)
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Max());
                    }

                    
                }

                else if (query[0] == 4)
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Min());
                    }

                    
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
