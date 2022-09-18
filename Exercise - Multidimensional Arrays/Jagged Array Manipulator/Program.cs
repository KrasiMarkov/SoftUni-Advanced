using System;
using System.Linq;
using System.Collections.Generic;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                double[] current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                jagged[row] = current;
            }

            for (int row = 0; row < jagged.Length - 1; row++)
            {
                double[] rowLenght = jagged[row];

                double[] nextRowLenght = jagged[row + 1];

                if (rowLenght.Length == nextRowLenght.Length)
                {

                    jagged[row] = rowLenght.Select(e => e * 2).ToArray();
                    jagged[row + 1] = nextRowLenght.Select(e => e * 2).ToArray();
 
                }
                else
                {
                    jagged[row] = rowLenght.Select(e => e / 2).ToArray();
                    jagged[row + 1] = nextRowLenght.Select(e => e / 2).ToArray();
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                else if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);

                    int col = int.Parse(command[2]);

                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }


                }

                else if (command[0] == "Subtract")
                {

                    int row = int.Parse(command[1]);

                    int col = int.Parse(command[2]);

                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {

                Console.WriteLine(string.Join(" ", jagged[i]));
               
            }
        }
    }
}
