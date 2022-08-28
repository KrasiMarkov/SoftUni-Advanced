using System;
using System.Collections.Generic;
using System.Linq;
namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>();

            int N = numbers[0];

            int S = numbers[1];

            int X = numbers[2];

            

            

            for (int i = 0; i < N; i++)
            {
                int num = arr[i];

                myStack.Push(num);
                
            }

            for (int i = 0; i < S; i++)
            {
                myStack.Pop();

               
            }


            if (myStack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (myStack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(myStack.Min());
            }

            



        }
    }
}
