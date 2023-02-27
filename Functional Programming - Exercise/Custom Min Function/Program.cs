using System;
using System.Linq;
using System.Collections.Generic;
namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Func<int[], int> Myfunc = n => n.Min();

            Func<int[], int> myFunc = minNum;

            int result = myFunc(numbers);

            Console.WriteLine(result);

        }

        static int minNum(int[] numbers)
        {

            int minNum = int.MaxValue;

            foreach (var item in numbers)
            {
                if (item < minNum)
                {
                    minNum = item;
                }
                
            }



            return minNum;
        }
    }
}
