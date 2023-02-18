using System;
using System.Linq;
namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split().ToArray();

            Action<string[]> myFunc = a => Console.WriteLine(string.Join(Environment.NewLine, a));

            myFunc(line);

        }

       
    }
}
