using System;
using System.Collections.Generic;
using System.Linq;
namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Stack<string> myStack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {

                myStack.Push(input[i]);


            }

            while (myStack.Count > 1)
            {

                int operandOne = int.Parse(myStack.Pop());
                string opr = myStack.Pop();
                int operandTwo = int.Parse(myStack.Pop());

                int sum = 0;

                if (opr == "+")
                {
                    sum = operandOne + operandTwo;
                }

                else
                {
                    sum = operandOne - operandTwo;
                }

                myStack.Push(sum.ToString());
            }

            Console.WriteLine(myStack.Peek());


        }
    }
}
