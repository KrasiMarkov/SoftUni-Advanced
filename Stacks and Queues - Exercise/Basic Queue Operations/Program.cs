using System;
using System.Collections.Generic;
using System.Linq;
namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> myQueue = new Queue<int>();

            int N = numbers[0];

            int S = numbers[1];

            int X = numbers[2];





            for (int i = 0; i < N; i++)
            {
                int num = arr[i];

               myQueue.Enqueue(num);

            }

            for (int i = 0; i < S; i++)
            {
                myQueue.Dequeue();


            }


            if (myQueue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (myQueue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(myQueue.Min());
            }
        }
    }
}
