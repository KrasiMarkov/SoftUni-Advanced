using System;
using System.Linq;
using System.Collections.Generic;
namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> func = /*ParsePrice;*/ p => p += p * 0.2;

           

            double[] price = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(func)
                .ToArray();

            foreach (var item in price)
            {
                Console.WriteLine($"{item:F2}");
            }


        }
        //static double ParsePrice(double price)
        //{

        //    price += price * 0.2;

        //    return price;
        //}
            
                
             
           

    }

}
