using System;
using System.Linq;
using System.Collections.Generic;
namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            //names = names.Select(n => $"Sir {n}").ToList();

            names = MySelect(names, n => $"Sir {n}");

            Action<List<string>> myFunc = a => Console.WriteLine(string.Join(Environment.NewLine, a));

            myFunc(names);
        }

        static List<string> MySelect(List<string> names, Func<string, string> func)
        {
            List<string> newList = new List<string>();

            foreach (var item in names)
            {
                string newItem = func(item);

                newList.Add(newItem);
            }

            return newList;
        }
    }
}
