using System;
using System.Collections.Generic;
namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];


                if (symbol == '(')
                {
                    

                    myStack.Push(i);
                }

                else if (symbol == ')')
                {
                    var result = myStack.Pop();

                    string sub = text.Substring(result, i - result + 1);

                    Console.WriteLine(sub);
                }
            }
        }
    }
}
