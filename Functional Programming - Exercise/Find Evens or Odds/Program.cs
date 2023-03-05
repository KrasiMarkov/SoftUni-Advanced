using System;
using System.Collections.Generic;
using System.Linq;
namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            //Func<int[], string, List<int>> myFunc = ReturnNumbers;

            //var result = myFunc(numbers, command);

            //Console.WriteLine(string.Join(" ", result));

            int start = numbers[0];

            int end = numbers[1];

            Predicate<int> predicate = x => true;

            if (command == "even")
            {
                predicate = x => x % 2 == 0;
            }

            else if (command == "odd")
            {
                predicate = x => x % 2 != 0;
            }

            var result = MyWhere(start, end, predicate);

            Console.WriteLine(string.Join(" ", result));

        }

        static List<int> MyWhere(int start, int end, Predicate<int> predicate)
        {
            List<int> myList = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (predicate(i))
                {
                    myList.Add(i);
                }


            }

            return myList;
        }
        //static List<int> ReturnNumbers(int[] numbers, string command)
        //{
        //    int start = numbers[0];
        //    int end = numbers[1];
        //    string condition = command;
        //    List<int> myList = new List<int>();

        //    for (int i = start; i <= end; i++)
        //    {
        //        if (condition == "even")
        //        {
        //            if (i % 2 == 0)
        //            {
        //                myList.Add(i);
        //            }
        //        }

        //        else if (condition == "odd")
        //        {
        //            if (i % 2 != 0)
        //            {
        //                myList.Add(i);
        //            }
        //        }
        //    }

        //    return myList;
        //}
    }
}
