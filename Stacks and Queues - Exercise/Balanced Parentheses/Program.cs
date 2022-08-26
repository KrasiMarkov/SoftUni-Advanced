using System;
using System.Linq;
using System.Collections.Generic;
namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

            Stack<char> myStack = new Stack<char>();

            Queue<char> myQueue = new Queue<char>();

            bool flag = true;

            for (int i = 0; i < parentheses.Length; i++)
            {
                char symbol = parentheses[i];

                if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    myStack.Push(symbol);
                }
            }

            for (int i = 0; i < parentheses.Length; i++)
            {
                char symbol = parentheses[i];

                if (symbol == '}' || symbol == ']' || symbol == ')')
                {
                    myQueue.Enqueue(symbol);
                }
            }

            for (int i = 0; i < myStack.Count; i++)
            {
                char currentCharStack = myStack.Peek();

                char mySymbol = 'X';

                if (currentCharStack == '{')
                {
                    mySymbol = '}';
                }

                else if (currentCharStack == '[')
                {
                    mySymbol = ']';
                }

                else if (currentCharStack == '(')
                {
                    mySymbol = ')';
                }
                for (int j = 0; j < myQueue.Count; j++)
                {

                    char currentCharQueue = myQueue.Peek();


                    if (currentCharQueue == mySymbol)
                    {
                        myStack.Pop();
                        myQueue.Dequeue();
                        break;
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("NO");
                        break;
                    }


                }

                if (flag == false)
                {
                    break;
                }
            }

            if (flag == true)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
