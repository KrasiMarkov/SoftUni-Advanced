using System;
using System.Linq;
using System.Collections.Generic;
namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<int, int> addFunc = x => x += 1;
            Func<int, int> multiplyFunc = x => x *= 2;
            Func<int, int> subtractFunc = x => x -= 1;
            Action<List<int>> printList = x => Console.WriteLine(string.Join(" ", numbers));

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                else if (command == "add")
                {
                    numbers = numbers.Select(addFunc).ToList();
                }

                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiplyFunc).ToList();
                }

                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtractFunc).ToList();
                }

                else if (command == "print")
                {
                    printList(numbers);
                }
            }
        }
    }
}
