using System;
using System.Collections.Generic;
using System.Linq;
namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Queue<string> pumps = new Queue<string>();

            int index = 0;

            for (int i = 0; i < N; i++)
            {
                string date = Console.ReadLine();

                pumps.Enqueue(date);



            }

            for (int i = 0; i < pumps.Count; i++)
            {
                int totalAmount = 0;



                bool isComplete = true;

                for (int j = 0; j < pumps.Count; j++)
                {
                    string current = pumps.Dequeue();

                    int[] currentDate = current.Split().Select(int.Parse).ToArray();

                    int amountPetrol = currentDate[0];

                    int distance = currentDate[1];

                    totalAmount += amountPetrol;

                    if (totalAmount >= distance)
                    {
                        totalAmount -= distance;
                    }

                    else
                    {
                        isComplete = false;
                    }

                    pumps.Enqueue(current);
                }

                if (isComplete == true)
                {
                    index = i;
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(index);

        }
    }
}
