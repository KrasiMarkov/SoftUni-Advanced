using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var textBuilder = new StringBuilder();

            Stack<string> myStack = new Stack<string>();

            myStack.Push(textBuilder.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "1")
                {
                    string strForAppend = command[1];

                    textBuilder.Append(strForAppend);



                    myStack.Push(textBuilder.ToString());
                }

                else if (command[0] == "2")
                {
                    int count = int.Parse(command[1]);



                    int length = textBuilder.Length;

                    int startIndex = length - count;

                    textBuilder.Remove(startIndex, count);

                    myStack.Push(textBuilder.ToString());
                }

                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);

                    Console.WriteLine(textBuilder[index - 1]);



                }

                else if (command[0] == "4")
                {
                    myStack.Pop();

                    textBuilder = new StringBuilder();

                    textBuilder.Append(myStack.Peek());
                }
            }
        }
    }
}
