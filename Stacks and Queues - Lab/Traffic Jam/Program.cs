using System;
using System.Collections.Generic;
using System.Linq;
namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int counter = 0;

            while (true)
            {
                string car = Console.ReadLine();

                if (car == "end")
                {
                    break;
                }

                else if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {

                        if (cars.Count == 0)
                        {
                            break;
                        }

                        string outCar = cars.Dequeue();

                        counter++;

                        Console.WriteLine($"{outCar} passed!");

                       
                    }
                    continue;
                }

                cars.Enqueue(car);

            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
