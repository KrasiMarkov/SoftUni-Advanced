using System;
using System.Collections.Generic;
namespace Stacks_and_Queues___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> myStack = new Stack<char>();

            foreach (var item in input)
            {
                myStack.Push(item);
            }

            

            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop());
            }

        }
    }
}
