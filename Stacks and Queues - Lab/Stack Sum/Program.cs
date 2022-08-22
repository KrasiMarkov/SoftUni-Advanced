using System;
using System.Collections.Generic;
using System.Linq;
namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                myStack.Push(input[i]);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                else if (command[0] == "add")
                {
                    int firstNumber = int.Parse(command[1]);

                    int secondNumber = int.Parse(command[2]);

                    myStack.Push(firstNumber);

                    myStack.Push(secondNumber);

                }

                else if (command[0] == "remove")
                {
                    int count = int.Parse(command[1]);

                    if (myStack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            myStack.Pop();
                        }
                    }


                }

            }

            int sum = 0;

            foreach (var item in myStack)
            {
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
