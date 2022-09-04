using System;
using System.Linq;
using System.Collections.Generic;
namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(sequence);

            int capacity = capacityOfRack;

            int countRacks = 1;

            while (clothes.Count > 0)
            {
               int current = clothes.Peek();


                if (current <= capacity)
                {
                    int currentNumber = clothes.Pop();

                    capacity -= currentNumber;
                    
                    
                }

                else
                {
                    countRacks++;

                    capacity = capacityOfRack;


                }

               
            }

            Console.WriteLine(countRacks);

        }
    }
}
