using System;
using System.Linq;
using System.Collections.Generic;
namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> mySet = new HashSet<string>();

            bool flag = false;

            while (true)
            {
                string[] cars = Console.ReadLine().Split(", ").ToArray();

                if (cars[0] == "END")
                {
                    break;
                }

                else if (cars[0] == "IN")
                {
                    string number = cars[1];

                    mySet.Add(number);
                }

                else if (cars[0] == "OUT")
                {
                    string number = cars[1];

                    if (mySet.Contains(number))
                    {
                        mySet.Remove(number);
                    }
                }
            }

            if (mySet.Any())
            {
                flag = true;
            }

            if (flag == true)
            {
                foreach (var item in mySet)
                {
                    Console.WriteLine(item);
                }
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
