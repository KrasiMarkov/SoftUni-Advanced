using System;
using System.Linq;
using System.Collections.Generic;
namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> myQueue = new Queue<int>();

            List<int> final = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                myQueue.Enqueue(currentNumber);
            }


            while (myQueue.Count > 0)
            {
                int num = myQueue.Dequeue();

                if (num % 2 == 0)
                {
                    final.Add(num);
                }

            }

            Console.WriteLine(string.Join(", " ,final));

        }
    }
}
